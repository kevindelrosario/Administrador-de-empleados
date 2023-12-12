using ControrDeEmpleados.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControrDeEmpleados.BDD; // Agregamos archivos de la carpeta BDD

namespace ControrDeEmpleados.PL
{
    public partial class frmDepartamento : Form
    {
        public frmDepartamento()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            //Instruccion GUI
            recuperarInformacion();
        
            conexionBDD conexion = new conexionBDD();
            MessageBox.Show("conectado .." + conexion.conectar());

        }

        private void recuperarInformacion()
        {
            DepartamentoBLL oDepartamento = new DepartamentoBLL();
            
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oDepartamento.ID = ID;
            oDepartamento.Departamento = txtNombreDep.Text;

            //obteniendo los datos funciona

           // MessageBox.Show(oDepartamento.ID.ToString());
            //MessageBox.Show(oDepartamento.Departamento.ToString());


        }



    }
}
