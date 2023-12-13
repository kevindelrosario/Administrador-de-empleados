using ControlDeEmpleados.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**agregado***/
using System.Windows.Forms;
using ControlDeEmpleados.BDD;// Agregamos archivos de la carpeta BDD

namespace ControlDeEmpleados.PL
{
    public partial class frmDepartamento : Form
    {

        DepartamentoBDD oDepartamentoBDD;
        public frmDepartamento()
        {
            oDepartamentoBDD = new DepartamentoBDD();
            InitializeComponent();
            //Hacemos que se llame desde el inicio para que muestre los datos
            llenarGrilla();
            limpiarEntradas(); //para limpiar todo cuando empiece


        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            //Instruccion GUI
          //  recuperarInformacion();
        
            conexionBDD conexion = new conexionBDD();
          //  MessageBox.Show("conectado ..");//aqui entra la sentencia sql con la que actua la funcion

            //Clase BDD Deaprtamento... Objeto que tiene la informacion de la GUI
            oDepartamentoBDD.Agregar(recuperarInformacion());
            llenarGrilla();
            limpiarEntradas();
        }





        /***************************METODOS**********************************/
        private DepartamentoBLL recuperarInformacion()
        {
            DepartamentoBLL oDepartamentoBLL = new DepartamentoBLL();
            
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oDepartamentoBLL.ID = ID;
            oDepartamentoBLL.Departamento = txtNombreDep.Text;

            //Envia los valores que tiene de la interfaz de frmDepartamento
            return oDepartamentoBLL;

        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            //mostrar los datos de dataGri en los respectivos cuadros de textos
            int indice = e.RowIndex;

            grilla.ClearSelection(); //limpiamos
            if (indice >= 0) //para evitar los errores con los espacios vacios.
            {
                txtID.Text = grilla.Rows[indice].Cells[0].Value.ToString();//Toma el valor de la posicion 1 en este caso 0 del grilla
                txtNombreDep.Text = grilla.Rows[indice].Cells[1].Value.ToString();//Toma el valor de la posicion 2 en este caso 1 del grilla

                //El boton agregar se desactivara para que solo pueda modificar algo cuando seleccione algun elemento
                btAgregar.Enabled = false;
                btBorrar.Enabled = true;
                btModificar.Enabled = true;
                btCancelar.Enabled = true;

            }

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            oDepartamentoBDD.Eliminar(recuperarInformacion()); //el metodo recuperar nos da los valores de la interfaz
            llenarGrilla();
            limpiarEntradas();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            oDepartamentoBDD.Modificar(recuperarInformacion());
            llenarGrilla();
            limpiarEntradas();
        }


        public void llenarGrilla()
        {
            grilla.DataSource = oDepartamentoBDD.MostrarDepartamentos().Tables[0];//se meten los datos encontrados y los muestra
        }


        public void limpiarEntradas()
        {

            txtID.Text = " ";
            txtNombreDep.Text = " ";
            txtID.Enabled = false;
            btAgregar.Enabled = true;
            btBorrar.Enabled = false;
            btModificar.Enabled = false;
            btCancelar.Enabled = false;
        }

    }
}
