using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
namespace Uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void OneKeyDownHandler(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode.Equals(Keys.Return))
            {
                MessageBox.Show("Lütfen Bir Seçim Yapın");
            }
        }
        private void OneKeyDownHandler1(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode.Equals(Keys.Return))
            {
                Ping ping3 = new Ping();
                PingReply reply = ping3.Send(IPtextBox1.Text);
                MessageBox.Show(reply.Status.ToString(),IPtextBox1.Text);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            IPlistBox.Items.Remove(IPlistBox.SelectedItem);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPlistBox.Items.Add(IPtextBox.Text);
            IPtextBox.Clear();
        }

        private void IPClear_Click(object sender, EventArgs e)
        {
            IPlistBox.Items.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IPscan_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping(); 
            for (int i = 0; i < IPlistBox.Items.Count; i++)
            {
                PingReply reply = ping.Send((string)IPlistBox.Items[i]);
                MessageBox.Show(reply.Status.ToString(),(string)IPlistBox.Items[i]);
            }
        }

        private void IpPingAt_Click(object sender, EventArgs e)
        {
            Ping ping1 = new Ping();
            PingReply reply = ping1.Send(IPtextBox1.Text);
            MessageBox.Show(reply.Status.ToString(),IPtextBox1.Text);
            IPtextBox1.Clear();
        }
        
    }
}
