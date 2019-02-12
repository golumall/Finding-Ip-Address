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

namespace FindingIpAddress
{
    public partial class Form1 : Form
    {
             public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress[] address = Dns.GetHostAddresses(txtsite.Text);
                string str = string.Empty;
                foreach (IPAddress ip in address)
                {
                    str += ip;
                }
                Form2 ob = new Form2(str);
                ob.Show();
            }
            catch(Exception ee)
            {
                MessageBox.Show("Site does not Exist..");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 ob = new Form3();
            ob.Show();
             


        }
    }
}
