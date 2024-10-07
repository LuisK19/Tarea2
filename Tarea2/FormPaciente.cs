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
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
            tabPaciente.SelectedIndexChanged += tabPaciente_SelectedIndexChanged;
        }

        private void tabPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabPaciente.SelectedTab;
            selectedTab.Controls.Clear();  

            if (selectedTab.Controls.Count == 0)
            {
                if (selectedTab.Name == "tabPacienteCrear")
                {
                    FormPacienteCrear formPacienteCrear = new FormPacienteCrear
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formPacienteCrear);
                    formPacienteCrear.Show();
                }
                else if (selectedTab.Name == "tabPacienteModificar")
                {
                    FormPacienteModificar formPacienteModificar = new FormPacienteModificar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formPacienteModificar);
                    formPacienteModificar.Show();
                }
                else if (selectedTab.Name == "tabPacienteEliminar")
                {
                    FormPacienteEliminar formPacienteEliminar = new FormPacienteEliminar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formPacienteEliminar);
                    formPacienteEliminar.Show();
                }
                else if (selectedTab.Name == "tabPacienteMostrar")
                {
                    FormPacienteMostrar formPacienteMostrar = new FormPacienteMostrar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formPacienteMostrar);
                    formPacienteMostrar.Show();

                }
            }
        }
    }
}
