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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPalabras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTraducciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTraducir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovedades = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuPalabras,
            this.menuTraducciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(73, 24);
            this.menuArchivo.Text = "Archivo";
            // 
            // menuPalabras
            // 
            this.menuPalabras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsultar,
            this.menuRegistrar,
            this.menuModificar,
            this.menuEliminar});
            this.menuPalabras.Name = "menuPalabras";
            this.menuPalabras.Size = new System.Drawing.Size(78, 24);
            this.menuPalabras.Text = "Palabras";
            this.menuPalabras.Click += new System.EventHandler(this.menuPalabras_Click);
            // 
            // menuTraducciones
            // 
            this.menuTraducciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTraducir,
            this.menuNovedades});
            this.menuTraducciones.Name = "menuTraducciones";
            this.menuTraducciones.Size = new System.Drawing.Size(109, 24);
            this.menuTraducciones.Text = "Traducciones";
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(224, 26);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // menuConsultar
            // 
            this.menuConsultar.Name = "menuConsultar";
            this.menuConsultar.Size = new System.Drawing.Size(224, 26);
            this.menuConsultar.Text = "Consultar palabra";
            this.menuConsultar.Click += new System.EventHandler(this.menuConsultar_Click);
            // 
            // menuRegistrar
            // 
            this.menuRegistrar.Name = "menuRegistrar";
            this.menuRegistrar.Size = new System.Drawing.Size(224, 26);
            this.menuRegistrar.Text = "Registrar palabra";
            this.menuRegistrar.Click += new System.EventHandler(this.menuRegistrar_Click);
            // 
            // menuModificar
            // 
            this.menuModificar.Name = "menuModificar";
            this.menuModificar.Size = new System.Drawing.Size(224, 26);
            this.menuModificar.Text = "Modificar palabra";
            // 
            // menuEliminar
            // 
            this.menuEliminar.Name = "menuEliminar";
            this.menuEliminar.Size = new System.Drawing.Size(224, 26);
            this.menuEliminar.Text = "Eliminar palabra";
            // 
            // menuTraducir
            // 
            this.menuTraducir.Name = "menuTraducir";
            this.menuTraducir.Size = new System.Drawing.Size(224, 26);
            this.menuTraducir.Text = "Traducir palabra";
            // 
            // menuNovedades
            // 
            this.menuNovedades.Name = "menuNovedades";
            this.menuNovedades.Size = new System.Drawing.Size(224, 26);
            this.menuNovedades.Text = "Novedades";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 447);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gago Translate - Menú principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolStripMenuItem menuNovedades;
    }
}