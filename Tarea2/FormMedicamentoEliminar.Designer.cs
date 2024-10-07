namespace Tarea2
{
    partial class FormMedicamentoEliminar
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
            cbMedicamentos = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            dgvMedicamentos = new System.Windows.Forms.DataGridView();
            btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // cbMedicamentos
            // 
            cbMedicamentos.FormattingEnabled = true;
            cbMedicamentos.Location = new System.Drawing.Point(21, 51);
            cbMedicamentos.Name = "cbMedicamentos";
            cbMedicamentos.Size = new System.Drawing.Size(222, 28);
            cbMedicamentos.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(21, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 20);
            label4.TabIndex = 38;
            label4.Text = "Medicamentos:";
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.AllowUserToAddRows = false;
            dgvMedicamentos.AllowUserToDeleteRows = false;
            dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new System.Drawing.Point(260, 12);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.ReadOnly = true;
            dgvMedicamentos.RowHeadersWidth = 51;
            dgvMedicamentos.Size = new System.Drawing.Size(752, 594);
            dgvMedicamentos.TabIndex = 37;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(21, 577);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(94, 29);
            btnEliminar.TabIndex = 40;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormMedicamentoEliminar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(btnEliminar);
            Controls.Add(cbMedicamentos);
            Controls.Add(label4);
            Controls.Add(dgvMedicamentos);
            Name = "FormMedicamentoEliminar";
            Text = "FormMedicamentoEliminar";
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbMedicamentos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.Button btnEliminar;
    }
}