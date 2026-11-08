using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GagoTranslate
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

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
            FrmConsultarPalabra consulta = new FrmConsultarPalabra();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void menuRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrarPalabra registro = new FrmRegistrarPalabra();
            registro.MdiParent = this;
            registro.Show();
        }
    }
}
