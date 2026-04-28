using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace pryRintischSPDos
{
    public partial class frmDos : Form
    {
        public frmDos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            int Km = int.Parse(txtKm.Text);
            int Dias = int.Parse(cmbDias.Text);
            double PrecioTotal = 0;
            PrecioTotal = Km * 5;

            if (Km >= 100 && Dias >= 7)
            {
              
                PrecioTotal = PrecioTotal * 0.5;
                MessageBox.Show("El precio total del alquiler es: " + PrecioTotal.ToString("C"), "Organizacion Ferro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            
        }
    }
}
