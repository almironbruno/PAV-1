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


        //recibe el valor de string condicion, y devuelve la pk para poder relacionarlo , el objeto lo trabaja como int.
        public int ConsultarCondicion(string condicion)
        {
            int rta = 0;
            string Consulta = "SELECT id_condicion FROM condicion WHERE nombre_condicion = '"+condicion+"'";
            if (_BD.SelectNumeros(Consulta) > 0)
            {
                rta = _BD.SelectNumeros(Consulta);
            }
            else
            {
                rta = 0;
            }
            return rta;
            
        }

        //recibe el valor de string nombre_comercial, y devuelve la pk para poder relacionarlo , el objeto lo trabaja como int.
        public int ConsultarNombreComer(string nombreComercial)
        {
            int rta = 0;
            string Consulta = "SELECT id_nombrecomercial FROM nombres_comerciales WHERE nombre_comercial = '" + nombreComercial + "'";
            if (_BD.SelectNumeros(Consulta) > 0)
            {
                rta = _BD.SelectNumeros(Consulta);
            }
            else
            {
                rta = 0;
            }
            return rta;

        }
        //Recibe un id condicion y devuelve el nombre correspondiente
        public DataTable ConsultarNombreCondicionString(int id_condicion)
        {
            string Consulta = "SELECT nombre_condicion  FROM condicion WHERE id_condicion = '"+id_condicion+"'";
            return _BD.Ejecutar_Select(Consulta);
            

            

        }
        //recibe un id comercial y devuelve el nombre correspondiente
        public DataTable ConsultarNombreComercialString(int id_nombreComercial)
        {
            string Consulta = "SELECT nombre_comercial  FROM nombres_comerciales WHERE id_nombrecomercial = '" + id_nombreComercial + "'";
            
            return _BD.Ejecutar_Select(Consulta);
            
        }





        public void BorrarAuto(string patente)
        {
            string sqlBorrar = "DELETE FROM autos WHERE patente = '"+ patente +"'";
            _BD.Eliminar(sqlBorrar);
        }



        //Relacionar el auto modificado , con algun dato que sirva como antecedente para vincularlo, en este caso la patente vieja.
        public void ModificarAuto(Vehiculos autoMod,string patentevieja)
        {
            string sqlInsertar = $"UPDATE autos SET cod_serie_fabrica = '"+autoMod.cod_serie_fabrica+"', id_nombrecomercial = '"+autoMod.nombreComercial+"', año_fabricacion = '"+autoMod.año_Fabricacion+"' " +
                $", id_condicion = '"+autoMod.condicion+"', nro_chasis = '"+autoMod.nro_Chasis+"', nro_motor ='"+autoMod.nro_Motor+"' , patente = '"+autoMod.patente+"' " +
                $" WHERE patente = '"+patentevieja+"' ";
            _BD.modificar(sqlInsertar);
        }

       

        //Buscar auto a travez de un codigo de Serie.
        public DataTable BuscarAutoCodSerie(string codigoPk)
        {
            

            string consulta = "SELECT *  FROM autos WHERE cod_serie_fabrica = '"+codigoPk+"'";

            return _BD.Ejecutar_Select(consulta);

        }

        public DataTable BuscarAutoPatente(string patente)
        {


            string consulta = "SELECT *  FROM autos WHERE patente = '" + patente + "'";

            return _BD.Ejecutar_Select(consulta);

        }

        public DataTable BuscarDobleCriterio(string patente, string id)
        {


            string consulta = "SELECT * FROM autos WHERE cod_serie_fabrica = '"+id+"' AND patente = '"+patente+"'";

            return _BD.Ejecutar_Select(consulta);

        }





    }
}
