namespace AAA
{
    partial class 登录
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
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_psw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_login = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.check_stf = new System.Windows.Forms.CheckBox();
            this.check_manger = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(177, 69);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 21);
            this.text_name.TabIndex = 0;
            this.text_name.Text = "请填写用户名";
            this.text_name.Click += new System.EventHandler(this.text_name_Click);
            // 
            // text_psw
            // 
            this.text_psw.Location = new System.Drawing.Point(177, 122);
            this.text_psw.Name = "text_psw";
            this.text_psw.Size = new System.Drawing.Size(100, 21);
            this.text_psw.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // but_login
            // 
            this.but_login.Location = new System.Drawing.Point(119, 218);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(75, 23);
            this.but_login.TabIndex = 4;
            this.but_login.Text = "登录";
            this.but_login.UseVisualStyleBackColor = true;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // but_exit
            // 
            this.but_exit.Location = new System.Drawing.Point(258, 218);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(75, 23);
            this.but_exit.TabIndex = 5;
            this.but_exit.Text = "退出";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // check_stf
            // 
            this.check_stf.AutoSize = true;
            this.check_stf.Location = new System.Drawing.Point(140, 168);
            this.check_stf.Name = "check_stf";
            this.check_stf.Size = new System.Drawing.Size(48, 16);
            this.check_stf.TabIndex = 6;
            this.check_stf.Text = "员工";
            this.check_stf.UseVisualStyleBackColor = true;
            // 
            // check_manger
            // 
            this.check_manger.AutoSize = true;
            this.check_manger.Location = new System.Drawing.Point(229, 168);
            this.check_manger.Name = "check_manger";
            this.check_manger.Size = new System.Drawing.Size(48, 16);
            this.check_manger.TabIndex = 7;
            this.check_manger.Text = "经理";
            this.check_manger.UseVisualStyleBackColor = true;
            // 
            // 登录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 284);
            this.Controls.Add(this.check_manger);
            this.Controls.Add(this.check_stf);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_psw);
            this.Controls.Add(this.text_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "登录";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.登录_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_psw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.CheckBox check_stf;
        private System.Windows.Forms.CheckBox check_manger;
    }
}

