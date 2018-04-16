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
    public partial class Frm_add_friend : Form
    {
        //鼠标移动的位置
        Point mouse_off;
        //是否为左键
        bool is_mouse_left;

        public Frm_add_friend()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        //鼠标在窗体按下
        private void Frm_add_friend_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_off = new Point(-e.X, -e.Y);
                is_mouse_left = true;
            }
        }

        //鼠标移动
        private void Frm_add_friend_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                Point mouse_set = Control.MousePosition;
                mouse_set.Offset(mouse_off.X, mouse_off.Y);
                Location = mouse_set;
            }
        }

        //鼠标松开
        private void Frm_add_friend_MouseUp(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                is_mouse_left = false;
            }
        }

        private void Frm_add_friend_Load(object sender, EventArgs e)
        {
            //窗口加载时，隐藏查找结果控件
            lb_nouser.Hide();
            pb_head.Hide();
            lb_name.Hide();
            lb_userid.Hide();
            bt_add.Hide();
        }

        //查找按钮点击处理
        private void bt_find_Click(object sender, EventArgs e)
        {
            //获取用户输入的信息
            string str_input = tb_input.Text;
            if (str_input.Length < 1)
            {
                return;
            }

            //发送查找请求给服务器
            string str_msg = "finduser&" + str_input;
            Frm_login.send_data(str_msg);
        }

        //设置用户基本信息
        public void set_user_info(string[] arr_user_info)
        {
            if (arr_user_info[1] == "retcode")
            {
                pb_head.Hide();
                lb_name.Hide();
                lb_userid.Hide();
                bt_add.Hide();
                lb_nouser.Show();
            }
            else
            {
                lb_name.Text = arr_user_info[3];
                lb_userid.Text = arr_user_info[2];

                int head_index = int.Parse(arr_user_info[5]);
                switch (head_index)
                {
                    case 1:
                        pb_head.BackgroundImage = global::qqclient.Properties.Resources.head1;
                        break;
                    case 2:
                        pb_head.BackgroundImage = global::qqclient.Properties.Resources.head2;
                        break;
                    case 3:
                        pb_head.BackgroundImage = global::qqclient.Properties.Resources.head3;
                        break;
                    case 4:
                        pb_head.BackgroundImage = global::qqclient.Properties.Resources.head4;
                        break;
                    case 5:
                        pb_head.BackgroundImage = global::qqclient.Properties.Resources.head5;
                        break;
                    case 6:
                        pb_head.BackgroundImage = global::qqclient.Properties.Resources.head6;
                        break;
                    case 7:
                        pb_head.BackgroundImage = global::qqclient.Properties.Resources.head7;
                        break;
                    case 8:
                        pb_head.BackgroundImage = global::qqclient.Properties.Resources.head8;
                        break;
                    default:
                        pb_head.BackgroundImage = global::qqclient.Properties.Resources.head8;
                        break;
                }

                lb_nouser.Hide();
                pb_head.Show();
                lb_name.Show();
                lb_userid.Show();
                bt_add.Show();
            }
        }
    }
}
