using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class FormMedicamentoCrear : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormMedicamentoCrear()
        {
            InitializeComponent();
            CargarMedicamentos(); // Cargar medicamentos al iniciar el formulario
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDosificacion.Text) ||
                string.IsNullOrWhiteSpace(txtEfectosSecundarios.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete la información.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que no se repita el nombre del medicamento
            if (MedicamentoRepetido(txtNombre.Text))
            {
                MessageBox.Show("Ya existe un medicamento con el mismo nombre.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Intentar agregar el medicamento
            try
            {
                string query = "INSERT INTO Medicamento (Nombre, Dosificacion, EfectosSecundarios) " +
                               "VALUES (@Nombre, @Dosificacion, @EfectosSecundarios)";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Dosificacion", txtDosificacion.Text);
                    cmd.Parameters.AddWithValue("@EfectosSecundarios", txtEfectosSecundarios.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicamento agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // Limpia los campos después de agregar.
                    CargarMedicamentos(); // Refresca el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el medicamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para verificar si el medicamento ya existe
        private bool MedicamentoRepetido(string nombre)
        {
            string query = "SELECT COUNT(*) FROM Medicamento WHERE Nombre = @Nombre";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // Método para cargar los medicamentos en el DataGridView
        private void CargarMedicamentos()
        {
            string query = "SELECT MedicamentoID, Nombre, Dosificacion, EfectosSecundarios FROM Medicamento";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable medicamentos = new DataTable();
                    adapter.Fill(medicamentos);
                    dgvMedicamentos.DataSource = medicamentos;

                    // Ajustar automáticamente el tamaño de las columnas
                    dgvMedicamentos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los medicamentos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpiar los campos
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDosificacion.Clear();
            txtEfectosSecundarios.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
