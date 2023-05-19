using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Maestra
{
    /// <summary>
    /// Representa el formulario para borrar un cliente de la base de datos.
    /// </summary>
    public partial class fmrBorrarCliente : Form
    {
        // Variable de clase
        int id;

        /// <summary>
        /// Constructor de la clase fmrBorrarCliente.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public fmrBorrarCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Borrar Clientes".
        /// Borra el cliente de la base de datos y cierra el formulario.
        /// </summary>
        private void btnBorrarClientes_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion_sqlite;
            SQLiteCommand cmd_sqlite;

            // Establecer conexión a la base de datos
            Conexion_sqlite = new SQLiteConnection("Data Source=dbMercado.db;Version = 3; Compress= True");
            try
            {
                Conexion_sqlite.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró la base de datos");
            }

            // Crear el comando de borrado y asignar el valor del campo de texto "id"
            cmd_sqlite = Conexion_sqlite.CreateCommand();
            try
            {
                id = int.Parse(txtid.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Llena el campo.");
            }

            // Ejecutar la consulta de borrado en la base de datos
            cmd_sqlite.CommandText = $"DELETE from tblClientes WHERE ID = {id}";
            cmd_sqlite.ExecuteNonQuery();

            // Cerrar la conexión a la base de datos
            Conexion_sqlite.Close();

            // Limpiar el campo de texto
            txtid.Text = null;

            // Cerrar el formulario
            this.Close();
        }

        /// <summary>
        /// Evento que se activa al presionar una tecla en el campo de texto "id".
        /// Permite solo la entrada de dígitos en el campo de texto.
        /// </summary>
        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Cancelar".
        /// Limpia el campo de texto y cierra el formulario sin borrar el cliente.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar el campo de texto
            txtid.Text = null;

            // Cerrar el formulario
            this.Close();
        }
    }
}
