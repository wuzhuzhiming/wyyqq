namespace qqclient
{
    partial class Frm_login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.bt_login = new System.Windows.Forms.Button();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.link_lab_register = new System.Windows.Forms.LinkLabel();
            this.bt_close = new System.Windows.Forms.Button();
            this.imglisthead = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // bt_login
            // 
            this.bt_login.BackgroundImage = global::qqclient.Properties.Resources.bt_login_bk;
            this.bt_login.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_login.Location = new System.Drawing.Point(220, 254);
            this.bt_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(177, 42);
            this.bt_login.TabIndex = 2;
            this.bt_login.Text = "登录";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(220, 128);
            this.tb_account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_account.MaxLength = 16;
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(207, 25);
            this.tb_account.TabIndex = 0;
            this.tb_account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_account_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(163, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(163, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(220, 188);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pass.MaxLength = 16;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(207, 25);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pass_KeyPress);
            // 
            // link_lab_register
            // 
            this.link_lab_register.AutoSize = true;
            this.link_lab_register.Location = new System.Drawing.Point(423, 268);
            this.link_lab_register.Name = "link_lab_register";
            this.link_lab_register.Size = new System.Drawing.Size(37, 15);
            this.link_lab_register.TabIndex = 3;
            this.link_lab_register.TabStop = true;
            this.link_lab_register.Text = "注册";
            this.link_lab_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lab_register_LinkClicked);
            // 
            // bt_close
            // 
            this.bt_close.BackgroundImage = global::qqclient.Properties.Resources.bt_close;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_close.Location = new System.Drawing.Point(568, 3);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(28, 29);
            this.bt_close.TabIndex = 4;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // imglisthead
            // 
            this.imglisthead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglisthead.ImageStream")));
            this.imglisthead.TransparentColor = System.Drawing.Color.Transparent;
            this.imglisthead.Images.SetKeyName(0, "head1.jpg");
            this.imglisthead.Images.SetKeyName(1, "head2.jpg");
            this.imglisthead.Images.SetKeyName(2, "head3.jpg");
            this.imglisthead.Images.SetKeyName(3, "head4.jpg");
            this.imglisthead.Images.SetKeyName(4, "head5.jpg");
            this.imglisthead.Images.SetKeyName(5, "head6.jpg");
            this.imglisthead.Images.SetKeyName(6, "head7.jpg");
            this.imglisthead.Images.SetKeyName(7, "head8.jpg");
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qqclient.Properties.Resources.login_bk;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.link_lab_register);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.bt_login);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_login_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.LinkLabel link_lab_register;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.ImageList imglisthead;
    }
}

