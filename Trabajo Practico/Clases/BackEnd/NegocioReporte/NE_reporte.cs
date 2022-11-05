using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Trabajo_Practico.Clases.BackEnd.NegocioReporte
{
    internal class NE_reporte
    {
        private BE_Acceso_Datos bd = new BE_Acceso_Datos();
        public NE_reporte() 
        {
             
        
        }

        public DataTable cargarReporte(string sql) 
        {
            DataTable dataTable = new DataTable();
            dataTable = bd.Ejecutar_Select(sql); 
            return dataTable;
        }

    }
}
