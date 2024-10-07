namespace Tarea2
{
    partial class FormMedicamentoCrear
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
            dgvMedicamentos = new System.Windows.Forms.DataGridView();
            txtEfectosSecundarios = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtDosificacion = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnCrear = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
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
            dgvMedicamentos.TabIndex = 23;
            // 
            // txtEfectosSecundarios
            // 
            txtEfectosSecundarios.Location = new System.Drawing.Point(16, 163);
            txtEfectosSecundarios.Name = "txtEfectosSecundarios";
            txtEfectosSecundarios.Size = new System.Drawing.Size(222, 27);
            txtEfectosSecundarios.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 140);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(144, 20);
            label3.TabIndex = 21;
            label3.Text = "Efectos Secundarios:";
            // 
            // txtDosificacion
            // 
            txtDosificacion.Location = new System.Drawing.Point(16, 101);
            txtDosificacion.Name = "txtDosificacion";
            txtDosificacion.Size = new System.Drawing.Size(222, 27);
            txtDosificacion.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 20);
            label2.TabIndex = 19;
            label2.Text = "Dosificacion:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(16, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(222, 27);
            txtNombre.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 20);
            label1.TabIndex = 17;
            label1.Text = "Nombre:";
            // 
            // btnCrear
            // 
            btnCrear.Location = new System.Drawing.Point(153, 571);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(105, 35);
            btnCrear.TabIndex = 25;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(16, 571);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(96, 35);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormMedicamentoCrear
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(btnCrear);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvMedicamentos);
            Controls.Add(txtEfectosSecundarios);
            Controls.Add(label3);
            Controls.Add(txtDosificacion);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FormMedicamentoCrear";
            Text = "FormMedicamentoCrear";
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.TextBox txtEfectosSecundarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDosificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
    }
}