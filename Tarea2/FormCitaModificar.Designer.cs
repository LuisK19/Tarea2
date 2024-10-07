namespace Tarea2
{
    partial class FormCitaModificar
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
            dgvCitas = new System.Windows.Forms.DataGridView();
            label10 = new System.Windows.Forms.Label();
            dtpFechaHora = new System.Windows.Forms.DateTimePicker();
            BtnRegistar = new System.Windows.Forms.Button();
            BtnLimpiar = new System.Windows.Forms.Button();
            txtPersonalAdicional = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtEpicrisis = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtResultados = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtDuracion = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtMotivoConsulta = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbMedicos = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            cbPacientes = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            cbCitas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new System.Drawing.Point(238, 33);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.Size = new System.Drawing.Size(782, 576);
            dgvCitas.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(12, 500);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(50, 20);
            label10.TabIndex = 40;
            label10.Text = "Fecha:";
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpFechaHora.Location = new System.Drawing.Point(12, 523);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new System.Drawing.Size(202, 27);
            dtpFechaHora.TabIndex = 39;
            // 
            // BtnRegistar
            // 
            BtnRegistar.Location = new System.Drawing.Point(138, 580);
            BtnRegistar.Name = "BtnRegistar";
            BtnRegistar.Size = new System.Drawing.Size(94, 29);
            BtnRegistar.TabIndex = 38;
            BtnRegistar.Text = "Registar";
            BtnRegistar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new System.Drawing.Point(12, 580);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new System.Drawing.Size(94, 29);
            BtnLimpiar.TabIndex = 37;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtPersonalAdicional
            // 
            txtPersonalAdicional.Location = new System.Drawing.Point(12, 470);
            txtPersonalAdicional.Multiline = true;
            txtPersonalAdicional.Name = "txtPersonalAdicional";
            txtPersonalAdicional.Size = new System.Drawing.Size(202, 27);
            txtPersonalAdicional.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 447);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(130, 20);
            label7.TabIndex = 35;
            label7.Text = "PersonalAdicional:";
            // 
            // txtEpicrisis
            // 
            txtEpicrisis.Location = new System.Drawing.Point(12, 416);
            txtEpicrisis.Multiline = true;
            txtEpicrisis.Name = "txtEpicrisis";
            txtEpicrisis.Size = new System.Drawing.Size(202, 27);
            txtEpicrisis.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 393);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 20);
            label6.TabIndex = 33;
            label6.Text = "Epicrisis:";
            // 
            // txtResultados
            // 
            txtResultados.Location = new System.Drawing.Point(12, 356);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new System.Drawing.Size(202, 34);
            txtResultados.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 333);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 20);
            label5.TabIndex = 31;
            label5.Text = "Resultados:";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new System.Drawing.Point(12, 303);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new System.Drawing.Size(202, 27);
            txtDuracion.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 280);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 20);
            label4.TabIndex = 29;
            label4.Text = "Duracion:";
            // 
            // txtMotivoConsulta
            // 
            txtMotivoConsulta.Location = new System.Drawing.Point(12, 193);
            txtMotivoConsulta.Multiline = true;
            txtMotivoConsulta.Name = "txtMotivoConsulta";
            txtMotivoConsulta.Size = new System.Drawing.Size(202, 81);
            txtMotivoConsulta.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 170);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 20);
            label3.TabIndex = 27;
            label3.Text = "Motivo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 116);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 20);
            label2.TabIndex = 26;
            label2.Text = "Medico";
            // 
            // cbMedicos
            // 
            cbMedicos.FormattingEnabled = true;
            cbMedicos.Location = new System.Drawing.Point(12, 139);
            cbMedicos.Name = "cbMedicos";
            cbMedicos.Size = new System.Drawing.Size(202, 28);
            cbMedicos.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 62);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 20);
            label1.TabIndex = 24;
            label1.Text = "Paciente:";
            // 
            // cbPacientes
            // 
            cbPacientes.FormattingEnabled = true;
            cbPacientes.Location = new System.Drawing.Point(12, 85);
            cbPacientes.Name = "cbPacientes";
            cbPacientes.Size = new System.Drawing.Size(202, 28);
            cbPacientes.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 10);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(38, 20);
            label8.TabIndex = 43;
            label8.Text = "Cita:";
            // 
            // cbCitas
            // 
            cbCitas.FormattingEnabled = true;
            cbCitas.Location = new System.Drawing.Point(12, 33);
            cbCitas.Name = "cbCitas";
            cbCitas.Size = new System.Drawing.Size(202, 28);
            cbCitas.TabIndex = 42;
            // 
            // FormCitaModificar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(label8);
            Controls.Add(cbCitas);
            Controls.Add(dgvCitas);
            Controls.Add(label10);
            Controls.Add(dtpFechaHora);
            Controls.Add(BtnRegistar);
            Controls.Add(BtnLimpiar);
            Controls.Add(txtPersonalAdicional);
            Controls.Add(label7);
            Controls.Add(txtEpicrisis);
            Controls.Add(label6);
            Controls.Add(txtResultados);
            Controls.Add(label5);
            Controls.Add(txtDuracion);
            Controls.Add(label4);
            Controls.Add(txtMotivoConsulta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbMedicos);
            Controls.Add(label1);
            Controls.Add(cbPacientes);
            Name = "FormCitaModificar";
            Text = "FormCitaModificar";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFechaHora;
        private System.Windows.Forms.Button BtnRegistar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox txtPersonalAdicional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEpicrisis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMotivoConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCitas;
    }
}