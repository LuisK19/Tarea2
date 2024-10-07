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
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
            tabPersonal.SelectedIndexChanged += tabPersonal_SelectedIndexChanged;
        }

        private void tabPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabPersonal.SelectedTab;
            selectedTab.Controls.Clear();

            if (selectedTab.Controls.Count == 0)
            {
                if (selectedTab.Name == "tabPersonalCrear")
                {
                    FormPersonalCrear formPersonalCrear = new FormPersonalCrear
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formPersonalCrear);
                    formPersonalCrear.Show();
                }
                else if (selectedTab.Name == "tabPersonalModificar")
                {
                    FormPersonalModificar formPersonalModificar = new FormPersonalModificar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formPersonalModificar);
                    formPersonalModificar.Show();
                }
                else if (selectedTab.Name == "tabPersonalEliminar")
                {
                    FormPersonalEliminar formPersonalEliminar = new FormPersonalEliminar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formPersonalEliminar);
                    formPersonalEliminar.Show();
                }
                else if (selectedTab.Name == "tabPersonalMostrar")
                {
                    FormPersonalMostrar formPersonalMostrar = new FormPersonalMostrar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formPersonalMostrar);
                    formPersonalMostrar.Show();
                }
            }
        }
    }
}
