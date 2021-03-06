﻿using System;
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
using System.Data.SqlClient;

namespace qqserver
{
    public partial class Frm_server : Form
    {
        //监听套接字
        public static Socket s_listen = null;
        //监听线程
        Thread th_listen = null;
        //在线用户列表 <userid, 客户端socket>
        Dictionary<int, Socket> online_players = new Dictionary<int, Socket>();
        Dictionary<Socket, int> online_sockets = new Dictionary<Socket, int>();

        //消息类型
        enum NEWS_TYPE
        {
            APPLY_FRIEND = 1,       //申请好友
            APPLY_GROUP = 2,        //申请加群
        }

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
        public void listen_connect()
        {
            Socket s_client = null;

            //在循环中监听客户端的连接请求
            while (true)
            {
                //客户端连接成功，并创建一个与客户端进行通信的套接字
                try
                {
                    s_client = s_listen.Accept();
                }
                catch
                {
                    return;
                }

                //label3.Text = "客户端已连接！";
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
        public void recv_data(object s_clientparam)
        {
            Socket s_client = s_clientparam as Socket;

            //在循环中接受客户端发送的数据
            while(true)
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
                handle_data(s_client, str_recv);
            }
        }

        //对接收到的数据，按照类型进行分发处理
        public void handle_data(Socket s_client, string str_recv)
        {
            if (s_client == null || str_recv == null ||str_recv.Length == 0)
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
            if (arr_recv[0] == "register"){
                //注册
                register(s_client, arr_recv);
            }else if (arr_recv[0] == "login"){
                //登陆
                login(s_client, arr_recv);
            }else if (arr_recv[0] == "finduser"){
                //查找用户
                find_user(s_client, arr_recv);
            }else if (arr_recv[0] == "addfriend"){
                //添加好友
                add_friend(s_client, arr_recv);
            }else if (arr_recv[0] == "getnews"){
                //获取一条消息
                get_one_news(s_client, arr_recv);
            }else if (arr_recv[0] == "operatenews"){
                //处理一条消息
                operate_one_news(s_client, arr_recv);
            }else if (arr_recv[0] == "getfriends"){
                //获取好友列表
                get_friends(s_client, arr_recv);
            }else if (arr_recv[0] == "sendchat"){
                //发送聊天信息
                send_chat(s_client, arr_recv);
            }else if (arr_recv[0] == "modify"){
                //用户修改资料
                modify_userinfo(s_client, arr_recv);
            }
        }

        //发送数据给指定客户端
        public void send_data(Socket s_client, string str_data)
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

        //由在线玩家的socket获取userid
        private int get_online_userid(Socket s_client)
        {
            if (online_sockets.ContainsKey(s_client))
            {
                return online_sockets[s_client];
            }
            else
            {
                return 0;
            }
        }

        //由在线玩家的userid获取socket
        private Socket get_online_socket(int userid)
        {
            if (online_players.ContainsKey(userid))
            {
                return online_players[userid];
            }
            else
            {
                return null;
            }
        }

        //注册
        public void register(Socket s_client, string[] arr_recv)
        {
            //账号、密码、昵称、性别、头像
            if (arr_recv.Length < 6)
            {
                //label3.Text = arr_recv[0] + arr_recv[1] + arr_recv[2];
                string str_msg = "retcode&0&注册信息不完整";
                send_data(s_client, str_msg);
            }
            else
            {
                //检测账号是否已经存在
                if (dboperate.check_account(arr_recv[1]))
                {
                    string str_msg = "retcode&0&账号已存在";
                    send_data(s_client, str_msg);
                }
                else
                {
                    //保存玩家的注册信息到数据库
                    dboperate.create_user(arr_recv);
                    //并发送成功通知给客户端
                    string str_msg = "retcode&1&注册成功";
                    send_data(s_client, str_msg);
                }
            }
        }

        //登陆
        public void login(Socket s_client, string[] arr_recv)
        {
            //账号、密码
            if (arr_recv.Length < 3)
            {
                string str_msg = "retcode&0&登陆信息不完整";
                send_data(s_client, str_msg);
            }
            else
            {
                //检测账号是否存在
                if (!dboperate.check_account(arr_recv[1]))
                {
                    string str_msg = "retcode&0&账号不存在";
                    send_data(s_client, str_msg);
                    return;
                }

                //检测密码是否正确
                if (!dboperate.check_pass(arr_recv[1], arr_recv[2]))
                {
                    string str_msg = "retcode&0&密码错误";
                    send_data(s_client, str_msg);
                    return;
                }

                //账号、密码检测通过后，从数据库中获取用户的基本信息
                Dictionary<string, string> map_result = dboperate.get_user_info(arr_recv[1]);
                if (!map_result.ContainsKey("userid") || !map_result.ContainsKey("name") ||
                    !map_result.ContainsKey("sex") || !map_result.ContainsKey("head"))
                {
                    string str_msg = "retcode&0&获取用户数据失败";
                    send_data(s_client, str_msg);
                }
                else
                {
                    //添加到在线列表
                    if (!online_players.ContainsKey(int.Parse(map_result["userid"])))
                    {
                        online_players.Add(int.Parse(map_result["userid"]), s_client);
                    }
                    else
                    {
                        online_players[int.Parse(map_result["userid"])] = s_client;
                    }

                    if (!online_sockets.ContainsKey(s_client))
                    {
                        online_sockets.Add(s_client, int.Parse(map_result["userid"]));
                    }
                    else
                    {
                        online_sockets[s_client] = int.Parse(map_result["userid"]);
                    }
                    
                    //返回用户信息给客户端
                    string str_msg = String.Format(@"login_rsp&{0}&{1}&{2}&{3}&{4}&{5}",
                        arr_recv[1], map_result["userid"].ToString(), map_result["name"].ToString(), 
                        map_result["sex"].ToString(), map_result["head"].ToString(), arr_recv[2]);
                    send_data(s_client, str_msg);
                }
            }
        }

        //查找用户
        public void find_user(Socket s_client, string[] arr_recv)
        {
            if (arr_recv.Length < 2)
            {
                string str_msg = "retcode&0&缺少参数无法查找用户";
                send_data(s_client, str_msg);
            }
            else
            {
                int userid = 0;
                if (int.TryParse(arr_recv[1], out userid))
                {
                    //如果参数是数字，则通过userid查找
                    Dictionary<string, string> map_result = dboperate.get_user_info_from_userid(userid);
                    if (!map_result.ContainsKey("userid") || !map_result.ContainsKey("name") ||
                    !map_result.ContainsKey("sex") || !map_result.ContainsKey("head"))
                    {
                        string str_msg = "finduser_rsp&retcode&0";
                        send_data(s_client, str_msg);
                    }
                    else
                    {
                        //返回用户信息给客户端
                        string str_msg = String.Format(@"finduser_rsp&{0}&{1}&{2}&{3}&{4}",
                            map_result["account"].ToString(), map_result["userid"].ToString(), map_result["name"].ToString(),
                            map_result["sex"].ToString(), map_result["head"].ToString());
                        send_data(s_client, str_msg);
                    }
                }
                else
                {
                    //如果参数不是数字，则通过用户账号查找
                    Dictionary<string, string> map_result = dboperate.get_user_info(arr_recv[1]);
                    if (!map_result.ContainsKey("userid") || !map_result.ContainsKey("name") ||
                    !map_result.ContainsKey("sex") || !map_result.ContainsKey("head"))
                    {
                        string str_msg = "finduser_rsp&retcode&0";
                        send_data(s_client, str_msg);
                    }
                    else
                    {
                        //返回用户信息给客户端
                        string str_msg = String.Format(@"finduser_rsp&{0}&{1}&{2}&{3}&{4}",
                            map_result["account"].ToString(), map_result["userid"].ToString(), map_result["name"].ToString(),
                            map_result["sex"].ToString(), map_result["head"].ToString());
                        send_data(s_client, str_msg);
                    }
                }
            }
        }

        //添加好友
        public void add_friend(Socket s_client, string[] arr_recv)
        {
            if (arr_recv.Length < 2)
            {
                string str_msg = "retcode&0&添加好友失败";
                send_data(s_client, str_msg);
            }
            else
            {
                int self_userid = get_online_userid(s_client);
                int with_userid = int.Parse(arr_recv[1]);

                if (self_userid != with_userid && !dboperate.check_friend(self_userid, with_userid))
                {
                    Dictionary<string, string> map_result = dboperate.get_user_info_from_userid(with_userid);
                    if (!map_result.ContainsKey("userid") || !map_result.ContainsKey("name") ||
                    !map_result.ContainsKey("sex") || !map_result.ContainsKey("head"))
                    {
                        string str_msg = "retcode&0&添加好友失败";
                        send_data(s_client, str_msg);
                    }
                    else
                    {
                        //添加好友申请给目标用户
                        dboperate.create_news(with_userid, (int)NEWS_TYPE.APPLY_FRIEND, self_userid, 0);
                        //返回用户信息给客户端
                        string str_msg = "retcode&1&添加成功，等待对方处理";
                        send_data(s_client, str_msg);
                    }
                }
            }
        }

        //获取一条消息
        public void get_one_news(Socket s_client, string[] arr_recv)
        {
            //每次只获取一条
            int self_userid = get_online_userid(s_client);
            int news_type = 0;
            string with_userid, with_username, with_groupid, with_groupname;
            dboperate.get_one_news(self_userid, ref news_type, out with_userid, out with_username, out with_groupid, out with_groupname);

            if (news_type == 0)
            {
                //没有消息
                string str_msg = "getnews_rsp&retcode&0";
                send_data(s_client, str_msg);
            }
            else
            {
                //返回消息给客户端
                string str_msg = String.Format(@"getnews_rsp&{0}&{1}&{2}&{3}&{4}",
                    news_type, with_userid, with_username, with_groupid, with_groupname);
                send_data(s_client, str_msg);
            }
        }

        //处理一条消息
        public void operate_one_news(Socket s_client, string[] arr_recv)
        {
            //删除相关消息
            int self_userid = get_online_userid(s_client);
            dboperate.del_news(self_userid, int.Parse(arr_recv[2]), int.Parse(arr_recv[3]), int.Parse(arr_recv[4]));

            int news_result = int.Parse(arr_recv[1]);
            int news_type = int.Parse(arr_recv[2]);

            if (news_type == (int)NEWS_TYPE.APPLY_FRIEND)
            {
                //请求添加好友
                if (news_result == 1)
                {
                    //同意
                    int with_userid = int.Parse(arr_recv[3]);
                    if (!dboperate.check_friend(self_userid, with_userid))
                    {
                        //不是好友时，添加好友数据到数据库
                        dboperate.create_friend(self_userid, with_userid);
                    }

                    //给客户端返回消息类型
                    string str_msg = String.Format("operatenews_rsp&{0}", news_type);
                    send_data(s_client, str_msg);
                    //如果对方在线，则给对方发送消息类型
                    Socket s_with_client = get_online_socket(with_userid);
                    if (s_with_client != null)
                    {
                        string str_msg_2 = String.Format("operatenews_notify&{0}", news_type);
                        send_data(s_with_client, str_msg_2);
                    }
                    return;
                }
            }
            else
            {
                //申请加入群
            }
        }

        //获取好友列表
        public void get_friends(Socket s_client, string[] arr_recv)
        {
            int self_userid = get_online_userid(s_client);
            List<string> list_friend = dboperate.get_friendlist(self_userid);
            string str_msg = "getfriends_rsp";
            if (list_friend.Count > 0 )
            {
                str_msg = str_msg + "&";
            }
            for (int i = 0; i < list_friend.Count; i++)
            {
                str_msg = str_msg + list_friend[i];
                if (i < list_friend.Count - 1)
                {
                    str_msg = str_msg + "-";
                }
            }
            send_data(s_client, str_msg);
        }

        //发送聊天信息
        public void send_chat(Socket s_client, string[] arr_recv)
        {
            if (arr_recv.Length < 3)
            {
                return;
            }

            int self_userid = get_online_userid(s_client);
            int chat_userid = int.Parse(arr_recv[1]);
            string str_chat = arr_recv[2];

            if (self_userid != chat_userid)
            {
                if (!online_players.ContainsKey(chat_userid))
                {
                    //如果对方不在线，则不发送
                    return;
                }

                //发送聊天信息给好友
                Socket s_chat = online_players[chat_userid];
                string str_msg = "sendchat_rsp&" + self_userid + "&" + str_chat;
                send_data(s_chat, str_msg);
            }
        }

        //用户修改资料
        public void modify_userinfo(Socket s_client, string[] arr_recv)
        {
            if (arr_recv.Length < 4)
            {
                return;
            }

            //从数据库中获取用户的基本信息
            int userid = get_online_userid(s_client);
            Dictionary<string, string> map_result = dboperate.get_user_info_from_userid(userid);
            if (!map_result.ContainsKey("userid") || !map_result.ContainsKey("name") ||
                !map_result.ContainsKey("pass") || !map_result.ContainsKey("head"))
            {
                string str_msg = "retcode&0&修改用户资料失败";
                send_data(s_client, str_msg);
            }
            else
            {
                //修改用户资料
                dboperate.modify_userinfo(userid, arr_recv);
                //如果用户昵称和头像发生了变化，则通知客户端
                if (arr_recv[2] != map_result["name"].ToString() || arr_recv[3] != map_result["head"].ToString())
                {
                    string str_msg = String.Format(@"modify_rsp&{0}&{1}&{2}", arr_recv[1], arr_recv[2], arr_recv[3]);
                    send_data(s_client, str_msg);
                }
            }
        }
    }
}
