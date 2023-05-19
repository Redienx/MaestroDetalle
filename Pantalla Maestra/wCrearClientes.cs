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
    /// Representa el formulario para crear nuevos clientes en una base de datos SQLite.
    /// </summary>
    public partial class fmrCrearClientes : Form
    {
        // Variables de clase
        string Nombre, Apellido, Celular, Correo;
        int Edad;

        /// <summary>
        /// Constructor de la clase fmrCrearClientes.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public fmrCrearClientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se activa al presionar una tecla en el campo de texto "Edad".
        /// Permite solo la entrada de dígitos en el campo de texto.
        /// </summary>
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Crear Clientes".
        /// Inserta los datos del nuevo cliente en la base de datos y cierra el formulario.
        /// </summary>
        private void btnCrearClientes_Click(object sender, EventArgs e)
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

            // Crear el comando de inserción y asignar los valores de los campos de texto
            cmd_sqlite = Conexion_sqlite.CreateCommand();
            try
            {
                Nombre = txtNombre.Text;
                Apellido = txtApellido.Text;
                Edad = int.Parse(txtEdad.Text);
                Celular = txtCelular.Text;
                Correo = txtCorreo.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los valores no pueden ser nulos. Por favor, llena todos los campos.");
            }

            // Ejecutar la consulta de inserción en la base de datos
            cmd_sqlite.CommandText = $"INSERT INTO tblClientes(Nombre, Apellido, Edad, Celular, Correo) VALUES('{Nombre}', '{Apellido}', '{Edad}', '{Celular}', '{Correo}')";
            cmd_sqlite.ExecuteNonQuery();

            // Cerrar la conexión a la base de datos
            Conexion_sqlite.Close();

            // Limpiar los campos de texto
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtEdad.Text = null;
            txtCelular.Text = null;
            txtCorreo.Text = null;

            // Cerrar el formulario
            this.Close();
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Cancelar".
        /// Limpia los campos de texto y cierra el formulario sin guardar los datos.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtEdad.Text = null;
            txtCelular.Text = null;
            txtCorreo.Text = null;

            // Cerrar el formulario
            this.Close();
        }
    }
}
