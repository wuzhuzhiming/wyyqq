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
            this.bt_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "监听IP：";
            // 
            // Tb_ip
            // 
            this.Tb_ip.Location = new System.Drawing.Point(235, 81);
            this.Tb_ip.Name = "Tb_ip";
            this.Tb_ip.Size = new System.Drawing.Size(201, 25);
            this.Tb_ip.TabIndex = 1;
            this.Tb_ip.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "监听端口：";
            // 
            // Tb_port
            // 
            this.Tb_port.Location = new System.Drawing.Point(235, 152);
            this.Tb_port.Name = "Tb_port";
            this.Tb_port.Size = new System.Drawing.Size(201, 25);
            this.Tb_port.TabIndex = 3;
            this.Tb_port.Text = "5000";
            // 
            // Bt_start
            // 
            this.Bt_start.Location = new System.Drawing.Point(134, 220);
            this.Bt_start.Name = "Bt_start";
            this.Bt_start.Size = new System.Drawing.Size(111, 32);
            this.Bt_start.TabIndex = 4;
            this.Bt_start.Text = "启动服务器";
            this.Bt_start.UseVisualStyleBackColor = true;
            this.Bt_start.Click += new System.EventHandler(this.Bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(325, 220);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(111, 32);
            this.bt_stop.TabIndex = 5;
            this.bt_stop.Text = "关闭服务器";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.Bt_stop_Click);
            // 
            // Frm_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.Bt_start);
            this.Controls.Add(this.Tb_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_ip);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Frm_server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "即时通信-服务器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_port;
        private System.Windows.Forms.Button Bt_start;
        private System.Windows.Forms.Button bt_stop;
    }
}

