namespace GagoTranslate
{
    partial class FrmConsultarPalabra
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblCodigo = new Label();
            lblPalabra = new Label();
            txtCodigo = new TextBox();
            txtPalabra = new TextBox();
            btnBuscarCodigo = new Button();
            btnBuscarPalabra = new Button();
            dgvTraducciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTraducciones).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(30, 58, 95);
            lblTitulo.Location = new Point(200, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(217, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consultar palabra";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.FromArgb(38, 52, 73);
            lblCodigo.Location = new Point(60, 100);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // lblPalabra
            // 
            lblPalabra.AutoSize = true;
            lblPalabra.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPalabra.ForeColor = Color.FromArgb(38, 52, 73);
            lblPalabra.Location = new Point(60, 160);
            lblPalabra.Name = "lblPalabra";
            lblPalabra.Size = new Size(137, 20);
            lblPalabra.TabIndex = 2;
            lblPalabra.Text = "Palabra en español:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.White;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.ForeColor = Color.FromArgb(38, 52, 73);
            txtCodigo.Location = new Point(140, 100);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(180, 25);
            txtCodigo.TabIndex = 4;
            // 
            // txtPalabra
            // 
            txtPalabra.BackColor = Color.White;
            txtPalabra.BorderStyle = BorderStyle.FixedSingle;
            txtPalabra.ForeColor = Color.FromArgb(38, 52, 73);
            txtPalabra.Location = new Point(220, 160);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(180, 25);
            txtPalabra.TabIndex = 5;
            // 
            // btnBuscarCodigo
            // 
            btnBuscarCodigo.BackColor = Color.SteelBlue;
            btnBuscarCodigo.Cursor = Cursors.Hand;
            btnBuscarCodigo.FlatAppearance.BorderSize = 0;
            btnBuscarCodigo.FlatStyle = FlatStyle.Flat;
            btnBuscarCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarCodigo.ForeColor = Color.White;
            btnBuscarCodigo.Location = new Point(433, 94);
            btnBuscarCodigo.Name = "btnBuscarCodigo";
            btnBuscarCodigo.Size = new Size(121, 35);
            btnBuscarCodigo.TabIndex = 6;
            btnBuscarCodigo.Text = "Buscar por código";
            btnBuscarCodigo.UseVisualStyleBackColor = false;
            btnBuscarCodigo.Click += btnBuscarCodigo_Click;
            // 
            // btnBuscarPalabra
            // 
            btnBuscarPalabra.BackColor = Color.SteelBlue;
            btnBuscarPalabra.Cursor = Cursors.Hand;
            btnBuscarPalabra.FlatAppearance.BorderSize = 0;
            btnBuscarPalabra.FlatStyle = FlatStyle.Flat;
            btnBuscarPalabra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPalabra.ForeColor = Color.White;
            btnBuscarPalabra.Location = new Point(433, 154);
            btnBuscarPalabra.Name = "btnBuscarPalabra";
            btnBuscarPalabra.Size = new Size(121, 35);
            btnBuscarPalabra.TabIndex = 7;
            btnBuscarPalabra.Text = "Buscar palabra";
            btnBuscarPalabra.UseVisualStyleBackColor = false;
            btnBuscarPalabra.Click += btnBuscarPalabra_Click;
            // 
            // dgvTraducciones
            // 
            dgvTraducciones.AllowUserToAddRows = false;
            dgvTraducciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 247, 251);
            dgvTraducciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTraducciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTraducciones.BackgroundColor = Color.White;
            dgvTraducciones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTraducciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTraducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(38, 52, 73);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTraducciones.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTraducciones.GridColor = Color.FromArgb(219, 234, 254);
            dgvTraducciones.Location = new Point(60, 220);
            dgvTraducciones.MultiSelect = false;
            dgvTraducciones.Name = "dgvTraducciones";
            dgvTraducciones.ReadOnly = true;
            dgvTraducciones.RowHeadersVisible = false;
            dgvTraducciones.RowHeadersWidth = 51;
            dgvTraducciones.RowTemplate.Height = 24;
            dgvTraducciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTraducciones.Size = new Size(494, 160);
            dgvTraducciones.TabIndex = 9;
            // 
            // FrmConsultarPalabra
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(613, 429);
            Controls.Add(dgvTraducciones);
            Controls.Add(btnBuscarPalabra);
            Controls.Add(btnBuscarCodigo);
            Controls.Add(txtPalabra);
            Controls.Add(txtCodigo);
            Controls.Add(lblPalabra);
            Controls.Add(lblCodigo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultarPalabra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar palabra - Gago Translate";
            ((System.ComponentModel.ISupportInitialize)dgvTraducciones).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.Button btnBuscarPalabra;
        private System.Windows.Forms.DataGridView dgvTraducciones;
    }
}