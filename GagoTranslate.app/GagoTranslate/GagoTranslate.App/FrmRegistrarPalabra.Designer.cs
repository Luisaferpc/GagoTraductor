namespace GagoTranslate
{
    partial class FrmRegistrarPalabra
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
            lblPalabra = new Label();
            txtPalabra = new TextBox();
            lblIngles = new Label();
            lblFrances = new Label();
            lblAleman = new Label();
            txtIngles = new TextBox();
            txtFrances = new TextBox();
            txtAleman = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(30, 58, 95);
            lblTitulo.Location = new Point(154, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(286, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar nueva palabra";
            // 
            // lblPalabra
            // 
            lblPalabra.AutoSize = true;
            lblPalabra.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblPalabra.ForeColor = Color.FromArgb(38, 52, 73);
            lblPalabra.Location = new Point(70, 108);
            lblPalabra.Name = "lblPalabra";
            lblPalabra.Size = new Size(143, 20);
            lblPalabra.TabIndex = 1;
            lblPalabra.Text = "Palabra en español:";
            // 
            // txtPalabra
            // 
            txtPalabra.BackColor = Color.White;
            txtPalabra.BorderStyle = BorderStyle.FixedSingle;
            txtPalabra.ForeColor = Color.FromArgb(38, 52, 73);
            txtPalabra.Location = new Point(230, 103);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(279, 25);
            txtPalabra.TabIndex = 3;
            // 
            // lblIngles
            // 
            lblIngles.AutoSize = true;
            lblIngles.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblIngles.ForeColor = Color.FromArgb(38, 52, 73);
            lblIngles.Location = new Point(177, 180);
            lblIngles.Name = "lblIngles";
            lblIngles.Size = new Size(53, 20);
            lblIngles.TabIndex = 5;
            lblIngles.Text = "Inglés:";
            // 
            // lblFrances
            // 
            lblFrances.AutoSize = true;
            lblFrances.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblFrances.ForeColor = Color.FromArgb(38, 52, 73);
            lblFrances.Location = new Point(177, 230);
            lblFrances.Name = "lblFrances";
            lblFrances.Size = new Size(65, 20);
            lblFrances.TabIndex = 6;
            lblFrances.Text = "Francés:";
            // 
            // lblAleman
            // 
            lblAleman.AutoSize = true;
            lblAleman.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblAleman.ForeColor = Color.FromArgb(38, 52, 73);
            lblAleman.Location = new Point(177, 280);
            lblAleman.Name = "lblAleman";
            lblAleman.Size = new Size(65, 20);
            lblAleman.TabIndex = 7;
            lblAleman.Text = "Alemán:";
            // 
            // txtIngles
            // 
            txtIngles.BackColor = Color.White;
            txtIngles.BorderStyle = BorderStyle.FixedSingle;
            txtIngles.ForeColor = Color.FromArgb(38, 52, 73);
            txtIngles.Location = new Point(249, 177);
            txtIngles.Name = "txtIngles";
            txtIngles.Size = new Size(180, 25);
            txtIngles.TabIndex = 8;
            // 
            // txtFrances
            // 
            txtFrances.BackColor = Color.White;
            txtFrances.BorderStyle = BorderStyle.FixedSingle;
            txtFrances.ForeColor = Color.FromArgb(38, 52, 73);
            txtFrances.Location = new Point(249, 227);
            txtFrances.Name = "txtFrances";
            txtFrances.Size = new Size(180, 25);
            txtFrances.TabIndex = 9;
            // 
            // txtAleman
            // 
            txtAleman.BackColor = Color.White;
            txtAleman.BorderStyle = BorderStyle.FixedSingle;
            txtAleman.ForeColor = Color.FromArgb(38, 52, 73);
            txtAleman.Location = new Point(249, 277);
            txtAleman.Name = "txtAleman";
            txtAleman.Size = new Size(180, 25);
            txtAleman.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(111, 351);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 35);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar palabra";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.SteelBlue;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(251, 351);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 35);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(107, 114, 128);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(391, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 35);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmRegistrarPalabra
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(613, 429);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtAleman);
            Controls.Add(txtFrances);
            Controls.Add(txtIngles);
            Controls.Add(lblAleman);
            Controls.Add(lblFrances);
            Controls.Add(lblIngles);
            Controls.Add(txtPalabra);
            Controls.Add(lblPalabra);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistrarPalabra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar palabra - Gago Translate";
            Load += FrmRegistrarPalabra_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label lblIngles;
        private System.Windows.Forms.Label lblFrances;
        private System.Windows.Forms.Label lblAleman;
        private System.Windows.Forms.TextBox txtIngles;
        private System.Windows.Forms.TextBox txtFrances;
        private System.Windows.Forms.TextBox txtAleman;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}