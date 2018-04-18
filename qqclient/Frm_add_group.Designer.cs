namespace qqclient
{
    partial class Frm_add_group
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
            this.lb_nogroup = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.lb_groupid = new System.Windows.Forms.Label();
            this.pb_head = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.bt_find = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nogroup
            // 
            this.lb_nogroup.AutoSize = true;
            this.lb_nogroup.BackColor = System.Drawing.Color.Transparent;
            this.lb_nogroup.Location = new System.Drawing.Point(64, 104);
            this.lb_nogroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nogroup.Name = "lb_nogroup";
            this.lb_nogroup.Size = new System.Drawing.Size(65, 12);
            this.lb_nogroup.TabIndex = 30;
            this.lb_nogroup.Text = "没有找到群";
            // 
            // bt_add
            // 
            this.bt_add.BackgroundImage = global::qqclient.Properties.Resources.bt_login_bk;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_add.Location = new System.Drawing.Point(66, 170);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 29;
            this.bt_add.Text = "申请加入";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // lb_groupid
            // 
            this.lb_groupid.AutoSize = true;
            this.lb_groupid.BackColor = System.Drawing.Color.Transparent;
            this.lb_groupid.Location = new System.Drawing.Point(116, 144);
            this.lb_groupid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_groupid.Name = "lb_groupid";
            this.lb_groupid.Size = new System.Drawing.Size(17, 12);
            this.lb_groupid.TabIndex = 28;
            this.lb_groupid.Text = "ID";
            // 
            // pb_head
            // 
            this.pb_head.BackColor = System.Drawing.Color.White;
            this.pb_head.Location = new System.Drawing.Point(66, 116);
            this.pb_head.Margin = new System.Windows.Forms.Padding(2);
            this.pb_head.Name = "pb_head";
            this.pb_head.Size = new System.Drawing.Size(38, 40);
            this.pb_head.TabIndex = 27;
            this.pb_head.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Location = new System.Drawing.Point(116, 116);
            this.lb_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(29, 12);
            this.lb_name.TabIndex = 26;
            this.lb_name.Text = "昵称";
            // 
            // bt_find
            // 
            this.bt_find.BackgroundImage = global::qqclient.Properties.Resources.bt_login_bk;
            this.bt_find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_find.Location = new System.Drawing.Point(300, 64);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(75, 23);
            this.bt_find.TabIndex = 25;
            this.bt_find.Text = "查找";
            this.bt_find.UseVisualStyleBackColor = true;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(66, 66);
            this.tb_input.MaxLength = 16;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(204, 21);
            this.tb_input.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(34, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 2);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "添加群";
            // 
            // bt_close
            // 
            this.bt_close.BackgroundImage = global::qqclient.Properties.Resources.bt_close;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_close.Location = new System.Drawing.Point(426, 2);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(21, 23);
            this.bt_close.TabIndex = 21;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // Frm_add_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qqclient.Properties.Resources.login_bk;
            this.ClientSize = new System.Drawing.Size(450, 230);
            this.Controls.Add(this.lb_nogroup);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.lb_groupid);
            this.Controls.Add(this.pb_head);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.bt_find);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_add_group";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加群";
            this.Load += new System.EventHandler(this.Frm_add_group_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_add_group_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_add_group_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_add_group_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nogroup;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label lb_groupid;
        private System.Windows.Forms.PictureBox pb_head;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_close;
    }
}