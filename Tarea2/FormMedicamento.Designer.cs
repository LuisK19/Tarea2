namespace Tarea2
{
    partial class FormMedicamento
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
            tabMedicamento = new System.Windows.Forms.TabControl();
            tabMedicamentoCrear = new System.Windows.Forms.TabPage();
            tabMedicamentoModificar = new System.Windows.Forms.TabPage();
            tabMedicamentoEliminar = new System.Windows.Forms.TabPage();
            tabMedicamentosMostrar = new System.Windows.Forms.TabPage();
            tabMedicamento.SuspendLayout();
            SuspendLayout();
            // 
            // tabMedicamento
            // 
            tabMedicamento.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabMedicamento.Controls.Add(tabMedicamentoCrear);
            tabMedicamento.Controls.Add(tabMedicamentoModificar);
            tabMedicamento.Controls.Add(tabMedicamentoEliminar);
            tabMedicamento.Controls.Add(tabMedicamentosMostrar);
            tabMedicamento.Location = new System.Drawing.Point(1, 0);
            tabMedicamento.Name = "tabMedicamento";
            tabMedicamento.SelectedIndex = 0;
            tabMedicamento.Size = new System.Drawing.Size(1080, 703);
            tabMedicamento.TabIndex = 1;
            // 
            // tabMedicamentoCrear
            // 
            tabMedicamentoCrear.Location = new System.Drawing.Point(4, 29);
            tabMedicamentoCrear.Name = "tabMedicamentoCrear";
            tabMedicamentoCrear.Padding = new System.Windows.Forms.Padding(3);
            tabMedicamentoCrear.Size = new System.Drawing.Size(1072, 670);
            tabMedicamentoCrear.TabIndex = 0;
            tabMedicamentoCrear.Text = "Crear Medicamento";
            tabMedicamentoCrear.UseVisualStyleBackColor = true;
            // 
            // tabMedicamentoModificar
            // 
            tabMedicamentoModificar.Location = new System.Drawing.Point(4, 29);
            tabMedicamentoModificar.Name = "tabMedicamentoModificar";
            tabMedicamentoModificar.Padding = new System.Windows.Forms.Padding(3);
            tabMedicamentoModificar.Size = new System.Drawing.Size(1072, 670);
            tabMedicamentoModificar.TabIndex = 1;
            tabMedicamentoModificar.Text = "Modificar Medicamento";
            tabMedicamentoModificar.UseVisualStyleBackColor = true;
            // 
            // tabMedicamentoEliminar
            // 
            tabMedicamentoEliminar.Location = new System.Drawing.Point(4, 29);
            tabMedicamentoEliminar.Name = "tabMedicamentoEliminar";
            tabMedicamentoEliminar.Padding = new System.Windows.Forms.Padding(3);
            tabMedicamentoEliminar.Size = new System.Drawing.Size(1072, 670);
            tabMedicamentoEliminar.TabIndex = 2;
            tabMedicamentoEliminar.Text = "Eliminar Medicamento";
            tabMedicamentoEliminar.UseVisualStyleBackColor = true;
            // 
            // tabMedicamentosMostrar
            // 
            tabMedicamentosMostrar.Location = new System.Drawing.Point(4, 29);
            tabMedicamentosMostrar.Name = "tabMedicamentosMostrar";
            tabMedicamentosMostrar.Padding = new System.Windows.Forms.Padding(3);
            tabMedicamentosMostrar.Size = new System.Drawing.Size(1072, 670);
            tabMedicamentosMostrar.TabIndex = 3;
            tabMedicamentosMostrar.Text = "Mostrar Medicamento";
            tabMedicamentosMostrar.UseVisualStyleBackColor = true;
            // 
            // FormMedicamento
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1082, 703);
            Controls.Add(tabMedicamento);
            Name = "FormMedicamento";
            Text = "FormMedicamento";
            tabMedicamento.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabMedicamento;
        private System.Windows.Forms.TabPage tabMedicamentoCrear;
        private System.Windows.Forms.TabPage tabMedicamentoModificar;
        private System.Windows.Forms.TabPage tabMedicamentoEliminar;
        private System.Windows.Forms.TabPage tabMedicamentosMostrar;
    }
}