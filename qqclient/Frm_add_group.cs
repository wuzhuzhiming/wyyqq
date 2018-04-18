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
    public partial class Frm_add_group : Form
    {
        //鼠标移动的位置
        Point mouse_off;
        //是否为左键
        bool is_mouse_left;
        //查找到的用户groupid
        string find_groupid = "";

        public Frm_add_group()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            //获取用户输入的信息
            string str_input = tb_input.Text;
            if (str_input.Length < 8)
            {
                return;
            }

            //发送查找请求给服务器
            string str_msg = "findgroup&" + str_input;
            Frm_login.send_data(str_msg);
        }

        //加群按钮的点击处理
        private void bt_add_Click(object sender, EventArgs e)
        {
            if (find_groupid.Length > 0)
            {
                //发送查找请求给服务器
                string str_msg = String.Format("addgroup&{0}", find_groupid);
                Frm_login.send_data(str_msg);
            }
        }

        private void Frm_add_group_Load(object sender, EventArgs e)
        {
            //窗口加载时，隐藏查找结果控件
            lb_nogroup.Hide();
            pb_head.Hide();
            lb_name.Hide();
            lb_groupid.Hide();
            bt_add.Hide();
        }

        //鼠标在窗体按下
        private void Frm_add_group_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_off = new Point(-e.X, -e.Y);
                is_mouse_left = true;
            }
        }

        //鼠标移动
        private void Frm_add_group_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                Point mouse_set = Control.MousePosition;
                mouse_set.Offset(mouse_off.X, mouse_off.Y);
                Location = mouse_set;
            }
        }

        //鼠标松开
        private void Frm_add_group_MouseUp(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                is_mouse_left = false;
            }
        }

        //设置群的基本信息
        public void set_group_info(string[] arr_user_info)
        {
            if (arr_user_info[1] == "retcode")
            {
                pb_head.Hide();
                lb_name.Hide();
                lb_groupid.Hide();
                bt_add.Hide();
                lb_nogroup.Show();
                find_groupid = "";
            }
            else
            {
                lb_name.Text = arr_user_info[3];
                lb_groupid.Text = arr_user_info[2];

                int head_index = int.Parse(arr_user_info[5]);
                Frm_login frm_login = (Frm_login)(this.Owner);
                pb_head.BackgroundImage = frm_login.get_imglisthead().Images[head_index - 1];

                lb_nogroup.Hide();
                pb_head.Show();
                lb_name.Show();
                lb_groupid.Show();
                find_groupid = arr_user_info[2];

                //如果查找到的群，本人还不是该群成员，才显示申请加入按钮
                //if (frm_login.frm_main.cur_userid != int.Parse(find_groupid))
                //{
                //    bt_add.Show();
                //}
            }
        }
    }
}
