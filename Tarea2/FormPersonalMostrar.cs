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
    public partial class FormPersonalMostrar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;
        public FormPersonalMostrar()
        {
            InitializeComponent();
            CargarDGV();
        }

        private void CargarDGV()
        {
            string query = "SELECT Cedula, Nombre, PrimerApellido, SegundoApellido, Especialidad, Experiencia, Telefono, Email FROM PersonalMedico";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable personal = new DataTable();
                    adapter.Fill(personal);
                    dgvPersonal.DataSource = personal;
                    dgvPersonal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el personal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
