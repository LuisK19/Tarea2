using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class FormProcedimientoModificar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormProcedimientoModificar()
        {
            InitializeComponent();
            CargarProcedimientos();
            CargarDGVProcedimientos();
            CargarMedicosAdicionales();
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

            cbProcedimientos.DisplayMember = "ProcedimientoID";  // Mostrar detalles del procedimiento en el ComboBox
            cbProcedimientos.ValueMember = "ProcedimientoID"; // Usar ProcedimientoID como valor
        }

        private void cbProcedimientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProcedimientos.SelectedItem != null)
            {
                string procedimientoID = (cbProcedimientos.SelectedItem as dynamic).ProcedimientoID;
                CargarDatosProcedimiento(procedimientoID);
            }
        }

        private void CargarDatosProcedimiento(string procedimientoID)
        {
            string query = "SELECT * FROM Procedimiento WHERE ProcedimientoID = @ProcedimientoID";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProcedimientoID", procedimientoID);
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtDescripcion.Text = reader["Descripcion"].ToString();
                        txtDuracion.Text = reader["Duracion"].ToString();
                        txtEpicrisis.Text = reader["Epicrisis"].ToString();
                        dtpFechaProcedimiento.Value = Convert.ToDateTime(reader["FechaProcedimiento"]);
                    }
                }
            }
        }

        private void CargarMedicosAdicionales()
        {
            clbMedicosAdicionales.Items.Clear(); // Limpiar la lista antes de cargar
            string query = "SELECT Cedula, Nombre, PrimerApellido FROM PersonalMedico";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Agregar médicos adicionales al CheckedListBox
                    clbMedicosAdicionales.Items.Add(new
                    {
                        Cedula = reader["Cedula"].ToString(),
                        Nombre = $"{reader["Nombre"]} {reader["PrimerApellido"]}"
                    });
                }
            }

            clbMedicosAdicionales.DisplayMember = "Nombre";  // Mostrar el nombre del médico
            clbMedicosAdicionales.ValueMember = "Cedula";    // Usar la cédula del médico como valor
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (cbProcedimientos.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtDuracion.Text) ||
                string.IsNullOrWhiteSpace(txtEpicrisis.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar el formato de duración
            if (!TimeSpan.TryParse(txtDuracion.Text, out TimeSpan duracion))
            {
                MessageBox.Show("La duración debe tener un formato válido (ejemplo: '01:30:00').", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Modificar el procedimiento médico
            try
            {
                string query = "UPDATE Procedimiento SET Descripcion = @Descripcion, FechaProcedimiento = @FechaProcedimiento, Duracion = @Duracion, Epicrisis = @Epicrisis WHERE ProcedimientoID = @ProcedimientoID";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProcedimientoID", (cbProcedimientos.SelectedItem as dynamic).ProcedimientoID);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@FechaProcedimiento", dtpFechaProcedimiento.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Duracion", txtDuracion.Text);
                    cmd.Parameters.AddWithValue("@Epicrisis", txtEpicrisis.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                // 4. Actualizar médicos adicionales
                ActualizarMedicosAdicionales((cbProcedimientos.SelectedItem as dynamic).ProcedimientoID);

                MessageBox.Show("Procedimiento modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDGVProcedimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el procedimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarMedicosAdicionales(int procedimientoID)
        {
            // Primero, eliminar los médicos adicionales existentes
            string deleteQuery = "DELETE FROM PersonalAdicional WHERE ProcedimientoID = @ProcedimientoID";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@ProcedimientoID", procedimientoID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            // Luego, insertar los médicos adicionales seleccionados
            string insertQuery = "INSERT INTO PersonalAdicional (ProcedimientoID, CedulaMedico, Rol) VALUES (@ProcedimientoID, @CedulaMedico, @Rol)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                foreach (var item in clbMedicosAdicionales.CheckedItems)
                {
                    string cedulaMedico = (item as dynamic).Cedula;

                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@ProcedimientoID", procedimientoID);
                    cmd.Parameters.AddWithValue("@CedulaMedico", cedulaMedico);
                    cmd.Parameters.AddWithValue("@Rol", txtRolMedico.Text); // Asegúrate de tener un campo de texto para el rol

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para limpiar los campos
        private void LimpiarCampos()
        {
            cbProcedimientos.SelectedIndex = -1;
            clbMedicosAdicionales.Items.Clear();
            txtDescripcion.Clear();
            txtDuracion.Clear();
            txtEpicrisis.Clear();
            dtpFechaProcedimiento.Value = DateTime.Now;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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
    }
}
