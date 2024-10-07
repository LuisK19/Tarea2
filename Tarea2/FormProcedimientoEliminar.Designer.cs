namespace Tarea2
{
    partial class FormProcedimientoEliminar
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
            cbProcedimientos = new System.Windows.Forms.ComboBox();
            dgvProcedimientos = new System.Windows.Forms.DataGridView();
            BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvProcedimientos).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 17);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(147, 20);
            label8.TabIndex = 38;
            label8.Text = "Id de Procedimiento:";
            // 
            // cbProcedimientos
            // 
            cbProcedimientos.FormattingEnabled = true;
            cbProcedimientos.Location = new System.Drawing.Point(12, 40);
            cbProcedimientos.Name = "cbProcedimientos";
            cbProcedimientos.Size = new System.Drawing.Size(229, 28);
            cbProcedimientos.TabIndex = 37;
            // 
            // dgvProcedimientos
            // 
            dgvProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcedimientos.Location = new System.Drawing.Point(257, 17);
            dgvProcedimientos.Name = "dgvProcedimientos";
            dgvProcedimientos.RowHeadersWidth = 51;
            dgvProcedimientos.Size = new System.Drawing.Size(763, 584);
            dgvProcedimientos.TabIndex = 36;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new System.Drawing.Point(12, 577);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new System.Drawing.Size(94, 29);
            BtnEliminar.TabIndex = 39;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // FormProcedimientoEliminar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 618);
            Controls.Add(BtnEliminar);
            Controls.Add(label8);
            Controls.Add(cbProcedimientos);
            Controls.Add(dgvProcedimientos);
            Name = "FormProcedimientoEliminar";
            Text = "FormProcedimientoEliminar";
            ((System.ComponentModel.ISupportInitialize)dgvProcedimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbProcedimientos;
        private System.Windows.Forms.DataGridView dgvProcedimientos;
        private System.Windows.Forms.Button BtnEliminar;
    }
}