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
    /// Formulario para realizar la compra de un producto.
    /// </summary>
    public partial class fmrComprarProducto : Form
    {
        int ID_Clientes, ID_Prductos, CuotasTotales, CuotasRestantes, PagoInicial, TotalPagar;

        public fmrComprarProducto()
        {
            InitializeComponent();
        }

        private void Restringirsolonumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Comprar Productos".
        /// Realiza la inserción de los datos de la compra en la base de datos.
        /// </summary>
        private void btnComprarProductos_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion_sqlite;
            SQLiteCommand cmd_sqlite;
            SQLiteCommand cmd2_sqlite;
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

            // Crear el comando de inserción y asignar los valores de los campos de texto
            cmd_sqlite = Conexion_sqlite.CreateCommand();
            cmd2_sqlite = Conexion_sqlite.CreateCommand();

            try
            {
                ID_Clientes = int.Parse(txtIDClientes.Text);
                ID_Prductos = int.Parse(txtIDProductos.Text);
                CuotasTotales = int.Parse(txtCuotasTotales.Text);
                PagoInicial = int.Parse(txtPagoInicial.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los valores no pueden ser nulos. Por favor, llena todos los campos.");
            }

            cmd_sqlite.CommandText = $"SELECT Valor_Producto FROM tblProducto WHERE ID = '{ID_Prductos}'";
            dataReader_sqlite = cmd_sqlite.ExecuteReader();
            try
            {
                while (dataReader_sqlite.Read())
                {
                    TotalPagar = int.Parse(dataReader_sqlite.GetString(0));
                }
            }
            catch (Exception ex) { MessageBox.Show("No Se encuentra el regristro"); }

            CuotasRestantes = CuotasTotales - 1;

            // Ejecutar la consulta de inserción en la base de datos
            cmd2_sqlite.CommandText = $"INSERT INTO tblCuotas(ID_Clientes, ID_Productos, Cuotas_Totales, Cuotas_Pagadas, Cuotas_Restantes, Total_Pagado, Total_a_Pagar) VALUES('{ID_Clientes}', '{ID_Prductos}', '{CuotasTotales}', '1', '{CuotasRestantes}', '{PagoInicial}', '{TotalPagar}');";
            cmd2_sqlite.ExecuteNonQuery();

            // Cerrar la conexión a la base de datos
            Conexion_sqlite.Close();

            txtIDClientes.Text = null;
            txtIDProductos.Text = null;
            txtCuotasTotales.Text = null;
            txtPagoInicial.Text = null;

            this.Close();
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Cancelar".
        /// Limpia los campos de texto y cierra el formulario.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIDClientes.Text = null;
            txtIDProductos.Text = null;
            txtCuotasTotales.Text = null;
            txtPagoInicial.Text = null;

            this.Close();
        }
    }
}
