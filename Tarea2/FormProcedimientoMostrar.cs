using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class FormProcedimientoMostrar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;
        public FormProcedimientoMostrar()
        {
            InitializeComponent();
            CargarDGVProcedimientos();
        }
        private void CargarDGVProcedimientos()
        {
            string query = @"SELECT P.ProcedimientoID, C.CitaID, C.Cedula, C.CedulaMedico, P.Descripcion, 
                             P.FechaProcedimiento, P.Duracion, P.Epicrisis 
                             FROM Procedimiento P
                             INNER JOIN Cita C ON P.CitaID = C.CitaID";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable procedimientos = new DataTable();
                    adapter.Fill(procedimientos);
                    dgvProcedimientos.DataSource = procedimientos;

                    // Ajustar el tamaño de las columnas
                    dgvProcedimientos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los procedimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
