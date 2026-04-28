using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

            if (txtNombre.Text == "")
            {

                MessageBox.Show("Ingrese un Nombre de Destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;

            }
            else if (mskKm.Text == "")
            {

                MessageBox.Show("Ingrese la cantidad de Kilómetros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskKm.Focus();
                return;

            }
            else if (cmbDias.SelectedIndex == -1)
            {

                MessageBox.Show("Seleccione la cantidad de Días.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDias.Focus();
                return;

            }
            else
            {
                
                int Km = int.Parse(mskKm.Text); 
                int Dias = int.Parse(cmbDias.Text); 
                double PrecioTotal = 0; 
                PrecioTotal = Km * 5;

                if (Km >= 100 && Dias >= 7)
                {

                    PrecioTotal = PrecioTotal * 0.5;
                    MessageBox.Show("El Descuennto fue Aplicado con Exito" + "\n" + "Lugar de Destino: " + txtNombre.Text + "\n" + "El Precio del Viaje es: " + PrecioTotal.ToString("C") + "\n" + "Muchas Gracias por Elegirnos", "Organizacion Ferro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    mskKm.Clear();
                    cmbDias.SelectedIndex = -1;
                    txtNombre.Focus();

                }
                else if (Km <= 99 && Dias <= 6)
                {
                                     
                    MessageBox.Show("No se aplicó ningún descuento" + "\n" + "Lugar de Destino: " + txtNombre.Text + "\n" + "El Precio del Viaje es: " + PrecioTotal.ToString("C") + "\n" + "Muchas Gracias por Elegirnos", "Organizacion Ferro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    mskKm.Clear();
                    cmbDias.SelectedIndex = -1;
                    txtNombre.Focus();

                }
                else if (Km >= 100 && Dias <= 6)
                {
                    
                    MessageBox.Show("No se aplicó ningún descuento" + "\n" + "Lugar de Destino: " + txtNombre.Text + "\n" + "El Precio del Viaje es: " + PrecioTotal.ToString("C") + "\n" + "Muchas Gracias por Elegirnos", "Organizacion Ferro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    mskKm.Clear();
                    cmbDias.SelectedIndex = -1;
                    txtNombre.Focus();

                }
                else if (Km <= 99 && Dias >= 7)
                {

                    MessageBox.Show("No se aplicó ningún descuento" + "\n" + "Lugar de Destino: " + txtNombre.Text + "\n" + "El Precio del Viaje es: " + PrecioTotal.ToString("C") + "\n" + "Muchas Gracias por Elegirnos", "Organizacion Ferro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    mskKm.Clear();
                    cmbDias.SelectedIndex = -1;
                    txtNombre.Focus();

                }
            }
        }
        private void frmDos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
