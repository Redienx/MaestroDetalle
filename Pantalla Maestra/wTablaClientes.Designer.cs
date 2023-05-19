namespace Pantalla_Maestra
{
    partial class fmrTablaClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizarBase = new System.Windows.Forms.Button();
            this.rbnid = new System.Windows.Forms.RadioButton();
            this.rbnNombre = new System.Windows.Forms.RadioButton();
            this.rbnApellido = new System.Windows.Forms.RadioButton();
            this.rbnEdad = new System.Windows.Forms.RadioButton();
            this.rbnCelular = new System.Windows.Forms.RadioButton();
            this.rbnCorreo = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnCuotas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(12, 150);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.RowTemplate.Height = 24;
            this.dtgUsuarios.Size = new System.Drawing.Size(805, 340);
            this.dtgUsuarios.TabIndex = 0;
            this.dtgUsuarios.CurrentCellChanged += new System.EventHandler(this.dtgUsuarios_CurrentCellChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(86, 12);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(126, 49);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(359, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(126, 49);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(491, 12);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(126, 49);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizarBase
            // 
            this.btnActualizarBase.Location = new System.Drawing.Point(227, 12);
            this.btnActualizarBase.Name = "btnActualizarBase";
            this.btnActualizarBase.Size = new System.Drawing.Size(126, 49);
            this.btnActualizarBase.TabIndex = 4;
            this.btnActualizarBase.Text = "Actualizar Base de datos";
            this.btnActualizarBase.UseVisualStyleBackColor = true;
            this.btnActualizarBase.Click += new System.EventHandler(this.btnActualizarBase_Click);
            // 
            // rbnid
            // 
            this.rbnid.AutoSize = true;
            this.rbnid.Location = new System.Drawing.Point(12, 74);
            this.rbnid.Name = "rbnid";
            this.rbnid.Size = new System.Drawing.Size(41, 20);
            this.rbnid.TabIndex = 5;
            this.rbnid.TabStop = true;
            this.rbnid.Text = "ID";
            this.rbnid.UseVisualStyleBackColor = true;
            // 
            // rbnNombre
            // 
            this.rbnNombre.AutoSize = true;
            this.rbnNombre.Location = new System.Drawing.Point(59, 74);
            this.rbnNombre.Name = "rbnNombre";
            this.rbnNombre.Size = new System.Drawing.Size(77, 20);
            this.rbnNombre.TabIndex = 6;
            this.rbnNombre.TabStop = true;
            this.rbnNombre.Text = "Nombre";
            this.rbnNombre.UseVisualStyleBackColor = true;
            // 
            // rbnApellido
            // 
            this.rbnApellido.AutoSize = true;
            this.rbnApellido.Location = new System.Drawing.Point(142, 74);
            this.rbnApellido.Name = "rbnApellido";
            this.rbnApellido.Size = new System.Drawing.Size(78, 20);
            this.rbnApellido.TabIndex = 7;
            this.rbnApellido.TabStop = true;
            this.rbnApellido.Text = "Apellido";
            this.rbnApellido.UseVisualStyleBackColor = true;
            // 
            // rbnEdad
            // 
            this.rbnEdad.AutoSize = true;
            this.rbnEdad.Location = new System.Drawing.Point(226, 74);
            this.rbnEdad.Name = "rbnEdad";
            this.rbnEdad.Size = new System.Drawing.Size(61, 20);
            this.rbnEdad.TabIndex = 8;
            this.rbnEdad.TabStop = true;
            this.rbnEdad.Text = "Edad";
            this.rbnEdad.UseVisualStyleBackColor = true;
            // 
            // rbnCelular
            // 
            this.rbnCelular.AutoSize = true;
            this.rbnCelular.Location = new System.Drawing.Point(293, 74);
            this.rbnCelular.Name = "rbnCelular";
            this.rbnCelular.Size = new System.Drawing.Size(70, 20);
            this.rbnCelular.TabIndex = 9;
            this.rbnCelular.TabStop = true;
            this.rbnCelular.Text = "Celular";
            this.rbnCelular.UseVisualStyleBackColor = true;
            // 
            // rbnCorreo
            // 
            this.rbnCorreo.AutoSize = true;
            this.rbnCorreo.Location = new System.Drawing.Point(369, 74);
            this.rbnCorreo.Name = "rbnCorreo";
            this.rbnCorreo.Size = new System.Drawing.Size(69, 20);
            this.rbnCorreo.TabIndex = 10;
            this.rbnCorreo.TabStop = true;
            this.rbnCorreo.Text = "Correo";
            this.rbnCorreo.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(87, 112);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(116, 22);
            this.txtBuscar.TabIndex = 11;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(12, 114);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(69, 20);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(209, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 32);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(489, 107);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(107, 37);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(602, 106);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 37);
            this.btnAnterior.TabIndex = 16;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(708, 107);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(109, 37);
            this.btnUltimo.TabIndex = 17;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(394, 107);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(89, 37);
            this.btnPrimero.TabIndex = 18;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnCuotas
            // 
            this.btnCuotas.Location = new System.Drawing.Point(623, 12);
            this.btnCuotas.Name = "btnCuotas";
            this.btnCuotas.Size = new System.Drawing.Size(126, 49);
            this.btnCuotas.TabIndex = 19;
            this.btnCuotas.Text = "Tabla Cuotas";
            this.btnCuotas.UseVisualStyleBackColor = true;
            this.btnCuotas.Click += new System.EventHandler(this.btnCuotas_Click);
            // 
            // fmrTablaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 502);
            this.Controls.Add(this.btnCuotas);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rbnCorreo);
            this.Controls.Add(this.rbnCelular);
            this.Controls.Add(this.rbnEdad);
            this.Controls.Add(this.rbnApellido);
            this.Controls.Add(this.rbnNombre);
            this.Controls.Add(this.rbnid);
            this.Controls.Add(this.btnActualizarBase);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dtgUsuarios);
            this.Name = "fmrTablaClientes";
            this.Text = "Tabla Clientes";
            this.Load += new System.EventHandler(this.fmrTablaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        public System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Button btnActualizarBase;
        private System.Windows.Forms.RadioButton rbnid;
        private System.Windows.Forms.RadioButton rbnNombre;
        private System.Windows.Forms.RadioButton rbnApellido;
        private System.Windows.Forms.RadioButton rbnEdad;
        private System.Windows.Forms.RadioButton rbnCelular;
        private System.Windows.Forms.RadioButton rbnCorreo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnCuotas;
    }
}

