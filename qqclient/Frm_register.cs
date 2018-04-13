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
        public Frm_register()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        //鼠标移动的位置
        Point mouse_off;
        //是否为左键
        bool is_mouse_left;

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
            string str_head = str_sex;  //男女各有一个默认头像

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
    }
}
