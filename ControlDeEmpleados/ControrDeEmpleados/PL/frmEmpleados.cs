using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Agregado*/
using ControlDeEmpleados.BDD;
using ControlDeEmpleados.BLL;

namespace ControlDeEmpleados.PL
{
    public partial class frmEmpleados : Form
    {
       EmpleadoBDD oEmpleadoBDD;
        byte[] imagenByte;


        public frmEmpleados()
        {
            oEmpleadoBDD = new EmpleadoBDD();
            InitializeComponent();
           llenarGrilla(); //para que inicie con todo relleno....
            limpiarEntradas();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            DepartamentoBDD objDepartamento = new DepartamentoBDD(); //creamos objecto de la clase Depart para usar sus funciones

            comboDepartamento.DataSource = objDepartamento.MostrarDepartamentos().Tables[0];//tomamos la informacion que da esta funcion
            comboDepartamento.DisplayMember = "departamento"; //indicamos que valor queremos obtener
            comboDepartamento.ValueMember = "idDepartamento";
            limpiarEntradas();

        }

        private void btExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecctorImagen = new OpenFileDialog();
            selecctorImagen.Title = "Seleccionar imagen";
        
        if(selecctorImagen.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image= Image.FromStream(selecctorImagen.OpenFile());
                MemoryStream memoria = new MemoryStream();
                picFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);

                imagenByte = memoria.ToArray();

            }


        }

        /****************************AGREGAR***************************************/
        private void btAgregar_Click(object sender, EventArgs e)
        {
            conexionBDD conexion = new conexionBDD();
            // conexion.PruebaConectar();


            //MessageBox.Show("coneccion... " + conexion.PruebaConectar());
            oEmpleadoBDD.Agregar(recolectarDatos());
            llenarGrilla();
            limpiarEntradas();
        }


        /****************************************************************************************************************/
        /*************************RECOLECCION DE INFORMACION DEL USUARIO******************************************************/
        /****************************************************************************************************************/
        private EmpleadosBLL recolectarDatos()
        {
            EmpleadosBLL objEmpleados = new EmpleadosBLL();//Llamamos la clase BLL de empleados

            //int ID = 0; int.TryParse(txtId.Text, out ID);

            int codigoEmpleado = 1; //buscamos el empleado numero 1 que si no existe tomamos el default
            int.TryParse(txtId.Text, out codigoEmpleado);

            //rellenamos toda la informacion de la clase
            objEmpleados.ID = codigoEmpleado;
            objEmpleados.nombreEmpleado = txtNombre.Text;
            objEmpleados.primerApellido = txtPApellido.Text;
            objEmpleados.segundoApellido = txtSApellido.Text;
            objEmpleados.correo= txtCorreo.Text;


            //vemos si existe un valor en departamento y lo depositamos en el IDDepartamento
            int IDDepartamento = 0;
            int.TryParse(comboDepartamento.SelectedValue.ToString(), out IDDepartamento);

            objEmpleados.Departamento = IDDepartamento; 
            objEmpleados.fotoEmpleado = imagenByte; //tomamos la imagen obtenida en examinar anteriormente
           return objEmpleados;
        }


        public void llenarGrilla()
        {
            grilla.DataSource = oEmpleadoBDD.MostrarEmpleados().Tables[0];//se meten los datos encontrados y los muestra
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            grilla.ClearSelection();

            if (indice >= 0) //para evitar los errores con los espacios vacios.
            {
                txtId.Text = grilla.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = grilla.Rows[indice].Cells[1].Value.ToString();
                txtPApellido.Text = grilla.Rows[indice].Cells[2].Value.ToString();
                txtSApellido.Text = grilla.Rows[indice].Cells[3].Value.ToString();
                txtCorreo.Text = grilla.Rows[indice].Cells[4].Value.ToString();

                //activa los botones
                btAgregar.Enabled = false;
                btBorrar.Enabled = true;
                btModificar.Enabled = true;
                btCancelar.Enabled = true;

                /*
                       picFoto.Image = Image.FromStream(grilla.Rows[indice].Cells[4].Value.byte[]);
                       MemoryStream memoria = new MemoryStream();
                       picFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);

                       imagenByte = memoria.ToArray();

                  */
                // int i = grilla.Rows[indice].Cells[5].Value.GetType(v);

            }

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            oEmpleadoBDD.Modificar(recolectarDatos());
            llenarGrilla();
            limpiarEntradas();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            oEmpleadoBDD.Eliminar(recolectarDatos()); //el metodo recuperar nos da los valores de la interfaz
            llenarGrilla();
            limpiarEntradas();
        }

        public void limpiarEntradas()
        {

            txtId.Text = " ";
            txtNombre.Text = " ";
            txtId.Enabled = false;
            btAgregar.Enabled = true;
            btBorrar.Enabled = false;
            btModificar.Enabled = false;
            btCancelar.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
        }
    }
}
