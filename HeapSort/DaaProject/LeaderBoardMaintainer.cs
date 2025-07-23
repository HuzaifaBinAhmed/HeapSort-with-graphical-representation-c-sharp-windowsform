using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaaProject
{
    public partial class LeaderBoardMaintainer : Form
    {

        List<Player> players = new List<Player>();

        public LeaderBoardMaintainer()  
        {
            InitializeComponent();

        }

        private void LeaderBoardMaintainer_Load(object sender, EventArgs e)
        {

        }
        
        private void btnLoadCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                players.Clear();
                foreach (var line in File.ReadAllLines(ofd.FileName).Skip(1))
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                    {
                        players.Add(new Player(parts[0], score));
                    }
                }
            }
            MessageBox.Show("File Uploaded Succesffully, Now Kindly Select Min or Max to Apply Heap Tree");
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            players.Clear();

        }



        private void btnMaxHeapTree_Click(object sender, EventArgs e)
        {
            if (players == null || players.Count == 0)
            {
                MessageBox.Show("No players available.");
                return;
            }

            FrmHeapTree heapForm = new FrmHeapTree(players, isMaxHeap: true);
            heapForm.Show();
        }

        private void btnMinHeapTree_Click(object sender, EventArgs e)
        {
            
            if (players == null || players.Count == 0)
                {
                    MessageBox.Show("No players available.");
                    return;
                }

            FrmHeapTree heapForm = new FrmHeapTree(players, isMaxHeap: false);
            heapForm.Show();

        }

        private void lblHeapcalls_Click(object sender, EventArgs e)
        {

        }
    }
}

   
