namespace qqclient
{
    partial class Frm_register
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_man = new System.Windows.Forms.RadioButton();
            this.rb_woman = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pb_head = new System.Windows.Forms.PictureBox();
            this.bt_register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackgroundImage = global::qqclient.Properties.Resources.bt_close;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_close.Location = new System.Drawing.Point(649, 3);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(28, 29);
            this.bt_close.TabIndex = 6;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户注册";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(39, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(600, 1);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(180, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "账号：";
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(269, 71);
            this.tb_account.Margin = new System.Windows.Forms.Padding(4);
            this.tb_account.MaxLength = 16;
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(207, 25);
            this.tb_account.TabIndex = 0;
            this.tb_account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_account_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(180, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "密码：";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(269, 124);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pass.MaxLength = 16;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(207, 25);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pass_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(180, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "昵称：";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(269, 176);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name.MaxLength = 16;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(207, 25);
            this.tb_name.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(180, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "性别：";
            // 
            // rb_man
            // 
            this.rb_man.AutoSize = true;
            this.rb_man.BackColor = System.Drawing.Color.Transparent;
            this.rb_man.Location = new System.Drawing.Point(269, 230);
            this.rb_man.Margin = new System.Windows.Forms.Padding(4);
            this.rb_man.Name = "rb_man";
            this.rb_man.Size = new System.Drawing.Size(43, 19);
            this.rb_man.TabIndex = 3;
            this.rb_man.Text = "男";
            this.rb_man.UseVisualStyleBackColor = false;
            // 
            // rb_woman
            // 
            this.rb_woman.AutoSize = true;
            this.rb_woman.BackColor = System.Drawing.Color.Transparent;
            this.rb_woman.Checked = true;
            this.rb_woman.Location = new System.Drawing.Point(341, 230);
            this.rb_woman.Margin = new System.Windows.Forms.Padding(4);
            this.rb_woman.Name = "rb_woman";
            this.rb_woman.Size = new System.Drawing.Size(43, 19);
            this.rb_woman.TabIndex = 4;
            this.rb_woman.TabStop = true;
            this.rb_woman.Text = "女";
            this.rb_woman.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(180, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "头像：";
            // 
            // pb_head
            // 
            this.pb_head.BackColor = System.Drawing.Color.Transparent;
            this.pb_head.BackgroundImage = global::qqclient.Properties.Resources.head8;
            this.pb_head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_head.Location = new System.Drawing.Point(269, 285);
            this.pb_head.Margin = new System.Windows.Forms.Padding(4);
            this.pb_head.Name = "pb_head";
            this.pb_head.Size = new System.Drawing.Size(50, 50);
            this.pb_head.TabIndex = 20;
            this.pb_head.TabStop = false;
            this.pb_head.Click += new System.EventHandler(this.pb_head_Click);
            // 
            // bt_register
            // 
            this.bt_register.BackgroundImage = global::qqclient.Properties.Resources.bt_login_bk;
            this.bt_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_register.Location = new System.Drawing.Point(269, 379);
            this.bt_register.Margin = new System.Windows.Forms.Padding(4);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(177, 42);
            this.bt_register.TabIndex = 5;
            this.bt_register.Text = "注册";
            this.bt_register.UseVisualStyleBackColor = true;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // Frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qqclient.Properties.Resources.login_bk;
            this.ClientSize = new System.Drawing.Size(680, 466);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.pb_head);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rb_woman);
            this.Controls.Add(this.rb_man);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_register";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_register_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_register_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_register_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_man;
        private System.Windows.Forms.RadioButton rb_woman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pb_head;
        private System.Windows.Forms.Button bt_register;
    }
}