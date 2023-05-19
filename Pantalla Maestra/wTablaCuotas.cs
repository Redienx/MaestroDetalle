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
    public partial class fmrTablaCuotas : Form
    {
        int indice = 0;

        public fmrTablaCuotas()
        {
            InitializeComponent();
        }

        private void fmrVentas_Load(object sender, EventArgs e)
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
            string Consulta = "SELECT * from tblCuotas";
            // Ejecutar la consulta y llenar un DataTable con los resultados
            SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
            DataTable dt = new DataTable();
            dataAdapter_sqlite.Fill(dt);
            dtgCuotas.DataSource = dt; // Se asigna el resultado de la consulta a un DataGridView llamado "dtgUsuarios"

            Conexion_sqlite.Close(); // Se cierra la conexión
        }

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

            string Consulta = "SELECT * from tblCuotas";
            SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
            DataTable dt = new DataTable();
            dataAdapter_sqlite.Fill(dt);
            dtgCuotas.DataSource = dt;

            Conexion_sqlite.Close();
        }

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
                    string Consulta = "SELECT * from tblCuotas WHERE ID = " + txtBuscar.Text + "";
                    SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
                    DataTable dt = new DataTable();
                    dataAdapter_sqlite.Fill(dt);
                    dtgCuotas.DataSource = dt;
                    SQLiteCommand cmd_sqlite = new SQLiteCommand(Consulta, Conexion_sqlite);
                    SQLiteDataReader dataReader_sqlite = cmd_sqlite.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar un valor");
                }

                Conexion_sqlite.Close();
            }
            else if (rbnID_Clientes.Checked == true)
            {
                try
                {
                    string Consulta = "SELECT * from tblCuotas WHERE ID_Clientes = '" + txtBuscar.Text + "'";
                    SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
                    DataTable dt = new DataTable();
                    dataAdapter_sqlite.Fill(dt);
                    dtgCuotas.DataSource = dt;
                    SQLiteCommand cmd_sqlite = new SQLiteCommand(Consulta, Conexion_sqlite);
                    SQLiteDataReader dataReader_sqlite = cmd_sqlite.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar un valor");
                }

                Conexion_sqlite.Close();
            }
            else if (rbnID_Producto.Checked == true)
            {
                try
                {
                    string Consulta = "SELECT * from tblCuotas WHERE ID_Productos = '" + txtBuscar.Text + "'";
                    SQLiteDataAdapter dataAdapter_sqlite = new SQLiteDataAdapter(Consulta, Conexion_sqlite);
                    DataTable dt = new DataTable();
                    dataAdapter_sqlite.Fill(dt);
                    dtgCuotas.DataSource = dt;
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

        // Evento que se activa Cuando una celda del datagridview cambia
        

        // Evento que se activa al hacer clic en el botón "Siguiente"
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int Siguiente = indice + 1;
            try
            {
                dtgCuotas.CurrentCell = dtgCuotas.Rows[Siguiente].Cells[dtgCuotas.CurrentCell.ColumnIndex];
            }
            catch (Exception ex) { MessageBox.Show("Llego al tope maximo"); }
        }

        // Evento que se activa al hacer clic en el botón "Anterior"
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int Anterior = indice - 1;
            try
            {
                dtgCuotas.CurrentCell = dtgCuotas.Rows[Anterior].Cells[dtgCuotas.CurrentCell.ColumnIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Llego al tope Maximo");
            }
        }
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            dtgCuotas.CurrentCell = dtgCuotas.Rows[0].Cells[dtgCuotas.CurrentCell.ColumnIndex];
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            dtgCuotas.CurrentCell = dtgCuotas.Rows[dtgCuotas.RowCount - 1].Cells[0];
        }

        private void btnComprarProducto_Click(object sender, EventArgs e)
        {
            fmrComprarProducto fmrComprarProducto = new fmrComprarProducto();
            fmrComprarProducto.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            fmrTablaClientes fmrTablaClientes = new fmrTablaClientes();
            fmrTablaClientes.Show();
            this.Close();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            fmrPagarCuota fmrPagarCuota = new fmrPagarCuota();
            fmrPagarCuota.Show();
        }

        private void dtgCuotas_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dtgCuotas.CurrentRow != null)
            {
                indice = dtgCuotas.CurrentRow.Index;
            }
        }
    }
}
