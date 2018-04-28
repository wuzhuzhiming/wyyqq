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
    public partial class Frm_modify : Form
    {
        //鼠标移动的位置
        Point mouse_off;
        //是否为左键
        bool is_mouse_left;
        //头像编号
        int head_index = 1;

        public Frm_modify()
        {
            InitializeComponent();
        }

        public void set_user_info(string user_name, int user_head)
        {
            head_index = user_head;
            tb_name.Text = user_name;
            Frm_login frm_login = (Frm_login)(this.Owner.Owner);
            pb_head.BackgroundImage = frm_login.get_imglisthead().Images[user_head - 1];
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        //鼠标在窗体按下
        private void Frm_modify_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_off = new Point(-e.X, -e.Y);
                is_mouse_left = true;
            }
        }

        //鼠标移动
        private void Frm_modify_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                Point mouse_set = Control.MousePosition;
                mouse_set.Offset(mouse_off.X, mouse_off.Y);
                Location = mouse_set;
            }
        }

        //鼠标松开
        private void Frm_modify_MouseUp(object sender, MouseEventArgs e)
        {
            if (is_mouse_left)
            {
                is_mouse_left = false;
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

        private void bt_modify_Click(object sender, EventArgs e)
        {
            //获取用户输入的信息
            string str_pass = tb_pass.Text;
            string str_name = tb_name.Text;

            //检测密码、昵称的长度
            if (str_pass.Length > 0 && str_pass.Length < 6)
            {
                MessageBox.Show("密码不能少于6位");
                return;
            }
            if (str_name.Length < 1)
            {
                MessageBox.Show("昵称不能为空");
                return;
            }

            //如果用户资料发生了变化，则发送用户的新数据给服务器
            Frm_main frm_main = (Frm_main)(this.Owner);
            if ((str_pass.Length > 0 && str_pass != frm_main.self_pass) || 
                str_name != frm_main.self_name ||
                head_index != frm_main.self_head)
            {
                string str_msg = "modify&" + str_pass + "&" + str_name + "&" + head_index;
                Frm_login.send_data(str_msg);
            }

            Close();
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
            Frm_login frm_login = (Frm_login)(this.Owner);
            pb_head.BackgroundImage = frm_login.get_imglisthead().Images[head - 1];
        }
    }
}
