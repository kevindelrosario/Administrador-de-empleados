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


namespace ControlDeEmpleados.PL
{
    public partial class frmEmpleados : Form
    {

        byte[] imagenByte;

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            DepartamentoBDD objDepartamento = new DepartamentoBDD(); //creamos objecto de la clase Depart para usar sus funciones

            comboDepartamento.DataSource = objDepartamento.MostrarDepartamentos().Tables[0];//tomamos la informacion que da esta funcion
            comboDepartamento.DisplayMember = "departamento"; //indicamos que valor queremos obtener
            comboDepartamento.ValueMember = "idDepartamento";


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



    }
}
