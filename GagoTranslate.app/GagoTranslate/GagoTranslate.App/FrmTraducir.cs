using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gago.Library.Datos;

namespace GagoTranslate
{
    public partial class FrmTraducir : Form
    {
        public FrmTraducir()
        {
            InitializeComponent();
        }

        private void FrmTraducir_Load(object sender, EventArgs e)
        {
            cmbIdioma.SelectedIndex = 0;
            txtResultado.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();

            if (palabra == "")
            {
                MessageBox.Show("Escribe una palabra en español.");
                return;
            }

            string[] abreviaciones = { "EN", "FR", "AL" };

            try
            {
                NuevaTraduccion datos = new NuevaTraduccion();
                string resultado = datos.ObtenerTraduccion(palabra, abreviaciones[cmbIdioma.SelectedIndex]);

                txtResultado.Text = resultado == "" ? "No se encontró la palabra." : resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traducir: " + ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtPalabra_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIdioma_Click(object sender, EventArgs e)
        {

        }
    }
}
