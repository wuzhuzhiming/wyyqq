namespace qqserver
{
    partial class Frm_server
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_port = new System.Windows.Forms.TextBox();
            this.Bt_start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "监听IP：";
            // 
            // Tb_ip
            // 
            this.Tb_ip.Location = new System.Drawing.Point(176, 65);
            this.Tb_ip.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_ip.Name = "Tb_ip";
            this.Tb_ip.Size = new System.Drawing.Size(152, 21);
            this.Tb_ip.TabIndex = 1;
            this.Tb_ip.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "监听端口：";
            // 
            // Tb_port
            // 
            this.Tb_port.Location = new System.Drawing.Point(176, 122);
            this.Tb_port.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_port.Name = "Tb_port";
            this.Tb_port.Size = new System.Drawing.Size(152, 21);
            this.Tb_port.TabIndex = 3;
            this.Tb_port.Text = "5000";
            // 
            // Bt_start
            // 
            this.Bt_start.Location = new System.Drawing.Point(176, 177);
            this.Bt_start.Margin = new System.Windows.Forms.Padding(2);
            this.Bt_start.Name = "Bt_start";
            this.Bt_start.Size = new System.Drawing.Size(83, 26);
            this.Bt_start.TabIndex = 4;
            this.Bt_start.Text = "启动服务器";
            this.Bt_start.UseVisualStyleBackColor = true;
            this.Bt_start.Click += new System.EventHandler(this.Bt_start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 5;
            // 
            // Frm_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(438, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bt_start);
            this.Controls.Add(this.Tb_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_ip);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(454, 328);
            this.MinimumSize = new System.Drawing.Size(454, 328);
            this.Name = "Frm_server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "即时通信-服务器";
            this.Load += new System.EventHandler(this.Frm_server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_port;
        private System.Windows.Forms.Button Bt_start;
        private System.Windows.Forms.Label label3;
    }
}

