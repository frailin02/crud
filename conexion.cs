using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    internal class conexion
    {
        public static MySqlConnection conexionn()
        {
            string servidor = "localhost:3306";
            string bd = "sakila";
            string usuario = "root";
            string password = "password";
            string cadenaConexion = "Database="+bd +";Data source="+servidor+"; User Id="+ usuario+";password="+password+"" ;

            try
            {
                MySqlConnection conexionbd = new MySqlConnection
                (cadenaConexion);
                return conexionbd;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
                throw;
            }
        }
    }
}
