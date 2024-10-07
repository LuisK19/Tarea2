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
    public partial class FormCitaMostrar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;
        public FormCitaMostrar()
        {
            InitializeComponent();
            CargarDGV(); // Cargar el DataGridView al iniciar el formulario
        }

        private void CargarDGV()
        {
            string query = "SELECT CitaID, Cedula, CedulaMedico, MotivoConsulta, Duracion, Resultados, FechaHora, Epicrisis, PersonalAdicional FROM Cita";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable citas = new DataTable();
                    adapter.Fill(citas);
                    dgvCitas.DataSource = citas;

                    // Ajustar automáticamente el tamaño de las columnas
                    dgvCitas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las citas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
