namespace Pantalla_Maestra
{
    partial class fmrComprarProducto
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnComprarProductos = new System.Windows.Forms.Button();
            this.txtCuotasTotales = new System.Windows.Forms.TextBox();
            this.txtIDProductos = new System.Windows.Forms.TextBox();
            this.txtIDClientes = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCuotasTotales = new System.Windows.Forms.Label();
            this.lblIDProductos = new System.Windows.Forms.Label();
            this.lblidClientes = new System.Windows.Forms.Label();
            this.txtPagoInicial = new System.Windows.Forms.TextBox();
            this.lblPagoInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(207, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancerlar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnComprarProductos
            // 
            this.btnComprarProductos.Location = new System.Drawing.Point(107, 271);
            this.btnComprarProductos.Name = "btnComprarProductos";
            this.btnComprarProductos.Size = new System.Drawing.Size(94, 37);
            this.btnComprarProductos.TabIndex = 30;
            this.btnComprarProductos.Text = "Comprar";
            this.btnComprarProductos.UseVisualStyleBackColor = true;
            this.btnComprarProductos.Click += new System.EventHandler(this.btnComprarProductos_Click);
            // 
            // txtCuotasTotales
            // 
            this.txtCuotasTotales.Location = new System.Drawing.Point(148, 188);
            this.txtCuotasTotales.Name = "txtCuotasTotales";
            this.txtCuotasTotales.Size = new System.Drawing.Size(163, 22);
            this.txtCuotasTotales.TabIndex = 27;
            this.txtCuotasTotales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Restringirsolonumeros);
            // 
            // txtIDProductos
            // 
            this.txtIDProductos.Location = new System.Drawing.Point(148, 149);
            this.txtIDProductos.Name = "txtIDProductos";
            this.txtIDProductos.Size = new System.Drawing.Size(163, 22);
            this.txtIDProductos.TabIndex = 26;
            this.txtIDProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Restringirsolonumeros);
            // 
            // txtIDClientes
            // 
            this.txtIDClientes.Location = new System.Drawing.Point(148, 111);
            this.txtIDClientes.Name = "txtIDClientes";
            this.txtIDClientes.Size = new System.Drawing.Size(163, 22);
            this.txtIDClientes.TabIndex = 25;
            this.txtIDClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Restringirsolonumeros);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(74, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(254, 29);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Compra de Producto";
            // 
            // lblCuotasTotales
            // 
            this.lblCuotasTotales.AutoSize = true;
            this.lblCuotasTotales.Location = new System.Drawing.Point(40, 194);
            this.lblCuotasTotales.Name = "lblCuotasTotales";
            this.lblCuotasTotales.Size = new System.Drawing.Size(98, 16);
            this.lblCuotasTotales.TabIndex = 23;
            this.lblCuotasTotales.Text = "Cuotas Totales";
            // 
            // lblIDProductos
            // 
            this.lblIDProductos.AutoSize = true;
            this.lblIDProductos.Location = new System.Drawing.Point(54, 155);
            this.lblIDProductos.Name = "lblIDProductos";
            this.lblIDProductos.Size = new System.Drawing.Size(84, 16);
            this.lblIDProductos.TabIndex = 20;
            this.lblIDProductos.Text = "ID Productos";
            // 
            // lblidClientes
            // 
            this.lblidClientes.AutoSize = true;
            this.lblidClientes.Location = new System.Drawing.Point(67, 114);
            this.lblidClientes.Name = "lblidClientes";
            this.lblidClientes.Size = new System.Drawing.Size(71, 16);
            this.lblidClientes.TabIndex = 19;
            this.lblidClientes.Text = "ID Clientes";
            // 
            // txtPagoInicial
            // 
            this.txtPagoInicial.Location = new System.Drawing.Point(148, 231);
            this.txtPagoInicial.Name = "txtPagoInicial";
            this.txtPagoInicial.Size = new System.Drawing.Size(163, 22);
            this.txtPagoInicial.TabIndex = 32;
            this.txtPagoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Restringirsolonumeros);
            // 
            // lblPagoInicial
            // 
            this.lblPagoInicial.AutoSize = true;
            this.lblPagoInicial.Location = new System.Drawing.Point(61, 237);
            this.lblPagoInicial.Name = "lblPagoInicial";
            this.lblPagoInicial.Size = new System.Drawing.Size(77, 16);
            this.lblPagoInicial.TabIndex = 33;
            this.lblPagoInicial.Text = "Pago Inicial";
            // 
            // fmrComprarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 360);
            this.Controls.Add(this.lblPagoInicial);
            this.Controls.Add(this.txtPagoInicial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnComprarProductos);
            this.Controls.Add(this.txtCuotasTotales);
            this.Controls.Add(this.txtIDProductos);
            this.Controls.Add(this.txtIDClientes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCuotasTotales);
            this.Controls.Add(this.lblIDProductos);
            this.Controls.Add(this.lblidClientes);
            this.Name = "fmrComprarProducto";
            this.Text = "Comprar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnComprarProductos;
        private System.Windows.Forms.TextBox txtCuotasTotales;
        private System.Windows.Forms.TextBox txtIDProductos;
        private System.Windows.Forms.TextBox txtIDClientes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCuotasTotales;
        private System.Windows.Forms.Label lblIDProductos;
        private System.Windows.Forms.Label lblidClientes;
        private System.Windows.Forms.TextBox txtPagoInicial;
        private System.Windows.Forms.Label lblPagoInicial;
    }
}