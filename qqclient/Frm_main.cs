using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qqclient
{
    public partial class Frm_main : Form
    {
        //鼠标移动的位置
        Point mouse_off;
        //是否为左键
        bool is_mouse_left = false;
        //本人的信息
        public int self_userid = 0;
        public string self_name = "";
        public int self_head = 1;
        public string self_pass = "";

        //好友信息列表
        struct friend_info
        {
            public int userid;
            public string name;
            public int head;
        }
        Dictionary<int, friend_info> map_friendinfo = new Dictionary<int, friend_info>();

        //聊天窗口列表
        Dictionary<int, Form> map_chatfrm = new Dictionary<int, Form>();

        //添加好友窗口
        public Frm_add_friend frm_add_friend = null;

        //消息类型
        enum NEWS_TYPE
        {
            APPLY_FRIEND = 1,       //申请好友
            APPLY_GROUP = 2,        //申请加群
        }

        public Frm_main()
        {
            InitializeComponent();

            //设置为不检测线程安全
            CheckForIllegalCrossThreadCalls = false;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            //主界面关闭时，要关闭整个进程
            Application.Exit();
        }

        private void bt_min_Click(object sender, EventArgs e)
        {
            //最小化
            this.WindowState = FormWindowState.Minimized;
        }

        //鼠标在窗体按下
        private void Frm_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_off = new Point(-e.X, -e.Y);
                is_mouse_left = true;
            }
        }

        //鼠标移动
        private void Frm_main_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                Point mouse_set = Control.MousePosition;
                mouse_set.Offset(mouse_off.X, mouse_off.Y);
                Location = mouse_set;
            }
        }

        //鼠标松开
        private void Frm_main_MouseUp(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                is_mouse_left = false;
            }
        }

        //检测给定的userid是否已经是本人的好友
        public bool check_friend(int userid)
        {
            if (map_friendinfo.ContainsKey(userid))
            {
                return true;
            }
            return false;
        }

        //设置用户基本信息
        public void set_user_info(string[] arr_user_info)
        {
            lb_name.Text = arr_user_info[3];
            lb_userid.Text = arr_user_info[2];
            self_userid = int.Parse(arr_user_info[2]);
            self_name = arr_user_info[3];
            self_pass = arr_user_info[6];

            self_head = int.Parse(arr_user_info[5]);
            Frm_login frm_login = (Frm_login)(this.Owner);
            pb_head.BackgroundImage = frm_login.get_imglisthead().Images[self_head - 1];
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            //主界面加载时，获取好友列表
            get_friendlist();
        }

        private void bt_add_friend_Click(object sender, EventArgs e)
        {
            //弹出添加好友窗口
            //Frm_login frm_login = (Frm_login)(this.Owner);
            //frm_login.frm_add_friend.Show();

            frm_add_friend = new Frm_add_friend();
            frm_add_friend.Owner = this.Owner;
            frm_add_friend.Show();
        }

        //设置添加好友窗口的用户信息
        public void set_frm_addfriend_user_info(string[] arr_user_info)
        {
            frm_add_friend.set_user_info(arr_user_info);
        }

        private void bt_add_group_Click(object sender, EventArgs e)
        {

        }

        private void bt_news_Click(object sender, EventArgs e)
        {
            //发送请求消息的请求
            string str_msg = "getnews";
            Frm_login.send_data(str_msg);
        }

        //处理消息返回
        public void operate_news(string[] arr_recv)
        {
            int news_type = int.Parse(arr_recv[1]);
            if (news_type == (int)NEWS_TYPE.APPLY_FRIEND)
            {
                //好友添加成功后刷新好友列表
                get_friendlist();
            }
        }

        //向服务端请求好友列表
        public void get_friendlist()
        {
            string str_msg = "getfriends";
            Frm_login.send_data(str_msg);
        }

        //获取好友列表数据后，刷新好友列表
        public void set_friendlist(string[] arr_recv)
        {
            //lv_friend.BeginUpdate();

            //清空好友列表
            lv_friend.Items.Clear();
            map_friendinfo.Clear();

            if (arr_recv.Length < 2)
            {
                return;
            }

            string[] arr_friends = arr_recv[1].Split('-');
            foreach(string str_friend in arr_friends)
            {
                string[] arr_data = str_friend.Split('|');
                int friend_userid = int.Parse(arr_data[0]);
                string friend_name = arr_data[1];
                int friend_sex = int.Parse(arr_data[2]);
                int friend_head = int.Parse(arr_data[3]);

                //添加到好友列表中显示
                ListViewItem lvitem = new ListViewItem();
                lvitem.ImageIndex = friend_head - 1;
                lvitem.Text = friend_userid.ToString();
                lvitem.SubItems.Add(friend_name);
                lv_friend.Items.Add(lvitem);

                //添加到好友信息列表中保存
                friend_info friendinfo;
                friendinfo.userid = friend_userid;
                friendinfo.name = friend_name;
                friendinfo.head = friend_head;
                map_friendinfo.Add(friend_userid, friendinfo);
            }

            //lv_friend.EndUpdate();
        }

        //双击好友头像后，弹出聊天窗口
        private void lv_friend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lv_friend.SelectedItems.Count > 0)
            {
                int selected_userid = int.Parse(lv_friend.SelectedItems[0].Text);
                if (map_friendinfo.ContainsKey(selected_userid))
                {
                    Frm_chat frm_chat = null;
                    if (map_chatfrm.ContainsKey(selected_userid))
                    {
                        //如果此好友的聊天窗口已经存在，则不再创建新的聊天窗口
                        frm_chat = (Frm_chat)map_chatfrm[selected_userid];
                    }
                    else
                    {
                        //如果此好友的聊天窗口不存在，则创建新的聊天窗口，并加入到聊天窗口map中
                        frm_chat = new Frm_chat();
                        frm_chat.Owner = this;
                        map_chatfrm[selected_userid] = (Form)frm_chat;
                        //设置聊天窗口的好友信息
                        frm_chat.set_friend_info(self_userid, self_name, selected_userid, map_friendinfo[selected_userid].name, map_friendinfo[selected_userid].head);
                    }

                    //显示聊天窗口
                    frm_chat.Show();
                }
            }
        }

        //从聊天窗口map中删除对应好友的数据
        public void remove_frmchat(int userid)
        {
            if (map_friendinfo.ContainsKey(userid))
            {
                map_chatfrm.Remove(userid);
            }
        }

        //收到好友发送的聊天信息
        public void send_chat_rsp(string[] arr_recv)
        {
            int friend_userid = int.Parse(arr_recv[1]);
            if (map_friendinfo.ContainsKey(friend_userid))
            {
                Frm_chat frm_chat = null;
                if (map_chatfrm.ContainsKey(friend_userid))
                {
                    //如果此好友的聊天窗口已经存在，则不再创建新的聊天窗口
                    frm_chat = (Frm_chat)map_chatfrm[friend_userid];
                }
                else
                {
                    //如果此好友的聊天窗口不存在，则创建新的聊天窗口，并加入到聊天窗口map中
                    frm_chat = new Frm_chat();
                    frm_chat.Owner = this;
                    map_chatfrm[friend_userid] = (Form)frm_chat;
                    frm_chat.set_friend_info(self_userid, self_name, friend_userid, map_friendinfo[friend_userid].name, map_friendinfo[friend_userid].head);
                }

                //添加本次聊天信息到聊天窗口
                string str_cur_chat = map_friendinfo[friend_userid].name + " " + DateTime.Now.ToString() + "\n  " + arr_recv[2];
                frm_chat.recv_chat(str_cur_chat);
            }
        }

        //点击菜单按钮
        private void bt_menu_MouseDown(object sender, MouseEventArgs e)
        {
            cms_menu.Show((Button)sender, new Point(e.X, e.Y));
        }

        private void tsmi_modify_Click(object sender, EventArgs e)
        {
            //弹出修改资料窗口
            Frm_modify frm_modify = new Frm_modify();
            frm_modify.Owner = this;
            frm_modify.set_user_info(self_pass, self_name, self_head);
            frm_modify.Show();
        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //修改用户资料返回
        public void modify_rsp(string[] arr_recv)
        {
            self_pass = arr_recv[1];
            self_name = arr_recv[2];
            self_head = int.Parse(arr_recv[3]);

            lb_name.Text = self_name;
            Frm_login frm_login = (Frm_login)(this.Owner);
            pb_head.BackgroundImage = frm_login.get_imglisthead().Images[self_head - 1];
        }
    }
}
