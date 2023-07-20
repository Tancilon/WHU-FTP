namespace FTP_Client
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.IP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.username = new System.Windows.Forms.Label();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lsb_local = new System.Windows.Forms.ListBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lsb_server = new System.Windows.Forms.ListBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsb_status = new System.Windows.Forms.ListBox();
            this.btn_conn = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_IP = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.IP);
            this.flowLayoutPanel1.Controls.Add(this.tb_IP);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.tb_port);
            this.flowLayoutPanel1.Controls.Add(this.btn_conn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(938, 53);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // IP
            // 
            this.IP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IP.AutoSize = true;
            this.IP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IP.Location = new System.Drawing.Point(8, 22);
            this.IP.Margin = new System.Windows.Forms.Padding(8, 20, 3, 2);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(130, 24);
            this.IP.TabIndex = 0;
            this.IP.Text = "服务器IP：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(415, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(80, 20, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务器端口：";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.username);
            this.flowLayoutPanel2.Controls.Add(this.tb_username);
            this.flowLayoutPanel2.Controls.Add(this.password);
            this.flowLayoutPanel2.Controls.Add(this.tb_password);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(938, 60);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(8, 20);
            this.username.Margin = new System.Windows.Forms.Padding(8, 20, 3, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(94, 24);
            this.username.TabIndex = 0;
            this.username.Text = "用户名:";
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(149, 20);
            this.tb_IP.Margin = new System.Windows.Forms.Padding(8, 20, 3, 2);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(183, 28);
            this.tb_IP.TabIndex = 4;
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(580, 20);
            this.tb_port.Margin = new System.Windows.Forms.Padding(8, 20, 3, 2);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(188, 28);
            this.tb_port.TabIndex = 5;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(113, 20);
            this.tb_username.Margin = new System.Windows.Forms.Padding(8, 20, 73, 2);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(220, 28);
            this.tb_username.TabIndex = 1;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(414, 20);
            this.password.Margin = new System.Windows.Forms.Padding(8, 20, 3, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(82, 24);
            this.password.TabIndex = 2;
            this.password.Text = "密码：";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(507, 20);
            this.tb_password.Margin = new System.Windows.Forms.Padding(8, 20, 3, 2);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(262, 28);
            this.tb_password.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 131);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 171);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(938, 238);
            this.splitContainer1.SplitterDistance = 452;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lsb_local);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_upload);
            this.splitContainer2.Size = new System.Drawing.Size(452, 238);
            this.splitContainer2.SplitterDistance = 189;
            this.splitContainer2.TabIndex = 0;
            // 
            // lsb_local
            // 
            this.lsb_local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsb_local.FormattingEnabled = true;
            this.lsb_local.ItemHeight = 18;
            this.lsb_local.Location = new System.Drawing.Point(0, 0);
            this.lsb_local.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.lsb_local.Name = "lsb_local";
            this.lsb_local.ScrollAlwaysVisible = true;
            this.lsb_local.Size = new System.Drawing.Size(452, 189);
            this.lsb_local.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lsb_server);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btn_download);
            this.splitContainer3.Size = new System.Drawing.Size(482, 238);
            this.splitContainer3.SplitterDistance = 189;
            this.splitContainer3.TabIndex = 0;
            // 
            // lsb_server
            // 
            this.lsb_server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsb_server.FormattingEnabled = true;
            this.lsb_server.ItemHeight = 18;
            this.lsb_server.Location = new System.Drawing.Point(0, 0);
            this.lsb_server.Name = "lsb_server";
            this.lsb_server.ScrollAlwaysVisible = true;
            this.lsb_server.Size = new System.Drawing.Size(482, 189);
            this.lsb_server.TabIndex = 0;
            // 
            // btn_upload
            // 
            this.btn_upload.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_upload.Location = new System.Drawing.Point(359, 0);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(93, 45);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "上传";
            this.btn_upload.UseVisualStyleBackColor = true;
            // 
            // btn_download
            // 
            this.btn_download.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_download.Location = new System.Drawing.Point(387, 0);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(95, 45);
            this.btn_download.TabIndex = 0;
            this.btn_download.Text = "下载";
            this.btn_download.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsb_status);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态：";
            // 
            // lsb_status
            // 
            this.lsb_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsb_status.FormattingEnabled = true;
            this.lsb_status.ItemHeight = 18;
            this.lsb_status.Location = new System.Drawing.Point(3, 24);
            this.lsb_status.Name = "lsb_status";
            this.lsb_status.ScrollAlwaysVisible = true;
            this.lsb_status.Size = new System.Drawing.Size(932, 104);
            this.lsb_status.TabIndex = 0;
            // 
            // btn_conn
            // 
            this.btn_conn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_conn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_conn.Location = new System.Drawing.Point(821, 7);
            this.btn_conn.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(92, 35);
            this.btn_conn.TabIndex = 6;
            this.btn_conn.Text = "连接";
            this.btn_conn.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 113);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.button1);
            this.splitContainer4.Panel1.Controls.Add(this.tb_path);
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.lb_IP);
            this.splitContainer4.Size = new System.Drawing.Size(938, 58);
            this.splitContainer4.SplitterDistance = 452;
            this.splitContainer4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 20, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "本地路径：";
            // 
            // tb_path
            // 
            this.tb_path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_path.Location = new System.Drawing.Point(142, 17);
            this.tb_path.Margin = new System.Windows.Forms.Padding(8, 20, 3, 2);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(256, 28);
            this.tb_path.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(404, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_IP
            // 
            this.lb_IP.AutoSize = true;
            this.lb_IP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_IP.Location = new System.Drawing.Point(0, 40);
            this.lb_IP.Name = "lb_IP";
            this.lb_IP.Size = new System.Drawing.Size(0, 18);
            this.lb_IP.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(938, 540);
            this.Controls.Add(this.splitContainer4);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox lsb_local;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListBox lsb_server;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsb_status;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_IP;
    }
}

