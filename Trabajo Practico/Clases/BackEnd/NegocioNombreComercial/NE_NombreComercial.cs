using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Clases.BackEnd.NegocioNombreComercial
{
    internal class NE_NombreComercial
    {

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();


        public void AgregarNombreComercial(NombresComerciales nombrecomercialAgregar)
        {
            string sqlInsertar = $"INSERT INTO nombres_comerciales" + "(nombre_comercial, id_marca, id_gama)"
                                 + " VALUES(' "
                                 + nombrecomercialAgregar.nombre_comercial + "'"
                                 + ", '" + nombrecomercialAgregar.marca + "'"
                                 + ", '" + nombrecomercialAgregar.gama + "')";

            _BD.ejecutar(sqlInsertar);
        }


        public void BorrarNombreComercial(string nom)
        {

            string sqlBorrar = "DELETE FROM nombres_comerciales WHERE nombre_comercial = '" + nom + "'";
            _BD.Eliminar(sqlBorrar);
        }


        public void ModificarNombreComercial(NombresComerciales nomcomMod, string nombreViejo)
        {                
        }

        public string consultaNomCom(string nomcom, string marc, string gam)
        {

            string sqlConsulta = $@"SELECT * FROM nombres_comeciales WHERE
                                 nombre_comercial LIKE '{nomcom}'
                                 AND id_marca LIKE '{marc}' AND
                                 id_gama LIKE '{gam}'";

            return sqlConsulta;
        }
    }
}

    

