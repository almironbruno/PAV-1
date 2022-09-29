using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases.Entidades
{
    public class Barrio
    {
        public string nombreBarrio { get; set; }

        

        public Barrio(string nombreBarrio)
        {
            this.nombreBarrio = nombreBarrio;
            
        }

        public string Mostrar(Barrio bar)
        {
            string salida = "Nombre del nuevo Barrio: " + bar.nombreBarrio;

            return salida;
        }
    }

    
}
