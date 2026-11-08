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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.lblSinonimos = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.btnBuscarPalabra = new System.Windows.Forms.Button();
            this.lstSinonimos = new System.Windows.Forms.ListBox();
            this.dgvTraducciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(68, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(113, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consultar palabra";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(68, 63);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(68, 138);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(128, 16);
            this.lblPalabra.TabIndex = 2;
            this.lblPalabra.Text = "Palabra en español:";
            // 
            // lblSinonimos
            // 
            this.lblSinonimos.AutoSize = true;
            this.lblSinonimos.Location = new System.Drawing.Point(68, 378);
            this.lblSinonimos.Name = "lblSinonimos";
            this.lblSinonimos.Size = new System.Drawing.Size(143, 16);
            this.lblSinonimos.TabIndex = 3;
            this.lblSinonimos.Text = "Sinónimos en español:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(71, 91);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(71, 166);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(100, 22);
            this.txtPalabra.TabIndex = 5;
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(540, 80);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(145, 33);
            this.btnBuscarCodigo.TabIndex = 6;
            this.btnBuscarCodigo.Text = "Buscar por código";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPalabra
            // 
            this.btnBuscarPalabra.Location = new System.Drawing.Point(540, 142);
            this.btnBuscarPalabra.Name = "btnBuscarPalabra";
            this.btnBuscarPalabra.Size = new System.Drawing.Size(138, 33);
            this.btnBuscarPalabra.TabIndex = 7;
            this.btnBuscarPalabra.Text = "Buscar palabra";
            this.btnBuscarPalabra.UseVisualStyleBackColor = true;
            this.btnBuscarPalabra.Click += new System.EventHandler(this.btnBuscarPalabra_Click);
            // 
            // lstSinonimos
            // 
            this.lstSinonimos.FormattingEnabled = true;
            this.lstSinonimos.ItemHeight = 16;
            this.lstSinonimos.Location = new System.Drawing.Point(71, 407);
            this.lstSinonimos.Name = "lstSinonimos";
            this.lstSinonimos.Size = new System.Drawing.Size(155, 84);
            this.lstSinonimos.TabIndex = 8;
            // 
            // dgvTraducciones
            // 
            this.dgvTraducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraducciones.Location = new System.Drawing.Point(71, 206);
            this.dgvTraducciones.Name = "dgvTraducciones";
            this.dgvTraducciones.RowHeadersWidth = 51;
            this.dgvTraducciones.RowTemplate.Height = 24;
            this.dgvTraducciones.Size = new System.Drawing.Size(635, 150);
            this.dgvTraducciones.TabIndex = 9;
            // 
            // FrmConsultarPalabra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.dgvTraducciones);
            this.Controls.Add(this.lstSinonimos);
            this.Controls.Add(this.btnBuscarPalabra);
            this.Controls.Add(this.btnBuscarCodigo);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblSinonimos);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultarPalabra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar palabra - Gago Translate";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.Label lblSinonimos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.Button btnBuscarPalabra;
        private System.Windows.Forms.ListBox lstSinonimos;
        private System.Windows.Forms.DataGridView dgvTraducciones;
    }
}