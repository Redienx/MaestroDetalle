namespace Pantalla_Maestra
{
    partial class fmrTablaCuotas
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
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbnID_Clientes = new System.Windows.Forms.RadioButton();
            this.rbnid = new System.Windows.Forms.RadioButton();
            this.btnActualizarBase = new System.Windows.Forms.Button();
            this.btnPagarCuota = new System.Windows.Forms.Button();
            this.btnComprarProducto = new System.Windows.Forms.Button();
            this.dtgCuotas = new System.Windows.Forms.DataGridView();
            this.btnClientes = new System.Windows.Forms.Button();
            this.rbnID_Producto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrimero
            // 
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(394, 107);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(89, 37);
            this.btnPrimero.TabIndex = 36;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(708, 107);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(109, 37);
            this.btnUltimo.TabIndex = 35;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(602, 106);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 37);
            this.btnAnterior.TabIndex = 34;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(489, 107);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(107, 37);
            this.btnSiguiente.TabIndex = 33;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(209, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 32);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(12, 114);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(69, 20);
            this.lblBuscar.TabIndex = 31;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(87, 112);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(116, 22);
            this.txtBuscar.TabIndex = 30;
            // 
            // rbnID_Clientes
            // 
            this.rbnID_Clientes.AutoSize = true;
            this.rbnID_Clientes.Location = new System.Drawing.Point(59, 74);
            this.rbnID_Clientes.Name = "rbnID_Clientes";
            this.rbnID_Clientes.Size = new System.Drawing.Size(96, 20);
            this.rbnID_Clientes.TabIndex = 25;
            this.rbnID_Clientes.TabStop = true;
            this.rbnID_Clientes.Text = "ID_Clientes";
            this.rbnID_Clientes.UseVisualStyleBackColor = true;
            // 
            // rbnid
            // 
            this.rbnid.AutoSize = true;
            this.rbnid.Location = new System.Drawing.Point(12, 74);
            this.rbnid.Name = "rbnid";
            this.rbnid.Size = new System.Drawing.Size(41, 20);
            this.rbnid.TabIndex = 24;
            this.rbnid.TabStop = true;
            this.rbnid.Text = "ID";
            this.rbnid.UseVisualStyleBackColor = true;
            // 
            // btnActualizarBase
            // 
            this.btnActualizarBase.Location = new System.Drawing.Point(444, 12);
            this.btnActualizarBase.Name = "btnActualizarBase";
            this.btnActualizarBase.Size = new System.Drawing.Size(126, 49);
            this.btnActualizarBase.TabIndex = 23;
            this.btnActualizarBase.Text = "Actualizar Base de datos";
            this.btnActualizarBase.UseVisualStyleBackColor = true;
            this.btnActualizarBase.Click += new System.EventHandler(this.btnActualizarBase_Click);
            // 
            // btnPagarCuota
            // 
            this.btnPagarCuota.Location = new System.Drawing.Point(576, 12);
            this.btnPagarCuota.Name = "btnPagarCuota";
            this.btnPagarCuota.Size = new System.Drawing.Size(126, 49);
            this.btnPagarCuota.TabIndex = 21;
            this.btnPagarCuota.Text = "Pagar";
            this.btnPagarCuota.UseVisualStyleBackColor = true;
            this.btnPagarCuota.Click += new System.EventHandler(this.btnPagarCuota_Click);
            // 
            // btnComprarProducto
            // 
            this.btnComprarProducto.Location = new System.Drawing.Point(303, 12);
            this.btnComprarProducto.Name = "btnComprarProducto";
            this.btnComprarProducto.Size = new System.Drawing.Size(126, 49);
            this.btnComprarProducto.TabIndex = 20;
            this.btnComprarProducto.Text = "Comprar";
            this.btnComprarProducto.UseVisualStyleBackColor = true;
            this.btnComprarProducto.Click += new System.EventHandler(this.btnComprarProducto_Click);
            // 
            // dtgCuotas
            // 
            this.dtgCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCuotas.Location = new System.Drawing.Point(12, 150);
            this.dtgCuotas.Name = "dtgCuotas";
            this.dtgCuotas.ReadOnly = true;
            this.dtgCuotas.RowHeadersWidth = 51;
            this.dtgCuotas.RowTemplate.Height = 24;
            this.dtgCuotas.Size = new System.Drawing.Size(805, 340);
            this.dtgCuotas.TabIndex = 19;
            this.dtgCuotas.CurrentCellChanged += new System.EventHandler(this.dtgCuotas_CurrentCellChanged);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(157, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(126, 49);
            this.btnClientes.TabIndex = 37;
            this.btnClientes.Text = "Tabla Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // rbnID_Producto
            // 
            this.rbnID_Producto.AutoSize = true;
            this.rbnID_Producto.Location = new System.Drawing.Point(161, 74);
            this.rbnID_Producto.Name = "rbnID_Producto";
            this.rbnID_Producto.Size = new System.Drawing.Size(109, 20);
            this.rbnID_Producto.TabIndex = 38;
            this.rbnID_Producto.TabStop = true;
            this.rbnID_Producto.Text = "ID_Productos";
            this.rbnID_Producto.UseVisualStyleBackColor = true;
            // 
            // fmrTablaCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 502);
            this.Controls.Add(this.rbnID_Producto);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rbnID_Clientes);
            this.Controls.Add(this.rbnid);
            this.Controls.Add(this.btnActualizarBase);
            this.Controls.Add(this.btnPagarCuota);
            this.Controls.Add(this.btnComprarProducto);
            this.Controls.Add(this.dtgCuotas);
            this.Name = "fmrTablaCuotas";
            this.Text = "Tabla Cuotas";
            this.Load += new System.EventHandler(this.fmrVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbnID_Clientes;
        private System.Windows.Forms.RadioButton rbnid;
        private System.Windows.Forms.Button btnActualizarBase;
        private System.Windows.Forms.Button btnPagarCuota;
        private System.Windows.Forms.Button btnComprarProducto;
        public System.Windows.Forms.DataGridView dtgCuotas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.RadioButton rbnID_Producto;
    }
}