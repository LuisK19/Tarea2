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
    public partial class FormPersonalEliminar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormPersonalEliminar()
        {
            InitializeComponent();
            CargarPersonal();
            CargarDGV();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbPersonal.SelectedItem != null)
            {
                string cedulaSeleccionada = (cbPersonal.SelectedItem as dynamic).Cedula;
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este personal médico y sus datos asociados?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EliminarPersonal(cedulaSeleccionada);
                    CargarDGV();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un personal médico para eliminar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarPersonal(string cedula)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        // Eliminar el personal de todas las tablas relacionadas
                        string[] queries = {
                            "DELETE FROM MedicoProcedimiento WHERE CedulaMedico = @Cedula",
                            "DELETE FROM Cita WHERE CedulaMedico = @Cedula",
                            "DELETE FROM PersonalMedico WHERE Cedula = @Cedula"
                        };

                        foreach (string query in queries)
                        {
                            MySqlCommand cmd = new MySqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@Cedula", cedula);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Personal médico eliminado correctamente, junto con los datos relacionados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPersonal(); // Recargar los datos en el ComboBox
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el personal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPersonal()
        {
            string query = "SELECT Cedula, Nombre, PrimerApellido, SegundoApellido FROM PersonalMedico";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                cbPersonal.Items.Clear();  // Limpiar el ComboBox antes de cargar
                while (reader.Read())
                {
                    cbPersonal.Items.Add(new { Cedula = reader["Cedula"].ToString(), Nombre = $"{reader["Nombre"]} {reader["PrimerApellido"]} {reader["SegundoApellido"]}" });
                }
            }

            cbPersonal.DisplayMember = "Nombre";  // Mostrar el nombre completo en el ComboBox
            cbPersonal.ValueMember = "Cedula";    // Usar la cédula como valor
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
