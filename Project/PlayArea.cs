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
    class TreeNode
    {
        int[,] ModelAreaNew, ModelAreaOld;
        TreeNode Parent;
        List<TreeNode> childs;
        public TreeNode(int[,] ModelArea, TreeNode Parent)
        {
            ModelAreaOld = ModelArea;
            ModelAreaNew = ModelArea;
        }
    }
    public partial class PlayArea : Form
    {
        Random rand;
        Color PlayerColor;
        Color ComputerColor;
        int PlayerFirstTurn;
        int ComputerValue = 2;
        int PlayerValue = 1;
        int[,] ModelArea;
        public PlayArea()
        {
            InitializeComponent();
            rand = new Random();
            PlayerColor = Color.Green;
            ComputerColor = Color.Red;
            PlayerFirstTurn = rand.Next(1, 3);
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = 3;
            ModelArea = new int[3, 3];
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ModelArea[dataGridView1.CurrentCell.RowIndex, dataGridView1.CurrentCell.ColumnIndex] == 0)
            {
                dataGridView1.CurrentCell.Style.BackColor = PlayerColor;
                ModelArea[dataGridView1.CurrentCell.RowIndex, dataGridView1.CurrentCell.ColumnIndex] = PlayerValue;
            }
            dataGridView1.CurrentCell.Selected = false;
        }
        void BotThread()
        {
            List<TreeNode> TurnsTree = new List<TreeNode>();
        }
        void FillTree(int[,] ModelArea, ref List<TreeNode> TurnsTree)
        {

        }
    }
}
