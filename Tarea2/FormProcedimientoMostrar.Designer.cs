namespace Tarea2
{
    partial class FormProcedimientoMostrar
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
            dgvProcedimientos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProcedimientos).BeginInit();
            SuspendLayout();
            // 
            // dgvProcedimientos
            // 
            dgvProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcedimientos.Location = new System.Drawing.Point(0, 3);
            dgvProcedimientos.Name = "dgvProcedimientos";
            dgvProcedimientos.RowHeadersWidth = 51;
            dgvProcedimientos.Size = new System.Drawing.Size(1032, 614);
            dgvProcedimientos.TabIndex = 37;
            // 
            // FormProcedimientoMostrar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(dgvProcedimientos);
            Name = "FormProcedimientoMostrar";
            Text = "FormProcedimientoMostrar";
            ((System.ComponentModel.ISupportInitialize)dgvProcedimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcedimientos;
    }
}