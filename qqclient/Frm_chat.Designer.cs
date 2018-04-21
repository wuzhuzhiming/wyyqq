namespace qqclient
{
    partial class Frm_chat
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
            this.bt_min = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.lb_userid = new System.Windows.Forms.Label();
            this.pb_head = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.rtxt_msg = new System.Windows.Forms.RichTextBox();
            this.rtxt_chat = new System.Windows.Forms.RichTextBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.bt_close2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_min
            // 
            this.bt_min.BackgroundImage = global::qqclient.Properties.Resources.bt_min;
            this.bt_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_min.FlatAppearance.BorderSize = 0;
            this.bt_min.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_min.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_min.Location = new System.Drawing.Point(548, 3);
            this.bt_min.Name = "bt_min";
            this.bt_min.Size = new System.Drawing.Size(21, 23);
            this.bt_min.TabIndex = 2;
            this.bt_min.UseVisualStyleBackColor = true;
            this.bt_min.Click += new System.EventHandler(this.bt_min_Click);
            // 
            // bt_close
            // 
            this.bt_close.BackgroundImage = global::qqclient.Properties.Resources.bt_close;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_close.Location = new System.Drawing.Point(576, 3);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(21, 23);
            this.bt_close.TabIndex = 3;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // lb_userid
            // 
            this.lb_userid.AutoSize = true;
            this.lb_userid.BackColor = System.Drawing.Color.Transparent;
            this.lb_userid.Location = new System.Drawing.Point(60, 37);
            this.lb_userid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_userid.Name = "lb_userid";
            this.lb_userid.Size = new System.Drawing.Size(17, 12);
            this.lb_userid.TabIndex = 14;
            this.lb_userid.Text = "ID";
            // 
            // pb_head
            // 
            this.pb_head.BackColor = System.Drawing.Color.White;
            this.pb_head.Location = new System.Drawing.Point(10, 11);
            this.pb_head.Margin = new System.Windows.Forms.Padding(2);
            this.pb_head.Name = "pb_head";
            this.pb_head.Size = new System.Drawing.Size(38, 40);
            this.pb_head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_head.TabIndex = 13;
            this.pb_head.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Location = new System.Drawing.Point(60, 13);
            this.lb_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(29, 12);
            this.lb_name.TabIndex = 12;
            this.lb_name.Text = "昵称";
            // 
            // rtxt_msg
            // 
            this.rtxt_msg.BackColor = System.Drawing.Color.White;
            this.rtxt_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_msg.Location = new System.Drawing.Point(10, 56);
            this.rtxt_msg.Name = "rtxt_msg";
            this.rtxt_msg.ReadOnly = true;
            this.rtxt_msg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxt_msg.Size = new System.Drawing.Size(578, 278);
            this.rtxt_msg.TabIndex = 4;
            this.rtxt_msg.Text = "";
            // 
            // rtxt_chat
            // 
            this.rtxt_chat.BackColor = System.Drawing.Color.White;
            this.rtxt_chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_chat.Location = new System.Drawing.Point(10, 346);
            this.rtxt_chat.Name = "rtxt_chat";
            this.rtxt_chat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxt_chat.Size = new System.Drawing.Size(578, 65);
            this.rtxt_chat.TabIndex = 0;
            this.rtxt_chat.Text = "";
            // 
            // bt_send
            // 
            this.bt_send.BackgroundImage = global::qqclient.Properties.Resources.bt_login_bk;
            this.bt_send.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.bt_send.FlatAppearance.BorderSize = 0;
            this.bt_send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_send.Location = new System.Drawing.Point(501, 417);
            this.bt_send.Margin = new System.Windows.Forms.Padding(2);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(87, 25);
            this.bt_send.TabIndex = 1;
            this.bt_send.Text = "发送";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // bt_close2
            // 
            this.bt_close2.BackgroundImage = global::qqclient.Properties.Resources.bt_login_bk;
            this.bt_close2.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.bt_close2.FlatAppearance.BorderSize = 0;
            this.bt_close2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close2.Location = new System.Drawing.Point(400, 417);
            this.bt_close2.Margin = new System.Windows.Forms.Padding(2);
            this.bt_close2.Name = "bt_close2";
            this.bt_close2.Size = new System.Drawing.Size(87, 25);
            this.bt_close2.TabIndex = 5;
            this.bt_close2.Text = "关闭";
            this.bt_close2.UseVisualStyleBackColor = true;
            this.bt_close2.Click += new System.EventHandler(this.bt_close2_Click);
            // 
            // Frm_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qqclient.Properties.Resources.login_bk;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.bt_close2);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.rtxt_chat);
            this.Controls.Add(this.rtxt_msg);
            this.Controls.Add(this.lb_userid);
            this.Controls.Add(this.pb_head);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.bt_min);
            this.Controls.Add(this.bt_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "聊天中";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_chat_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_chat_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_chat_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_min;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label lb_userid;
        private System.Windows.Forms.PictureBox pb_head;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.RichTextBox rtxt_msg;
        private System.Windows.Forms.RichTextBox rtxt_chat;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.Button bt_close2;
    }
}