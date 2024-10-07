namespace Tarea2
{
    partial class FormProcedimiento
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
            tabProcedimiento = new System.Windows.Forms.TabControl();
            tabProcedimientoCrear = new System.Windows.Forms.TabPage();
            tabProcedimientoModificar = new System.Windows.Forms.TabPage();
            tabProcedimientoEliminar = new System.Windows.Forms.TabPage();
            tabProcedimientoMostrar = new System.Windows.Forms.TabPage();
            tabProcedimiento.SuspendLayout();
            SuspendLayout();
            // 
            // tabProcedimiento
            // 
            tabProcedimiento.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabProcedimiento.Controls.Add(tabProcedimientoCrear);
            tabProcedimiento.Controls.Add(tabProcedimientoModificar);
            tabProcedimiento.Controls.Add(tabProcedimientoEliminar);
            tabProcedimiento.Controls.Add(tabProcedimientoMostrar);
            tabProcedimiento.Location = new System.Drawing.Point(1, 0);
            tabProcedimiento.Name = "tabProcedimiento";
            tabProcedimiento.SelectedIndex = 0;
            tabProcedimiento.ShowToolTips = true;
            tabProcedimiento.Size = new System.Drawing.Size(1080, 703);
            tabProcedimiento.TabIndex = 3;
            // 
            // tabProcedimientoCrear
            // 
            tabProcedimientoCrear.Location = new System.Drawing.Point(4, 29);
            tabProcedimientoCrear.Name = "tabProcedimientoCrear";
            tabProcedimientoCrear.Padding = new System.Windows.Forms.Padding(3);
            tabProcedimientoCrear.Size = new System.Drawing.Size(1072, 670);
            tabProcedimientoCrear.TabIndex = 0;
            tabProcedimientoCrear.Text = "Crear Procedimiento";
            tabProcedimientoCrear.UseVisualStyleBackColor = true;
            // 
            // tabProcedimientoModificar
            // 
            tabProcedimientoModificar.Location = new System.Drawing.Point(4, 29);
            tabProcedimientoModificar.Name = "tabProcedimientoModificar";
            tabProcedimientoModificar.Padding = new System.Windows.Forms.Padding(3);
            tabProcedimientoModificar.Size = new System.Drawing.Size(1072, 670);
            tabProcedimientoModificar.TabIndex = 1;
            tabProcedimientoModificar.Text = "Modificar Procedimiento";
            tabProcedimientoModificar.UseVisualStyleBackColor = true;
            // 
            // tabProcedimientoEliminar
            // 
            tabProcedimientoEliminar.Location = new System.Drawing.Point(4, 29);
            tabProcedimientoEliminar.Name = "tabProcedimientoEliminar";
            tabProcedimientoEliminar.Padding = new System.Windows.Forms.Padding(3);
            tabProcedimientoEliminar.Size = new System.Drawing.Size(1072, 670);
            tabProcedimientoEliminar.TabIndex = 2;
            tabProcedimientoEliminar.Text = "Eliminar Procedimiento";
            tabProcedimientoEliminar.UseVisualStyleBackColor = true;
            // 
            // tabProcedimientoMostrar
            // 
            tabProcedimientoMostrar.Location = new System.Drawing.Point(4, 29);
            tabProcedimientoMostrar.Name = "tabProcedimientoMostrar";
            tabProcedimientoMostrar.Padding = new System.Windows.Forms.Padding(3);
            tabProcedimientoMostrar.Size = new System.Drawing.Size(1072, 670);
            tabProcedimientoMostrar.TabIndex = 3;
            tabProcedimientoMostrar.Text = "Mostrar Procedimiento";
            tabProcedimientoMostrar.UseVisualStyleBackColor = true;
            // 
            // FormProcedimiento
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1082, 703);
            Controls.Add(tabProcedimiento);
            Name = "FormProcedimiento";
            Text = "FormProcedimiento";
            tabProcedimiento.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabProcedimiento;
        private System.Windows.Forms.TabPage tabProcedimientoCrear;
        private System.Windows.Forms.TabPage tabProcedimientoModificar;
        private System.Windows.Forms.TabPage tabProcedimientoEliminar;
        private System.Windows.Forms.TabPage tabProcedimientoMostrar;
    }
}