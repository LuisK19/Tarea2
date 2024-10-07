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
    public partial class FormMedicamentoMostrar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;
        public FormMedicamentoMostrar()
        {
            InitializeComponent();
            CargarDGV();
        }
        private void CargarDGV()
        {
            string query = "SELECT MedicamentoID, Nombre, Dosificacion, EfectosSecundarios FROM Medicamento";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable medicamentos = new DataTable();
                    adapter.Fill(medicamentos);
                    dgvMedicamentos.DataSource = medicamentos;

                    // Ajustar automáticamente el tamaño de las columnas
                    dgvMedicamentos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los medicamentos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
