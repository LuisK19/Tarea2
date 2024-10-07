namespace Tarea2
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnPaciente = new System.Windows.Forms.Button();
            btnPersonal = new System.Windows.Forms.Button();
            btnMedicamento = new System.Windows.Forms.Button();
            BtnCitas = new System.Windows.Forms.Button();
            BtnProcedimiento = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnPaciente
            // 
            btnPaciente.Location = new System.Drawing.Point(424, 130);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new System.Drawing.Size(167, 60);
            btnPaciente.TabIndex = 0;
            btnPaciente.Text = "Menu Pacientes";
            btnPaciente.UseVisualStyleBackColor = true;
            btnPaciente.Click += btnPaciente_Click;
            // 
            // btnPersonal
            // 
            btnPersonal.Location = new System.Drawing.Point(424, 196);
            btnPersonal.Name = "btnPersonal";
            btnPersonal.Size = new System.Drawing.Size(167, 66);
            btnPersonal.TabIndex = 1;
            btnPersonal.Text = "Menu Persona Medico";
            btnPersonal.UseVisualStyleBackColor = true;
            btnPersonal.Click += btnPersonal_Click;
            // 
            // btnMedicamento
            // 
            btnMedicamento.Location = new System.Drawing.Point(424, 268);
            btnMedicamento.Name = "btnMedicamento";
            btnMedicamento.Size = new System.Drawing.Size(167, 74);
            btnMedicamento.TabIndex = 2;
            btnMedicamento.Text = "Menu Medicamento";
            btnMedicamento.UseVisualStyleBackColor = true;
            btnMedicamento.Click += btnMedicamento_Click;
            // 
            // BtnCitas
            // 
            BtnCitas.Location = new System.Drawing.Point(424, 348);
            BtnCitas.Name = "BtnCitas";
            BtnCitas.Size = new System.Drawing.Size(167, 65);
            BtnCitas.TabIndex = 3;
            BtnCitas.Text = "Menu Citas";
            BtnCitas.UseVisualStyleBackColor = true;
            BtnCitas.Click += BtnCitas_Click;
            // 
            // BtnProcedimiento
            // 
            BtnProcedimiento.Location = new System.Drawing.Point(424, 419);
            BtnProcedimiento.Name = "BtnProcedimiento";
            BtnProcedimiento.Size = new System.Drawing.Size(167, 65);
            BtnProcedimiento.TabIndex = 4;
            BtnProcedimiento.Text = "Menu Procedimiento";
            BtnProcedimiento.UseVisualStyleBackColor = true;
            BtnProcedimiento.Click += BtnProcedimiento_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1082, 703);
            Controls.Add(BtnProcedimiento);
            Controls.Add(BtnCitas);
            Controls.Add(btnMedicamento);
            Controls.Add(btnPersonal);
            Controls.Add(btnPaciente);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnMedicamento;
        private System.Windows.Forms.Button BtnCitas;
        private System.Windows.Forms.Button BtnProcedimiento;
    }
}

