using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControrDeEmpleados.BLL
{
     class EmpleadosBLL
    {
        public int ID {  get; set; }
        public string nombreEmpleado { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string correo {  get; set; }
        public byte[] fotoEmpleado { get; set; }
    }
}
