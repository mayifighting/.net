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

namespace Server
{
    public partial class Server : Form
    {
        TcpListener Listener;
        public Socket SocketClient;
        NetworkStream NetStream;
        StreamReader ServerReader;
        StreamWriter ServerWriter;
        Thread Thd;
        public Server()
        {
            InitializeComponent();
        }
        void GetMessage()
        {
            if (NetStream != null && NetStream.DataAvailable)
            {
                rtxChatinfo.AppendText(DateTime .Now .ToString ());
                rtxChatinfo.AppendText(" 客户端说：\n");
                rtxChatinfo.AppendText(ServerReader .ReadLine ()+"\n");
                rtxChatinfo.SelectionStart = rtxChatinfo.Text.Length;
                rtxChatinfo.Focus();
                rtxSendMessage.Focus();
            }
        }
        public void BeginLister()
        {
            while (true)
            {
                try
                {
                    IPAddress[] Ips = Dns.GetHostAddresses("");
                    string GetIp = Ips[0].ToString();
                    Listener = new TcpListener(IPAddress .Parse (GetIp ),8888);
                    Listener.Start();
                    CheckForIllegalCrossThreadCalls = false;
                    butBeginSever.Enabled = false;
                    this.Text = "服务器已经开启.....";
                    SocketClient = Listener.AcceptSocket();
                    NetStream = new NetworkStream(SocketClient );
                    ServerWriter = new StreamWriter(NetStream );
                    ServerReader = new StreamReader(NetStream );
                    if (SocketClient.Connected)
                    {
                        MessageBox.Show("客户端连接成功！","服务器消息",MessageBoxButtons .OK ,MessageBoxIcon.Information );
                    }
                }
                catch { }
            }
        }

        private void butBeginSever_Click(object sender, EventArgs e)
        {
            Thd = new Thread(new ThreadStart (BeginLister ));
            Thd.Start();
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
                    ServerWriter.WriteLine(rtxSendMessage.Text);
                    ServerWriter.Flush();
                    rtxChatinfo.AppendText(DateTime.Now.ToString());
                    rtxChatinfo.AppendText(" 服务器说：\n");
                    rtxChatinfo.AppendText(rtxSendMessage.Text + "\n");
                    rtxSendMessage.Clear();
                    rtxChatinfo.SelectionStart =rtxChatinfo.Text.Length;
                    rtxChatinfo.Focus();
                    rtxSendMessage.Focus();
                }
                else
                {
                    MessageBox.Show("信息不能为空！","服务器消息",MessageBoxButtons .OK ,MessageBoxIcon.Information );
                    rtxSendMessage.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("客户端连接失败....","服务器消息",MessageBoxButtons .OK ,MessageBoxIcon .Error );
                return;
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Thd.Abort();
                this.Close();
            }
            catch { this.Close(); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Dr = MessageBox.Show("这样会中断与客户端的联系，你要关闭窗体吗？","服务器信息",MessageBoxButtons.OK ,MessageBoxIcon .Warning );
            if (DialogResult.Yes == Dr)
            {
                try
                {
                    Listener.Stop();
                    this.Thd.Abort();
                    e.Cancel = false ;
                }
                catch { }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
