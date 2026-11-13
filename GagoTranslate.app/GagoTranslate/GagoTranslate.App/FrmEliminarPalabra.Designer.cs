namespace GagoTranslate
{
    partial class FrmEliminarPalabra
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            btnBuscar = new Button();
            lblPalabra = new Label();
            lblIngles = new Label();
            lblFrances = new Label();
            lblAleman = new Label();
            txtPalabra = new TextBox();
            txtIngles = new TextBox();
            txtFrances = new TextBox();
            txtAleman = new TextBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(30, 58, 95);
            lblTitulo.Location = new Point(206, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(202, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Eliminar palabra";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.FromArgb(38, 52, 73);
            lblCodigo.Location = new Point(70, 108);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(155, 20);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código de la palabra:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.White;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(234, 105);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(165, 25);
            txtCodigo.TabIndex = 2;
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
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
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
            txtPalabra.BackColor = Color.Azure;
            txtPalabra.BorderStyle = BorderStyle.FixedSingle;
            txtPalabra.Location = new Point(234, 155);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.ReadOnly = true;
            txtPalabra.Size = new Size(165, 25);
            txtPalabra.TabIndex = 9;
            // 
            // txtIngles
            // 
            txtIngles.BackColor = Color.Azure;
            txtIngles.BorderStyle = BorderStyle.FixedSingle;
            txtIngles.Location = new Point(249, 215);
            txtIngles.Name = "txtIngles";
            txtIngles.ReadOnly = true;
            txtIngles.Size = new Size(125, 25);
            txtIngles.TabIndex = 11;
            // 
            // txtFrances
            // 
            txtFrances.BackColor = Color.Azure;
            txtFrances.BorderStyle = BorderStyle.FixedSingle;
            txtFrances.Location = new Point(249, 259);
            txtFrances.Name = "txtFrances";
            txtFrances.ReadOnly = true;
            txtFrances.Size = new Size(125, 25);
            txtFrances.TabIndex = 12;
            txtFrances.TextChanged += txtFrances_TextChanged;
            // 
            // txtAleman
            // 
            txtAleman.BackColor = Color.Azure;
            txtAleman.BorderStyle = BorderStyle.FixedSingle;
            txtAleman.Location = new Point(249, 301);
            txtAleman.Name = "txtAleman";
            txtAleman.ReadOnly = true;
            txtAleman.Size = new Size(125, 25);
            txtAleman.TabIndex = 13;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SteelBlue;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(111, 351);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 35);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar palabra";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(107, 114, 128);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(386, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 35);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmEliminarPalabra
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(613, 429);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(txtAleman);
            Controls.Add(txtFrances);
            Controls.Add(txtIngles);
            Controls.Add(txtPalabra);
            Controls.Add(lblAleman);
            Controls.Add(lblFrances);
            Controls.Add(lblIngles);
            Controls.Add(lblPalabra);
            Controls.Add(btnBuscar);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEliminarPalabra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar palabra - Gago Translate";
            Load += FrmEliminarPalabra_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.Label lblIngles;
        private System.Windows.Forms.Label lblFrances;
        private System.Windows.Forms.Label lblAleman;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.TextBox txtIngles;
        private System.Windows.Forms.TextBox txtFrances;
        private System.Windows.Forms.TextBox txtAleman;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
    }
}