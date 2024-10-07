namespace Tarea2
{
    partial class FormPersonalCrear
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
            dgvPersonal = new System.Windows.Forms.DataGridView();
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
            txtCedula = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnCrear = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            txtEspecialidad = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtExperiencia = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonal
            // 
            dgvPersonal.AllowUserToAddRows = false;
            dgvPersonal.AllowUserToDeleteRows = false;
            dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonal.Location = new System.Drawing.Point(264, 12);
            dgvPersonal.Name = "dgvPersonal";
            dgvPersonal.ReadOnly = true;
            dgvPersonal.RowHeadersWidth = 51;
            dgvPersonal.Size = new System.Drawing.Size(752, 594);
            dgvPersonal.TabIndex = 33;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(16, 347);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(222, 27);
            txtEmail.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(16, 324);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(49, 20);
            label6.TabIndex = 30;
            label6.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(16, 282);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(222, 27);
            txtTelefono.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(16, 259);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 20);
            label5.TabIndex = 28;
            label5.Text = "Telefono:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new System.Drawing.Point(16, 223);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new System.Drawing.Size(222, 27);
            txtSegundoApellido.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(16, 200);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(130, 20);
            label4.TabIndex = 26;
            label4.Text = "Segundo apellido:";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new System.Drawing.Point(16, 163);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new System.Drawing.Size(222, 27);
            txtPrimerApellido.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 140);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(114, 20);
            label3.TabIndex = 24;
            label3.Text = "Primer apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(16, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(222, 27);
            txtNombre.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 20);
            label2.TabIndex = 22;
            label2.Text = "Nombre:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new System.Drawing.Point(16, 41);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new System.Drawing.Size(222, 27);
            txtCedula.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 20);
            label1.TabIndex = 19;
            label1.Text = "Cedula:";
            // 
            // btnCrear
            // 
            btnCrear.Location = new System.Drawing.Point(153, 571);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(105, 35);
            btnCrear.TabIndex = 18;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(16, 571);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(96, 35);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new System.Drawing.Point(16, 406);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new System.Drawing.Size(222, 27);
            txtEspecialidad.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(16, 383);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(96, 20);
            label7.TabIndex = 34;
            label7.Text = "Especialidad:";
            // 
            // txtExperiencia
            // 
            txtExperiencia.Location = new System.Drawing.Point(16, 464);
            txtExperiencia.Name = "txtExperiencia";
            txtExperiencia.Size = new System.Drawing.Size(222, 27);
            txtExperiencia.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(16, 441);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(88, 20);
            label8.TabIndex = 36;
            label8.Text = "Experiencia:";
            // 
            // FormPersonalCrear
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(txtExperiencia);
            Controls.Add(label8);
            Controls.Add(txtEspecialidad);
            Controls.Add(label7);
            Controls.Add(dgvPersonal);
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
            Controls.Add(label1);
            Controls.Add(btnCrear);
            Controls.Add(btnLimpiar);
            Name = "FormPersonalCrear";
            Text = "FormPersonalCrear";
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonal;
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
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExperiencia;
        private System.Windows.Forms.Label label8;
    }
}