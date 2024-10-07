namespace Tarea2
{
    partial class FormMedicamentoMostrar
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
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.AllowUserToAddRows = false;
            dgvMedicamentos.AllowUserToDeleteRows = false;
            dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new System.Drawing.Point(0, 0);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.ReadOnly = true;
            dgvMedicamentos.RowHeadersWidth = 51;
            dgvMedicamentos.Size = new System.Drawing.Size(1034, 618);
            dgvMedicamentos.TabIndex = 38;
            // 
            // FormMedicamentoMostrar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(dgvMedicamentos);
            Name = "FormMedicamentoMostrar";
            Text = "FormMedicamentoMostrar";
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicamentos;
    }
}