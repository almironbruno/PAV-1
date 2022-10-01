using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico.Clases.BackEnd.NegocioLocalidades;

namespace Trabajo_Practico.Clases.Entidades
{
    public class Localidades
    {
        public string nombreLocalidad { get; set; }

        public Localidades(string _nombreLocalidad)
        {
            nombreLocalidad = _nombreLocalidad;
        }

        public string toString()
        {
            string s = $"Nombre de localidad: {nombreLocalidad}";
            return s;
        }
        //public string mostrar(Localidades localidad)
        //{
        //    NE_Localidades negoLocalidad = new NE_Localidades();

        //    DataTable tablaConi = new DataTable();
        //    DataTable tablaComer = new DataTable();

        //}


        /*
         *  public string mostrar(Vehiculos vehi)
        {

            NE_Autos negoAutos = new NE_Autos();

            DataTable tablaCondi = new DataTable();
            DataTable tablaComer = new DataTable();
            
            //Tabla donde se cargaria la fila que contendria el string equivalente al id Condicion
            tablaCondi = negoAutos.ConsultarNombreCondicionString(condicion);

            //Tabla donde se cargaria la fila que contendria el string equivalente al id nombreComercial
            tablaComer = negoAutos.ConsultarNombreComercialString(nombreComercial);

            string condi = "";
            string comer = "";

            if (tablaCondi.Rows.Count > 0)
            {
                //Nombre de condicion
                 condi = tablaCondi.Rows[0]["nombre_condicion"].ToString();
            }
            else
            {
                condi = "Error";
            }

            if (tablaComer.Rows.Count > 0)
            {
                //Nombre Comercial
                 comer = tablaComer.Rows[0]["nombre_comercial"].ToString();

            }
            else
            {
                comer = "Error";
            }
            
            //Salida completa de los datos del auto
            string salida = "Cod.Serie: " + vehi.cod_serie_fabrica + " - Nom.Comercial: " + comer + " - Año.Fab: " + vehi.año_Fabricacion +
                " - Condicion: " + condi + " - Nro.Chas: " + vehi.nro_Chasis + " - Nro.Motor: " + vehi.nro_Motor + " - Patente: " + vehi.patente + ".";
            
            return salida;
        }
         */

    }
}
