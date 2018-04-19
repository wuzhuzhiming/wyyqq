namespace qqclient
{
    partial class Frm_news
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
            this.lb_news = new System.Windows.Forms.Label();
            this.bt_agree = new System.Windows.Forms.Button();
            this.bt_refuse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackgroundImage = global::qqclient.Properties.Resources.bt_close;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_close.Location = new System.Drawing.Point(480, 2);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(21, 23);
            this.bt_close.TabIndex = 9;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "消息";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(34, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 2);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lb_news
            // 
            this.lb_news.AutoSize = true;
            this.lb_news.BackColor = System.Drawing.Color.Transparent;
            this.lb_news.Location = new System.Drawing.Point(60, 75);
            this.lb_news.Name = "lb_news";
            this.lb_news.Size = new System.Drawing.Size(101, 12);
            this.lb_news.TabIndex = 15;
            this.lb_news.Text = "没有未处理的消息";
            // 
            // bt_agree
            // 
            this.bt_agree.BackgroundImage = global::qqclient.Properties.Resources.bt_login_bk;
            this.bt_agree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_agree.Location = new System.Drawing.Point(226, 132);
            this.bt_agree.Name = "bt_agree";
            this.bt_agree.Size = new System.Drawing.Size(75, 23);
            this.bt_agree.TabIndex = 16;
            this.bt_agree.Text = "同意";
            this.bt_agree.UseVisualStyleBackColor = true;
            this.bt_agree.Click += new System.EventHandler(this.bt_agree_Click);
            // 
            // bt_refuse
            // 
            this.bt_refuse.BackgroundImage = global::qqclient.Properties.Resources.bt_login_bk;
            this.bt_refuse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_refuse.Location = new System.Drawing.Point(328, 132);
            this.bt_refuse.Name = "bt_refuse";
            this.bt_refuse.Size = new System.Drawing.Size(75, 23);
            this.bt_refuse.TabIndex = 17;
            this.bt_refuse.Text = "拒绝";
            this.bt_refuse.UseVisualStyleBackColor = true;
            this.bt_refuse.Click += new System.EventHandler(this.bt_refuse_Click);
            // 
            // Frm_news
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::qqclient.Properties.Resources.login_bk;
            this.ClientSize = new System.Drawing.Size(504, 189);
            this.Controls.Add(this.bt_refuse);
            this.Controls.Add(this.bt_agree);
            this.Controls.Add(this.lb_news);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_news";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "消息";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_news_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_news_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_news_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_news;
        private System.Windows.Forms.Button bt_agree;
        private System.Windows.Forms.Button bt_refuse;
    }
}