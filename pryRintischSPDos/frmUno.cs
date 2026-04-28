using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRintischSPDos
{
    public partial class frmUno : Form
    {
        public frmUno()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmDos frmDos = new frmDos();
            this.Hide();
            frmDos.Show();
        }
    }
}
