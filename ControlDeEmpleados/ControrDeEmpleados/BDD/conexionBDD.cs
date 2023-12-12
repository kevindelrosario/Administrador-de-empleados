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

        public bool conectar()
        {
            try
            {
                string conString = "Server=localhost; Database=dbSistema; User=kevin; Password=1234;";
                
                SqlConnection Conexion = new SqlConnection(conString);
                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = "SELECT * FROM Empleado"; //sentencia sql
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


            string conString = "server=localhost; database=dbSistema; user=kevin; password=1234;";
               // public MySqlConnection conectar = new MySqlConnection();

                 MySqlDataAdapter adaptador = new MySqlDataAdapter();

            return true;
    }

          
        


    }
}
