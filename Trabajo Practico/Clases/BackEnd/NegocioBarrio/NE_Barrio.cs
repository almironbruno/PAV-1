using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Trabajo_Practico.Clases;
using System.Windows.Forms;
using Trabajo_Practico.Clases.Entidades;
using System.Xml.Serialization;

namespace Trabajo_Practico.Clases.BackEnd.NegocioBarrio
{
    class NE_Barrio
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos(); 

        public void AgregarBarrio(Barrio barrioAgregar)
        {
            string sqlInsertar = @"INSERT into barrios"
                                  +"(nombre_barrio)"
                                  +"VALUES('" + barrioAgregar.nombre_Barrio + "')";



            //INSERTAR a traves de la funcion del BackEnd.
            _BD.Insertar(sqlInsertar);
        }

        public void BorrarBarrio(string nombreBarrio)
        {
            string sqlBorrar = "DELETE FROM barrios WHERE nombre_barrio = '" + nombreBarrio + "' ";
            _BD.Eliminar(sqlBorrar);
        }

        public void ModificarBarrio(Barrio modificarBarrio, string pk)
        {
            string sqlInsertar = $"UPDATE barrios SET nombre_barrio = '{modificarBarrio.nombre_Barrio}' WHERE Id_barrios = {pk}";
            _BD.Insertar(sqlInsertar);
        }
    }
}
