using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class FormProcedimientoEliminar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormProcedimientoEliminar()
        {
            InitializeComponent();
            CargarProcedimientos();
            CargarDGVProcedimientos();
        }

        private void CargarProcedimientos()
        {
            string query = "SELECT P.ProcedimientoID, C.CitaID, C.Cedula, C.CedulaMedico, P.Descripcion FROM Procedimiento P INNER JOIN Cita C ON P.CitaID = C.CitaID";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Agregar los procedimientos al ComboBox
                    cbProcedimientos.Items.Add(new
                    {
                        ProcedimientoID = reader["ProcedimientoID"].ToString(),
                        Detalle = $"{reader["Cedula"]} - {reader["Descripcion"]}",
                        CedulaMedico = reader["CedulaMedico"].ToString(),
                        CitaID = reader["CitaID"].ToString()
                    });
                }
            }

            cbProcedimientos.DisplayMember = "Detalle";  // Mostrar detalles del procedimiento en el ComboBox
            cbProcedimientos.ValueMember = "ProcedimientoID"; // Usar ProcedimientoID como valor
        }

        private void CargarDGVProcedimientos()
        {
            string query = @"SELECT P.ProcedimientoID, C.CitaID, C.Cedula, C.CedulaMedico, P.Descripcion, 
                             P.FechaProcedimiento, P.Duracion, P.Epicrisis 
                             FROM Procedimiento P
                             INNER JOIN Cita C ON P.CitaID = C.CitaID";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable procedimientos = new DataTable();
                    adapter.Fill(procedimientos);
                    dgvProcedimientos.DataSource = procedimientos;

                    // Ajustar el tamaño de las columnas
                    dgvProcedimientos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los procedimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (cbProcedimientos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un procedimiento a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ProcedimientoID seleccionado
            string procedimientoID = (cbProcedimientos.SelectedItem as dynamic).ProcedimientoID;

            // Confirmar la eliminación
            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este procedimiento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Eliminar registros relacionados en otras tablas
                    EliminarMedicosAdicionales(procedimientoID);
                    EliminarResultados(procedimientoID);

                    // Eliminar el procedimiento
                    string query = "DELETE FROM Procedimiento WHERE ProcedimientoID = @ProcedimientoID";
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ProcedimientoID", procedimientoID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Procedimiento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // Limpia los campos después de eliminar
                    CargarProcedimientos(); // Cargar nuevamente los procedimientos
                    CargarDGVProcedimientos(); // Cargar nuevamente el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el procedimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para eliminar registros de PersonalAdicional relacionados con el procedimiento
        private void EliminarMedicosAdicionales(string procedimientoID)
        {
            string query = "DELETE FROM PersonalAdicional WHERE ProcedimientoID = @ProcedimientoID";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProcedimientoID", procedimientoID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar registros de ResultadoProcedimiento relacionados con el procedimiento
        private void EliminarResultados(string procedimientoID)
        {
            string query = "DELETE FROM ResultadoProcedimiento WHERE ProcedimientoID = @ProcedimientoID";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProcedimientoID", procedimientoID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para limpiar los campos
        private void LimpiarCampos()
        {
            cbProcedimientos.SelectedIndex = -1; // Limpiar selección del ComboBox
        }
    }
}
