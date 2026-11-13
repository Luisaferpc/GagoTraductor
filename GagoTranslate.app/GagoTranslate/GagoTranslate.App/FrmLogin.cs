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
using Gago.Library.Entidades;

namespace GagoTranslate
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtContrasena.Text == "")
            {
                MessageBox.Show("Escribe el usuario y la contraseña.");
                return;
            }

            try
            {
                NuevoUsuario datos = new NuevoUsuario();
                Usuario usuario = datos.ValidarLogin(txtUsuario.Text.Trim(), txtContrasena.Text);

                if (usuario == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    return;
                }

                FrmPrincipal principal = new FrmPrincipal(usuario);
                principal.FormClosed += (s, args) => Application.Exit();
                principal.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
