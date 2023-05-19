namespace Pantalla_Maestra
{
    partial class fmrPagarCuota
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
            this.lblPagoInicial = new System.Windows.Forms.Label();
            this.lblNumeroCuota = new System.Windows.Forms.Label();
            this.lblIDProductos = new System.Windows.Forms.Label();
            this.lblidClientes = new System.Windows.Forms.Label();
            this.txtIDClientes = new System.Windows.Forms.TextBox();
            this.txtIDProductos = new System.Windows.Forms.TextBox();
            this.txtNumeroCuota = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(104, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(199, 29);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Pago de Cuotas";
            // 
            // lblPagoInicial
            // 
            this.lblPagoInicial.AutoSize = true;
            this.lblPagoInicial.Location = new System.Drawing.Point(115, 224);
            this.lblPagoInicial.Name = "lblPagoInicial";
            this.lblPagoInicial.Size = new System.Drawing.Size(40, 16);
            this.lblPagoInicial.TabIndex = 37;
            this.lblPagoInicial.Text = "Pago";
            // 
            // lblNumeroCuota
            // 
            this.lblNumeroCuota.AutoSize = true;
            this.lblNumeroCuota.Location = new System.Drawing.Point(41, 186);
            this.lblNumeroCuota.Name = "lblNumeroCuota";
            this.lblNumeroCuota.Size = new System.Drawing.Size(115, 16);
            this.lblNumeroCuota.TabIndex = 36;
            this.lblNumeroCuota.Text = "Numero de Cuota ";
            // 
            // lblIDProductos
            // 
            this.lblIDProductos.AutoSize = true;
            this.lblIDProductos.Location = new System.Drawing.Point(71, 144);
            this.lblIDProductos.Name = "lblIDProductos";
            this.lblIDProductos.Size = new System.Drawing.Size(84, 16);
            this.lblIDProductos.TabIndex = 35;
            this.lblIDProductos.Text = "ID Productos";
            // 
            // lblidClientes
            // 
            this.lblidClientes.AutoSize = true;
            this.lblidClientes.Location = new System.Drawing.Point(84, 103);
            this.lblidClientes.Name = "lblidClientes";
            this.lblidClientes.Size = new System.Drawing.Size(71, 16);
            this.lblidClientes.TabIndex = 34;
            this.lblidClientes.Text = "ID Clientes";
            // 
            // txtIDClientes
            // 
            this.txtIDClientes.Location = new System.Drawing.Point(162, 103);
            this.txtIDClientes.Name = "txtIDClientes";
            this.txtIDClientes.Size = new System.Drawing.Size(141, 22);
            this.txtIDClientes.TabIndex = 38;
            this.txtIDClientes.TextChanged += new System.EventHandler(this.txtIDClientes_TextChanged);
            this.txtIDClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Restringirsolonumeros);
            // 
            // txtIDProductos
            // 
            this.txtIDProductos.Location = new System.Drawing.Point(162, 144);
            this.txtIDProductos.Name = "txtIDProductos";
            this.txtIDProductos.Size = new System.Drawing.Size(141, 22);
            this.txtIDProductos.TabIndex = 39;
            this.txtIDProductos.TextChanged += new System.EventHandler(this.txtIDProductos_TextChanged);
            this.txtIDProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Restringirsolonumeros);
            // 
            // txtNumeroCuota
            // 
            this.txtNumeroCuota.Location = new System.Drawing.Point(162, 183);
            this.txtNumeroCuota.Name = "txtNumeroCuota";
            this.txtNumeroCuota.ReadOnly = true;
            this.txtNumeroCuota.Size = new System.Drawing.Size(141, 22);
            this.txtNumeroCuota.TabIndex = 40;
            this.txtNumeroCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Restringirsolonumeros);
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(162, 224);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(141, 22);
            this.txtPago.TabIndex = 41;
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Restringirsolonumeros);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(118, 273);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(99, 40);
            this.btnPagar.TabIndex = 42;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 40);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(329, 103);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(44, 16);
            this.lblClientes.TabIndex = 44;
            this.lblClientes.Text = "label1";
            this.lblClientes.Visible = false;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(329, 150);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(44, 16);
            this.lblProductos.TabIndex = 45;
            this.lblProductos.Text = "label2";
            this.lblProductos.Visible = false;
            // 
            // fmrPagarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 391);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.txtNumeroCuota);
            this.Controls.Add(this.txtIDProductos);
            this.Controls.Add(this.txtIDClientes);
            this.Controls.Add(this.lblPagoInicial);
            this.Controls.Add(this.lblNumeroCuota);
            this.Controls.Add(this.lblIDProductos);
            this.Controls.Add(this.lblidClientes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "fmrPagarCuota";
            this.Text = "Pagar Cuota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPagoInicial;
        private System.Windows.Forms.Label lblNumeroCuota;
        private System.Windows.Forms.Label lblIDProductos;
        private System.Windows.Forms.Label lblidClientes;
        private System.Windows.Forms.TextBox txtIDClientes;
        private System.Windows.Forms.TextBox txtIDProductos;
        private System.Windows.Forms.TextBox txtNumeroCuota;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblProductos;
    }
}