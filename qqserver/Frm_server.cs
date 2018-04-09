using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace qqserver
{
    public partial class Frm_server : Form
    {
        public Frm_server()
        {
            InitializeComponent();
        }

        //监听套接字
        public static Socket s_listen = null;
        //监听线程
        Thread th_listen = null;

        //"启动服务器" 按钮的处理
        private void Bt_start_Click(object sender, EventArgs e)
        {
            //创建监听套接字实例
            s_listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //设置监听的ip和端口
            IPAddress addr = IPAddress.Parse("127.0.0.1");
            IPEndPoint point = new IPEndPoint(addr, int.Parse("5000"));
            //绑定套接字
            s_listen.Bind(point);
            //开始监听，监听队列长度是20
            s_listen.Listen(20);
            //创建监听线程
            th_listen = new Thread(listen_connect);
            //将线程设置为随着主线程结束而结束
            th_listen.IsBackground = true;
            //启动监听线程
            th_listen.Start();
            label3.Text = "服务器已启动！";

            //禁用输入框和启动按钮
            Tb_ip.Enabled = false;
            Tb_port.Enabled = false;
            Bt_start.Enabled = false;
        }

        //窗体加载时的处理
        private void Frm_server_Load(object sender, EventArgs e)
        {
            
        }

        //监听客户端连接请求(线程函数)
        public static void listen_connect()
        {
            Socket s_client = null;

            //在循环中监听客户端的连接请求
            while (true)
            {
                //客户端连接成功，并创建一个与客户端进行通信的套接字
                s_client = s_listen.Accept();
                //创建一个与客户端进行通信的线程
            }
        }

        //接受客户端发送的数据(线程函数)
        public static void recv_data()
        {

        }
    }
}
