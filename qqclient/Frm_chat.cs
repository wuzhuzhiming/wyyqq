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
    public partial class Frm_chat : Form
    {
        //鼠标移动的位置
        Point mouse_off;
        //是否为左键
        bool is_mouse_left = false;

        //本人的信息
        public int self_userid = 0;
        public string self_name = "";

        //当前聊天窗口对应的好友信息
        public int friend_userid = 0;
        public string friend_name = "";
        public int friend_head = 0;

        public Frm_chat()
        {
            InitializeComponent();
        }

        //设置好友信息
        public void set_friend_info(int self_userid_param, string self_name_param, int userid, string name, int head)
        {
            self_userid = self_userid_param;
            self_name = self_name_param;
            friend_userid = userid;
            friend_name = name;
            friend_head = head;

            lb_name.Text = friend_name;
            lb_userid.Text = friend_userid.ToString();
            Frm_login frm_login = (Frm_login)(this.Owner.Owner);
            pb_head.BackgroundImage = frm_login.get_imglisthead().Images[friend_head - 1];
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            //聊天窗口关闭时，删除frm_main中的对应窗口数据
            //Frm_main frm_main = (Frm_main)(this.Owner);
            //frm_main.remove_frmchat(friend_userid);

            //为了保存聊天框的聊天记录，此处只隐藏，不关闭
            Hide();
        }

        private void bt_close2_Click(object sender, EventArgs e)
        {
            //聊天窗口关闭时，删除frm_main中的对应窗口数据
            //Frm_main frm_main = (Frm_main)(this.Owner);
            //frm_main.remove_frmchat(friend_userid);

            //为了保存聊天框的聊天记录，此处只隐藏，不关闭
            Hide();
        }

        private void bt_min_Click(object sender, EventArgs e)
        {
            //最小化
            this.WindowState = FormWindowState.Minimized;
        }

        //鼠标在窗体按下
        private void Frm_chat_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_off = new Point(-e.X, -e.Y);
                is_mouse_left = true;
            }
        }

        //鼠标移动
        private void Frm_chat_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                Point mouse_set = Control.MousePosition;
                mouse_set.Offset(mouse_off.X, mouse_off.Y);
                Location = mouse_set;
            }
        }

        //鼠标松开
        private void Frm_chat_MouseUp(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                is_mouse_left = false;
            }
        }

        //发送聊天信息
        private void bt_send_Click(object sender, EventArgs e)
        {
            string str_chat = rtxt_chat.Text;
            if (str_chat.Length < 1)
            {
                //如果输入框没有内容，则不发送
                return;
            }

            //清空输入框
            rtxt_chat.Clear();
            //将本人发送的信息显示到聊天框
            string str_self_chat = self_name + " " + DateTime.Now.ToString() + "\n  " + str_chat + "\n\n";
            rtxt_msg.AppendText(str_self_chat);
            rtxt_msg.Focus();

            string str_msg = "sendchat&" + friend_userid + "&" + str_chat;
            Frm_login.send_data(str_msg);
        }

        //收到聊天信息
        public void recv_chat(string str_chat)
        {
            rtxt_msg.AppendText(str_chat + "\n\n");
            rtxt_msg.Focus();
        }
    }
}
