using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Trabajo_Practico.Clases;
using System.Windows.Forms;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Clases.BackEnd.NegocioAutos
{
    class NE_Autos
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void AgregarAuto(Vehiculos autoAgregar)
        {

            string sqlInsertar = @"INSERT INTO autos"
                                 + "(cod_serie_fabrica, id_nombrecomercial, año_fabricacion, id_condicion, nro_chasis, nro_motor, patente)"
                                 + "VALUES('"
                                 + autoAgregar.cod_serie_fabrica + "'"
                                 + ", '" + autoAgregar.nombreComercial + "'"
                                 + ", '" + autoAgregar.año_Fabricacion + "'"
                                 + ", '" + autoAgregar.condicion + "'"
                                 + ", '" + autoAgregar.nro_Chasis + "'"
                                 + ", '" + autoAgregar.nro_Motor + "'"
                                 + ", '" + autoAgregar.patente+ "')";

            //Insertar A Travez de la funcion de BackEnd

            _BD.Insertar(sqlInsertar);


        }


        public void BorrarAuto(string patente)
        {
            string sqlBorrar = "DELETE FROM autos WHERE patente = '"+ patente +"'";
            _BD.Eliminar(sqlBorrar);
        }
    }
}
