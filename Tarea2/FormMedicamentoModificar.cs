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
    public partial class FormMedicamentoModificar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormMedicamentoModificar()
        {
            InitializeComponent();
            CargarMedicamentos();
            CargarDGV(); // Cargar el DataGridView al iniciar el formulario
        }

        private void CargarMedicamentos()
        {
            string query = "SELECT MedicamentoID, Nombre FROM Medicamento";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Agregar los nombres de medicamentos al ComboBox
                    cbMedicamentos.Items.Add(new { MedicamentoID = reader["MedicamentoID"].ToString(), Nombre = reader["Nombre"].ToString() });
                }
            }

            cbMedicamentos.DisplayMember = "Nombre";  // Mostrar el nombre en el ComboBox
            cbMedicamentos.ValueMember = "MedicamentoID"; // Usar MedicamentoID como valor
        }

        private void cbMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar la información del medicamento seleccionado
            if (cbMedicamentos.SelectedItem != null)
            {
                string medicamentoID = (cbMedicamentos.SelectedItem as dynamic).MedicamentoID;
                CargarMedicamento(medicamentoID);
            }
        }

        private void CargarMedicamento(string medicamentoID)
        {
            string query = "SELECT Nombre, Dosificacion, EfectosSecundarios FROM Medicamento WHERE MedicamentoID = @MedicamentoID";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MedicamentoID", medicamentoID);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtNombre.Text = reader["Nombre"].ToString();
                        txtDosificacion.Text = reader["Dosificacion"].ToString();
                        txtEfectosSecundarios.Text = reader["EfectosSecundarios"].ToString();
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDosificacion.Text) ||
                string.IsNullOrWhiteSpace(txtEfectosSecundarios.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete la información.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Verificar que no se repita el nombre del medicamento
            if (MedicamentoRepetido(txtNombre.Text))
            {
                MessageBox.Show("Ya existe un medicamento con el mismo nombre.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Intentar modificar el medicamento
            try
            {
                string query = "UPDATE Medicamento SET Nombre = @Nombre, Dosificacion = @Dosificacion, EfectosSecundarios = @EfectosSecundarios " +
                               "WHERE MedicamentoID = @MedicamentoID";

                string medicamentoID = (cbMedicamentos.SelectedItem as dynamic).MedicamentoID; // La MedicamentoID seleccionada en el ComboBox

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MedicamentoID", medicamentoID);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Dosificacion", txtDosificacion.Text);
                    cmd.Parameters.AddWithValue("@EfectosSecundarios", txtEfectosSecundarios.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicamento modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarMedicamentos(); // Refresca el ComboBox
                    CargarDGV(); // Refresca el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el medicamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void CargarDGV()
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
            cbMedicamentos.SelectedIndex = -1; // Limpiar selección del ComboBox
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
