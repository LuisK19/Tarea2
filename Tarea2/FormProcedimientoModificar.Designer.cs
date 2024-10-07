namespace Tarea2
{
    partial class FormProcedimientoModificar
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
            txtRolMedico = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            dgvProcedimientos = new System.Windows.Forms.DataGridView();
            BtnGuardar = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            dtpFechaProcedimiento = new System.Windows.Forms.DateTimePicker();
            txtEpicrisis = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtDuracion = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            clbMedicosAdicionales = new System.Windows.Forms.CheckedListBox();
            cbCitas = new System.Windows.Forms.ComboBox();
            BtnLimpiar = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            cbProcedimientos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProcedimientos).BeginInit();
            SuspendLayout();
            // 
            // txtRolMedico
            // 
            txtRolMedico.Location = new System.Drawing.Point(12, 531);
            txtRolMedico.Name = "txtRolMedico";
            txtRolMedico.Size = new System.Drawing.Size(229, 27);
            txtRolMedico.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 508);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(210, 20);
            label7.TabIndex = 32;
            label7.Text = "Rol para el Personal Adicional:";
            // 
            // dgvProcedimientos
            // 
            dgvProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcedimientos.Location = new System.Drawing.Point(286, 17);
            dgvProcedimientos.Name = "dgvProcedimientos";
            dgvProcedimientos.RowHeadersWidth = 51;
            dgvProcedimientos.Size = new System.Drawing.Size(734, 584);
            dgvProcedimientos.TabIndex = 31;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new System.Drawing.Point(147, 572);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new System.Drawing.Size(94, 29);
            BtnGuardar.TabIndex = 30;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 362);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(134, 20);
            label6.TabIndex = 29;
            label6.Text = "Personal Adicional:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 309);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(172, 20);
            label5.TabIndex = 28;
            label5.Text = "Fecha de Procedimiento:";
            // 
            // dtpFechaProcedimiento
            // 
            dtpFechaProcedimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFechaProcedimiento.Location = new System.Drawing.Point(12, 332);
            dtpFechaProcedimiento.Name = "dtpFechaProcedimiento";
            dtpFechaProcedimiento.Size = new System.Drawing.Size(229, 27);
            dtpFechaProcedimiento.TabIndex = 27;
            // 
            // txtEpicrisis
            // 
            txtEpicrisis.Location = new System.Drawing.Point(12, 279);
            txtEpicrisis.Name = "txtEpicrisis";
            txtEpicrisis.Size = new System.Drawing.Size(229, 27);
            txtEpicrisis.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 256);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 20);
            label4.TabIndex = 25;
            label4.Text = "Epicrisis:";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new System.Drawing.Point(12, 219);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new System.Drawing.Size(229, 27);
            txtDuracion.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 196);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 20);
            label3.TabIndex = 23;
            label3.Text = "Duracion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(12, 148);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(229, 34);
            txtDescripcion.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 20);
            label2.TabIndex = 21;
            label2.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 20);
            label1.TabIndex = 20;
            label1.Text = "Id de Cita";
            // 
            // clbMedicosAdicionales
            // 
            clbMedicosAdicionales.FormattingEnabled = true;
            clbMedicosAdicionales.Location = new System.Drawing.Point(12, 385);
            clbMedicosAdicionales.Name = "clbMedicosAdicionales";
            clbMedicosAdicionales.Size = new System.Drawing.Size(229, 114);
            clbMedicosAdicionales.TabIndex = 19;
            // 
            // cbCitas
            // 
            cbCitas.FormattingEnabled = true;
            cbCitas.Location = new System.Drawing.Point(12, 94);
            cbCitas.Name = "cbCitas";
            cbCitas.Size = new System.Drawing.Size(229, 28);
            cbCitas.TabIndex = 18;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new System.Drawing.Point(12, 572);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new System.Drawing.Size(94, 29);
            BtnLimpiar.TabIndex = 17;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 17);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(147, 20);
            label8.TabIndex = 35;
            label8.Text = "Id de Procedimiento:";
            // 
            // cbProcedimientos
            // 
            cbProcedimientos.FormattingEnabled = true;
            cbProcedimientos.Location = new System.Drawing.Point(12, 40);
            cbProcedimientos.Name = "cbProcedimientos";
            cbProcedimientos.Size = new System.Drawing.Size(229, 28);
            cbProcedimientos.TabIndex = 34;
            // 
            // FormProcedimientoModificar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(label8);
            Controls.Add(cbProcedimientos);
            Controls.Add(txtRolMedico);
            Controls.Add(label7);
            Controls.Add(dgvProcedimientos);
            Controls.Add(BtnGuardar);
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
            Name = "FormProcedimientoModificar";
            Text = "FormProcedimientoModificar";
            ((System.ComponentModel.ISupportInitialize)dgvProcedimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtRolMedico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvProcedimientos;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaProcedimiento;
        private System.Windows.Forms.TextBox txtEpicrisis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbMedicosAdicionales;
        private System.Windows.Forms.ComboBox cbCitas;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbProcedimientos;
    }
}