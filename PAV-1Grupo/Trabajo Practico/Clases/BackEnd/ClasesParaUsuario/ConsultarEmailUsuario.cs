using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Trabajo_Practico.Clases.BackEnd
{
    internal class ConsultarEmailUsuario
    {
        //Consultar si el email ingresado, ya esta asociado a algun usuario de la bd.
        public static bool consultarCorreo(string email)
        {
           bool resultado = false;

           string cadenaDeConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

           SqlConnection cn = new SqlConnection(cadenaDeConexion);

            
           SqlCommand cmd = new SqlCommand();

           string consulta = "SELECT * FROM usuarios U WHERE U.email LIKE @email";

           cmd.Parameters.Clear();
           cmd.Parameters.AddWithValue("@email", email);

           cmd.CommandType = CommandType.Text;
           cmd.CommandText = consulta;

           cn.Open();

           cmd.Connection = cn;

           DataTable tabla = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(tabla);

           if (tabla.Rows.Count == 1)
           {
                    resultado = true;   
           }
           else
           {
                    resultado = false;
           }
 
            return resultado;
        }
    }
}
