namespace Tarea2
{
    partial class FormCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabCita = new System.Windows.Forms.TabControl();
            tabCitaCrear = new System.Windows.Forms.TabPage();
            tabCitaModificar = new System.Windows.Forms.TabPage();
            tabCitaEliminar = new System.Windows.Forms.TabPage();
            tabCitaMostrar = new System.Windows.Forms.TabPage();
            tabCita.SuspendLayout();
            SuspendLayout();
            // 
            // tabCita
            // 
            tabCita.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabCita.Controls.Add(tabCitaCrear);
            tabCita.Controls.Add(tabCitaModificar);
            tabCita.Controls.Add(tabCitaEliminar);
            tabCita.Controls.Add(tabCitaMostrar);
            tabCita.Location = new System.Drawing.Point(1, 0);
            tabCita.Name = "tabCita";
            tabCita.SelectedIndex = 0;
            tabCita.ShowToolTips = true;
            tabCita.Size = new System.Drawing.Size(1080, 703);
            tabCita.TabIndex = 2;
            // 
            // tabCitaCrear
            // 
            tabCitaCrear.Location = new System.Drawing.Point(4, 29);
            tabCitaCrear.Name = "tabCitaCrear";
            tabCitaCrear.Padding = new System.Windows.Forms.Padding(3);
            tabCitaCrear.Size = new System.Drawing.Size(1072, 670);
            tabCitaCrear.TabIndex = 0;
            tabCitaCrear.Text = "Crear Cita";
            tabCitaCrear.UseVisualStyleBackColor = true;
            // 
            // tabCitaModificar
            // 
            tabCitaModificar.Location = new System.Drawing.Point(4, 29);
            tabCitaModificar.Name = "tabCitaModificar";
            tabCitaModificar.Padding = new System.Windows.Forms.Padding(3);
            tabCitaModificar.Size = new System.Drawing.Size(1072, 670);
            tabCitaModificar.TabIndex = 1;
            tabCitaModificar.Text = "Modificar Cita";
            tabCitaModificar.UseVisualStyleBackColor = true;
            // 
            // tabCitaEliminar
            // 
            tabCitaEliminar.Location = new System.Drawing.Point(4, 29);
            tabCitaEliminar.Name = "tabCitaEliminar";
            tabCitaEliminar.Padding = new System.Windows.Forms.Padding(3);
            tabCitaEliminar.Size = new System.Drawing.Size(1072, 670);
            tabCitaEliminar.TabIndex = 2;
            tabCitaEliminar.Text = "Eliminar Cita";
            tabCitaEliminar.UseVisualStyleBackColor = true;
            // 
            // tabCitaMostrar
            // 
            tabCitaMostrar.Location = new System.Drawing.Point(4, 29);
            tabCitaMostrar.Name = "tabCitaMostrar";
            tabCitaMostrar.Padding = new System.Windows.Forms.Padding(3);
            tabCitaMostrar.Size = new System.Drawing.Size(1072, 670);
            tabCitaMostrar.TabIndex = 3;
            tabCitaMostrar.Text = "Mostrar Cita";
            tabCitaMostrar.UseVisualStyleBackColor = true;
            // 
            // FormCita
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1082, 703);
            Controls.Add(tabCita);
            Name = "FormCita";
            Text = "FormCita";
            tabCita.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabCita;
        private System.Windows.Forms.TabPage tabCitaCrear;
        private System.Windows.Forms.TabPage tabCitaModificar;
        private System.Windows.Forms.TabPage tabCitaEliminar;
        private System.Windows.Forms.TabPage tabCitaMostrar;
    }
}