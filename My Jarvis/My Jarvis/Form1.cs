using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace My_Jarvis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NetWorkCheck("app.baljeetsingh.net");
            NetWorkCheck("baljeetsingh.net");

        }

        private void NetWorkCheck(string pHostNameOrAddress)
        {
            Ping ping = new Ping();
            PingReply pingReply = ping.Send(pHostNameOrAddress);
            textBox1.Text += Environment.NewLine + string.Concat(DateTime.Now.ToString(CultureInfo.InvariantCulture), " - " , pHostNameOrAddress, " - ",  pingReply?.Address.MapToIPv4());
            
        }
    }
}
