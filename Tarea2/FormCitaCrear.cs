using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class FormCitaCrear : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormCitaCrear()
        {
            InitializeComponent();
            CargarPacientes();
            CargarMedicos();
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

        private void BtnRegistar_Click(object sender, EventArgs e)
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

            // 3. Intentar registrar la cita
            try
            {
                string query = "INSERT INTO Cita (Cedula, CedulaMedico, MotivoConsulta, Duracion, Resultados, FechaHora, Epicrisis, PersonalAdicional) " +
                               "VALUES (@Cedula, @CedulaMedico, @MotivoConsulta, @Duracion, @Resultados, @FechaHora, @Epicrisis, @PersonalAdicional)";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
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
                    MessageBox.Show("Cita registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // Limpia los campos después de registrar
                    CargarDGV(); // Cargar nuevamente el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
