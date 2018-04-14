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
    public partial class Frm_register : Form
    {
        //鼠标移动的位置
        Point mouse_off;
        //是否为左键
        bool is_mouse_left;
        //头像编号
        int head_index = 8;

        public Frm_register()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        //鼠标在窗体按下
        private void Frm_register_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_off = new Point(-e.X, -e.Y);
                is_mouse_left = true;
            }
        }

        //鼠标移动
        private void Frm_register_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                Point mouse_set = Control.MousePosition;
                mouse_set.Offset(mouse_off.X, mouse_off.Y);
                Location = mouse_set;
            }
        }

        //鼠标松开
        private void Frm_register_MouseUp(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                is_mouse_left = false;
            }
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

        private void bt_register_Click(object sender, EventArgs e)
        {
            //获取用户输入的信息
            string str_account = tb_account.Text;
            string str_pass = tb_pass.Text;
            string str_name = tb_name.Text;
            string str_sex = "2";   //性别 1-男 2-女
            if (rb_man.Checked)
            {
                str_sex = "1";
            }
            string str_head = head_index.ToString();

            //检测账号、密码、昵称的长度
            if (str_account.Length < 8)
            {
                MessageBox.Show("账号不能少于8位");
                return;
            }
            if (str_pass.Length < 6)
            {
                MessageBox.Show("密码不能少于6位");
                return;
            }
            if (str_name.Length < 1)
            {
                MessageBox.Show("昵称不能为空");
                return;
            }

            //发送用户的注册信息给服务器
            string str_msg = "register&" + str_account + "&" + str_pass + "&" + str_name + "&" + str_sex + "&" + str_head;
            Frm_login.send_data(str_msg);
        }

        //点击头像按钮的处理
        private void pb_head_Click(object sender, EventArgs e)
        {
            Frm_head frm_head = new Frm_head();
            frm_head.Owner = this;
            frm_head.Show();
        }

        //选择头像之后的处理
        public void select_head(int head)
        {
            head_index = head;

            switch(head)
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
                    break;
            }
        }
    }
}
