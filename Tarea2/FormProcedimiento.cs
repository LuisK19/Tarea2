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
    public partial class FormProcedimiento : Form
    {
        public FormProcedimiento()
        {
            InitializeComponent();
            tabProcedimiento.SelectedIndexChanged += tabProcedimiento_SelectedIndexChanged;
        }

        private void tabProcedimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = tabProcedimiento.SelectedTab;
            selectedTab.Controls.Clear(); // Limpiar los controles actuales

            if (selectedTab.Controls.Count == 0)
            {
                if (selectedTab.Name == "tabProcedimientoCrear")
                {
                    FormProcedimientoCrear formProcedimientoCrear = new FormProcedimientoCrear
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formProcedimientoCrear);
                    formProcedimientoCrear.Show();
                }
                else if (selectedTab.Name == "tabProcedimientoModificar")
                {
                    FormProcedimientoModificar formProcedimientoModificar = new FormProcedimientoModificar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formProcedimientoModificar);
                    formProcedimientoModificar.Show();
                }
                else if (selectedTab.Name == "tabProcedimientoEliminar")
                {
                    FormProcedimientoEliminar formProcedimientoEliminar = new FormProcedimientoEliminar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formProcedimientoEliminar);
                    formProcedimientoEliminar.Show();
                }
                else if (selectedTab.Name == "tabProcedimientoMostrar")
                {
                    FormProcedimientoMostrar formProcedimientoMostrar = new FormProcedimientoMostrar
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,
                        FormBorderStyle = FormBorderStyle.None
                    };
                    selectedTab.Controls.Add(formProcedimientoMostrar);
                    formProcedimientoMostrar.Show();
                }
            }
        }
    }
}
