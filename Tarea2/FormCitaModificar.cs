using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class FormCitaModificar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormCitaModificar()
        {
            InitializeComponent();
            CargarPacientes();
            CargarMedicos();
            CargarCitas(); // Cargar citas en el ComboBox
            CargarDGV(); // Cargar el DataGridView al iniciar el formulario
        }

        private void CargarPacientes()
        {
            string query = "SELECT Cedula, Nombre, PrimerApellido FROM Paciente";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Agregar pacientes al ComboBox
                    cbPacientes.Items.Add(new { Cedula = reader["Cedula"].ToString(), Nombre = $"{reader["Nombre"]} {reader["PrimerApellido"]}" });
                }
            }

            cbPacientes.DisplayMember = "Nombre";  // Mostrar el nombre en el ComboBox
            cbPacientes.ValueMember = "Cedula";    // Usar Cedula como valor
        }

        private void CargarMedicos()
        {
            string query = "SELECT Cedula, Nombre, PrimerApellido FROM PersonalMedico";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Agregar médicos al ComboBox
                    cbMedicos.Items.Add(new { Cedula = reader["Cedula"].ToString(), Nombre = $"{reader["Nombre"]} {reader["PrimerApellido"]}" });
                }
            }

            cbMedicos.DisplayMember = "Nombre";  // Mostrar el nombre en el ComboBox
            cbMedicos.ValueMember = "Cedula";    // Usar Cedula como valor
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

        private void cbCitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar la información de la cita seleccionada
            if (cbCitas.SelectedItem != null)
            {
                string citaID = (cbCitas.SelectedItem as dynamic).CitaID;
                CargarCita(citaID);
            }
        }

        private void CargarCita(string citaID)
        {
            string query = "SELECT Cedula, CedulaMedico, MotivoConsulta, Duracion, Resultados, FechaHora, Epicrisis, PersonalAdicional FROM Cita WHERE CitaID = @CitaID";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CitaID", citaID);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cbPacientes.SelectedValue = reader["Cedula"].ToString();
                        cbMedicos.SelectedValue = reader["CedulaMedico"].ToString();
                        txtMotivoConsulta.Text = reader["MotivoConsulta"].ToString();
                        txtDuracion.Text = reader["Duracion"].ToString();
                        txtResultados.Text = reader["Resultados"].ToString();
                        txtEpicrisis.Text = reader["Epicrisis"].ToString();
                        txtPersonalAdicional.Text = reader["PersonalAdicional"].ToString();
                        dtpFechaHora.Value = Convert.ToDateTime(reader["FechaHora"]);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (cbPacientes.SelectedItem == null ||
                cbMedicos.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtMotivoConsulta.Text) ||
                string.IsNullOrWhiteSpace(txtDuracion.Text) ||
                string.IsNullOrWhiteSpace(txtResultados.Text) ||
                string.IsNullOrWhiteSpace(txtEpicrisis.Text) ||
                string.IsNullOrWhiteSpace(txtPersonalAdicional.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar el formato de duración
            if (!TimeSpan.TryParse(txtDuracion.Text, out TimeSpan duration) || duration.TotalMinutes <= 0)
            {
                MessageBox.Show("La duración debe tener un formato válido (ej. '00:30:00' para 30 minutos).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Intentar modificar la cita
            try
            {
                int citaID = Convert.ToInt32((cbCitas.SelectedItem as dynamic).CitaID); // Obtener CitaID

                string query = "UPDATE Cita SET Cedula = @Cedula, CedulaMedico = @CedulaMedico, MotivoConsulta = @MotivoConsulta, " +
                               "Duracion = @Duracion, Resultados = @Resultados, FechaHora = @FechaHora, Epicrisis = @Epicrisis, " +
                               "PersonalAdicional = @PersonalAdicional WHERE CitaID = @CitaID";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CitaID", citaID);
                    cmd.Parameters.AddWithValue("@Cedula", (cbPacientes.SelectedItem as dynamic).Cedula);
                    cmd.Parameters.AddWithValue("@CedulaMedico", (cbMedicos.SelectedItem as dynamic).Cedula);
                    cmd.Parameters.AddWithValue("@MotivoConsulta", txtMotivoConsulta.Text);
                    cmd.Parameters.AddWithValue("@Duracion", txtDuracion.Text);
                    cmd.Parameters.AddWithValue("@Resultados", txtResultados.Text);
                    cmd.Parameters.AddWithValue("@FechaHora", dtpFechaHora.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Epicrisis", txtEpicrisis.Text);
                    cmd.Parameters.AddWithValue("@PersonalAdicional", txtPersonalAdicional.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cita modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // Limpia los campos después de modificar
                    CargarCitas(); // Cargar nuevamente el ComboBox
                    CargarDGV(); // Cargar nuevamente el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            cbPacientes.SelectedIndex = -1; // Limpiar selección del ComboBox
            cbMedicos.SelectedIndex = -1; // Limpiar selección del ComboBox
            txtMotivoConsulta.Clear();
            txtDuracion.Clear();
            txtResultados.Clear();
            txtEpicrisis.Clear();
            txtPersonalAdicional.Clear();
            dtpFechaHora.Value = DateTime.Now; // Establecer la fecha y hora actual
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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
