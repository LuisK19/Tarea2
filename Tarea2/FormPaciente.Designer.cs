namespace Tarea2
{
    partial class FormPaciente
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
            tabPaciente = new System.Windows.Forms.TabControl();
            tabPacienteCrear = new System.Windows.Forms.TabPage();
            tabPacienteModificar = new System.Windows.Forms.TabPage();
            tabPacienteEliminar = new System.Windows.Forms.TabPage();
            tabPacienteMostrar = new System.Windows.Forms.TabPage();
            tabPaciente.SuspendLayout();
            SuspendLayout();
            // 
            // tabPaciente
            // 
            tabPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabPaciente.Controls.Add(tabPacienteCrear);
            tabPaciente.Controls.Add(tabPacienteModificar);
            tabPaciente.Controls.Add(tabPacienteEliminar);
            tabPaciente.Controls.Add(tabPacienteMostrar);
            tabPaciente.Location = new System.Drawing.Point(0, 0);
            tabPaciente.Name = "tabPaciente";
            tabPaciente.SelectedIndex = 0;
            tabPaciente.Size = new System.Drawing.Size(1080, 703);
            tabPaciente.TabIndex = 0;
            // 
            // tabPacienteCrear
            // 
            tabPacienteCrear.Location = new System.Drawing.Point(4, 29);
            tabPacienteCrear.Name = "tabPacienteCrear";
            tabPacienteCrear.Padding = new System.Windows.Forms.Padding(3);
            tabPacienteCrear.Size = new System.Drawing.Size(1072, 670);
            tabPacienteCrear.TabIndex = 0;
            tabPacienteCrear.Text = "Crear Paciente";
            tabPacienteCrear.UseVisualStyleBackColor = true;
            // 
            // tabPacienteModificar
            // 
            tabPacienteModificar.Location = new System.Drawing.Point(4, 29);
            tabPacienteModificar.Name = "tabPacienteModificar";
            tabPacienteModificar.Padding = new System.Windows.Forms.Padding(3);
            tabPacienteModificar.Size = new System.Drawing.Size(972, 620);
            tabPacienteModificar.TabIndex = 1;
            tabPacienteModificar.Text = "Modificar Paciente";
            tabPacienteModificar.UseVisualStyleBackColor = true;
            // 
            // tabPacienteEliminar
            // 
            tabPacienteEliminar.Location = new System.Drawing.Point(4, 29);
            tabPacienteEliminar.Name = "tabPacienteEliminar";
            tabPacienteEliminar.Padding = new System.Windows.Forms.Padding(3);
            tabPacienteEliminar.Size = new System.Drawing.Size(972, 620);
            tabPacienteEliminar.TabIndex = 2;
            tabPacienteEliminar.Text = "Eliminar Paciente";
            tabPacienteEliminar.UseVisualStyleBackColor = true;
            // 
            // tabPacienteMostrar
            // 
            tabPacienteMostrar.Location = new System.Drawing.Point(4, 29);
            tabPacienteMostrar.Name = "tabPacienteMostrar";
            tabPacienteMostrar.Padding = new System.Windows.Forms.Padding(3);
            tabPacienteMostrar.Size = new System.Drawing.Size(972, 620);
            tabPacienteMostrar.TabIndex = 3;
            tabPacienteMostrar.Text = "Mostrar Paciente";
            tabPacienteMostrar.UseVisualStyleBackColor = true;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1082, 703);
            Controls.Add(tabPaciente);
            Name = "FormPaciente";
            Text = "FormPaciente";
            tabPaciente.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabPaciente;
        private System.Windows.Forms.TabPage tabPacienteCrear;
        private System.Windows.Forms.TabPage tabPacienteModificar;
        private System.Windows.Forms.TabPage tabPacienteEliminar;
        private System.Windows.Forms.TabPage tabPacienteMostrar;
    }
}