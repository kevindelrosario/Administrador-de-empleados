namespace ControlDeEmpleados.PL
{
    partial class frmEmpleados
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPApellido = new System.Windows.Forms.TextBox();
            this.txtSApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btExaminar = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(280, 57);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(416, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtPApellido
            // 
            this.txtPApellido.Location = new System.Drawing.Point(280, 117);
            this.txtPApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPApellido.Name = "txtPApellido";
            this.txtPApellido.Size = new System.Drawing.Size(284, 22);
            this.txtPApellido.TabIndex = 3;
            // 
            // txtSApellido
            // 
            this.txtSApellido.Location = new System.Drawing.Point(590, 117);
            this.txtSApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSApellido.Name = "txtSApellido";
            this.txtSApellido.Size = new System.Drawing.Size(312, 22);
            this.txtSApellido.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(280, 206);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(622, 22);
            this.txtCorreo.TabIndex = 5;
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Location = new System.Drawing.Point(280, 270);
            this.comboDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(453, 24);
            this.comboDepartamento.TabIndex = 6;
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(35, 395);
            this.grilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grilla.Name = "grilla";
            this.grilla.RowHeadersWidth = 51;
            this.grilla.RowTemplate.Height = 24;
            this.grilla.Size = new System.Drawing.Size(867, 313);
            this.grilla.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Primer apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Departamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Segundo Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID:";
            // 
            // btCancelar
            // 
            this.btCancelar.Image = global::ControrDeEmpleados.Properties.Resources.cancelar2;
            this.btCancelar.Location = new System.Drawing.Point(744, 317);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(158, 74);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btBorrar
            // 
            this.btBorrar.Image = global::ControrDeEmpleados.Properties.Resources.eliminar;
            this.btBorrar.Location = new System.Drawing.Point(604, 315);
            this.btBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(129, 76);
            this.btBorrar.TabIndex = 10;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btModificar
            // 
            this.btModificar.Image = global::ControrDeEmpleados.Properties.Resources.editarPersona;
            this.btModificar.Location = new System.Drawing.Point(443, 315);
            this.btModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(141, 76);
            this.btModificar.TabIndex = 9;
            this.btModificar.Text = "Modificar";
            this.btModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btModificar.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::ControrDeEmpleados.Properties.Resources.addPersona;
            this.btAgregar.Location = new System.Drawing.Point(277, 315);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(148, 76);
            this.btAgregar.TabIndex = 8;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // btExaminar
            // 
            this.btExaminar.Image = global::ControrDeEmpleados.Properties.Resources.examinar;
            this.btExaminar.Location = new System.Drawing.Point(35, 315);
            this.btExaminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExaminar.Name = "btExaminar";
            this.btExaminar.Size = new System.Drawing.Size(236, 76);
            this.btExaminar.TabIndex = 7;
            this.btExaminar.Text = "Examinar";
            this.btExaminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExaminar.UseVisualStyleBackColor = true;
            this.btExaminar.Click += new System.EventHandler(this.btExaminar_Click);
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(35, 47);
            this.picFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(236, 247);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btExaminar);
            this.Controls.Add(this.comboDepartamento);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtSApellido);
            this.Controls.Add(this.txtPApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.picFoto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPApellido;
        private System.Windows.Forms.TextBox txtSApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox comboDepartamento;
        private System.Windows.Forms.Button btExaminar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}