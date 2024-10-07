using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace Tarea2
{
    public partial class FormPacienteEliminar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormPacienteEliminar()
        {
            InitializeComponent();
            CargarPacientes();
            CargarDGV();
        }

        private void CargarPacientes()
        {
            string query = "SELECT Cedula, Nombre, PrimerApellido, SegundoApellido FROM Paciente";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Agregar las cédulas al ComboBox
                    cmbPacientes.Items.Add(new { Cedula = reader["Cedula"].ToString(), Nombre = $"{reader["Nombre"]} {reader["PrimerApellido"]} {reader["SegundoApellido"]}" });
                }
            }

            cmbPacientes.DisplayMember = "Nombre";  // Mostrar el nombre completo en el ComboBox
            cmbPacientes.ValueMember = "Cedula";    // Usar la cédula como valor
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un paciente
            if (cmbPacientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un paciente a eliminar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cedulaSeleccionada = (cmbPacientes.SelectedItem as dynamic).Cedula;

            // Confirmar la eliminación
            DialogResult dialogResult = MessageBox.Show($"¿Está seguro de que desea eliminar al paciente con cédula {cedulaSeleccionada}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        // Eliminar el paciente de la base de datos
                        string query = "DELETE FROM Paciente WHERE Cedula = @Cedula";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Cedula", cedulaSeleccionada);
                        cmd.ExecuteNonQuery();

                        // Eliminar los historiales médicos del paciente
                        string queryHistorial = "DELETE FROM HistorialMedico WHERE Cedula = @Cedula";
                        MySqlCommand cmdHistorial = new MySqlCommand(queryHistorial, conn);
                        cmdHistorial.Parameters.AddWithValue("@Cedula", cedulaSeleccionada);
                        cmdHistorial.ExecuteNonQuery();

                        // Eliminar las citas del paciente
                        string queryCitas = "DELETE FROM Cita WHERE Cedula = @Cedula";
                        MySqlCommand cmdCitas = new MySqlCommand(queryCitas, conn);
                        cmdCitas.Parameters.AddWithValue("@Cedula", cedulaSeleccionada);
                        cmdCitas.ExecuteNonQuery();

                        // Eliminar los padecimientos del paciente
                        string queryPadecimientos = "DELETE FROM Padecimiento WHERE Cedula = @Cedula";
                        MySqlCommand cmdPadecimientos = new MySqlCommand(queryPadecimientos, conn);
                        cmdPadecimientos.Parameters.AddWithValue("@Cedula", cedulaSeleccionada);
                        cmdPadecimientos.ExecuteNonQuery();

                        // Confirmar la eliminación
                        MessageBox.Show("Paciente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarPacientes(); // Refrescar el ComboBox
                        CargarDGV(); // Refrescar el DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            cmbPacientes.SelectedIndex = -1; // Limpiar selección del ComboBox
        }

        // Método para cargar los pacientes en el DataGridView
        private void CargarDGV()
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
