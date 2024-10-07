namespace Tarea2
{
    partial class FormPacienteCrear
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
            btnLimpiar = new System.Windows.Forms.Button();
            btnCrear = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            txtCedula = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtPrimerApellido = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtSegundoApellido = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            dgvPacientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(12, 571);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(96, 35);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new System.Drawing.Point(149, 571);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(105, 35);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Cedula:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new System.Drawing.Point(12, 410);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new System.Drawing.Size(222, 27);
            dtpFechaNacimiento.TabIndex = 3;
            // 
            // txtCedula
            // 
            txtCedula.Location = new System.Drawing.Point(12, 41);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new System.Drawing.Size(222, 27);
            txtCedula.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(12, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(222, 27);
            txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre:";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new System.Drawing.Point(12, 163);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new System.Drawing.Size(222, 27);
            txtPrimerApellido.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 140);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(114, 20);
            label3.TabIndex = 7;
            label3.Text = "Primer apellido:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new System.Drawing.Point(12, 223);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new System.Drawing.Size(222, 27);
            txtSegundoApellido.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 200);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(130, 20);
            label4.TabIndex = 9;
            label4.Text = "Segundo apellido:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(12, 282);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(222, 27);
            txtTelefono.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 259);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 20);
            label5.TabIndex = 11;
            label5.Text = "Telefono:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(12, 347);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(222, 27);
            txtEmail.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 324);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(49, 20);
            label6.TabIndex = 13;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 387);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(149, 20);
            label7.TabIndex = 15;
            label7.Text = "Fecha de nacimiento:";
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new System.Drawing.Point(260, 12);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new System.Drawing.Size(752, 594);
            dgvPacientes.TabIndex = 16;
            // 
            // FormPacienteCrear
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
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
            Controls.Add(txtCedula);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label1);
            Controls.Add(btnCrear);
            Controls.Add(btnLimpiar);
            Name = "FormPacienteCrear";
            Text = "FormPacienteCrear";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPacientes;
    }
}