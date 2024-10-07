using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class FormPacienteCrear : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormPacienteCrear()
        {
            InitializeComponent();
            CargarPacientes();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete la información.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que la cédula sea numérica y tenga exactamente 9 dígitos
            if (!EsNumero(txtCedula.Text) || txtCedula.Text.Length != 9)
            {
                MessageBox.Show("La cédula debe tener 9 dígitos numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validar que el teléfono sea numérico y tenga exactamente 8 dígitos
            if (!EsNumero(txtTelefono.Text) || txtTelefono.Text.Length != 8)
            {
                MessageBox.Show("El número de teléfono debe tener 8 dígitos numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Validar que la cédula, teléfono o email no se repitan en la base de datos
            if (ExistePaciente(txtCedula.Text, txtTelefono.Text, txtEmail.Text))
            {
                MessageBox.Show("Ya existe un paciente con la misma cédula, teléfono o email.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Intentar agregar el paciente
            try
            {
                string query = "INSERT INTO Paciente (Cedula, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Telefono, Email) " +
                               "VALUES (@Cedula, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Telefono, @Email)";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@PrimerApellido", txtPrimerApellido.Text);
                    cmd.Parameters.AddWithValue("@SegundoApellido", txtSegundoApellido.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paciente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPacientes();  // Refrescar el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para verificar si la cédula, teléfono o email ya existen
        private bool ExistePaciente(string cedula, string telefono, string email)
        {
            string query = "SELECT COUNT(*) FROM Paciente WHERE Cedula = @Cedula OR Telefono = @Telefono OR Email = @Email";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cedula", cedula);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // Método para limpiar los campos
        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        // Método para cargar los pacientes en el DataGridView
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


        // Función para verificar si el string es numérico
        private bool EsNumero(string valor)
        {
            foreach (char c in valor)
            {
                if (!char.IsDigit(c))
                {
                    return false;  // No es numérico
                }
            }
            return true;  // Es numérico
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
