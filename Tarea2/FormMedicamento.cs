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
    public partial class FormMedicamento : Form
    {
        public FormMedicamento()
        {
            InitializeComponent();
            tabMedicamento.SelectedIndexChanged += tabMedicamento_SelectedIndexChanged;
        }

        private void tabMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabMedicamento.SelectedTab;
            selectedTab.Controls.Clear();

            if (selectedTab.Controls.Count == 0)
            {
                if (selectedTab.Name == "tabMedicamentoCrear")
                {
                    FormMedicamentoCrear formMedicamentoCrear = new FormMedicamentoCrear
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formMedicamentoCrear);
                    formMedicamentoCrear.Show();
                }
                else if (selectedTab.Name == "tabMedicamentoModificar")
                {
                    FormMedicamentoModificar formMedicamentoModificar = new FormMedicamentoModificar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formMedicamentoModificar);
                    formMedicamentoModificar.Show();
                }
                else if (selectedTab.Name == "tabMedicamentoEliminar")
                {
                    FormMedicamentoEliminar formMedicamentoEliminar = new FormMedicamentoEliminar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formMedicamentoEliminar);
                    formMedicamentoEliminar.Show();
                }
                else if (selectedTab.Name == "tabMedicamentosMostrar")
                {
                    FormMedicamentoMostrar formMedicamentoMostrar = new FormMedicamentoMostrar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formMedicamentoMostrar);
                    formMedicamentoMostrar.Show();
                }
            }
        }
    }
}
