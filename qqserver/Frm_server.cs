using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace qqserver
{
    public partial class Frm_server : Form
    {
        public Frm_server()
        {
            InitializeComponent();
        }

        //监听套接字
        static Socket s_watch = null;

        //"启动服务器" 按钮的处理
        private void Bt_start_Click(object sender, EventArgs e)
        {

        }

        //"关闭服务器" 按钮的处理
        private void Bt_stop_Click(object sender, EventArgs e)
        {

        }
    }
}
