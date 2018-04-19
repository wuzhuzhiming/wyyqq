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
    public partial class Frm_news : Form
    {
        //鼠标移动的位置
        Point mouse_off;
        //是否为左键
        bool is_mouse_left;
        //消息相关数据
        int news_type = 0;
        string with_userid = "";
        string with_username = "";
        string with_groupid = "";
        string with_groupname = "";

        //消息类型
        enum NEWS_TYPE
        {
            APPLY_FRIEND = 1,       //申请好友
            APPLY_GROUP = 2,        //申请加群
        }

        public Frm_news()
        {
            InitializeComponent();
        }

        private void Frm_news_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_off = new Point(-e.X, -e.Y);
                is_mouse_left = true;
            }
        }

        private void Frm_news_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                Point mouse_set = Control.MousePosition;
                mouse_set.Offset(mouse_off.X, mouse_off.Y);
                Location = mouse_set;
            }
        }

        private void Frm_news_MouseUp(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                is_mouse_left = false;
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void set_news(string[] arr_news_data)
        {
            if (arr_news_data[1] == "retcode")
            {
                lb_news.Text = "没有未处理的消息";
                bt_agree.Hide();
                bt_refuse.Hide();

                news_type = 0;
                with_userid = "";
                with_username = "";
                with_groupid = "";
                with_groupname = "";
            }
            else
            {
                news_type = int.Parse(arr_news_data[1]);
                with_userid = arr_news_data[2];
                with_username = arr_news_data[3];
                with_groupid = arr_news_data[4];
                with_groupname = arr_news_data[5];

                string str_lb = "";
                if (news_type == (int)NEWS_TYPE.APPLY_FRIEND)
                {
                    str_lb = string.Format(@"{0}({1}) 请求添加你为好友", with_username, with_userid);
                }
                else if (news_type == (int)NEWS_TYPE.APPLY_GROUP)
                {
                    str_lb = string.Format(@"{0}({1}) 申请加入群 {2}({3})", with_username, with_userid, with_groupname, with_groupid);
                }
                lb_news.Text = str_lb;
                bt_agree.Show();
                bt_refuse.Show();
            }
        }

        private void bt_agree_Click(object sender, EventArgs e)
        {
            //同意好友申请、加群申请
            string str_msg = String.Format(@"operatenews&1&{0}&{1}&{2}", news_type, with_userid, with_groupid);
            Frm_login.send_data(str_msg);
            Hide();
        }

        private void bt_refuse_Click(object sender, EventArgs e)
        {
            //拒绝好友申请、加群申请
            string str_msg = String.Format(@"operatenews&0&{0}&{1}&{2}", news_type, with_userid, with_groupid);
            Frm_login.send_data(str_msg);
            Hide();
        }
    }
}
