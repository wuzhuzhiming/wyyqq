﻿namespace qqclient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_min = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.pb_head = new System.Windows.Forms.PictureBox();
            this.lb_userid = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_add_friend = new System.Windows.Forms.Button();
            this.bt_add_group = new System.Windows.Forms.Button();
            this.bt_news = new System.Windows.Forms.Button();
            this.lv_friend = new System.Windows.Forms.ListView();
            this.imglist_head = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackgroundImage = global::qqclient.Properties.Resources.bt_close;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_close.Location = new System.Drawing.Point(329, 2);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.bt_min.Location = new System.Drawing.Point(292, 2);
            this.bt_min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.pb_head.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_head.Name = "pb_head";
            this.pb_head.Size = new System.Drawing.Size(51, 50);
            this.pb_head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 5);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // bt_add_friend
            // 
            this.bt_add_friend.BackgroundImage = global::qqclient.Properties.Resources.bt_add_friend;
            this.bt_add_friend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_add_friend.FlatAppearance.BorderSize = 0;
            this.bt_add_friend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_add_friend.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_add_friend.Location = new System.Drawing.Point(16, 754);
            this.bt_add_friend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add_friend.Name = "bt_add_friend";
            this.bt_add_friend.Size = new System.Drawing.Size(28, 29);
            this.bt_add_friend.TabIndex = 15;
            this.bt_add_friend.UseVisualStyleBackColor = true;
            this.bt_add_friend.Click += new System.EventHandler(this.bt_add_friend_Click);
            // 
            // bt_add_group
            // 
            this.bt_add_group.BackgroundImage = global::qqclient.Properties.Resources.bt_add_group;
            this.bt_add_group.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_add_group.FlatAppearance.BorderSize = 0;
            this.bt_add_group.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_add_group.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_add_group.Location = new System.Drawing.Point(52, 754);
            this.bt_add_group.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add_group.Name = "bt_add_group";
            this.bt_add_group.Size = new System.Drawing.Size(28, 29);
            this.bt_add_group.TabIndex = 16;
            this.bt_add_group.UseVisualStyleBackColor = true;
            this.bt_add_group.Click += new System.EventHandler(this.bt_add_group_Click);
            // 
            // bt_news
            // 
            this.bt_news.BackgroundImage = global::qqclient.Properties.Resources.bt_news;
            this.bt_news.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_news.FlatAppearance.BorderSize = 0;
            this.bt_news.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_news.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_news.Location = new System.Drawing.Point(88, 754);
            this.bt_news.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_news.Name = "bt_news";
            this.bt_news.Size = new System.Drawing.Size(28, 29);
            this.bt_news.TabIndex = 17;
            this.bt_news.UseVisualStyleBackColor = true;
            this.bt_news.Click += new System.EventHandler(this.bt_news_Click);
            // 
            // lv_friend
            // 
            this.lv_friend.BackColor = System.Drawing.Color.White;
            this.lv_friend.LargeImageList = this.imglist_head;
            this.lv_friend.Location = new System.Drawing.Point(13, 130);
            this.lv_friend.MultiSelect = false;
            this.lv_friend.Name = "lv_friend";
            this.lv_friend.Size = new System.Drawing.Size(335, 617);
            this.lv_friend.SmallImageList = this.imglist_head;
            this.lv_friend.StateImageList = this.imglist_head;
            this.lv_friend.TabIndex = 18;
            this.lv_friend.UseCompatibleStateImageBehavior = false;
            // 
            // imglist_head
            // 
            this.imglist_head.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist_head.ImageStream")));
            this.imglist_head.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist_head.Images.SetKeyName(0, "head1.jpg");
            this.imglist_head.Images.SetKeyName(1, "head2.jpg");
            this.imglist_head.Images.SetKeyName(2, "head3.jpg");
            this.imglist_head.Images.SetKeyName(3, "head4.jpg");
            this.imglist_head.Images.SetKeyName(4, "head5.jpg");
            this.imglist_head.Images.SetKeyName(5, "head6.jpg");
            this.imglist_head.Images.SetKeyName(6, "head7.jpg");
            this.imglist_head.Images.SetKeyName(7, "head8.jpg");
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qqclient.Properties.Resources.login_bk;
            this.ClientSize = new System.Drawing.Size(360, 792);
            this.Controls.Add(this.lv_friend);
            this.Controls.Add(this.bt_news);
            this.Controls.Add(this.bt_add_group);
            this.Controls.Add(this.bt_add_friend);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_userid);
            this.Controls.Add(this.pb_head);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.bt_min);
            this.Controls.Add(this.bt_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "即时通信";
            this.Load += new System.EventHandler(this.Frm_main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_main_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button bt_add_friend;
        private System.Windows.Forms.Button bt_add_group;
        private System.Windows.Forms.Button bt_news;
        private System.Windows.Forms.ListView lv_friend;
        private System.Windows.Forms.ImageList imglist_head;
    }
}