namespace qqclient
{
    partial class Frm_modify
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
            this.bt_modify = new System.Windows.Forms.Button();
            this.pb_head = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_modify
            // 
            this.bt_modify.BackgroundImage = global::qqclient.Properties.Resources.bt_login_bk;
            this.bt_modify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_modify.Location = new System.Drawing.Point(202, 208);
            this.bt_modify.Name = "bt_modify";
            this.bt_modify.Size = new System.Drawing.Size(133, 34);
            this.bt_modify.TabIndex = 26;
            this.bt_modify.Text = "修改";
            this.bt_modify.UseVisualStyleBackColor = true;
            this.bt_modify.Click += new System.EventHandler(this.bt_modify_Click);
            // 
            // pb_head
            // 
            this.pb_head.BackColor = System.Drawing.Color.Transparent;
            this.pb_head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_head.Location = new System.Drawing.Point(202, 147);
            this.pb_head.Name = "pb_head";
            this.pb_head.Size = new System.Drawing.Size(38, 40);
            this.pb_head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_head.TabIndex = 35;
            this.pb_head.TabStop = false;
            this.pb_head.Click += new System.EventHandler(this.pb_head_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(135, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 34;
            this.label6.Text = "头像：";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(202, 104);
            this.tb_name.MaxLength = 16;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(156, 21);
            this.tb_name.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(135, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "昵称：";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(202, 62);
            this.tb_pass.MaxLength = 16;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(156, 21);
            this.tb_pass.TabIndex = 22;
            this.tb_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pass_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(135, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "密码：";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(29, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(450, 1);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "修改资料";
            // 
            // bt_close
            // 
            this.bt_close.BackgroundImage = global::qqclient.Properties.Resources.bt_close;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_close.Location = new System.Drawing.Point(487, 2);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(21, 23);
            this.bt_close.TabIndex = 27;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // Frm_modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qqclient.Properties.Resources.login_bk;
            this.ClientSize = new System.Drawing.Size(510, 266);
            this.Controls.Add(this.bt_modify);
            this.Controls.Add(this.pb_head);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改资料";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_modify_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_modify_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_modify_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_head)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_modify;
        private System.Windows.Forms.PictureBox pb_head;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_close;
    }
}