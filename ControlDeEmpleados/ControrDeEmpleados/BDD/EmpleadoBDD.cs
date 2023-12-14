using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/***agregado***/
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using ControlDeEmpleados.BLL;
using ControlDeEmpleados.BDD;

namespace ControlDeEmpleados.BDD
{
    class EmpleadoBDD
    {
        conexionBDD conexion = new conexionBDD();
        public EmpleadoBDD()
        {
            conexion = new conexionBDD();
        }
    
        public bool Agregar(EmpleadosBLL oEmpleadoBLL)
        {

            /*No funciona*/
            return conexion.ejecutarComandoSinRetorno($"INSERT INTO Empleado(nombre,primerApellido,segundoApellido,correo) " +
                $"VALUES('" + oEmpleadoBLL.nombreEmpleado+"'," +"'"+oEmpleadoBLL.primerApellido+ "'," + "'" 
                + oEmpleadoBLL.segundoApellido + "'," + "'" + oEmpleadoBLL.correo+ "')");
            //insert into Empleado (nombre, primerApellido, segundoApellido,correo)
            //values('kevin', 'montero', 'del Rosario', 'kevinfmdelrosario@gmail.com');
        }



        public int Eliminar(EmpleadosBLL oEmpleadoBLL)
        {

            conexion.ejecutarComandoSinRetorno($"DELETE FROM Empleado WHERE idEmpleado=" + oEmpleadoBLL.ID);
            return 1;
        }

        public int Modificar(EmpleadosBLL oEmpleadoBLL)
        {

            conexion.ejecutarComandoSinRetorno($"UPDATE Empleado SET nombre ='" + oEmpleadoBLL.nombreEmpleado + "',"+"primerApellido = '" + oEmpleadoBLL.primerApellido + "',"
              + "segundoApellido = '" + oEmpleadoBLL.segundoApellido + "'," + "correo = '" + oEmpleadoBLL.correo + "'"
              + "  WHERE idEmpleado=" + oEmpleadoBLL.ID);
            return 1;

        }



        public DataSet MostrarEmpleados()
        {
            MySqlCommand sentencia = new MySqlCommand("SELECT * FROM Empleado");
            return conexion.EjecutarSentencia(sentencia);

        }

   


    }
}
