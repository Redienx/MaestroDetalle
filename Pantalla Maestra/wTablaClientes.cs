using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

///<summary>
///Codigo Hecho por Sneider
///La finalidad es Realizar el CRUD en una pantalla Maestra
/// </summary>

namespace Pantalla_Maestra
{
    public partial class fmrTablaClientes : Form
    {
        // Varibles
        int indice = 0;
        public fmrTablaClientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se activa cuando se carga el formulario.
        /// Establece la conexión con la base de datos y carga los datos de la tabla de clientes en el DataGridView.
        /// </summary>
        private void fmrTablaClientes_Load(object sender, EventArgs e)
        {
            // Se establece la conexión con la base de datos SQLite
            SQLiteConnection Conexion_sqlite;
            Conexion_sqlite = new SQLiteConnection("Data Source=dbMercado.db;Version = 3; Compress= True");

            try
            {
                Conexion_sqlite.Open(); // Se abre la conexión
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró la base de datos");
            }

            // Consulta para obtener todos los registros de la tabla de clientes
            string Consulta = "SELECT * from tblClientes";
            // Ejecutar la consulta y llenar un DataTable con los resultados
            SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
            DataTable dt = new DataTable();
            dataAdapter_sqlite.Fill(dt);
            dtgUsuarios.DataSource = dt; // Se asigna el resultado de la consulta a un DataGridView llamado "dtgUsuarios"

            Conexion_sqlite.Close(); // Se cierra la conexión
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Actualizar Base".
        /// Vuelve a cargar los datos de la tabla de clientes desde la base de datos y los muestra en el DataGridView.
        /// </summary>
        private void btnActualizarBase_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion_sqlite;
            Conexion_sqlite = new SQLiteConnection("Data Source=dbMercado.db;Version = 3; Compress= True");

            try
            {
                Conexion_sqlite.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró la base de datos");
            }

            string Consulta = "SELECT * from tblClientes";
            SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
            DataTable dt = new DataTable();
            dataAdapter_sqlite.Fill(dt);
            dtgUsuarios.DataSource = dt;

            Conexion_sqlite.Close();
        }

        /// <summary>
        /// Evento que se activa al hacer clic en el botón "Buscar".
        /// Realiza una consulta a la base de datos según los criterios de búsqueda seleccionados por el usuario y muestra el resultado en el DataGridView.
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion_sqlite;
            Conexion_sqlite = new SQLiteConnection("Data Source=dbMercado.db;Version = 3; Compress= True");

            try
            {
                Conexion_sqlite.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontró la base de datos");
            }

            if (rbnid.Checked == true)
            {
                try
                {
                    string Consulta = "SELECT * from tblClientes WHERE ID = " + txtBuscar.Text + "";
                    SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
                    DataTable dt = new DataTable();
                    dataAdapter_sqlite.Fill(dt);
                    dtgUsuarios.DataSource = dt;
                    SQLiteCommand cmd_sqlite = new SQLiteCommand(Consulta, Conexion_sqlite);
                    SQLiteDataReader dataReader_sqlite = cmd_sqlite.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar un valor");
                }

                Conexion_sqlite.Close();
            }
            else if (rbnNombre.Checked == true)
            {
                try
                {
                    string Consulta = "SELECT * from tblClientes WHERE Nombre = '" + txtBuscar.Text + "'";
                    SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
                    DataTable dt = new DataTable();
                    dataAdapter_sqlite.Fill(dt);
                    dtgUsuarios.DataSource = dt;
                    SQLiteCommand cmd_sqlite = new SQLiteCommand(Consulta, Conexion_sqlite);
                    SQLiteDataReader dataReader_sqlite = cmd_sqlite.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar un valor");
                }

                Conexion_sqlite.Close();
            }
            else if (rbnApellido.Checked == true)
            {
                try
                {
                    string Consulta = "SELECT * from tblClientes WHERE Apellido = '" + txtBuscar.Text + "'";
                    SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
                    DataTable dt = new DataTable();
                    dataAdapter_sqlite.Fill(dt);
                    dtgUsuarios.DataSource = dt;
                    SQLiteCommand cmd_sqlite = new SQLiteCommand(Consulta, Conexion_sqlite);
                    SQLiteDataReader dataReader_sqlite = cmd_sqlite.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar un valor");
                }

                Conexion_sqlite.Close();
            }
            else if (rbnEdad.Checked == true)
            {
                try
                {
                    string Consulta = "SELECT * from tblClientes WHERE Edad = " + txtBuscar.Text + "";
                    SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
                    DataTable dt = new DataTable();
                    dataAdapter_sqlite.Fill(dt);
                    dtgUsuarios.DataSource = dt;
                    SQLiteCommand cmd_sqlite = new SQLiteCommand(Consulta, Conexion_sqlite);
                    SQLiteDataReader dataReader_sqlite = cmd_sqlite.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar un valor");
                }

                Conexion_sqlite.Close();
            }
            else if (rbnCelular.Checked == true)
            {
                try
                {
                    string Consulta = "SELECT * from tblClientes WHERE Celular = '" + txtBuscar.Text + "'";
                    SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
                    DataTable dt = new DataTable();
                    dataAdapter_sqlite.Fill(dt);
                    dtgUsuarios.DataSource = dt;
                    SQLiteCommand cmd_sqlite = new SQLiteCommand(Consulta, Conexion_sqlite);
                    SQLiteDataReader dataReader_sqlite = cmd_sqlite.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar un valor");
                }

                Conexion_sqlite.Close();
            }
            else if (rbnCorreo.Checked == true)
            {
                try
                {
                    string Consulta = "SELECT * from tblClientes WHERE Correo = '" + txtBuscar.Text + "'";
                    SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
                    DataTable dt = new DataTable();
                    dataAdapter_sqlite.Fill(dt);
                    dtgUsuarios.DataSource = dt;
                    SQLiteCommand cmd_sqlite = new SQLiteCommand(Consulta, Conexion_sqlite);
                    SQLiteDataReader dataReader_sqlite = cmd_sqlite.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar un valor");
                }

                Conexion_sqlite.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una opción");
            }
        }

        // Evento que se activa al hacer clic en el botón "Borrar"
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            fmrBorrarCliente fmrBorrarCliente = new fmrBorrarCliente();
            fmrBorrarCliente.Show();
        }
        // Evento que se activa al hacer clic en el botón "Crear"
        private void btnCrear_Click(object sender, EventArgs e)
        {
            fmrCrearClientes fmrCrearClientes = new fmrCrearClientes();
            fmrCrearClientes.Show();
        }
        // Evento que se activa al hacer clic en el botón "Actualizar"
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            fmrActualizarClientes fmrActualizarClientes = new fmrActualizarClientes();
            fmrActualizarClientes.Show();
        }

        // Evento que se activa Cuando una celda del datagridview cambia
        private void dtgUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dtgUsuarios.CurrentRow != null)
            {
                indice = dtgUsuarios.CurrentRow.Index;
            }
        }

        // Evento que se activa al hacer clic en el botón "Siguiente"
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int Siguiente = indice + 1;
            try
            {
                dtgUsuarios.CurrentCell = dtgUsuarios.Rows[Siguiente].Cells[dtgUsuarios.CurrentCell.ColumnIndex];
            }
            catch (Exception ex) { MessageBox.Show("Llego al tope maximo"); }
        }

        // Evento que se activa al hacer clic en el botón "Anterior"
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int Anterior = indice - 1;
            try 
            {
                dtgUsuarios.CurrentCell = dtgUsuarios.Rows[Anterior].Cells[dtgUsuarios.CurrentCell.ColumnIndex];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Llego al tope Maximo");
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            dtgUsuarios.CurrentCell = dtgUsuarios.Rows[0].Cells[dtgUsuarios.CurrentCell.ColumnIndex];
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            dtgUsuarios.CurrentCell = dtgUsuarios.Rows[dtgUsuarios.RowCount - 1].Cells[0];
        }

        private void btnCuotas_Click(object sender, EventArgs e)
        {
            fmrTablaCuotas fmrTablaCuotas = new fmrTablaCuotas();
            fmrTablaCuotas.Show();
        }
    }
}
