using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FTP_Client
{
    public partial class Form1 : Form
    {



        /*ps：针对断点续传，可能还需要其他的考量*/

        //此处定义实现FTP功能时需要的所有全局变量
        #region  Private variable
        private TcpClient cmdServer;
        private TcpClient dataServer;
        private NetworkStream cmdStrmWtr;
        private StreamReader cmdStrmRdr;
        private NetworkStream dataStrmWtr;
        private StreamReader dataStrmRdr;
        private String cmdData;
        private byte[] szData;
        private const String CRLF = "\r\n";
        #endregion

        // 此处定义实现FTP相关的一些全局函数
        #region  Private Functions

        /// <summary>
        /// 获取命令端口返回结果，并记录在lsb_status上
        /// </summary>
        private String getSatus()
        {

            String ret = cmdStrmRdr.ReadLine();
            lsb_status.Items.Add(ret);
            lsb_status.SelectedIndex = lsb_status.Items.Count - 1;
            return ret;
        }

        /// <summary>
        /// 进入被动模式，并初始化数据端口的输入输出流
        /// </summary>
        private void openDataPort()
        {
            string retstr;
            string[] retArray;
            int dataPort;

            // Start Passive Mode 
            cmdData = "PASV" + CRLF;
            szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
            cmdStrmWtr.Write(szData, 0, szData.Length);
            retstr = this.getSatus();

            // Calculate data's port
            retArray = Regex.Split(retstr, ",");
            if (retArray[5][2] != ')') retstr = retArray[5].Substring(0, 3);
            else retstr = retArray[5].Substring(0, 2);
            dataPort = Convert.ToInt32(retArray[4]) * 256 + Convert.ToInt32(retstr);
            lsb_status.Items.Add("Get dataPort=" + dataPort);


            //Connect to the dataPort
            dataServer = new TcpClient(tb_IP.Text, dataPort);
            dataStrmRdr = new StreamReader(dataServer.GetStream());
            dataStrmWtr = dataServer.GetStream();
        }

        /// <summary>
        /// 断开数据端口的连接
        /// </summary>
        private void closeDataPort()
        {
            dataStrmRdr.Close();
            dataStrmWtr.Close();
            this.getSatus();

            cmdData = "ABOR" + CRLF;
            szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
            cmdStrmWtr.Write(szData, 0, szData.Length);
            this.getSatus();

        }

        /// <summary>
        /// 获得/刷新 右侧的服务器文件列表
        /// </summary>
        private void freshFileBox_Right()
        {

            openDataPort();

            string absFilePath;

            //List
            cmdData = "LIST" + CRLF;
            szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
            cmdStrmWtr.Write(szData, 0, szData.Length);
            this.getSatus();

            lsb_server.Items.Clear();
            while ((absFilePath = dataStrmRdr.ReadLine()) != null)
            {
                string[] temp = Regex.Split(absFilePath, " ");
                lsb_server.Items.Add(temp[temp.Length - 1]);
            }

            closeDataPort();
        }

        /// <summary>
        /// 获得/刷新 左侧的本地文件列表
        /// </summary>
        private void freshFileBox_Left()
        {
            lsb_local.Items.Clear();
            if (tb_path.Text == "") return;
            var files = Directory.GetFiles(tb_path.Text, "*.*");
            foreach (var file in files)
            {
                Console.WriteLine(file);
                string[] temp = Regex.Split(file, @"\\");
                lsb_local.Items.Add(temp[temp.Length - 1]);
            }
        }

        #endregion




        /*-->往下的代码定义和按钮等控件相关联的事件 <--*/



        //此部分用于处理连接按钮点击事件
        #region  Button:  Connect & Disconnect

        private void btn_conn_Click(object sender, EventArgs e)
        {
            if (btn_conn.Text == "连接")
            {
                Cursor cr = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                cmdServer = new TcpClient(tb_IP.Text, Convert.ToInt32(tb_port.Text));
                lsb_status.Items.Clear();
                try
                {
                    cmdStrmRdr = new StreamReader(cmdServer.GetStream());
                    cmdStrmWtr = cmdServer.GetStream();
                    this.getSatus();

                    string retstr;

                    //Login
                    cmdData = "USER " + tb_username.Text + CRLF;
                    szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                    cmdStrmWtr.Write(szData, 0, szData.Length);
                    this.getSatus();

                    cmdData = "PASS " + tb_password.Text + CRLF;
                    szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                    cmdStrmWtr.Write(szData, 0, szData.Length);
                    retstr = this.getSatus().Substring(0, 3);
                    if (Convert.ToInt32(retstr) == 530) throw new InvalidOperationException("帐号密码错误");

                    this.freshFileBox_Right();

                    lb_IP.Text = tb_IP.Text + ":";
                    btn_conn.Text = "断开";
                    btn_upload.Enabled = true;
                    btn_download.Enabled = true;
                }
                catch (InvalidOperationException err)
                {
                    lsb_status.Items.Add("ERROR: " + err.Message.ToString());
                }
                finally
                {
                    Cursor.Current = cr;
                }
            }
            else
            {
                Cursor cr = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;

                //Logout

                cmdData = "QUIT" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                cmdStrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();


                cmdStrmWtr.Close();
                cmdStrmRdr.Close();

                lb_IP.Text = "";
                btn_conn.Text = "连接";
                btn_upload.Enabled = false;
                btn_download.Enabled = false;
                lsb_server.Items.Clear();

                Cursor.Current = cr;
            }
        }

        #endregion

        // 此处设置选择本地路径 ：代码中有些变量涉及到前端控件的命名，此处前端还未完成，所以会报错
        #region  Button:  Set Path

        private void btn_setPath_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
                lsb_status.Items.Add("选中本地路径:" + path);
            }

            tb_path.Text = path;
            freshFileBox_Left();
        }

        #endregion



        // 下面这片区域实现上传和下载功能 ：代码中有些变量涉及到前端控件的命名，此处前端还未完成，所以会报错
        #region  Button:  upload & download

        /// <summary>
        /// 上传
        /// </summary>
        private long GetRemoteFileSize(string fileName)
        {
            cmdData = "SIZE " + fileName + CRLF;
            szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
            cmdStrmWtr.Write(szData, 0, szData.Length);
            string response = getSatus();
            if (response.StartsWith("213"))
            {
                return long.Parse(response.Substring(4));
            }
            return -1;
        }


         private long GetLocalFileSize(string filePath)
        {
            if (File.Exists(filePath))
            {
                return new FileInfo(filePath).Length;
            }
            return -1;
        }


        // 正常的上传逻辑
        private void NormalUpload(string filePath)
        {
            try
            {
                // 连接到服务器的数据端口
                this.openDataPort();
        
                string fileName = Path.GetFileName(filePath);
        
                // 使用 STOR 命令告知服务器要上传文件
                cmdData = "STOR " + fileName + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                cmdStrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();
        
                // 上传文件数据
                FileStream fstrm = new FileStream(filePath, FileMode.Open);
                byte[] fbytes = new byte[1030];
                int cnt = 0;
                while ((cnt = fstrm.Read(fbytes, 0, 1024)) > 0)
                {
                    dataStrmWtr.Write(fbytes, 0, cnt);
                }
                fstrm.Close();
        
                // 断开数据端口连接
                this.closeDataPort();
        
                // 刷新服务器文件列表
                this.freshFileBox_Right();
            }
            catch (Exception ex)
            {
                lsb_status.Items.Add("ERROR: " + ex.Message);
            }
        }

        // 断点续传上传逻辑
        private bool ResumeUpload(long resumeOffset, string filePath)
        {
            try
            {
                // 连接到服务器的数据端口
                this.openDataPort();
        
                // 发送 REST 命令通知服务器从指定偏移量继续上传
                cmdData = "REST " + resumeOffset + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                cmdStrmWtr.Write(szData, 0, szData.Length);
                string response = getSatus();
                if (!response.StartsWith("350"))
                {
                    // 服务器不支持断点续传
                    this.closeDataPort();
                    NormalUpload(filePath);
                    return false;
                }
        
                // 使用 STOR 命令告知服务器在现有文件末尾追加数据
                cmdData = "APPE " + fileName + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                cmdStrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();
        
                // 从指定偏移量开始上传
                FileStream fstrm = new FileStream(filePath, FileMode.Open);
                fstrm.Seek(resumeOffset, SeekOrigin.Begin);
                byte[] fbytes = new byte[1030];
                int cnt = 0;
                while ((cnt = fstrm.Read(fbytes, 0, 1024)) > 0)
                {
                    dataStrmWtr.Write(fbytes, 0, cnt);
                }
                fstrm.Close();
        
                // 断开数据端口连接
                this.closeDataPort();
        
                // 刷新服务器文件列表
                this.freshFileBox_Right();
        
                return true;
            }
            catch (Exception ex)
            {
                lsb_status.Items.Add("ERROR: " + ex.Message);
                return false;
            }
        }

        
        


        //上传文件过程
        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (tb_path.Text == "" || lsb_local.SelectedIndex < 0)
            {
                MessageBox.Show("请选择上传的文件", "ERROR");
                return;
            }

            Cursor cr = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            string fileName = lsb_local.Items[lsb_local.SelectedIndex].ToString();
            string filePath = tb_path.Text + "\\" + fileName;

            // 获取本地文件大小
            long localFileSize = GetLocalFileSize(filePath);
        
            // 获取服务器上已存在文件的大小
            long remoteFileSize = GetRemoteFileSize(fileName);

            // 如果服务器上文件已存在，则开始断点续传
            if (remoteFileSize >= 0)
            {
                if (remoteFileSize >= localFileSize)
                {
                    MessageBox.Show("服务器上已存在同名文件且大小不小于本地文件，无需上传。", "提示");
                    return;
                }
                else
                {
                    if (ResumeUpload(remoteFileSize, filePath))
                    {
                        MessageBox.Show("文件上传完成。", "提示");
                    }
                    else
                    {
                        MessageBox.Show("文件上传失败。", "错误");
                    }
                }
            }
            else
            {
                // 服务器上文件不存在，执行正常的上传过程
                NormalUpload(filePath);
            }
            
            Cursor.Current = cr;
        }


        


        /// <summary>
        /// 下载
        /// </summary>

       // 正常的下载逻辑
        private void NormalDownload(string filePath)
        {
            try
            {
                // 连接到服务器的数据端口
                this.openDataPort();
        
                string fileName = lsb_server.Items[lsb_server.SelectedIndex].ToString();
                filePath = tb_path.Text + "\\" + fileName;
        
                // 使用 RETR 命令告知服务器要下载文件
                cmdData = "RETR " + fileName + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                cmdStrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();
        
                // 下载文件数据
                FileStream fstrm = new FileStream(filePath, FileMode.Create);
                byte[] fbytes = new byte[1030];
                int cnt = 0;
                while ((cnt = dataStrmWtr.Read(fbytes, 0, 1024)) > 0)
                {
                    fstrm.Write(fbytes, 0, cnt);
                }
                fstrm.Close();
        
                // 断开数据端口连接
                this.closeDataPort();
        
                // 刷新本地文件列表
                this.freshFileBox_Left();
            }
            catch (Exception ex)
            {
                lsb_status.Items.Add("ERROR: " + ex.Message);
            }
        }

        // 断点续传下载逻辑
        private bool ResumeDownload(long resumeOffset, string filePath)
        {
            try
            {
                // 连接到服务器的数据端口
                this.openDataPort();
        
                // 发送 REST 命令通知服务器从指定偏移量继续下载
                cmdData = "REST " + resumeOffset + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                cmdStrmWtr.Write(szData, 0, szData.Length);
                string response = getSatus();
                if (!response.StartsWith("350"))
                {
                    // 服务器不支持断点续传
                    this.closeDataPort();
                    NormalDownload(filePath);
                    return false;
                }
        
                // 使用 RETR 命令告知服务器要下载文件
                cmdData = "RETR " + fileName + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                cmdStrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();
        
                // 从指定偏移量开始下载
                FileStream fstrm = new FileStream(filePath, FileMode.Append);
                byte[] fbytes = new byte[1030];
                int cnt = 0;
                while ((cnt = dataStrmWtr.Read(fbytes, 0, 1024)) > 0)
                {
                    fstrm.Write(fbytes, 0, cnt);
                }
                fstrm.Close();
        
                // 断开数据端口连接
                this.closeDataPort();
        
                // 刷新本地文件列表
                this.freshFileBox_Left();
        
                return true;
            }
            catch (Exception ex)
            {
                lsb_status.Items.Add("ERROR: " + ex.Message);
                return false;
            }
        }





        //下载文件过程
        private void btn_download_Click(object sender, EventArgs e)
        {

            if (tb_path.Text == "" || lsb_server.SelectedIndex < 0)
            {
                MessageBox.Show("请选择目标文件和下载路径", "ERROR");
                return;
            }

            Cursor cr = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            string fileName = lsb_server.Items[lsb_server.SelectedIndex].ToString();
            string filePath = tb_path.Text + "\\" + fileName;

            // 获取本地文件大小
            long localFileSize = GetLocalFileSize(filePath);
        
            // 获取服务器文件大小
            long remoteFileSize = GetRemoteFileSize(fileName);

            // 如果服务器上文件已存在，则开始断点续传
            if (remoteFileSize >= 0)
            {
                if (localFileSize >= remoteFileSize)
                {
                    MessageBox.Show("本地已存在同名文件且大小不小于服务器文件，无需下载。", "提示");
                    return;
                }
                else
                {
                    if (ResumeDownload(localFileSize, filePath))
                    {
                        MessageBox.Show("文件下载完成。", "提示");
                    }
                    else
                    {
                        MessageBox.Show("文件下载失败。", "错误");
                    }
                }
            }
            else
            {
                // 服务器上文件不存在，执行正常的下载过程
                NormalDownload(filePath);
            }
            
            Cursor.Current = cr;
        }

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
