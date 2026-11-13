using System;
using System.Data;
using System.Windows.Forms;
using Gago.Library.Datos;

namespace GagoTranslate
{
    public partial class FrmConsultarPalabra : Form
    {
        public FrmConsultarPalabra()
        {
            InitializeComponent();
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Escribe el código de la palabra (ej: P001).");
                return;
            }

            try
            {
                DataTable tabla = new Consultas().PorCodigo(txtCodigo.Text.Trim());
                MostrarResultado(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }
        }

        private void btnBuscarPalabra_Click(object sender, EventArgs e)
        {
            if (txtPalabra.Text.Trim() == "")
            {
                MessageBox.Show("Escribe la palabra en español.");
                return;
            }

            try
            {
                DataTable tabla = new Consultas().PorPalabra(txtPalabra.Text.Trim());
                MostrarResultado(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }
        }

        private void MostrarResultado(DataTable tabla)
        {
            dgvTraducciones.DataSource = tabla;

            if (tabla.Rows.Count == 0)
                MessageBox.Show("No se encontró ninguna palabra.");
        }
    }
}