using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Menu: Form
    {
        Client client = new Client();
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_box.Text != "")
            {
                client.name = login_box.Text;
                Error_text.Visible = false;
            }
            else Error_text.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/onizik55rus");
            Process.Start("https://vk.com/mrbzjaqq");
        }
    }
}
