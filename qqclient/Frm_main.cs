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

        //设置用户基本信息
        public void set_user_info(string[] arr_user_info)
        {
            lb_name.Text = arr_user_info[3];
            lb_userid.Text = arr_user_info[2];

            int head_index = int.Parse(arr_user_info[5]);
            switch(head_index)
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
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {

        }

        private void bt_add_friend_Click(object sender, EventArgs e)
        {
            //弹出添加好友窗口
            Frm_add_friend frm_add_friend = new Frm_add_friend();
            frm_add_friend.Show();
        }
    }
}
