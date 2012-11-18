using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace Client
{
    public partial class Client : Form
    {
        public TcpClient TcpClient;
        StreamReader ClientReader;
        StreamWriter ClientWrite;
        NetworkStream Stream;
        Thread Thd;
        public Client()
        {
            InitializeComponent();
        }
        void GetMessage()
        {
            if (Stream != null && Stream.DataAvailable)
            {
                rtxChatInfo.AppendText(DateTime.Now.ToString());
                rtxChatInfo.AppendText("服务器说:\n");
                rtxChatInfo.AppendText(ClientReader .ReadLine ()+"\n");
                rtxChatInfo.SelectionStart = rtxChatInfo.Text.Length;
                rtxChatInfo.Focus();
                rtxSendMessage.Focus();
            }
        }
        void GetConn()
        {
            while (true)
            {
                try
                {
                    TcpClient = new TcpClient(txtSeverIp .Text ,int.Parse (txtPort .Text .Trim ()));
                    Stream = TcpClient.GetStream();
                    ClientReader = new StreamReader(Stream);
                    ClientWrite = new StreamWriter(Stream);
                    txtSeverIp.Enabled = false;
                    butConnect.Enabled = false;
                    this.Text = "客户端" + "正在与" + txtSeverIp.Text.Trim() + "连接.....";
                    return;
                }
                catch 
                {
                    txtSeverIp.Enabled = true;
                    butConnect.Enabled = true;
                    this.Text = "连接失败.....";
                }
            }
        }

        private void butConnect_Click(object sender, EventArgs e)
        {
            if (txtSeverIp.Text.Trim() == "")
            {
                MessageBox.Show("请输入服务器IP", "客户端信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Thd = new Thread(new ThreadStart (GetConn));
                Thd.Start();
            }
        }

        private void tmrGetMess_Tick(object sender, EventArgs e)
        {
            GetMessage();
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtxSendMessage.Text.Trim() != "")
                {
                    ClientWrite.WriteLine(rtxSendMessage .Text );
                    ClientWrite.Flush();
                    rtxChatInfo.AppendText(DateTime .Now .ToString ());
                    rtxChatInfo.AppendText("客户端说：\n");
                    rtxChatInfo.AppendText(rtxSendMessage .Text +"\n");
                    rtxSendMessage .Clear ();
                    rtxChatInfo .SelectionStart =rtxChatInfo .Text .Length ;
                    rtxChatInfo .Focus ();
                    rtxSendMessage .Focus ();
                }
                else{
                    MessageBox .Show ("信息不能为空！","错误",MessageBoxButtons.OK ,MessageBoxIcon .Error );
                    txtSeverIp .Focus ();
                    return ;
                }
            }
            catch
            {
                txtSeverIp .Enabled =true;
                butConnect.Enabled = true;
                MessageBox.Show("服务器连接失败！","错误",MessageBoxButtons .OK ,MessageBoxIcon .Error );
                this.Text="连接失败....";
                return;
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("这样会中断与服务器的连接，你要关闭该窗体吗？","客户端信息",MessageBoxButtons.YesNo ,MessageBoxIcon.Warning );
            if (DialogResult.Yes == dr)
            {
                e.Cancel = false;
                if (Thd != null)
                {
                    Thd.Abort();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
