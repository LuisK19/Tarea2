using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class FormCitaEliminar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormCitaEliminar()
        {
            InitializeComponent();
            CargarCitas(); // Cargar citas en el ComboBox al iniciar el formulario
            CargarDGV(); // Cargar el DataGridView al iniciar el formulario
        }

        private void CargarCitas()
        {
            string query = "SELECT CitaID, Cedula, CedulaMedico, MotivoConsulta FROM Cita";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Agregar citas al ComboBox
                    cbCitas.Items.Add(new { CitaID = reader["CitaID"].ToString(), Detalle = $"{reader["Cedula"]} - {reader["CedulaMedico"]} - {reader["MotivoConsulta"]}" });
                }
            }

            cbCitas.DisplayMember = "Detalle"; // Mostrar detalles de la cita en el ComboBox
            cbCitas.ValueMember = "CitaID";    // Usar CitaID como valor
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (cbCitas.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una cita a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el CitaID seleccionado
            string citaID = (cbCitas.SelectedItem as dynamic).CitaID;

            // Confirmar la eliminación
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta cita?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Eliminar registros relacionados en otras tablas antes de eliminar la cita
                    EliminarHistorialMedico(citaID);
                    EliminarProcedimientoMedico(citaID);
                    EliminarTratamiento(citaID);

                    // Eliminar la cita
                    string query = "DELETE FROM Cita WHERE CitaID = @CitaID";
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@CitaID", citaID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cita eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // Limpia los campos después de eliminar
                    CargarCitas(); // Cargar nuevamente las citas
                    CargarDGV(); // Cargar nuevamente el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para eliminar registros de HistorialMedico relacionados con la cita
        private void EliminarHistorialMedico(string citaID)
        {
            string query = "DELETE FROM HistorialMedico WHERE CitaID = @CitaID";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CitaID", citaID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar registros de ProcedimientoMedico relacionados con la cita
        private void EliminarProcedimientoMedico(string citaID)
        {
            string query = "DELETE FROM ProcedimientoMedico WHERE CitaID = @CitaID";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CitaID", citaID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar registros de Tratamiento relacionados con la cita
        private void EliminarTratamiento(string citaID)
        {
            string query = "DELETE FROM Tratamiento WHERE CitaID = @CitaID";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CitaID", citaID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
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

        // Método para limpiar los campos
        private void LimpiarCampos()
        {
            cbCitas.SelectedIndex = -1; // Limpiar selección del ComboBox
        }
    }
}
