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

        /// <summary>
        /// Crea una coneccion
        /// </summary>
        /// <returns>Valor MySqlConenction con los valores de la coneccion</returns>
        public  MySqlConnection estableceConexion()
        {
            this.Conexion = new MySqlConnection(this.cadenaConexion);
            return this.Conexion;
        }


        public bool conectar()
        {
            try
            {
                string conString = "Server=localhost;Database=dbSistema;Uid=kevin;password=1234";
                
                SqlConnection Conexion = new SqlConnection(conString);
                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = "SELECT * FROM empleado"; //sentencia sql
                Comando.Connection = Conexion; //tomamos la coneccion
                Conexion.Open();
                Comando.ExecuteNonQuery();//ejecuta la sentencia
                Conexion.Close();

                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public bool conectarPrueba()
        {
            try
            {
                    MySqlCommand comando = new MySqlCommand();
                     //comando.CommandText = "SELECT * FROM empleado";
                    comando.CommandText = $"INSERT INTO Departamento(departamento) VALUES('ciencias')";
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

          
        


    }
}
