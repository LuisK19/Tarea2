namespace Tarea2
{
    partial class FormMedicamentoModificar
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
            btnModificar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            dgvMedicamentos = new System.Windows.Forms.DataGridView();
            txtEfectosSecundarios = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtDosificacion = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            cbMedicamentos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new System.Drawing.Point(142, 571);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(105, 35);
            btnModificar.TabIndex = 34;
            btnModificar.Text = "Guardar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(16, 571);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(96, 35);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.AllowUserToAddRows = false;
            dgvMedicamentos.AllowUserToDeleteRows = false;
            dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new System.Drawing.Point(264, 12);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.ReadOnly = true;
            dgvMedicamentos.RowHeadersWidth = 51;
            dgvMedicamentos.Size = new System.Drawing.Size(752, 594);
            dgvMedicamentos.TabIndex = 32;
            // 
            // txtEfectosSecundarios
            // 
            txtEfectosSecundarios.Location = new System.Drawing.Point(25, 234);
            txtEfectosSecundarios.Name = "txtEfectosSecundarios";
            txtEfectosSecundarios.Size = new System.Drawing.Size(222, 27);
            txtEfectosSecundarios.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(25, 211);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(144, 20);
            label3.TabIndex = 30;
            label3.Text = "Efectos Secundarios:";
            // 
            // txtDosificacion
            // 
            txtDosificacion.Location = new System.Drawing.Point(25, 172);
            txtDosificacion.Name = "txtDosificacion";
            txtDosificacion.Size = new System.Drawing.Size(222, 27);
            txtDosificacion.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 149);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 20);
            label2.TabIndex = 28;
            label2.Text = "Dosificacion:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(25, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(222, 27);
            txtNombre.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 89);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 20);
            label1.TabIndex = 26;
            label1.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(25, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 20);
            label4.TabIndex = 35;
            label4.Text = "Medicamentos:";
            // 
            // cbMedicamentos
            // 
            cbMedicamentos.FormattingEnabled = true;
            cbMedicamentos.Location = new System.Drawing.Point(25, 51);
            cbMedicamentos.Name = "cbMedicamentos";
            cbMedicamentos.Size = new System.Drawing.Size(222, 28);
            cbMedicamentos.TabIndex = 36;
            // 
            // FormMedicamentoModificar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(cbMedicamentos);
            Controls.Add(label4);
            Controls.Add(btnModificar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvMedicamentos);
            Controls.Add(txtEfectosSecundarios);
            Controls.Add(label3);
            Controls.Add(txtDosificacion);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FormMedicamentoModificar";
            Text = "FormMedicamentoModificar";
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.TextBox txtEfectosSecundarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDosificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMedicamentos;
    }
}