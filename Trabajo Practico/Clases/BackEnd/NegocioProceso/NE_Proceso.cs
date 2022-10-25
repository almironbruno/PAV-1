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

        public DataTable SelectVehiculoDisponible(int marca, int modelo, int condicion, int gama, int anoFab)
        {
			string consulta = (@"SELECT marcas.nombre,
				nombres_comerciales.nombre_comercial,
				condicion.nombre_condicion,
				gamas.nombre_gama,
				autos.año_fabricacion
                

				FROM autos
			
				INNER JOIN nombres_comerciales
				On autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial
				INNER JOIN marcas on nombres_comerciales.id_marca = marcas.id_marca
				INNER JOIN gamas on nombres_comerciales.id_gama = gamas.id_gama
				INNER JOIN condicion on autos.id_condicion = condicion.id_condicion


				WHERE marcas.id_marca = '"+marca+"' and " +
                "nombres_comerciales.id_nombrecomercial = '"+modelo+"' and  " +
                "condicion.id_condicion = '"+condicion+"' and " +
                "gamas.id_gama = '"+gama+"' and " +
                "autos.año_fabricacion = '"+anoFab+"'");


            try
            {
                DataTable tabla = new DataTable();
                tabla = _BD.Ejecutar_Select(consulta);
                return tabla;
            }
            catch (Exception ex)
            {

                throw;
            }

			


        }




    }
    
}
