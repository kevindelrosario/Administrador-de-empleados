namespace ControrDeEmpleados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDepartamento = new System.Windows.Forms.Button();
            this.btEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDepartamento
            // 
            this.btDepartamento.Location = new System.Drawing.Point(148, 135);
            this.btDepartamento.Name = "btDepartamento";
            this.btDepartamento.Size = new System.Drawing.Size(212, 134);
            this.btDepartamento.TabIndex = 0;
            this.btDepartamento.Text = "Departamento";
            this.btDepartamento.UseVisualStyleBackColor = true;
            // 
            // btEmpleado
            // 
            this.btEmpleado.Location = new System.Drawing.Point(399, 135);
            this.btEmpleado.Name = "btEmpleado";
            this.btEmpleado.Size = new System.Drawing.Size(212, 134);
            this.btEmpleado.TabIndex = 1;
            this.btEmpleado.Text = "Empleados";
            this.btEmpleado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEmpleado);
            this.Controls.Add(this.btDepartamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDepartamento;
        private System.Windows.Forms.Button btEmpleado;
    }
}

