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
    /// Representa el formulario para realizar el pago de una cuota.
    /// </summary>
    public partial class fmrPagarCuota : Form
    {
        // Variables de clase
        int NumeroCuota, CuotasTotales, Pago, TotalPagar, lectura2, CuotaRestante;
        string lectura, ID_Clientes, ID_Prductos;

        /// <summary>
        /// Limpia los campos de texto y cierra el formulario.
        /// </summary>
        public void Limpiar_txt()
        {
            txtIDClientes.Text = null;
            txtIDProductos.Text = null;
            txtNumeroCuota.Text = null;
            txtPago.Text = null;

            this.Close();
        }

        /// <summary>
        /// Constructor de la clase fmrPagarCuota.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public fmrPagarCuota()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se activa al cambiar el texto en el campo de texto "IDClientes".
        /// Obtiene el nombre y apellido del cliente correspondiente al ID ingresado y lo muestra en una etiqueta.
        /// </summary>
        private void txtIDClientes_TextChanged(object sender, EventArgs e)
        {
            SQLiteConnection Conexion_sqlite;
            SQLiteCommand cmd_sqlite;
            SQLiteDataReader dataReader_sqlite;

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

            ID_Clientes = txtIDClientes.Text;

            // Crear el comando de selección y asignar el valor del campo de texto "IDClientes"
            cmd_sqlite = Conexion_sqlite.CreateCommand();

            // Ejecutar la consulta de selección en la base de datos
            cmd_sqlite.CommandText = $"SELECT Nombre, Apellido FROM tblClientes WHERE ID = '{ID_Clientes}'";
            dataReader_sqlite = cmd_sqlite.ExecuteReader();
            try
            {
                while (dataReader_sqlite.Read())
                {
                    lectura = dataReader_sqlite.GetString(0);
                    lectura += dataReader_sqlite.GetString(1);
                }
            }
            catch (Exception ex) { MessageBox.Show("No se encuentra el registro"); }

            // Mostrar el nombre y apellido en la etiqueta
            lblClientes.Text = lectura;
            lblClientes.Visible = true;

            Conexion_sqlite.Close();
        }

        /// <summary>
        /// Evento que se activa al cambiar el texto en el campo de texto "IDProductos".
        /// Obtiene el nombre del producto correspondiente al ID ingresado y lo muestra en una etiqueta.
        /// También obtiene el número de cuota actual para ese producto y lo muestra en el campo de texto "NumeroCuota".
        /// </summary>
        private void txtIDProductos_TextChanged(object sender, EventArgs e)
        {
            SQLiteConnection Conexion_sqlite;
            SQLiteCommand cmd_sqlite;
            SQLiteCommand cmd2_sqlite;
            SQLiteDataReader dataReader_sqlite;
            SQLiteDataReader dataReader2_sqlite;

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

            ID_Prductos = txtIDProductos.Text;

            // Crear los comandos de selección y asignar el valor del campo de texto "IDProductos"
            cmd_sqlite = Conexion_sqlite.CreateCommand();
            cmd2_sqlite = Conexion_sqlite.CreateCommand();

            // Ejecutar la consulta de selección en la base de datos para obtener el nombre del producto
            cmd_sqlite.CommandText = $"SELECT Nombre_Producto FROM tblProducto WHERE ID = '{ID_Prductos}'";
            dataReader_sqlite = cmd_sqlite.ExecuteReader();
            try
            {
                while (dataReader_sqlite.Read())
                {
                    lectura = dataReader_sqlite.GetString(0);
                }
            }
            catch (Exception ex) { MessageBox.Show("No se encuentra el registro"); }

            // Mostrar el nombre del producto en la etiqueta
            lblProductos.Text = lectura;
            lblProductos.Visible = true;

            // Obtener el número de cuota actual para ese producto
            cmd2_sqlite.CommandText = $"SELECT Cuotas_Pagadas FROM tblCuotas WHERE ID_Clientes = '{ID_Clientes}' AND ID_Productos = '{ID_Prductos}';";
            dataReader2_sqlite = cmd2_sqlite.ExecuteReader();

            while (dataReader2_sqlite.Read())
            {
                lectura2 = int.Parse(dataReader2_sqlite.GetString(0));
            }

            lectura2 = lectura2 + 1;

            // Mostrar el número de cuota actual en el campo de texto "NumeroCuota"
            txtNumeroCuota.Text = lectura2.ToString();

            Conexion_sqlite.Close();
        }

        /// <summary>
        /// Evento que se activa al presionar una tecla en los campos de texto que deben contener solo números.
        /// Restringe la entrada de caracteres que no sean dígitos o espacios.
        /// </summary>
        private void Restringirsolonumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Pagar".
        /// Realiza el pago de una cuota en la base de datos y muestra un mensaje de éxito.
        /// </summary>
        private void btnPagar_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion_sqlite;
            SQLiteCommand cmd_sqlite;
            SQLiteCommand cmd1_sqlite;
            SQLiteCommand cmd2_sqlite;
            SQLiteCommand cmd3_sqlite;
            SQLiteCommand cmd4_sqlite;
            SQLiteDataReader dataReader_sqlite;
            SQLiteDataReader dataReader1_sqlite;
            SQLiteDataReader dataReader2_sqlite;

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

            // Crear los comandos de inserción y actualización y asignar los valores de los campos de texto
            cmd_sqlite = Conexion_sqlite.CreateCommand();
            cmd1_sqlite = Conexion_sqlite.CreateCommand();
            cmd2_sqlite = Conexion_sqlite.CreateCommand();
            cmd3_sqlite = Conexion_sqlite.CreateCommand();
            cmd4_sqlite = Conexion_sqlite.CreateCommand();

            try
            {
                ID_Clientes = txtIDClientes.Text;
                ID_Prductos = txtIDProductos.Text;
                NumeroCuota = int.Parse(txtNumeroCuota.Text);
                Pago = int.Parse(txtPago.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los valores no pueden ser nulos. Por favor, llena todos los campos.");
            }

            // Verificar si el cliente ha comprado el producto
            cmd1_sqlite.CommandText = $"SELECT ID_Clientes, ID_Productos FROM tblCuotas WHERE ID_Clientes = '{ID_Clientes}' AND ID_Productos = '{ID_Prductos}'";
            dataReader1_sqlite = cmd1_sqlite.ExecuteReader();

            if (dataReader1_sqlite.Read() == false)
            {
                MessageBox.Show("Este usuario no ha comprado este producto.");
                return;
            }

            // Obtener el valor del producto y el total a pagar
            cmd_sqlite.CommandText = $"SELECT Valor_Producto FROM tblProducto WHERE ID = '{ID_Prductos}'";
            dataReader_sqlite = cmd_sqlite.ExecuteReader();
            cmd2_sqlite.CommandText = $"SELECT Total_a_Pagar FROM tblCuotas WHERE ID_Clientes = '{ID_Clientes}' AND ID_Productos = '{ID_Prductos}';";
            dataReader2_sqlite = cmd2_sqlite.ExecuteReader();
            try
            {
                while (dataReader_sqlite.Read() && dataReader2_sqlite.Read())
                {
                    TotalPagar = int.Parse(dataReader_sqlite.GetString(0));
                    CuotasTotales = int.Parse(dataReader2_sqlite.GetString(0));

                }
            }
            catch (Exception ex) { MessageBox.Show("No se encuentra el registro"); }

            CuotaRestante = CuotasTotales - NumeroCuota;

            // Insertar el pago en la tabla de cuotas
            cmd3_sqlite.CommandText = $"INSERT INTO tblCuotas(ID_Clientes, ID_Productos, Cuotas_Totales, Cuotas_Pagadas, Cuotas_Restantes, Total_Pagado, Total_a_Pagar) VALUES('{ID_Clientes}', '{ID_Prductos}', {CuotasTotales}, {NumeroCuota}, {CuotaRestante}, {Pago}, {TotalPagar});";
            cmd3_sqlite.ExecuteNonQuery();
            Conexion_sqlite.Close();
            MessageBox.Show("Pago realizado.");
            Limpiar_txt();
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Cancelar".
        /// Limpia los campos de texto y cierra el formulario.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar_txt();
        }
    }
}
