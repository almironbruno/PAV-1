using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases.BackEnd.NegocioProceso
{
    class NE_Proceso
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable ConsultarIdMarca()
        {
            string Consulta = "SELECT marcas.nombre " +
                "FROM autos " +
                "INNER JOIN nombres_comerciales " +
                "On autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial" +
                "INNER JOIN marcas " +
                "on nombres_comerciales.id_marca = marcas.id_marca";
                
            return _BD.Ejecutar_Select(Consulta);

        }




    }
    
}
