using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Net.Sockets;
using System.IO; //IO主要是为了使用NetworkStream类来方便socket的读写
using System.Text.RegularExpressions; //IO主要是为了使用NetworkStream类来方便socket的读写

namespace FTP_Client
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
