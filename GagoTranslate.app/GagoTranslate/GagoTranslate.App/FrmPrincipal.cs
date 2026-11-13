using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gago.Library.Entidades;

namespace GagoTranslate
{
    public partial class FrmPrincipal : Form
    {
        private Usuario usuarioActual;

        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            bool esAdmin = usuarioActual.Rol == 1;

            menuRegistrar.Enabled = esAdmin;
            menuModificar.Enabled = esAdmin;
            menuEliminar.Enabled = esAdmin;

            this.Text = "Gago Translate - " + usuarioActual.NombreUsuario +
                        (esAdmin ? " (Administrador)" : " (Usuario)");
        }

        private void AbrirFormulario(Form formulario)
        {
            
            foreach (Form hijo in this.MdiChildren)
            {
                hijo.Close();
            }

            formulario.MdiParent = this;
            formulario.Show();
        }

        private void menuPalabras_Click(object sender, EventArgs e)
        {

        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsultarPalabra());
        }

        private void menuRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRegistrarPalabra());
        }

        private void menuModificar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmModificarPalabra());
        }

        private void menuEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEliminarPalabra());
        }

        private void menuTraducir_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmTraducir());
        }

        private void menuTraducciones_Click(object sender, EventArgs e)
        {

        }
    }
}