using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            messageTextBox.Text = "You can type here...";
        }

        private void MessageTextBox_Enter(object sender, EventArgs e)
        {
            if (messageTextBox.Text == "You can type here...")
            messageTextBox.Text = "";
        }

        private void messageTextBox_Leave(object sender, EventArgs e)
        {
            if (messageTextBox.Text == "")
            messageTextBox.Text = "You can type here...";
        }
    }
}
