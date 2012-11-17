using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Model;
namespace AAA
{
    public partial class 登录 : Form
    {
        public 登录()
        {
            InitializeComponent();
        }
        private void 登录_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500,200);//设置窗体弹出位置
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void text_name_Click(object sender, EventArgs e)
        {
            this.text_name.Clear();
        }

        
        private void but_login_Click(object sender, EventArgs e)
        {
            manager_window maw = new manager_window();
            if (this.text_name.Text != "" && this.text_psw.Text != ""&&(this.check_manger .Checked ||this.check_stf .Checked ))
            {
                if (this.check_stf .Checked )
                {
                    Model.Stuff stf = new Stuff();
                    stf.Name = this.text_name.Text.Trim();
                    if (this.text_psw.Text == stfmanager.login_(stf))//验证员工用户名和密码是否一致
                    {
                        maw.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码不正确！");
                    }
                }
                if (this.check_manger .Checked )
                {
                    Model.Manager mag = new Manager();
                    mag.Name = this.text_name.Text.Trim();
                    if (this.text_psw.Text ==managet_ .login_ (mag))//验证员工用户名和密码是否一致
                    {
                        maw.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码不正确！");
                    }
                }
            }
            else
            { MessageBox.Show("请填写完整信息！"); }
        }

    }
}
