using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Clases.BackEnd.NegocioLocalidades
{
    internal class NE_Localidades
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void agregarLocalidad(Localidades localidad)
        {
            string sqlInsertar = "INSERT INTO localidades (nombre_localidad) SELECT '" + localidad.nombreLocalidad.ToUpper().Trim() + "' WHERE NOT EXISTS(SELECT 1 FROM localidades WHERE nombre_localidad = '" + localidad.nombreLocalidad.ToUpper().Trim() + "')";
            _BD.Insertar(sqlInsertar);

            
        }

        public void modificarLocalidad(Localidades localidad, string antLocalidad)
        {
            string sqlModificado = $"UPDATE localidades SET nombre_localidad = '{localidad.nombreLocalidad}' WHERE nombre_localidad = '{antLocalidad}'";
            _BD.modificar(sqlModificado);
        }
        public DataTable buscarLocalidad(string nombreLocalidad)
        {
            string sqlConsulta = $"SELECT * FROM localidades WHERE nombre_localidad = '{nombreLocalidad}'";
            return _BD.Ejecutar_Select(sqlConsulta);
        }

        public void borrarLocalidad(string localidad)
        {
            string sqlBorrar = $"DELETE FROM localidades WHERE nombre_localidad = '{localidad}'";
            _BD.Eliminar(sqlBorrar);
        }
    }
}