namespace Client
{
    partial class Client
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
            this.主机信息 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeverIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.rtxChatInfo = new System.Windows.Forms.RichTextBox();
            this.rtxSendMessage = new System.Windows.Forms.RichTextBox();
            this.butConnect = new System.Windows.Forms.Button();
            this.butSend = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.tmrGetMess = new System.Windows.Forms.Timer(this.components);
            this.主机信息.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 主机信息
            // 
            this.主机信息.Controls.Add(this.butConnect);
            this.主机信息.Controls.Add(this.txtPort);
            this.主机信息.Controls.Add(this.txtSeverIp);
            this.主机信息.Controls.Add(this.label2);
            this.主机信息.Controls.Add(this.label1);
            this.主机信息.Location = new System.Drawing.Point(12, 12);
            this.主机信息.Name = "主机信息";
            this.主机信息.Size = new System.Drawing.Size(417, 52);
            this.主机信息.TabIndex = 0;
            this.主机信息.TabStop = false;
            this.主机信息.Text = "主机信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxChatInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "聊天信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butClose);
            this.groupBox2.Controls.Add(this.butSend);
            this.groupBox2.Controls.Add(this.rtxSendMessage);
            this.groupBox2.Location = new System.Drawing.Point(12, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息发送";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口";
            // 
            // txtSeverIp
            // 
            this.txtSeverIp.Location = new System.Drawing.Point(75, 18);
            this.txtSeverIp.Name = "txtSeverIp";
            this.txtSeverIp.Size = new System.Drawing.Size(133, 21);
            this.txtSeverIp.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(249, 18);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(85, 21);
            this.txtPort.TabIndex = 3;
            // 
            // rtxChatInfo
            // 
            this.rtxChatInfo.Location = new System.Drawing.Point(6, 20);
            this.rtxChatInfo.Name = "rtxChatInfo";
            this.rtxChatInfo.ReadOnly = true;
            this.rtxChatInfo.Size = new System.Drawing.Size(405, 283);
            this.rtxChatInfo.TabIndex = 0;
            this.rtxChatInfo.Text = "";
            // 
            // rtxSendMessage
            // 
            this.rtxSendMessage.Location = new System.Drawing.Point(6, 20);
            this.rtxSendMessage.Name = "rtxSendMessage";
            this.rtxSendMessage.Size = new System.Drawing.Size(405, 61);
            this.rtxSendMessage.TabIndex = 0;
            this.rtxSendMessage.Text = "";
            // 
            // butConnect
            // 
            this.butConnect.Location = new System.Drawing.Point(340, 18);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(71, 23);
            this.butConnect.TabIndex = 4;
            this.butConnect.Text = "连接";
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(230, 88);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(75, 23);
            this.butSend.TabIndex = 1;
            this.butSend.Text = "发送";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(336, 87);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "关闭";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // tmrGetMess
            // 
            this.tmrGetMess.Enabled = true;
            this.tmrGetMess.Tick += new System.EventHandler(this.tmrGetMess_Tick);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.主机信息);
            this.Name = "Client";
            this.Text = "客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.主机信息.ResumeLayout(false);
            this.主机信息.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 主机信息;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtSeverIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.RichTextBox rtxChatInfo;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.RichTextBox rtxSendMessage;
        private System.Windows.Forms.Timer tmrGetMess;
    }
}

