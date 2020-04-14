using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTool
{
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.sendToEmail = tbEmail.Text;
            Form1.slug = tbSlug.Text;
            Form1.isSendEmail = cbSend.Checked;
            if (Form1.sendToEmail != "" && Form1.slug != "" && Form1.isSendEmail)
            {
                if (Form1.isSendEmail) { MessageBox.Show("Sending Email To: " + Form1.sendToEmail); }
                this.Close();
            } else
            {
                if (Form1.isSendEmail) MessageBox.Show("Check Email and Slug before continuing");
                else this.Close();
            }


        }
    }
}
