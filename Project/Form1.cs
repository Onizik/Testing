using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zero_n_Cross
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void начатьВОтдельномОкнеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayArea playArea = new PlayArea();
            playArea.MdiParent = this;
            playArea.Show();
        }
    }
}
