namespace Tarea2
{
    partial class FormPersonalMostrar
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
            dgvPersonal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonal
            // 
            dgvPersonal.AllowUserToAddRows = false;
            dgvPersonal.AllowUserToDeleteRows = false;
            dgvPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonal.Location = new System.Drawing.Point(-1, 2);
            dgvPersonal.Name = "dgvPersonal";
            dgvPersonal.ReadOnly = true;
            dgvPersonal.RowHeadersWidth = 51;
            dgvPersonal.Size = new System.Drawing.Size(1032, 616);
            dgvPersonal.TabIndex = 63;
            // 
            // FormPersonalMostrar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(dgvPersonal);
            Name = "FormPersonalMostrar";
            Text = "FormPersonalMostrar";
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonal;
    }
}