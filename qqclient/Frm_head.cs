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
    public partial class Frm_head : Form
    {
        //父窗口类型 1-注册窗口 2-修改资料窗口
        public int owner_type = 1;

        public Frm_head()
        {
            InitializeComponent();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            Frm_register frm_register = (Frm_register)this.Owner;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        //传递数据给父窗口
        private void set_selected_head(int selected_index)
        {
            if (owner_type == 1)
            {
                Frm_register frm_register = (Frm_register)this.Owner;
                frm_register.select_head(selected_index);
            }
            else if (owner_type == 2)
            {
                Frm_modify frm_modify = (Frm_modify)this.Owner;
                frm_modify.select_head(selected_index);
            }

            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            set_selected_head(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            set_selected_head(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            set_selected_head(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            set_selected_head(4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            set_selected_head(5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            set_selected_head(6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            set_selected_head(7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            set_selected_head(8);
        }

        private void Frm_head_Load(object sender, EventArgs e)
        {
            Frm_login frm_login = null;
            if (owner_type == 1)
            {
                frm_login = (Frm_login)(this.Owner.Owner);
            }
            else if (owner_type == 2)
            {
                frm_login = (Frm_login)(this.Owner.Owner.Owner);
            }
            else
            {
                return;
            }
            
            pictureBox1.BackgroundImage = frm_login.get_imglisthead().Images[0];
            pictureBox2.BackgroundImage = frm_login.get_imglisthead().Images[1];
            pictureBox3.BackgroundImage = frm_login.get_imglisthead().Images[2];
            pictureBox4.BackgroundImage = frm_login.get_imglisthead().Images[3];
            pictureBox5.BackgroundImage = frm_login.get_imglisthead().Images[4];
            pictureBox6.BackgroundImage = frm_login.get_imglisthead().Images[5];
            pictureBox7.BackgroundImage = frm_login.get_imglisthead().Images[6];
            pictureBox8.BackgroundImage = frm_login.get_imglisthead().Images[7];
        }
    }
}
