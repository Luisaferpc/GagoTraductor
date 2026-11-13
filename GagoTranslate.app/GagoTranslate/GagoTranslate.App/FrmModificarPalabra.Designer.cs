namespace GagoTranslate
{
    partial class FrmModificarPalabra
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
            lblTitulo = new Label();
            lblBuscar = new Label();
            btnBuscar = new Button();
            txtCodigo = new TextBox();
            lblPalabra = new Label();
            lblIngles = new Label();
            lblFrances = new Label();
            lblAleman = new Label();
            txtPalabra = new TextBox();
            txtIngles = new TextBox();
            txtFrances = new TextBox();
            txtAleman = new TextBox();
            btnCancelar = new Button();
            btnGuardarCambios = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(30, 58, 95);
            lblTitulo.Location = new Point(200, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(220, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Modificar palabra";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.FromArgb(38, 52, 73);
            lblBuscar.Location = new Point(70, 108);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(155, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Código de la palabra:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(419, 99);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(127, 35);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.White;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.ForeColor = Color.FromArgb(38, 52, 73);
            txtCodigo.Location = new Point(234, 105);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(165, 25);
            txtCodigo.TabIndex = 3;
            // 
            // lblPalabra
            // 
            lblPalabra.AutoSize = true;
            lblPalabra.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblPalabra.ForeColor = Color.FromArgb(38, 52, 73);
            lblPalabra.Location = new Point(70, 158);
            lblPalabra.Name = "lblPalabra";
            lblPalabra.Size = new Size(143, 20);
            lblPalabra.TabIndex = 4;
            lblPalabra.Text = "Palabra en español:";
            // 
            // lblIngles
            // 
            lblIngles.AutoSize = true;
            lblIngles.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblIngles.ForeColor = Color.FromArgb(38, 52, 73);
            lblIngles.Location = new Point(177, 218);
            lblIngles.Name = "lblIngles";
            lblIngles.Size = new Size(53, 20);
            lblIngles.TabIndex = 6;
            lblIngles.Text = "Inglés:";
            // 
            // lblFrances
            // 
            lblFrances.AutoSize = true;
            lblFrances.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblFrances.ForeColor = Color.FromArgb(38, 52, 73);
            lblFrances.Location = new Point(177, 262);
            lblFrances.Name = "lblFrances";
            lblFrances.Size = new Size(65, 20);
            lblFrances.TabIndex = 7;
            lblFrances.Text = "Francés:";
            // 
            // lblAleman
            // 
            lblAleman.AutoSize = true;
            lblAleman.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblAleman.ForeColor = Color.FromArgb(38, 52, 73);
            lblAleman.Location = new Point(177, 304);
            lblAleman.Name = "lblAleman";
            lblAleman.Size = new Size(65, 20);
            lblAleman.TabIndex = 8;
            lblAleman.Text = "Alemán:";
            // 
            // txtPalabra
            // 
            txtPalabra.BackColor = Color.White;
            txtPalabra.BorderStyle = BorderStyle.FixedSingle;
            txtPalabra.ForeColor = Color.FromArgb(38, 52, 73);
            txtPalabra.Location = new Point(234, 155);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(165, 25);
            txtPalabra.TabIndex = 9;
            // 
            // txtIngles
            // 
            txtIngles.BackColor = Color.White;
            txtIngles.BorderStyle = BorderStyle.FixedSingle;
            txtIngles.ForeColor = Color.FromArgb(38, 52, 73);
            txtIngles.Location = new Point(249, 215);
            txtIngles.Name = "txtIngles";
            txtIngles.Size = new Size(125, 25);
            txtIngles.TabIndex = 11;
            // 
            // txtFrances
            // 
            txtFrances.BackColor = Color.White;
            txtFrances.BorderStyle = BorderStyle.FixedSingle;
            txtFrances.ForeColor = Color.FromArgb(38, 52, 73);
            txtFrances.Location = new Point(249, 259);
            txtFrances.Name = "txtFrances";
            txtFrances.Size = new Size(125, 25);
            txtFrances.TabIndex = 12;
            // 
            // txtAleman
            // 
            txtAleman.BackColor = Color.White;
            txtAleman.BorderStyle = BorderStyle.FixedSingle;
            txtAleman.ForeColor = Color.FromArgb(38, 52, 73);
            txtAleman.Location = new Point(249, 301);
            txtAleman.Name = "txtAleman";
            txtAleman.Size = new Size(125, 25);
            txtAleman.TabIndex = 13;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(107, 114, 128);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(386, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 35);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.SteelBlue;
            btnGuardarCambios.Cursor = Cursors.Hand;
            btnGuardarCambios.FlatAppearance.BorderSize = 0;
            btnGuardarCambios.FlatStyle = FlatStyle.Flat;
            btnGuardarCambios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardarCambios.ForeColor = Color.White;
            btnGuardarCambios.Location = new Point(111, 351);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(127, 35);
            btnGuardarCambios.TabIndex = 19;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // FrmModificarPalabra
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(613, 429);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnCancelar);
            Controls.Add(txtAleman);
            Controls.Add(txtFrances);
            Controls.Add(txtIngles);
            Controls.Add(txtPalabra);
            Controls.Add(lblAleman);
            Controls.Add(lblFrances);
            Controls.Add(lblIngles);
            Controls.Add(lblPalabra);
            Controls.Add(txtCodigo);
            Controls.Add(btnBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmModificarPalabra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar palabra - Gago Translate";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.Label lblIngles;
        private System.Windows.Forms.Label lblFrances;
        private System.Windows.Forms.Label lblAleman;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.TextBox txtIngles;
        private System.Windows.Forms.TextBox txtFrances;
        private System.Windows.Forms.TextBox txtAleman;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarCambios;
    }
}