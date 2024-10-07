using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace Tarea2
{
    public partial class FormPacienteMostrar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;
        public FormPacienteMostrar()
        {
            InitializeComponent();
            CargarPacientes();
        }
        private void CargarPacientes()
        {
            string query = "SELECT Cedula, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Telefono, Email FROM Paciente";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable pacientes = new DataTable();
                    adapter.Fill(pacientes);
                    dgvPacientes.DataSource = pacientes;

                    // Ajustar automáticamente el tamaño de las columnas
                    dgvPacientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

