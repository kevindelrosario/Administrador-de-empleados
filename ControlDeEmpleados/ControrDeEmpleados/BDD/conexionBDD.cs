using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; //para que nos agregue inform sql
using MySql.Data.MySqlClient;
using System.Data.SqlClient;// y agrega mas datos
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace ControlDeEmpleados.BDD
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

            }catch
            {
                return false;
            }
          
    }

        //sobreCarga metodo: INSERT, DELETE, UPDATE (mejoras a futuro)

        public bool ejecutarComandoSinRetorno(MySqlCommand MySqlComando)
        {
            try
            {
                MySqlCommand comando = MySqlComando;
                comando.Connection = this.estableceConexion();
                Conexion.Open();
                comando.ExecuteNonQuery();
                Conexion.Close();
                return true;

            }
            catch
            {
                return false;
            }

        }

        /***********************SELECT (retorna datos)********************************/

        public DataSet EjecutarSentencia(MySqlCommand sqlComando)
        {
            //Para adaptar la informacion
            DataSet DS = new DataSet();
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();

            try
            {
                MySqlCommand comando = new MySqlCommand(); //para obtener el comando sql
                comando = sqlComando; //aqui tomamos ese comando
                comando.Connection = estableceConexion(); // establecemos la coneccion

                Adaptador.SelectCommand = comando; //adaptamos el comando
                Conexion.Open(); //abrimos coneccion
                Adaptador.Fill(DS);//llenamos el adaptador
                Conexion.Close(); //cerramos coneccion
                return DS; //retorno los datos
            }catch
            {
                return DS;
            }

        }

       

        }

    }

