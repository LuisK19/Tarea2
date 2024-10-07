using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class FormProcedimientoCrear : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ClinicaPrivadaDB"].ConnectionString;

        public FormProcedimientoCrear()
        {
            InitializeComponent();
            CargarCitas();
            CargarDGVProcedimientos();
            CargarMedicosAdicionales();
        }

        private void CargarCitas()
        {
            string query = "SELECT CitaID, Cedula, MotivoConsulta, CedulaMedico FROM Cita";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Agregar las citas al ComboBox
                    cbCitas.Items.Add(new { CitaID = reader["CitaID"].ToString(), Detalle = $"{reader["Cedula"]} - {reader["MotivoConsulta"]}", CedulaMedico = reader["CedulaMedico"].ToString() });
                }
            }

            cbCitas.DisplayMember = "CitaID";  // Mostrar detalles de la cita en el ComboBox
            cbCitas.ValueMember = "CitaID";     // Usar CitaID como valor
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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (cbCitas.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtDuracion.Text) ||
                string.IsNullOrWhiteSpace(txtEpicrisis.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que los médicos adicionales no incluyan al médico principal
            string cedulaMedicoPrincipal = (cbCitas.SelectedItem as dynamic).CedulaMedico;
            foreach (var item in clbMedicosAdicionales.CheckedItems)
            {
                string cedulaMedicoAdicional = (item as dynamic).Cedula;
                if (cedulaMedicoAdicional == cedulaMedicoPrincipal)
                {
                    MessageBox.Show("No se puede incluir al médico principal como médico adicional.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // 3. Validar el formato de duración
            if (!TimeSpan.TryParse(txtDuracion.Text, out TimeSpan duracion))
            {
                MessageBox.Show("La duración debe tener un formato válido (ejemplo: '01:30:00').", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Registrar el procedimiento médico
            try
            {
                string query = "INSERT INTO Procedimiento (CitaID, Descripcion, FechaProcedimiento, Duracion, Epicrisis) " +
                               "VALUES (@CitaID, @Descripcion, @FechaProcedimiento, @Duracion, @Epicrisis)";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CitaID", (cbCitas.SelectedItem as dynamic).CitaID);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@FechaProcedimiento", dtpFechaProcedimiento.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Duracion", txtDuracion.Text);
                    cmd.Parameters.AddWithValue("@Epicrisis", txtEpicrisis.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                // Obtener el ProcedimientoID recién insertado
                int procedimientoID = ObtenerUltimoProcedimientoID();

                // Si se seleccionaron médicos adicionales, registrarlos
                RegistrarMedicosAdicionales(procedimientoID);

                MessageBox.Show("Procedimiento registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarCitas();
                CargarDGVProcedimientos();
                CargarMedicosAdicionales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el procedimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int ObtenerUltimoProcedimientoID()
        {
            int procedimientoID = 0;
            string query = "SELECT MAX(ProcedimientoID) FROM Procedimiento";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                procedimientoID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return procedimientoID;
        }

        private void RegistrarMedicosAdicionales(int procedimientoID)
        {
            string query = "INSERT INTO PersonalAdicional (ProcedimientoID, CedulaMedico, Rol) VALUES (@ProcedimientoID, @CedulaMedico, @Rol)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                foreach (var item in clbMedicosAdicionales.CheckedItems)
                {
                    string cedulaMedico = (item as dynamic).Cedula;

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProcedimientoID", procedimientoID);
                    cmd.Parameters.AddWithValue("@CedulaMedico", cedulaMedico);
                    cmd.Parameters.AddWithValue("@Rol", txtRolMedico.Text); 

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para limpiar los campos
        private void LimpiarCampos()
        {
            cbCitas.SelectedIndex = -1;
            clbMedicosAdicionales.Items.Clear();
            txtDescripcion.Clear();
            txtDuracion.Clear();
            txtEpicrisis.Clear();
            txtRolMedico.Clear();
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
