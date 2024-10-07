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
    public partial class FormCita : Form
    {
        public FormCita()
        {
            InitializeComponent();
            tabCita.SelectedIndexChanged += tabCita_SelectedIndexChanged;
        }

        private void tabCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabCita.SelectedTab;
            selectedTab.Controls.Clear();

            if (selectedTab.Controls.Count == 0)
            {
                if (selectedTab.Name == "tabCitaCrear")
                {
                    FormCitaCrear formCitaCrear = new FormCitaCrear
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formCitaCrear);
                    formCitaCrear.Show();
                }
                else if (selectedTab.Name == "tabCitaModificar")
                {
                    FormCitaModificar formCitaModificar = new FormCitaModificar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formCitaModificar);
                    formCitaModificar.Show();
                }
                else if (selectedTab.Name == "tabCitaEliminar")
                {
                    FormCitaEliminar formCitaEliminar = new FormCitaEliminar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formCitaEliminar);
                    formCitaEliminar.Show();
                }
                else if (selectedTab.Name == "tabCitaMostrar")
                {
                    FormCitaMostrar formCitaMostrar = new FormCitaMostrar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formCitaMostrar);
                    formCitaMostrar.Show();
                }
            }
        }
    }
}
