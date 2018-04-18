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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_register frm_register = (Frm_register)this.Owner;
            frm_register.select_head(1);
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_register frm_register = (Frm_register)this.Owner;
            frm_register.select_head(2);
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Frm_register frm_register = (Frm_register)this.Owner;
            frm_register.select_head(3);
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Frm_register frm_register = (Frm_register)this.Owner;
            frm_register.select_head(4);
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Frm_register frm_register = (Frm_register)this.Owner;
            frm_register.select_head(5);
            Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Frm_register frm_register = (Frm_register)this.Owner;
            frm_register.select_head(6);
            Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Frm_register frm_register = (Frm_register)this.Owner;
            frm_register.select_head(7);
            Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Frm_register frm_register = (Frm_register)this.Owner;
            frm_register.select_head(8);
            Close();
        }

        private void Frm_head_Load(object sender, EventArgs e)
        {
            Frm_login frm_login = (Frm_login)(this.Owner.Owner);
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
