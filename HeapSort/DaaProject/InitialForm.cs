using System;
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
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void btnOpenLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderBoardMaintainer frmLeaderboard = new LeaderBoardMaintainer();
            frmLeaderboard.Show();
            this.Hide();
        }
    }
}
