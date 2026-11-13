using System;
using System.Windows.Forms;
using Gago.Library.Datos;
using Gago.Library.Entidades;

namespace GagoTranslate
{
    public partial class FrmModificarPalabra : Form
    {
        private PalabraCompleta palabraActual;

        public FrmModificarPalabra()
        {
            InitializeComponent();
            HabilitarEdicion(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            if (codigo == "")
            {
                MessageBox.Show("Escribe el código de la palabra (ej: P016).");
                return;
            }

            try
            {
                PalabraCompleta encontrada = new GestionPalabras().BuscarCompletaPorCodigo(codigo);

                if (encontrada == null)
                {
                    palabraActual = null;
                    LimpiarCampos();
                    HabilitarEdicion(false);
                    MessageBox.Show("No existe ninguna palabra con ese código.");
                    return;
                }

                palabraActual = encontrada;
                txtPalabra.Text = encontrada.PalabraEspanol;
                txtIngles.Text = encontrada.Ingles;
                txtFrances.Text = encontrada.Frances;
                txtAleman.Text = encontrada.Aleman;
                HabilitarEdicion(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (palabraActual == null)
            {
                MessageBox.Show("Primero busca una palabra por su código.");
                return;
            }

            string espanol = txtPalabra.Text.Trim();
            string ingles = txtIngles.Text.Trim();
            string frances = txtFrances.Text.Trim();
            string aleman = txtAleman.Text.Trim();

            if (espanol == "" || ingles == "" || frances == "" || aleman == "")
            {
                MessageBox.Show("Completa la palabra en español y sus tres traducciones.");
                return;
            }

            palabraActual.PalabraEspanol = espanol;
            palabraActual.Ingles = ingles;
            palabraActual.Frances = frances;
            palabraActual.Aleman = aleman;

            try
            {
                new GestionPalabras().Modificar(palabraActual);
                MessageBox.Show("Cambios guardados correctamente.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabilitarEdicion(bool habilitar)
        {
            txtPalabra.Enabled = habilitar;
            txtIngles.Enabled = habilitar;
            txtFrances.Enabled = habilitar;
            txtAleman.Enabled = habilitar;
            btnGuardarCambios.Enabled = habilitar;
        }

        private void LimpiarCampos()
        {
            txtPalabra.Clear();
            txtIngles.Clear();
            txtFrances.Clear();
            txtAleman.Clear();
        }
    }
}
