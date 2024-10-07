namespace Tarea2
{
    partial class FormCitaEliminar
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
            label8 = new System.Windows.Forms.Label();
            cbCitas = new System.Windows.Forms.ComboBox();
            dgvCitas = new System.Windows.Forms.DataGridView();
            BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 10);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(38, 20);
            label8.TabIndex = 46;
            label8.Text = "Cita:";
            // 
            // cbCitas
            // 
            cbCitas.FormattingEnabled = true;
            cbCitas.Location = new System.Drawing.Point(12, 33);
            cbCitas.Name = "cbCitas";
            cbCitas.Size = new System.Drawing.Size(202, 28);
            cbCitas.TabIndex = 45;
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new System.Drawing.Point(247, 33);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.Size = new System.Drawing.Size(782, 576);
            dgvCitas.TabIndex = 44;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new System.Drawing.Point(12, 577);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new System.Drawing.Size(94, 29);
            BtnEliminar.TabIndex = 47;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // FormCitaEliminar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(BtnEliminar);
            Controls.Add(label8);
            Controls.Add(cbCitas);
            Controls.Add(dgvCitas);
            Name = "FormCitaEliminar";
            Text = "FormCitaEliminar";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCitas;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Button BtnEliminar;
    }
}