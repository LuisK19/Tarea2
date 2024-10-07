using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            FormPaciente formPaciente = new FormPaciente();
            formPaciente.Show();

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            FormPersonal formPersonal = new FormPersonal();
            formPersonal.Show();
        }

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            FormMedicamento formMedicamento = new FormMedicamento();
            formMedicamento.Show();
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {
            FormCita formCita = new FormCita();
            formCita.Show();
        }

        private void BtnProcedimiento_Click(object sender, EventArgs e)
        {
            FormProcedimiento formProcedimiento = new FormProcedimiento();
            formProcedimiento.Show();
        }
    }
}
