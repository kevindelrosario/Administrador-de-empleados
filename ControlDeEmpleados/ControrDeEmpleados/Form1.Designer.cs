namespace ControlDeEmpleados
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
            this.btEmpleado = new System.Windows.Forms.Button();
            this.btDepartamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEmpleado
            // 
            this.btEmpleado.Image = global::ControrDeEmpleados.Properties.Resources.empleadosPrueba;
            this.btEmpleado.Location = new System.Drawing.Point(340, 70);
            this.btEmpleado.Name = "btEmpleado";
            this.btEmpleado.Size = new System.Drawing.Size(271, 162);
            this.btEmpleado.TabIndex = 1;
            this.btEmpleado.Text = "Empleados";
            this.btEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEmpleado.UseVisualStyleBackColor = true;
            this.btEmpleado.Click += new System.EventHandler(this.btEmpleado_Click);
            // 
            // btDepartamento
            // 
            this.btDepartamento.Image = global::ControrDeEmpleados.Properties.Resources.departamentos;
            this.btDepartamento.Location = new System.Drawing.Point(24, 70);
            this.btDepartamento.Name = "btDepartamento";
            this.btDepartamento.Size = new System.Drawing.Size(291, 162);
            this.btDepartamento.TabIndex = 0;
            this.btDepartamento.Text = "Departamentos";
            this.btDepartamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDepartamento.UseVisualStyleBackColor = true;
            this.btDepartamento.Click += new System.EventHandler(this.btDepartamento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(641, 316);
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

