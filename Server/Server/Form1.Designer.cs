namespace Server
{
    partial class Server
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.butBeginSever = new System.Windows.Forms.Button();
            this.butSend = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.tmrGetMess = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxChatinfo = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtxSendMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // butBeginSever
            // 
            this.butBeginSever.Location = new System.Drawing.Point(295, 9);
            this.butBeginSever.Name = "butBeginSever";
            this.butBeginSever.Size = new System.Drawing.Size(100, 23);
            this.butBeginSever.TabIndex = 2;
            this.butBeginSever.Text = "启动服务器";
            this.butBeginSever.UseVisualStyleBackColor = true;
            this.butBeginSever.Click += new System.EventHandler(this.butBeginSever_Click);
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(234, 108);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(75, 23);
            this.butSend.TabIndex = 3;
            this.butSend.Text = "发送";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(329, 108);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 4;
            this.butClose.Text = "关闭";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // tmrGetMess
            // 
            this.tmrGetMess.Enabled = true;
            this.tmrGetMess.Tick += new System.EventHandler(this.tmrGetMess_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butBeginSever);
            this.groupBox1.Location = new System.Drawing.Point(22, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 36);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器连接";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxChatinfo);
            this.groupBox2.Location = new System.Drawing.Point(22, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 286);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "聊天信息";
            // 
            // rtxChatinfo
            // 
            this.rtxChatinfo.Location = new System.Drawing.Point(6, 20);
            this.rtxChatinfo.Name = "rtxChatinfo";
            this.rtxChatinfo.ReadOnly = true;
            this.rtxChatinfo.Size = new System.Drawing.Size(398, 260);
            this.rtxChatinfo.TabIndex = 0;
            this.rtxChatinfo.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtxSendMessage);
            this.groupBox3.Controls.Add(this.butClose);
            this.groupBox3.Controls.Add(this.butSend);
            this.groupBox3.Location = new System.Drawing.Point(22, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 137);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信息发送";
            // 
            // rtxSendMessage
            // 
            this.rtxSendMessage.Location = new System.Drawing.Point(6, 20);
            this.rtxSendMessage.Name = "rtxSendMessage";
            this.rtxSendMessage.Size = new System.Drawing.Size(398, 82);
            this.rtxSendMessage.TabIndex = 0;
            this.rtxSendMessage.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 495);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Server";
            this.Text = "服务器端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butBeginSever;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Timer tmrGetMess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxChatinfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtxSendMessage;
    }
}

