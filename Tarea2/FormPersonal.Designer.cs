namespace Tarea2
{
    partial class FormPersonal
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
            tabPersonal = new System.Windows.Forms.TabControl();
            tabPersonalCrear = new System.Windows.Forms.TabPage();
            tabPersonalModificar = new System.Windows.Forms.TabPage();
            tabPersonalEliminar = new System.Windows.Forms.TabPage();
            tabPersonalMostrar = new System.Windows.Forms.TabPage();
            tabPersonal.SuspendLayout();
            SuspendLayout();
            // 
            // tabPersonal
            // 
            tabPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabPersonal.Controls.Add(tabPersonalCrear);
            tabPersonal.Controls.Add(tabPersonalModificar);
            tabPersonal.Controls.Add(tabPersonalEliminar);
            tabPersonal.Controls.Add(tabPersonalMostrar);
            tabPersonal.Location = new System.Drawing.Point(1, 0);
            tabPersonal.Name = "tabPersonal";
            tabPersonal.SelectedIndex = 0;
            tabPersonal.Size = new System.Drawing.Size(1080, 703);
            tabPersonal.TabIndex = 1;
            // 
            // tabPersonalCrear
            // 
            tabPersonalCrear.Location = new System.Drawing.Point(4, 29);
            tabPersonalCrear.Name = "tabPersonalCrear";
            tabPersonalCrear.Padding = new System.Windows.Forms.Padding(3);
            tabPersonalCrear.Size = new System.Drawing.Size(1072, 670);
            tabPersonalCrear.TabIndex = 0;
            tabPersonalCrear.Text = "Crear Personal";
            tabPersonalCrear.UseVisualStyleBackColor = true;
            // 
            // tabPersonalModificar
            // 
            tabPersonalModificar.Location = new System.Drawing.Point(4, 29);
            tabPersonalModificar.Name = "tabPersonalModificar";
            tabPersonalModificar.Padding = new System.Windows.Forms.Padding(3);
            tabPersonalModificar.Size = new System.Drawing.Size(1072, 670);
            tabPersonalModificar.TabIndex = 1;
            tabPersonalModificar.Text = "Modificar Personal";
            tabPersonalModificar.UseVisualStyleBackColor = true;
            // 
            // tabPersonalEliminar
            // 
            tabPersonalEliminar.Location = new System.Drawing.Point(4, 29);
            tabPersonalEliminar.Name = "tabPersonalEliminar";
            tabPersonalEliminar.Padding = new System.Windows.Forms.Padding(3);
            tabPersonalEliminar.Size = new System.Drawing.Size(1072, 670);
            tabPersonalEliminar.TabIndex = 2;
            tabPersonalEliminar.Text = "Eliminar Personal";
            tabPersonalEliminar.UseVisualStyleBackColor = true;
            // 
            // tabPersonalMostrar
            // 
            tabPersonalMostrar.Location = new System.Drawing.Point(4, 29);
            tabPersonalMostrar.Name = "tabPersonalMostrar";
            tabPersonalMostrar.Padding = new System.Windows.Forms.Padding(3);
            tabPersonalMostrar.Size = new System.Drawing.Size(1072, 670);
            tabPersonalMostrar.TabIndex = 3;
            tabPersonalMostrar.Text = "Mostrar Personal";
            tabPersonalMostrar.UseVisualStyleBackColor = true;
            // 
            // FormPersonal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1082, 703);
            Controls.Add(tabPersonal);
            Name = "FormPersonal";
            Text = "FormPersonal";
            tabPersonal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabPersonal;
        private System.Windows.Forms.TabPage tabPersonalCrear;
        private System.Windows.Forms.TabPage tabPersonalModificar;
        private System.Windows.Forms.TabPage tabPersonalEliminar;
        private System.Windows.Forms.TabPage tabPersonalMostrar;
    }
}