namespace GagoTranslate
{
    partial class FrmTraducir
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
            txtPalabra = new TextBox();
            btnTraducir = new Button();
            lblIdioma = new Label();
            lblResultado = new Label();
            cmbIdioma = new ComboBox();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(30, 58, 95);
            lblTitulo.Location = new Point(155, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(302, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Traductor Gago Translate";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.FromArgb(38, 52, 73);
            lblBuscar.Location = new Point(194, 108);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(225, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Escribe una palabra en español:";
            lblBuscar.Click += lblBuscar_Click;
            // 
            // txtPalabra
            // 
            txtPalabra.BackColor = Color.White;
            txtPalabra.BorderStyle = BorderStyle.FixedSingle;
            txtPalabra.ForeColor = Color.FromArgb(38, 52, 73);
            txtPalabra.Location = new Point(194, 133);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(225, 25);
            txtPalabra.TabIndex = 2;
            txtPalabra.TextChanged += txtPalabra_TextChanged;
            // 
            // btnTraducir
            // 
            btnTraducir.BackColor = Color.SteelBlue;
            btnTraducir.Cursor = Cursors.Hand;
            btnTraducir.FlatAppearance.BorderSize = 0;
            btnTraducir.FlatStyle = FlatStyle.Flat;
            btnTraducir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraducir.ForeColor = Color.White;
            btnTraducir.Location = new Point(245, 254);
            btnTraducir.Name = "btnTraducir";
            btnTraducir.Size = new Size(127, 35);
            btnTraducir.TabIndex = 3;
            btnTraducir.Text = "Traducir";
            btnTraducir.UseVisualStyleBackColor = false;
            btnTraducir.Click += button1_Click;
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblIdioma.ForeColor = Color.FromArgb(38, 52, 73);
            lblIdioma.Location = new Point(194, 195);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(81, 20);
            lblIdioma.TabIndex = 4;
            lblIdioma.Text = "Traducir a:";
            lblIdioma.Click += lblIdioma_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblResultado.ForeColor = Color.FromArgb(38, 52, 73);
            lblResultado.Location = new Point(209, 330);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(194, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado de la traducción:";
            // 
            // cmbIdioma
            // 
            cmbIdioma.BackColor = Color.White;
            cmbIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdioma.ForeColor = Color.FromArgb(38, 52, 73);
            cmbIdioma.FormattingEnabled = true;
            cmbIdioma.Items.AddRange(new object[] { "Inglés", "Francés", "Alemán" });
            cmbIdioma.Location = new Point(287, 194);
            cmbIdioma.Name = "cmbIdioma";
            cmbIdioma.Size = new Size(132, 25);
            cmbIdioma.TabIndex = 6;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.Azure;
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.ForeColor = Color.FromArgb(30, 58, 95);
            txtResultado.Location = new Point(209, 355);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(194, 27);
            txtResultado.TabIndex = 7;
            // 
            // FrmTraducir
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(613, 429);
            Controls.Add(txtResultado);
            Controls.Add(cmbIdioma);
            Controls.Add(lblResultado);
            Controls.Add(lblIdioma);
            Controls.Add(btnTraducir);
            Controls.Add(txtPalabra);
            Controls.Add(lblBuscar);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTraducir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Traducir palabra - Gago Translate";
            Load += FrmTraducir_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnTraducir;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.TextBox txtResultado;
    }
}