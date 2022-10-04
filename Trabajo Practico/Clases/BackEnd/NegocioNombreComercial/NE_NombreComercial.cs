using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Clases.BackEnd.NegocioNombreComercial
{
    class NE_NombreComercial
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public void AgregarNombreComercial(NombresComerciales nombrecomercial)
        {
            string sqlInsertar = @"INSERT INTO nombres_comerciales"
                                 + "(nombre_comercial, id_marca, id_gama)"
                                 + "VALUES('"
                                 + nombrecomercial.nombre_comercial + "'"
                                 + ", '" + nombrecomercial.id_marca + "'"
                                 + ", '" + nombrecomercial.id_gama + "')";
                                

            _BD.Insertar(sqlInsertar);
        }

        public void BorrarNombreComercial(string nombre_comercial)
        {
            string sqlBorrar = "DELETE FROM nombres_comerciales WHERE nombre_comercial = '" + nombre_comercial + "'";
            _BD.Eliminar(sqlBorrar);
        }
    }
}
