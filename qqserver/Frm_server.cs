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
        //监听套接字
        public static Socket s_listen = null;
        //监听线程
        Thread th_listen = null;

        public Frm_server()
        {
            InitializeComponent();
        }

        //"启动服务器" 按钮的处理
        private void Bt_start_Click(object sender, EventArgs e)
        {
            //创建监听套接字实例
            s_listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //关闭socket的优化
            s_listen.NoDelay = true;
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

        //监听客户端连接请求(线程函数)
        public static void listen_connect()
        {
            Socket s_client = null;

            //在循环中监听客户端的连接请求
            while (true)
            {
                //客户端连接成功，并创建一个与客户端进行通信的套接字
                s_client = s_listen.Accept();
                //关闭socket的优化
                s_client.NoDelay = true;
                //创建一个与客户端进行通信的线程
                ParameterizedThreadStart pthst = new ParameterizedThreadStart(recv_data);
                Thread th_recv = new Thread(pthst);
                //将线程设置为随着主线程结束而结束
                th_recv.IsBackground = true;
                //启动线程
                th_recv.Start(s_client);
            }
        }

        //接受客户端发送的数据(线程函数)
        public static void recv_data(object s_clientparam)
        {
            Socket s_client = s_clientparam as Socket;

            //在循环中接受客户端发送的数据
            while(true)
            {
                //创建一块接收数据的内存
                byte[] byte_recv = new byte[1024 * 1024];
                //接收数据(接收到的数据长度为len)
                int len = s_client.Receive(byte_recv);
                //将二进制数据转为字符串
                string str_recv = Encoding.UTF8.GetString(byte_recv, 0, len);
                //处理接收到的数据
                handle_data(s_client, str_recv);
            }
        }

        //对接收到的数据，按照类型进行分发处理
        public static void handle_data(Socket s_client, string str_recv)
        {
            if (s_client == null || str_recv == null ||str_recv.Length == 0)
            {
                return;
            }

            //分解接收到的数据(数据已'&'作为分隔符)
            string[] arr_recv = str_recv.Split('&');
            if (arr_recv.Length < 1)
            {
                return;
            }

            //根据数据类型进行分发处理
            if(arr_recv[0] == "register"){
                //注册
                register(s_client, arr_recv);
            }else if (arr_recv[0] == "login"){
                //登陆
                login(s_client, arr_recv);
            }
        }

        //发送数据给指定客户端
        public static void send_data(Socket s_client, string msg_data)
        {

        }

        //注册
        public static void register(Socket s_client, string[] arr_recv)
        {
            //账号、密码、昵称、性别、头像
            if (arr_recv.Length < 6)
            {
                string str_msg = "retcode&注册失败";
                send_data(s_client, str_msg);
                return;
            }
        }

        //登陆
        public static void login(Socket s_client, string[] arr_recv)
        {

        }
    }
}
