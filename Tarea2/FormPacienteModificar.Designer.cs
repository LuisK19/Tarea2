namespace Tarea2
{
    partial class FormPacienteModificar
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
            dgvPacientes = new System.Windows.Forms.DataGridView();
            label7 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtSegundoApellido = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtPrimerApellido = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            btnModificar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            cmbPacientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
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
            dgvPacientes.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 387);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(149, 20);
            label7.TabIndex = 32;
            label7.Text = "Fecha de nacimiento:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(12, 347);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(222, 27);
            txtEmail.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 324);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(49, 20);
            label6.TabIndex = 30;
            label6.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(12, 282);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(222, 27);
            txtTelefono.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 259);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 20);
            label5.TabIndex = 28;
            label5.Text = "Telefono:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new System.Drawing.Point(12, 223);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new System.Drawing.Size(222, 27);
            txtSegundoApellido.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 200);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(130, 20);
            label4.TabIndex = 26;
            label4.Text = "Segundo apellido:";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new System.Drawing.Point(12, 163);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new System.Drawing.Size(222, 27);
            txtPrimerApellido.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 140);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(114, 20);
            label3.TabIndex = 24;
            label3.Text = "Primer apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(12, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(222, 27);
            txtNombre.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 20);
            label2.TabIndex = 22;
            label2.Text = "Nombre:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new System.Drawing.Point(12, 410);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new System.Drawing.Size(222, 27);
            dtpFechaNacimiento.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 20);
            label1.TabIndex = 19;
            label1.Text = "Cedula:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new System.Drawing.Point(148, 555);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(105, 51);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "Guardar Cambios";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(12, 555);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(103, 47);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbPacientes
            // 
            cmbPacientes.FormattingEnabled = true;
            cmbPacientes.Location = new System.Drawing.Point(12, 47);
            cmbPacientes.Name = "cmbPacientes";
            cmbPacientes.Size = new System.Drawing.Size(222, 28);
            cmbPacientes.TabIndex = 34;
            // 
            // FormPacienteModificar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(cmbPacientes);
            Controls.Add(dgvPacientes);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtSegundoApellido);
            Controls.Add(label4);
            Controls.Add(txtPrimerApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Controls.Add(btnLimpiar);
            Name = "FormPacienteModificar";
            Text = "FormPacienteModificar";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbPacientes;
    }
}