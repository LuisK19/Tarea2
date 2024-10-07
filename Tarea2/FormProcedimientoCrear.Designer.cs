namespace Tarea2
{
    partial class FormProcedimientoCrear
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
            BtnLimpiar = new System.Windows.Forms.Button();
            cbCitas = new System.Windows.Forms.ComboBox();
            clbMedicosAdicionales = new System.Windows.Forms.CheckedListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            txtDuracion = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtEpicrisis = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            dtpFechaProcedimiento = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            BtnRegistrar = new System.Windows.Forms.Button();
            dgvProcedimientos = new System.Windows.Forms.DataGridView();
            txtRolMedico = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvProcedimientos).BeginInit();
            SuspendLayout();
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new System.Drawing.Point(12, 577);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new System.Drawing.Size(94, 29);
            BtnLimpiar.TabIndex = 0;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // cbCitas
            // 
            cbCitas.FormattingEnabled = true;
            cbCitas.Location = new System.Drawing.Point(12, 45);
            cbCitas.Name = "cbCitas";
            cbCitas.Size = new System.Drawing.Size(229, 28);
            cbCitas.TabIndex = 1;
            // 
            // clbMedicosAdicionales
            // 
            clbMedicosAdicionales.FormattingEnabled = true;
            clbMedicosAdicionales.Location = new System.Drawing.Point(12, 336);
            clbMedicosAdicionales.Name = "clbMedicosAdicionales";
            clbMedicosAdicionales.Size = new System.Drawing.Size(229, 158);
            clbMedicosAdicionales.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 20);
            label1.TabIndex = 3;
            label1.Text = "Id de Cita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(12, 99);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(229, 34);
            txtDescripcion.TabIndex = 5;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new System.Drawing.Point(12, 170);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new System.Drawing.Size(229, 27);
            txtDuracion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 147);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Duracion:";
            // 
            // txtEpicrisis
            // 
            txtEpicrisis.Location = new System.Drawing.Point(12, 230);
            txtEpicrisis.Name = "txtEpicrisis";
            txtEpicrisis.Size = new System.Drawing.Size(229, 27);
            txtEpicrisis.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 207);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 20);
            label4.TabIndex = 8;
            label4.Text = "Epicrisis:";
            // 
            // dtpFechaProcedimiento
            // 
            dtpFechaProcedimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFechaProcedimiento.Location = new System.Drawing.Point(12, 283);
            dtpFechaProcedimiento.Name = "dtpFechaProcedimiento";
            dtpFechaProcedimiento.Size = new System.Drawing.Size(229, 27);
            dtpFechaProcedimiento.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 260);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(172, 20);
            label5.TabIndex = 11;
            label5.Text = "Fecha de Procedimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 313);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(134, 20);
            label6.TabIndex = 12;
            label6.Text = "Personal Adicional:";
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.Location = new System.Drawing.Point(147, 577);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new System.Drawing.Size(94, 29);
            BtnRegistrar.TabIndex = 13;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = true;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // dgvProcedimientos
            // 
            dgvProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcedimientos.Location = new System.Drawing.Point(286, 22);
            dgvProcedimientos.Name = "dgvProcedimientos";
            dgvProcedimientos.RowHeadersWidth = 51;
            dgvProcedimientos.Size = new System.Drawing.Size(734, 584);
            dgvProcedimientos.TabIndex = 14;
            // 
            // txtRolMedico
            // 
            txtRolMedico.Location = new System.Drawing.Point(12, 524);
            txtRolMedico.Name = "txtRolMedico";
            txtRolMedico.Size = new System.Drawing.Size(229, 27);
            txtRolMedico.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 501);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(210, 20);
            label7.TabIndex = 15;
            label7.Text = "Rol para el Personal Adicional:";
            // 
            // FormProcedimientoCrear
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(txtRolMedico);
            Controls.Add(label7);
            Controls.Add(dgvProcedimientos);
            Controls.Add(BtnRegistrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpFechaProcedimiento);
            Controls.Add(txtEpicrisis);
            Controls.Add(label4);
            Controls.Add(txtDuracion);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clbMedicosAdicionales);
            Controls.Add(cbCitas);
            Controls.Add(BtnLimpiar);
            Name = "FormProcedimientoCrear";
            Text = "FormProcedimientoCrear";
            ((System.ComponentModel.ISupportInitialize)dgvProcedimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.ComboBox cbCitas;
        private System.Windows.Forms.CheckedListBox clbMedicosAdicionales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEpicrisis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaProcedimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.DataGridView dgvProcedimientos;
        private System.Windows.Forms.TextBox txtRolMedico;
        private System.Windows.Forms.Label label7;
    }
}