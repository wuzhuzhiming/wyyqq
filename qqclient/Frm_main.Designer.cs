namespace qqclient
{
    partial class Frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_min = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.pb_head = new System.Windows.Forms.PictureBox();
            this.lb_userid = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tc_friend = new System.Windows.Forms.TabControl();
            this.tp_friend = new System.Windows.Forms.TabPage();
            this.tp_group = new System.Windows.Forms.TabPage();
            this.bt_menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tc_friend.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackgroundImage = global::qqclient.Properties.Resources.bt_close;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_close.Location = new System.Drawing.Point(329, 3);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(28, 29);
            this.bt_close.TabIndex = 7;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_min
            // 
            this.bt_min.BackgroundImage = global::qqclient.Properties.Resources.bt_min;
            this.bt_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_min.FlatAppearance.BorderSize = 0;
            this.bt_min.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_min.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_min.Location = new System.Drawing.Point(292, 3);
            this.bt_min.Margin = new System.Windows.Forms.Padding(4);
            this.bt_min.Name = "bt_min";
            this.bt_min.Size = new System.Drawing.Size(28, 29);
            this.bt_min.TabIndex = 8;
            this.bt_min.UseVisualStyleBackColor = true;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Location = new System.Drawing.Point(97, 46);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(37, 15);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "昵称";
            // 
            // pb_head
            // 
            this.pb_head.BackColor = System.Drawing.Color.White;
            this.pb_head.Location = new System.Drawing.Point(31, 46);
            this.pb_head.Name = "pb_head";
            this.pb_head.Size = new System.Drawing.Size(50, 50);
            this.pb_head.TabIndex = 10;
            this.pb_head.TabStop = false;
            // 
            // lb_userid
            // 
            this.lb_userid.AutoSize = true;
            this.lb_userid.BackColor = System.Drawing.Color.Transparent;
            this.lb_userid.Location = new System.Drawing.Point(97, 81);
            this.lb_userid.Name = "lb_userid";
            this.lb_userid.Size = new System.Drawing.Size(23, 15);
            this.lb_userid.TabIndex = 11;
            this.lb_userid.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 5);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tc_friend
            // 
            this.tc_friend.Controls.Add(this.tp_friend);
            this.tc_friend.Controls.Add(this.tp_group);
            this.tc_friend.Location = new System.Drawing.Point(12, 141);
            this.tc_friend.Name = "tc_friend";
            this.tc_friend.SelectedIndex = 0;
            this.tc_friend.Size = new System.Drawing.Size(336, 606);
            this.tc_friend.TabIndex = 13;
            this.tc_friend.Tag = "";
            // 
            // tp_friend
            // 
            this.tp_friend.BackColor = System.Drawing.Color.White;
            this.tp_friend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_friend.Location = new System.Drawing.Point(4, 25);
            this.tp_friend.Name = "tp_friend";
            this.tp_friend.Padding = new System.Windows.Forms.Padding(3);
            this.tp_friend.Size = new System.Drawing.Size(328, 577);
            this.tp_friend.TabIndex = 0;
            this.tp_friend.Text = "好友               ";
            // 
            // tp_group
            // 
            this.tp_group.BackColor = System.Drawing.Color.White;
            this.tp_group.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tp_group.Location = new System.Drawing.Point(4, 25);
            this.tp_group.Name = "tp_group";
            this.tp_group.Padding = new System.Windows.Forms.Padding(3);
            this.tp_group.Size = new System.Drawing.Size(328, 577);
            this.tp_group.TabIndex = 1;
            this.tp_group.Text = "群                ";
            // 
            // bt_menu
            // 
            this.bt_menu.BackgroundImage = global::qqclient.Properties.Resources.bt_menu;
            this.bt_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_menu.FlatAppearance.BorderSize = 0;
            this.bt_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_menu.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_menu.Location = new System.Drawing.Point(12, 754);
            this.bt_menu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(28, 29);
            this.bt_menu.TabIndex = 14;
            this.bt_menu.UseVisualStyleBackColor = true;
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qqclient.Properties.Resources.login_bk;
            this.ClientSize = new System.Drawing.Size(360, 793);
            this.Controls.Add(this.bt_menu);
            this.Controls.Add(this.tc_friend);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_userid);
            this.Controls.Add(this.pb_head);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.bt_min);
            this.Controls.Add(this.bt_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "即时通信";
            this.Load += new System.EventHandler(this.Frm_main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_main_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tc_friend.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_min;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.PictureBox pb_head;
        private System.Windows.Forms.Label lb_userid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tc_friend;
        private System.Windows.Forms.TabPage tp_friend;
        private System.Windows.Forms.TabPage tp_group;
        private System.Windows.Forms.Button bt_menu;
    }
}