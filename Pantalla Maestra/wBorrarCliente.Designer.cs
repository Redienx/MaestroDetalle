namespace Pantalla_Maestra
{
    partial class fmrBorrarCliente
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
            this.btnBorrarClientes = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBorrarClientes
            // 
            this.btnBorrarClientes.Location = new System.Drawing.Point(78, 193);
            this.btnBorrarClientes.Name = "btnBorrarClientes";
            this.btnBorrarClientes.Size = new System.Drawing.Size(110, 52);
            this.btnBorrarClientes.TabIndex = 46;
            this.btnBorrarClientes.Text = "Borrar";
            this.btnBorrarClientes.UseVisualStyleBackColor = true;
            this.btnBorrarClientes.Click += new System.EventHandler(this.btnBorrarClientes_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(123, 144);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(178, 22);
            this.txtid.TabIndex = 40;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(75, 144);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 16);
            this.lblid.TabIndex = 39;
            this.lblid.Text = "id";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(125, 79);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(176, 29);
            this.lblTitulo.TabIndex = 38;
            this.lblTitulo.Text = "Borrar Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 52);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // fmrBorrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 395);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrarClientes);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblTitulo);
            this.Name = "fmrBorrarCliente";
            this.Text = "Borrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrarClientes;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
    }
}