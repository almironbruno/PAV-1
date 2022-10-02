using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Clases.BackEnd.NegocioMarcas
{
    internal class NE_Marcas
    {

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void AgregarMarca(Marca marca)
        {
            string sqlInsertar = "INSERT INTO marcas(nombre) SELECT '" + marca.nombreMarca + "' WHERE NOT EXISTS(SELECT 1 FROM marcas WHERE nombre = '" + marca.nombreMarca + "')";


            _BD.Insertar(sqlInsertar);
        }

        public void BorrarMarca(string nombre)
        {
            try
            {
                string sqlBorrar = "DELETE FROM marcas WHERE nombre = '" + nombre + "'";
                _BD.Eliminar(sqlBorrar);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puede eliminar una marca en uso por algun vehiculo del registro.");
                
            }
            
        }

        public void ModificarMarca(Marca marcaMod, string nombreViejo)
        {
            string sqlInsertar = "UPDATE marcas SET nombre = '" + marcaMod.nombreMarca + "' WHERE nombre = '" + nombreViejo + "'";
            _BD.modificar(sqlInsertar);
        }


        public DataTable BuscarMarcaId(int idMarca)
        {
            string sqlBuscar = "SELECT * FROM marcas WHERE id_marca = '" + idMarca + "'";
            return _BD.Ejecutar_Select(sqlBuscar);
       
        }


        public DataTable BuscarMarcaNombre(string nombre_marca)
        {
            string sqlBuscar = "SELECT * FROM marcas WHERE nombre = '" + nombre_marca + "'";
            return _BD.Ejecutar_Select(sqlBuscar);

        }

        public DataTable BuscarDobleCriterio(string nombre, int id)
        {
            string sqlBuscar = "SELECT * FROM marcas WHERE nombre = '" + nombre + "' AND id_marca = '" + id + "'";
            return (_BD.Ejecutar_Select(sqlBuscar));
        }

    }
}
