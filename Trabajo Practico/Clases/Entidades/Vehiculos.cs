using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico.Clases.BackEnd.NegocioAutos;

namespace Trabajo_Practico.Clases.Entidades
{
    public class Vehiculos
    {
        public string cod_serie_fabrica { get; set; }

        public int nombreComercial { get; set; }

        public string año_Fabricacion { get; set; }

        public int condicion { get; set; }   

        public string nro_Chasis { get; set; } 

        public string nro_Motor { get; set; }  

        public string patente { get; set; }

        public Vehiculos(string cod_serie_fabrica, int nombreComercial, string año_Fabricacion, int condicion, string nro_Chasis, string nro_Motor, string patente)
        {
            this.cod_serie_fabrica = cod_serie_fabrica;
            this.nombreComercial = nombreComercial;
            this.año_Fabricacion = año_Fabricacion;
            this.condicion = condicion;
            this.nro_Chasis = nro_Chasis;
            this.nro_Motor = nro_Motor;
            this.patente = patente;
        }

        public string mostrar(Vehiculos vehi)
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
        
    }

    
}
