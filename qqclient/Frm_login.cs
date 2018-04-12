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

namespace qqclient
{
    public partial class Frm_login : Form
    {
        //鼠标移动的位置
        Point mouse_off;
        //是否为左键
        bool is_mouse_left = false;
        //客户端套接字
        Socket s_client = null;
        //接收服务器消息的线程
        Thread th_recv = null;
        //是否已经连接服务器
        bool is_connect = false;

        public Frm_login()
        {
            InitializeComponent();
        }

        private void link_lab_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //连接服务器
            connect_server();
            //显示注册窗口
            Frm_register frm_register = new Frm_register();
            frm_register.Show();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        //鼠标在窗体按下
        private void Frm_login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_off = new Point(-e.X, -e.Y);
                is_mouse_left = true;
            }
        }

        //鼠标移动
        private void Frm_login_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                Point mouse_set = Control.MousePosition;
                mouse_set.Offset(mouse_off.X, mouse_off.Y);
                Location = mouse_set;
            }
        }

        //鼠标松开
        private void Frm_login_MouseUp(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                is_mouse_left = false;
            }
        }

        //窗口加载时的处理
        private void Frm_login_Load(object sender, EventArgs e)
        {
            //创建套接字实例
            s_client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //关闭socket的优化
            s_client.NoDelay = true;
            //设置ip和端口
            IPAddress addr = IPAddress.Parse("127.0.0.1");
            IPEndPoint point = new IPEndPoint(addr, int.Parse("5000"));

            //连接服务器
            try
            {
                s_client.Connect(point);
            }
            catch
            {
                return;
            }
            

            //创建接收服务器数据的线程
            th_recv = new Thread(recv_data);
            //将线程设置为随着主线程结束而结束
            th_recv.IsBackground = true;
            //启动监听线程
            th_recv.Start();
        }

        //连接服务器
        private void connect_server()
        {
            if (!is_connect)
            {
                //创建套接字实例
                s_client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //关闭socket的优化
                s_client.NoDelay = true;
                //设置ip和端口
                IPAddress addr = IPAddress.Parse("127.0.0.1");
                IPEndPoint point = new IPEndPoint(addr, int.Parse("5000"));

                //连接服务器
                try
                {
                    s_client.Connect(point);
                }
                catch
                {
                    return;
                }

                //创建接收服务器数据的线程
                th_recv = new Thread(recv_data);
                //将线程设置为随着主线程结束而结束
                th_recv.IsBackground = true;
                //启动监听线程
                th_recv.Start();

                //标记为已经连接
                is_connect = true;
            }
        }

        //接收服务器发送的数据(线程函数)
        private void recv_data()
        {

        }

        //登录按钮的处理
        private void bt_login_Click(object sender, EventArgs e)
        {
            //连接服务器
            connect_server();
        }
    }
}
