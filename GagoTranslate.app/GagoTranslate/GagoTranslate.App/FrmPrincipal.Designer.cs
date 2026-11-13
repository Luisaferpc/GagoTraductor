namespace GagoTranslate
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuArchivo = new ToolStripMenuItem();
            menuSalir = new ToolStripMenuItem();
            menuPalabras = new ToolStripMenuItem();
            menuConsultar = new ToolStripMenuItem();
            menuRegistrar = new ToolStripMenuItem();
            menuModificar = new ToolStripMenuItem();
            menuEliminar = new ToolStripMenuItem();
            menuTraducciones = new ToolStripMenuItem();
            menuTraducir = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuArchivo, menuPalabras, menuTraducciones });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 5, 8, 5);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(606, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            menuArchivo.BackColor = Color.SteelBlue;
            menuArchivo.DropDownItems.AddRange(new ToolStripItem[] { menuSalir });
            menuArchivo.ForeColor = Color.White;
            menuArchivo.Name = "menuArchivo";
            menuArchivo.Size = new Size(63, 21);
            menuArchivo.Text = "Archivo";
            // 
            // menuSalir
            // 
            menuSalir.BackColor = Color.White;
            menuSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuSalir.ForeColor = Color.SteelBlue;
            menuSalir.Name = "menuSalir";
            menuSalir.Size = new Size(180, 22);
            menuSalir.Text = "Salir";
            menuSalir.Click += menuSalir_Click;
            // 
            // menuPalabras
            // 
            menuPalabras.DropDownItems.AddRange(new ToolStripItem[] { menuConsultar, menuRegistrar, menuModificar, menuEliminar });
            menuPalabras.ForeColor = Color.White;
            menuPalabras.Name = "menuPalabras";
            menuPalabras.Size = new Size(70, 21);
            menuPalabras.Text = "Palabras";
            menuPalabras.Click += menuPalabras_Click;
            // 
            // menuConsultar
            // 
            menuConsultar.BackColor = Color.White;
            menuConsultar.ForeColor = Color.SteelBlue;
            menuConsultar.Name = "menuConsultar";
            menuConsultar.Size = new Size(181, 22);
            menuConsultar.Text = "Consultar palabra";
            menuConsultar.Click += menuConsultar_Click;
            // 
            // menuRegistrar
            // 
            menuRegistrar.BackColor = Color.White;
            menuRegistrar.ForeColor = Color.SteelBlue;
            menuRegistrar.Name = "menuRegistrar";
            menuRegistrar.Size = new Size(181, 22);
            menuRegistrar.Text = "Registrar palabra";
            menuRegistrar.Click += menuRegistrar_Click;
            // 
            // menuModificar
            // 
            menuModificar.BackColor = Color.White;
            menuModificar.ForeColor = Color.SteelBlue;
            menuModificar.Name = "menuModificar";
            menuModificar.Size = new Size(181, 22);
            menuModificar.Text = "Modificar palabra";
            menuModificar.Click += menuModificar_Click;
            // 
            // menuEliminar
            // 
            menuEliminar.BackColor = Color.White;
            menuEliminar.ForeColor = Color.SteelBlue;
            menuEliminar.Name = "menuEliminar";
            menuEliminar.Size = new Size(181, 22);
            menuEliminar.Text = "Eliminar palabra";
            menuEliminar.Click += menuEliminar_Click;
            // 
            // menuTraducciones
            // 
            menuTraducciones.DropDownItems.AddRange(new ToolStripItem[] { menuTraducir });
            menuTraducciones.ForeColor = Color.White;
            menuTraducciones.Name = "menuTraducciones";
            menuTraducciones.Size = new Size(96, 21);
            menuTraducciones.Text = "Traducciones";
            menuTraducciones.Click += menuTraducciones_Click;
            // 
            // menuTraducir
            // 
            menuTraducir.BackColor = Color.White;
            menuTraducir.ForeColor = Color.SteelBlue;
            menuTraducir.Name = "menuTraducir";
            menuTraducir.Size = new Size(180, 22);
            menuTraducir.Text = "Traducir palabra";
            menuTraducir.Click += menuTraducir_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(606, 475);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gago Translate - Menú principal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStripMenuItem menuPalabras;
        private System.Windows.Forms.ToolStripMenuItem menuConsultar;
        private System.Windows.Forms.ToolStripMenuItem menuRegistrar;
        private System.Windows.Forms.ToolStripMenuItem menuModificar;
        private System.Windows.Forms.ToolStripMenuItem menuEliminar;
        private System.Windows.Forms.ToolStripMenuItem menuTraducciones;
        private System.Windows.Forms.ToolStripMenuItem menuTraducir;
    }
}