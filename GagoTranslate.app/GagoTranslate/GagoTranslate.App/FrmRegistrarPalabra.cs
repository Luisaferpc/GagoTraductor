using System;
using System.Windows.Forms;
using Gago.Library.Datos;

namespace GagoTranslate
{
    public partial class FrmRegistrarPalabra : Form
    {
        public FrmRegistrarPalabra()
        {
            InitializeComponent();
        }

        private void FrmRegistrarPalabra_Load(object sender, EventArgs e)
        {
            txtPalabra.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string espanol = txtPalabra.Text.Trim();
            string ingles = txtIngles.Text.Trim();
            string frances = txtFrances.Text.Trim();
            string aleman = txtAleman.Text.Trim();

            if (espanol == "" || ingles == "" || frances == "" || aleman == "")
            {
                MessageBox.Show("Completa la palabra en español y sus tres traducciones.");
                return;
            }

            try
            {
                string codigo = new GestionPalabras().Registrar(espanol, ingles, frances, aleman);
                MessageBox.Show("Palabra registrada con el código " + codigo + ".");
                Limpiar();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            txtPalabra.Clear();
            txtIngles.Clear();
            txtFrances.Clear();
            txtAleman.Clear();
            txtPalabra.Focus();
        }
    }
}
