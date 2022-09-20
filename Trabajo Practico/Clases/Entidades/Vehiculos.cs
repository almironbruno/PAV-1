using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases.Entidades
{
    public class Vehiculos
    {
        public string cod_serie_fabrica { get; set; }

        public string nombreComercial { get; set; }

        public int año_Fabricacion { get; set; }

        public string condicion { get; set; }   

        public int nro_Chasis { get; set; } 

        public int nro_Motor { get; set; }  

        public string patente { get; set; }

        public Vehiculos(string cod_serie_fabrica, string nombreComercial, int año_Fabricacion, string condicion, int nro_Chasis, int nro_Motor, string patente)
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
            string salida = "Cod.Serie: " + vehi.cod_serie_fabrica + " - Nom.Comercial: " + vehi.nombreComercial + " - Año.Fab: " + vehi.año_Fabricacion +
                " - Condicion: " + vehi.condicion + " - Nro.Chas: " + vehi.nro_Chasis + " - Nro.Motor: " + vehi.nro_Motor + " - Patente: " + vehi.patente + ".";
            return salida;
        }
    }

    
}
