using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class frmBlackJack21 : Form
    {
        public frmBlackJack21()
        {
            InitializeComponent();
            
        }

        private void frmBlackJack21_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            frmBlackJackMultiplayer blackjackMultiplayer = new frmBlackJackMultiplayer(false);
            blackjackMultiplayer.ShowDialog();
        }

        private void btnCpu_Click(object sender, EventArgs e)
        {
            frmBlackJackMultiplayer blackjackMultiplayer = new frmBlackJackMultiplayer(true);
            blackjackMultiplayer.ShowDialog();
        }
    }
}
