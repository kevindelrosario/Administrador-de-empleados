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
     class DepartamentoBDD
    {

        conexionBDD conexion = new conexionBDD();
        public DepartamentoBDD() { 
        conexion = new conexionBDD();
        }

        public bool Agregar(DepartamentoBLL oDepartamentoBLL)
        {

          //  MySqlCommand MYSQLComando = new MySqlCommand($"INSERT INTO Departamento VALUES(@Departamento)");

        //    MYSQLComando.Parameters.Add("@Departamento",MySqlDbType.VarChar).Value=oDepartamentoBLL.Departamento;
        //    return conexion.ejecutarComandoSinRetorno(MYSQLComando);


           return conexion.ejecutarComandoSinRetorno($"INSERT INTO Departamento(departamento) VALUES('"+ oDepartamentoBLL.Departamento+"')");
        }


        public int Eliminar(DepartamentoBLL oDepartamentoBLL)
        {

            conexion.ejecutarComandoSinRetorno($"DELETE FROM Departamento WHERE idDepartamento=" + oDepartamentoBLL.ID);
            return 1;

        }

        public int Modificar(DepartamentoBLL oDepartamentoBLL)
        {

            conexion.ejecutarComandoSinRetorno($"UPDATE Departamento SET departamento ='"+ oDepartamentoBLL.Departamento+ "' "
                +"  WHERE idDepartamento=" + oDepartamentoBLL.ID);
            return 1;

        }


        public DataSet MostrarDepartamentos()
        {
            MySqlCommand sentencia = new MySqlCommand("SELECT * FROM Departamento");
            return conexion.EjecutarSentencia(sentencia);

        }




    }
}
