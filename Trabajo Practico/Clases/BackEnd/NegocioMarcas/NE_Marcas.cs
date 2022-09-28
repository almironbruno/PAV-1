using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico.Clases.BackEnd;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Clases.BackEnd.NegocioMarcas
{
    internal class NE_Marcas
    {

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void AgregarMarca(Marca marca)
        {
            string sqlInsertar = "INSERT INTO marcas(nombre) SELECT '"+marca.nombreMarca+"' WHERE NOT EXISTS(SELECT 1 FROM marcas WHERE nombre = '"+marca.nombreMarca+"')";
            
        
            _BD.Insertar(sqlInsertar);
        }

        public void BorrarMarca(string nombre)
        {
            string sqlBorrar = "DELETE FROM marcas WHERE nombre = '" + nombre + "'";
            _BD.Eliminar(sqlBorrar);
        }

        public void ModificarMarca(Marca marcaMod, string nombreViejo)
        {
            string sqlInsertar = "UPDATE marcas SET nombre = '"+marcaMod.nombreMarca+"' WHERE nombre = '"+nombreViejo+"'";
            _BD.modificar(sqlInsertar);
        }


    }
}
