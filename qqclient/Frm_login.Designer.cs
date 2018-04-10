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
            this.bt_login = new System.Windows.Forms.Button();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.link_lab_register = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // bt_login
            // 
            this.bt_login.BackgroundImage = global::qqclient.Properties.Resources.bt_login_bk;
            this.bt_login.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_login.Location = new System.Drawing.Point(220, 254);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(177, 42);
            this.bt_login.TabIndex = 0;
            this.bt_login.Text = "登录";
            this.bt_login.UseVisualStyleBackColor = true;
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(220, 128);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(206, 25);
            this.tb_account.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(220, 188);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(206, 25);
            this.tb_pass.TabIndex = 4;
            // 
            // link_lab_register
            // 
            this.link_lab_register.AutoSize = true;
            this.link_lab_register.Location = new System.Drawing.Point(423, 268);
            this.link_lab_register.Name = "link_lab_register";
            this.link_lab_register.Size = new System.Drawing.Size(37, 15);
            this.link_lab_register.TabIndex = 5;
            this.link_lab_register.TabStop = true;
            this.link_lab_register.Text = "注册";
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qqclient.Properties.Resources.login_bk;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.link_lab_register);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.bt_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
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
    }
}

