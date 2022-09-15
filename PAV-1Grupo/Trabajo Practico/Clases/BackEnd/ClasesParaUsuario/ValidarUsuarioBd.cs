using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Trabajo_Practico.Clases.BackEnd
{
    internal class ValidarUsuarioBd
    {
        //Validar el logueo de un usuario, que ya tienen sus datos cargados en la bd.
        public static bool ValidarUsuario(string nombre, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM usuarios U WHERE U.nombre LIKE @nombreUsu AND U.password LIKE @pass";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreusu", nombre);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }






    }
}
