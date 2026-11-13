using System;
using System.Windows.Forms;
using Gago.Library.Datos;
using Gago.Library.Entidades;

namespace GagoTranslate
{
    public partial class FrmEliminarPalabra : Form
    {
        private PalabraCompleta palabraActual;

        public FrmEliminarPalabra()
        {
            InitializeComponent();
        }

        private void FrmEliminarPalabra_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
        }
        
        private void txtFrances_TextChanged(object sender, EventArgs e)
        {

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
                    btnEliminar.Enabled = false;
                    MessageBox.Show("No existe ninguna palabra con ese código.");
                    return;
                }

                palabraActual = encontrada;
                txtPalabra.Text = encontrada.PalabraEspanol;
                txtIngles.Text = encontrada.Ingles;
                txtFrances.Text = encontrada.Frances;
                txtAleman.Text = encontrada.Aleman;
                btnEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (palabraActual == null)
            {
                MessageBox.Show("Primero busca una palabra por su código.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que quieres eliminar \"" + palabraActual.PalabraEspanol + "\" y todas sus traducciones?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                if (new GestionPalabras().Eliminar(palabraActual.IdPalabra))
                {
                    MessageBox.Show("Palabra eliminada correctamente.");
                    palabraActual = null;
                    txtCodigo.Clear();
                    LimpiarCampos();
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la palabra.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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