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
        static Socket s_client = null;
        //接收服务器消息的线程
        Thread th_recv = null;
        //是否已经连接服务器
        bool is_connect = false;
        //登陆窗口线程上下文对象，用于其它线程向登陆窗口线程发送通知
        SynchronizationContext login_th_context;
        //主窗口
        public Frm_main frm_main = null;
        //添加好友窗口
        public Frm_add_friend frm_add_friend = null;
        //加群窗口
        public Frm_add_group frm_add_group = null;
        //消息窗口
        public Frm_news frm_news = null;

        public Frm_login()
        {
            InitializeComponent();

            //设置为不检测线程安全
            CheckForIllegalCrossThreadCalls = false;
            //创建线程上下文对象
            login_th_context = SynchronizationContext.Current;
        }

        private void link_lab_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //连接服务器
            connect_server();
            //显示注册窗口
            Frm_register frm_register = new Frm_register();
            frm_register.Owner = this;
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

        //获取头像图片列表
        public System.Windows.Forms.ImageList get_imglisthead()
        {
            return imglisthead;
        }

        //窗口加载时的处理
        private void Frm_login_Load(object sender, EventArgs e)
        {
            //连接服务器
            connect_server();
            //创建主界面窗口对象
            frm_main = new Frm_main();
            frm_main.Owner = this;
            //创建添加好友窗口对象
            frm_add_friend = new Frm_add_friend();
            frm_add_friend.Owner = this;
            //创建加群窗口对象
            frm_add_group = new Frm_add_group();
            frm_add_group.Owner = this;
            //创建消息窗口对象
            frm_news = new Frm_news();
            frm_news.Owner = this;
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
                //设置为非阻塞
                //s_client.Blocking = false;
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
            //在循环中接受客户端发送的数据
            while (true)
            {
                //创建一块接收数据的内存
                byte[] byte_recv = new byte[1024 * 1024];

                //接收数据(接收到的数据长度为len)
                int len = 0;
                try
                {
                    len = s_client.Receive(byte_recv);
                }
                catch
                {
                    s_client.Close();
                    break;
                }

                //将二进制数据转为字符串
                string str_recv = Encoding.UTF8.GetString(byte_recv, 0, len);
                //处理接收到的数据
                handle_data(str_recv);
            }
        }

        //对接收到的数据，按照类型进行分发处理
        public void handle_data(string str_recv)
        {
            if (str_recv == null || str_recv.Length == 0)
            {
                return;
            }

            //分解接收到的数据(数据以'&'作为分隔符)
            string[] arr_recv = str_recv.Split('&');
            if (arr_recv.Length < 1)
            {
                return;
            }

            //根据数据类型进行分发处理
            if (arr_recv[0] == "retcode"){
                //返回值与提示信息
                MessageBox.Show(arr_recv[2]);
            }else if (arr_recv[0] == "login_rsp"){
                //登陆返回
                login_rsp(arr_recv);
            }else if (arr_recv[0] == "finduser_rsp"){
                //查找用户返回
                finduser_rsp(arr_recv);
            }else if (arr_recv[0] == "findgroup_rsp"){
                //查找群返回
                findgroup_rsp(arr_recv);
            }else if (arr_recv[0] == "getnews_rsp"){
                //获取消息返回
                getnews_rsp(arr_recv);
            }
        }

        //发送数据给服务器
        public static void send_data(string str_data)
        {
            //将字符串转为二进制 
            byte[] byte_data = Encoding.UTF8.GetBytes(str_data);
            //发送数据
            try
            {
                s_client.Send(byte_data);
            }
            catch
            {
                return;
            }
        }

        //登录按钮的处理
        private void bt_login_Click(object sender, EventArgs e)
        {
            //连接服务器
            connect_server();

            //获取用户输入的信息
            string str_account = tb_account.Text;
            string str_pass = tb_pass.Text;

            //检测账号、密码是否为空
            if (str_account.Length < 1)
            {
                MessageBox.Show("账号不能为空");
                return;
            }
            if (str_pass.Length < 1)
            {
                MessageBox.Show("密码不能为空");
                return;
            }

            //发送用户的登陆信息给服务器
            string str_msg = "login&" + str_account + "&" + str_pass;
            send_data(str_msg);
        }

        //登陆返回
        public void login_rsp(string[] arr_recv)
        {
            //登录成功后通知登陆窗口线程
            login_th_context.Post(new SendOrPostCallback(callback_login), arr_recv);
        }

        //登陆返回后的处理 - 线程回调
        private void callback_login(object obj)
        {
            string[] arr_recv = (string[])obj;
            frm_main.set_user_info(arr_recv);
            frm_main.Show();
            this.Hide();
        }

        //查找用户返回
        public void finduser_rsp(string[] arr_recv)
        {
            //查找用户后通知登陆窗口线程
            login_th_context.Post(new SendOrPostCallback(callback_finduser), arr_recv);
        }

        //查找用户返回后的处理 - 线程回调
        private void callback_finduser(object obj)
        {
            string[] arr_recv = (string[])obj;
            frm_add_friend.set_user_info(arr_recv);
        }

        //查找群返回
        public void findgroup_rsp(string[] arr_recv)
        {
            //查找群后通知登陆窗口线程
            login_th_context.Post(new SendOrPostCallback(callback_findgroup), arr_recv);
        }

        //查找群返回后的处理 - 线程回调
        private void callback_findgroup(object obj)
        {
            string[] arr_recv = (string[])obj;
            frm_add_group.set_group_info(arr_recv);
        }

        //获取消息返回
        public void getnews_rsp(string[] arr_recv)
        {
            //查找群后通知登陆窗口线程
            login_th_context.Post(new SendOrPostCallback(callback_getnews), arr_recv);
        }

        //获取消息返回后的处理 - 线程回调
        private void callback_getnews(object obj)
        {
            string[] arr_recv = (string[])obj;
            frm_news.set_news(arr_recv);
            frm_news.Show();
        }

        //账号输入框，做输入限制
        private void tb_account_KeyPress(object sender, KeyPressEventArgs e)
        {
            //账号只允许字母、数字、下划线
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == '_') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //密码输入框，做输入限制
        private void tb_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //密码只允许字母、数字、下划线
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == '_') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
