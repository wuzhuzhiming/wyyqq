namespace qqclient
{
    partial class Frm_add_friend
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.bt_find = new System.Windows.Forms.Button();
            this.lb_userid = new System.Windows.Forms.Label();
            this.pb_head = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.lb_nouser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackgroundImage = global::qqclient.Properties.Resources.bt_close;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_close.Location = new System.Drawing.Point(568, 2);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(28, 29);
            this.bt_close.TabIndex = 8;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "添加好友";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(45, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 2);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(88, 82);
            this.tb_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_input.MaxLength = 16;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(271, 25);
            this.tb_input.TabIndex = 14;
            // 
            // bt_find
            // 
            this.bt_find.BackgroundImage = global::qqclient.Properties.Resources.bt_login_bk;
            this.bt_find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_find.Location = new System.Drawing.Point(400, 80);
            this.bt_find.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(100, 29);
            this.bt_find.TabIndex = 15;
            this.bt_find.Text = "查找";
            this.bt_find.UseVisualStyleBackColor = true;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // lb_userid
            // 
            this.lb_userid.AutoSize = true;
            this.lb_userid.BackColor = System.Drawing.Color.Transparent;
            this.lb_userid.Location = new System.Drawing.Point(155, 180);
            this.lb_userid.Name = "lb_userid";
            this.lb_userid.Size = new System.Drawing.Size(23, 15);
            this.lb_userid.TabIndex = 18;
            this.lb_userid.Text = "ID";
            // 
            // pb_head
            // 
            this.pb_head.BackColor = System.Drawing.Color.White;
            this.pb_head.Location = new System.Drawing.Point(88, 145);
            this.pb_head.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_head.Name = "pb_head";
            this.pb_head.Size = new System.Drawing.Size(51, 50);
            this.pb_head.TabIndex = 17;
            this.pb_head.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Location = new System.Drawing.Point(155, 145);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(37, 15);
            this.lb_name.TabIndex = 16;
            this.lb_name.Text = "昵称";
            // 
            // bt_add
            // 
            this.bt_add.BackgroundImage = global::qqclient.Properties.Resources.bt_login_bk;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_add.Location = new System.Drawing.Point(88, 212);
            this.bt_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(100, 29);
            this.bt_add.TabIndex = 19;
            this.bt_add.Text = "加好友";
            this.bt_add.UseVisualStyleBackColor = true;
            // 
            // lb_nouser
            // 
            this.lb_nouser.AutoSize = true;
            this.lb_nouser.BackColor = System.Drawing.Color.Transparent;
            this.lb_nouser.Location = new System.Drawing.Point(85, 130);
            this.lb_nouser.Name = "lb_nouser";
            this.lb_nouser.Size = new System.Drawing.Size(127, 15);
            this.lb_nouser.TabIndex = 20;
            this.lb_nouser.Text = "没有找到用户信息";
            // 
            // Frm_add_friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qqclient.Properties.Resources.login_bk;
            this.ClientSize = new System.Drawing.Size(600, 288);
            this.Controls.Add(this.lb_nouser);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.lb_userid);
            this.Controls.Add(this.pb_head);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.bt_find);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_add_friend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加好友";
            this.Load += new System.EventHandler(this.Frm_add_friend_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_add_friend_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_add_friend_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_add_friend_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.Label lb_userid;
        private System.Windows.Forms.PictureBox pb_head;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label lb_nouser;
    }
}