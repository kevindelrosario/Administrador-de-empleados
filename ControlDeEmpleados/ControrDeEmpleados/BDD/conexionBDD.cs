using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; //para que nos agregue inform sql
using MySql.Data.MySqlClient;
using System.Data.SqlClient;// y agrega mas datos
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace ControrDeEmpleados.BDD
{
    class conexionBDD
    {

        private string cadenaConexion = "Server=localhost;Database=dbSistema;Uid=kevin;password=1234";
        MySqlConnection Conexion;

      

        /**CREA LA CONECCION**/
        public  MySqlConnection estableceConexion()
        {
            this.Conexion = new MySqlConnection(this.cadenaConexion);
            return this.Conexion;
        }



        /************metodo: INSERT, DELETE, UPDATE*****************************/
        public bool ejecutarComandoSinRetorno(string strComando)
        {
            try
            {
                    MySqlCommand comando = new MySqlCommand();
                //comando.CommandText = "SELECT * FROM empleado";  muestra
                 //comando.CommandText = $"INSERT INTO Departamento(departamento) VALUES('ciencias')"; agrega

                    comando.CommandText = strComando;
                    comando.Connection = this.estableceConexion();
                    Conexion.Open();
                    comando.ExecuteNonQuery();
                    Conexion.Close();
                   return true;

            }catch(Exception ex)
            {
                return false;
            }
          
    }

          /***********************SELECT (retorna datos)********************************/
        


    }
}
