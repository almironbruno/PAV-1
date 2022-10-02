using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases.Entidades
{
    public class Barrio
    {

        public string nombre_Barrio { get; set; }

 

        public Barrio(string nombreBarrio)
        {
            nombre_Barrio = nombreBarrio;
            
        }


        public string Mostrar(Barrio bar)
        {
            string salida = "Nombre del nuevo Barrio: " + bar.nombre_Barrio;

            return salida;
        }
    }

    
}
