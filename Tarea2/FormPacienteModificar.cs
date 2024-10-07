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
    public partial class FormPacienteModificar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormPacienteModificar()
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

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar la información del paciente seleccionado
            if (cmbPacientes.SelectedItem != null)
            {
                string cedula = (cmbPacientes.SelectedItem as dynamic).Cedula;
                CargarPaciente(cedula);
            }
        }

        private void CargarPaciente(string cedula)
        {
            string query = "SELECT Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Telefono, Email FROM Paciente WHERE Cedula = @Cedula";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cedula", cedula);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtPrimerApellido.Text = reader["PrimerApellido"].ToString();
                        txtSegundoApellido.Text = reader["SegundoApellido"].ToString();
                        dtpFechaNacimiento.Value = Convert.ToDateTime(reader["FechaNacimiento"]);
                        txtTelefono.Text = reader["Telefono"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete la información.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que el teléfono sea numérico y tenga exactamente 8 dígitos
            if (!EsNumero(txtTelefono.Text) || txtTelefono.Text.Length != 8)
            {
                MessageBox.Show("El número de teléfono debe tener 8 dígitos numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Verificar que no se repita el email
            string cedulaSeleccionada = (cmbPacientes.SelectedItem as dynamic).Cedula;
            if (EmailRepetido(txtEmail.Text, cedulaSeleccionada))
            {
                MessageBox.Show("Ya existe un paciente con el mismo email.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Verificar que no se repita el teléfono
            if (TelefonoRepetido(txtTelefono.Text, cedulaSeleccionada))
            {
                MessageBox.Show("Ya existe un paciente con el mismo teléfono.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Intentar modificar el paciente
            try
            {
                string query = "UPDATE Paciente SET Nombre = @Nombre, PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, " +
                               "FechaNacimiento = @FechaNacimiento, Telefono = @Telefono, Email = @Email WHERE Cedula = @Cedula";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Cedula", cedulaSeleccionada); // La cédula seleccionada en el ComboBox
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@PrimerApellido", txtPrimerApellido.Text);
                    cmd.Parameters.AddWithValue("@SegundoApellido", txtSegundoApellido.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paciente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPacientes(); // Refrescar el ComboBox
                    CargarDGV(); // Refrescar el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para verificar si el email ya existe
        private bool EmailRepetido(string email, string cedulaActual)
        {
            string query = "SELECT COUNT(*) FROM Paciente WHERE Email = @Email AND Cedula <> @CedulaActual";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@CedulaActual", cedulaActual);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // Método para verificar si el teléfono ya existe
        private bool TelefonoRepetido(string telefono, string cedulaActual)
        {
            string query = "SELECT COUNT(*) FROM Paciente WHERE Telefono = @Telefono AND Cedula <> @CedulaActual";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@CedulaActual", cedulaActual);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // Método para limpiar los campos
        private void LimpiarCampos()
        {
            cmbPacientes.SelectedIndex = -1; // Limpiar selección del ComboBox
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
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
