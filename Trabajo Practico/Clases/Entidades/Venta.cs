using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases.Entidades
{
    class Venta
    {
        
        public int legajo { get; set; }
        public int num_dni { get; set; }
        public string fecha { get; set; }
        public int tipo_doc { get; set; }

   
        public Venta(int legajo, int num_dni, string fecha, int tipo_doc)
        {
            this.legajo = legajo;
            this.num_dni = num_dni;
            this.fecha = fecha;
            this.tipo_doc = tipo_doc;
        }

        public Venta()
        {

        }
    }

   
}
