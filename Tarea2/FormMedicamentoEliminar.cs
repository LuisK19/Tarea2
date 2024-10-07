using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class FormMedicamentoEliminar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormMedicamentoEliminar()
        {
            InitializeComponent();
            CargarMedicamentos();
            CargarDGV(); // Cargar el DataGridView al iniciar el formulario
        }

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbMedicamentos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un medicamento para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string medicamentoID = (cbMedicamentos.SelectedItem as dynamic).MedicamentoID;

            // Confirmar la eliminación
            var result = MessageBox.Show("¿Está seguro de que desea eliminar este medicamento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Eliminar el medicamento de la base de datos
                    EliminarMedicamento(medicamentoID);

                    // Cargar el DataGridView nuevamente
                    CargarDGV();

                    // Limpiar la selección del ComboBox
                    cbMedicamentos.SelectedIndex = -1;
                    MessageBox.Show("Medicamento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el medicamento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EliminarMedicamento(string medicamentoID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Eliminar las relaciones en TratamientoMedicamento
                string deleteTratamientoQuery = "DELETE FROM TratamientoMedicamento WHERE MedicamentoID = @MedicamentoID";
                using (MySqlCommand cmd = new MySqlCommand(deleteTratamientoQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicamentoID", medicamentoID);
                    cmd.ExecuteNonQuery();
                }

                // Eliminar el medicamento de la tabla Medicamento
                string deleteMedicamentoQuery = "DELETE FROM Medicamento WHERE MedicamentoID = @MedicamentoID";
                using (MySqlCommand cmd = new MySqlCommand(deleteMedicamentoQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicamentoID", medicamentoID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
