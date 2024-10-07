namespace Tarea2
{
    partial class FormCitaCrear
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
            cbPacientes = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbMedicos = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            txtMotivoConsulta = new System.Windows.Forms.TextBox();
            txtDuracion = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtResultados = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtEpicrisis = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtPersonalAdicional = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            BtnLimpiar = new System.Windows.Forms.Button();
            BtnRegistar = new System.Windows.Forms.Button();
            dtpFechaHora = new System.Windows.Forms.DateTimePicker();
            label10 = new System.Windows.Forms.Label();
            dgvCitas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // cbPacientes
            // 
            cbPacientes.FormattingEnabled = true;
            cbPacientes.Location = new System.Drawing.Point(12, 30);
            cbPacientes.Name = "cbPacientes";
            cbPacientes.Size = new System.Drawing.Size(202, 28);
            cbPacientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Paciente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 61);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "Medico";
            // 
            // cbMedicos
            // 
            cbMedicos.FormattingEnabled = true;
            cbMedicos.Location = new System.Drawing.Point(12, 84);
            cbMedicos.Name = "cbMedicos";
            cbMedicos.Size = new System.Drawing.Size(202, 28);
            cbMedicos.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 115);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 20);
            label3.TabIndex = 4;
            label3.Text = "Motivo:";
            // 
            // txtMotivoConsulta
            // 
            txtMotivoConsulta.Location = new System.Drawing.Point(12, 138);
            txtMotivoConsulta.Multiline = true;
            txtMotivoConsulta.Name = "txtMotivoConsulta";
            txtMotivoConsulta.Size = new System.Drawing.Size(202, 81);
            txtMotivoConsulta.TabIndex = 5;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new System.Drawing.Point(12, 248);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new System.Drawing.Size(202, 27);
            txtDuracion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 225);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Duracion:";
            // 
            // txtResultados
            // 
            txtResultados.Location = new System.Drawing.Point(12, 301);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new System.Drawing.Size(202, 56);
            txtResultados.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 278);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 20);
            label5.TabIndex = 8;
            label5.Text = "Resultados:";
            // 
            // txtEpicrisis
            // 
            txtEpicrisis.Location = new System.Drawing.Point(12, 383);
            txtEpicrisis.Multiline = true;
            txtEpicrisis.Name = "txtEpicrisis";
            txtEpicrisis.Size = new System.Drawing.Size(202, 27);
            txtEpicrisis.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 360);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 20);
            label6.TabIndex = 10;
            label6.Text = "Epicrisis:";
            // 
            // txtPersonalAdicional
            // 
            txtPersonalAdicional.Location = new System.Drawing.Point(12, 437);
            txtPersonalAdicional.Multiline = true;
            txtPersonalAdicional.Name = "txtPersonalAdicional";
            txtPersonalAdicional.Size = new System.Drawing.Size(202, 27);
            txtPersonalAdicional.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 414);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(130, 20);
            label7.TabIndex = 12;
            label7.Text = "PersonalAdicional:";
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new System.Drawing.Point(12, 577);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new System.Drawing.Size(94, 29);
            BtnLimpiar.TabIndex = 18;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnRegistar
            // 
            BtnRegistar.Location = new System.Drawing.Point(138, 577);
            BtnRegistar.Name = "BtnRegistar";
            BtnRegistar.Size = new System.Drawing.Size(94, 29);
            BtnRegistar.TabIndex = 19;
            BtnRegistar.Text = "Registar";
            BtnRegistar.UseVisualStyleBackColor = true;
            BtnRegistar.Click += BtnRegistar_Click;
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpFechaHora.Location = new System.Drawing.Point(12, 490);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new System.Drawing.Size(202, 27);
            dtpFechaHora.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(12, 467);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(50, 20);
            label10.TabIndex = 21;
            label10.Text = "Fecha:";
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new System.Drawing.Point(238, 30);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.Size = new System.Drawing.Size(782, 576);
            dgvCitas.TabIndex = 22;
            // 
            // FormCitaCrear
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
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
            Name = "FormCitaCrear";
            Text = "FormCitaCrear";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMotivoConsulta;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEpicrisis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersonalAdicional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnRegistar;
        private System.Windows.Forms.DateTimePicker dtpFechaHora;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvCitas;
    }
}