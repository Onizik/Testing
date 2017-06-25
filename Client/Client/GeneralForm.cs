using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class GeneralForm : Form
    {
        public string Name;             
        public GeneralForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            userList.Text += Name + "\r\n";
            mainText.Text += "You has been connected to server. Have a nice day!";
        }
    }
}
