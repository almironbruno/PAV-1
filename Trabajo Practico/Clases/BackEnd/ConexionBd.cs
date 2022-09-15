using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace Trabajo_Practico.Clases.BackEnd
{
    class ConexionBd
    {
        string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

        SqlCommand cmd = new SqlCommand();
        SqlConnection cn = new SqlConnection();
        DataTable tabla = new DataTable();
    }

    private void Conectar()
    {
        
    }
    
}
