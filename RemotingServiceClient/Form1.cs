using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemotingServiceClient
{
    public partial class Form1 : Form
    {
        IOpetRemotingService.IOpetRemotingService client;
        
        public Form1()
        {
            InitializeComponent();
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (IOpetRemotingService.IOpetRemotingService)Activator.GetObject(typeof(IOpetRemotingService.IOpetRemotingService), "tcp://localhost:8080/GetMessage");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = client.GetMessage(textBox1.Text);
        }
    }
}
