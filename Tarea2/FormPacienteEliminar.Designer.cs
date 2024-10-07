namespace Tarea2
{
    partial class FormPacienteEliminar
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
            cmbPacientes = new System.Windows.Forms.ComboBox();
            dgvPacientes = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // cmbPacientes
            // 
            cmbPacientes.FormattingEnabled = true;
            cmbPacientes.Location = new System.Drawing.Point(12, 47);
            cmbPacientes.Name = "cmbPacientes";
            cmbPacientes.Size = new System.Drawing.Size(222, 28);
            cmbPacientes.TabIndex = 51;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new System.Drawing.Point(268, 12);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new System.Drawing.Size(752, 594);
            dgvPacientes.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 20);
            label1.TabIndex = 37;
            label1.Text = "Cedula:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(12, 571);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(105, 35);
            btnEliminar.TabIndex = 36;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormPacienteEliminar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(cmbPacientes);
            Controls.Add(dgvPacientes);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Name = "FormPacienteEliminar";
            Text = "FormPacienteEliminar";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
    }
}