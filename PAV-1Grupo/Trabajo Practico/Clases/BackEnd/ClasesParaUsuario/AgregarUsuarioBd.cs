using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trabajo_Practico.Clases.BackEnd
{
    internal class AgregarUsuarioBd
    {
        public static bool InsertarUsuario(string nombreUsuario, string apellidoUsuario,string password, string emailUsuario)
        {
            //recuperar cadena de conexion (usando string cadenaConexion que hicimos arriba)
            // Agregaremos en las referencias del proyecto, la de System.Configuration
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            //Objeto conexion con la cadena de conexion asignada 
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool resultado = false;

            try
            {
                //Objeto Sql
                SqlCommand cmd = new SqlCommand();
                //Consulta con parametros, el primer parentesis son columnas y el segundo los parametros
                string consulta = "INSERT INTO usuarios (nombre, apellido, password, email) VALUES(@nombreUsu, @apellido, @pass, @email)";


                //Limpiar parametros que pueda haber
                cmd.Parameters.Clear();

                //Pasar los parametros de la consulta a las variables
                cmd.Parameters.AddWithValue("@nombreUsu", nombreUsuario);
                cmd.Parameters.AddWithValue("@apellido", apellidoUsuario);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@email", emailUsuario);


                //Definir tipo de comando Texto
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                //Abrir la conexion
                cn.Open();
                cmd.Connection = cn;

                //Sirve para hacer un insert sin tener resultados de respuesta si fue exitoso
                cmd.ExecuteNonQuery();

                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }




            return resultado;
        }
    }
}
