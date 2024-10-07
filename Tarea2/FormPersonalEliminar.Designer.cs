namespace Tarea2
{
    partial class FormPersonalEliminar
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
            cbPersonal = new System.Windows.Forms.ComboBox();
            dgvPersonal = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).BeginInit();
            SuspendLayout();
            // 
            // cbPersonal
            // 
            cbPersonal.FormattingEnabled = true;
            cbPersonal.Location = new System.Drawing.Point(16, 47);
            cbPersonal.Name = "cbPersonal";
            cbPersonal.Size = new System.Drawing.Size(222, 28);
            cbPersonal.TabIndex = 63;
            // 
            // dgvPersonal
            // 
            dgvPersonal.AllowUserToAddRows = false;
            dgvPersonal.AllowUserToDeleteRows = false;
            dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonal.Location = new System.Drawing.Point(264, 12);
            dgvPersonal.Name = "dgvPersonal";
            dgvPersonal.ReadOnly = true;
            dgvPersonal.RowHeadersWidth = 51;
            dgvPersonal.Size = new System.Drawing.Size(752, 594);
            dgvPersonal.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 20);
            label1.TabIndex = 60;
            label1.Text = "Cedula:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(12, 577);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(94, 29);
            btnEliminar.TabIndex = 64;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormPersonalEliminar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(btnEliminar);
            Controls.Add(cbPersonal);
            Controls.Add(dgvPersonal);
            Controls.Add(label1);
            Name = "FormPersonalEliminar";
            Text = "FormPersonalEliminar";
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbPersonal;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
    }
}