using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Tarea2
{
    public partial class FormPersonalModificar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormPersonalModificar()
        {
            InitializeComponent();
            CargarPersonal();
            CargarDGV();
        }

        private void CargarPersonal()
        {
            string query = "SELECT Cedula, Nombre, PrimerApellido, SegundoApellido FROM PersonalMedico";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Agregar las cédulas al ComboBox
                    cbPersonal.Items.Add(new { Cedula = reader["Cedula"].ToString(), Nombre = $"{reader["Nombre"]} {reader["PrimerApellido"]} {reader["SegundoApellido"]}" });
                }
            }

            cbPersonal.DisplayMember = "Nombre";  // Mostrar el nombre completo en el ComboBox
            cbPersonal.ValueMember = "Cedula";    // Usar la cédula como valor
        }

        private void cbPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar la información del personal seleccionado
            if (cbPersonal.SelectedItem != null)
            {
                string cedula = (cbPersonal.SelectedItem as dynamic).Cedula;
                CargarPersonal(cedula);
            }
        }

        private void CargarPersonal(string cedula)
        {
            string query = "SELECT Nombre, PrimerApellido, SegundoApellido, Especialidad, Experiencia, Telefono, Email FROM PersonalMedico WHERE Cedula = @Cedula";

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
                        txtEspecialidad.Text = reader["Especialidad"].ToString();
                        txtExperiencia.Text = reader["Experiencia"].ToString();
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
            string cedulaSeleccionada = (cbPersonal.SelectedItem as dynamic).Cedula;
            if (EmailRepetido(txtEmail.Text, cedulaSeleccionada))
            {
                MessageBox.Show("Ya existe un personal con el mismo email.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Verificar que no se repita el teléfono
            if (TelefonoRepetido(txtTelefono.Text, cedulaSeleccionada))
            {
                MessageBox.Show("Ya existe un personal con el mismo teléfono.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Intentar modificar el personal
            try
            {
                string query = "UPDATE PersonalMedico SET Nombre = @Nombre, PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, " +
                               "Especialidad = @Especialidad, Experiencia = @Experiencia, Telefono = @Telefono, Email = @Email WHERE Cedula = @Cedula";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Cedula", cedulaSeleccionada);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@PrimerApellido", txtPrimerApellido.Text);
                    cmd.Parameters.AddWithValue("@SegundoApellido", txtSegundoApellido.Text);
                    cmd.Parameters.AddWithValue("@Especialidad", txtEspecialidad.Text);
                    cmd.Parameters.AddWithValue("@Experiencia", txtExperiencia.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Personal modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPersonal();
                    CargarDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el personal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para verificar si el email ya existe
        private bool EmailRepetido(string email, string cedulaActual)
        {
            string query = "SELECT COUNT(*) FROM PersonalMedico WHERE Email = @Email AND Cedula <> @CedulaActual";

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
            string query = "SELECT COUNT(*) FROM PersonalMedico WHERE Telefono = @Telefono AND Cedula <> @CedulaActual";

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
            cbPersonal.SelectedIndex = -1; // Limpiar selección del ComboBox
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtEspecialidad.Clear();
            txtExperiencia.Clear();
        }

        // Función para verificar si el string es numérico
        private bool EsNumero(string valor)
        {
            foreach (char c in valor)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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
