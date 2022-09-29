using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases.Entidades
{
    public class Empleados
    {

        public int legajoEmpleado { set; get; }
        public string nombre { set;  get; }
        public string apellido { set;  get; }
        public int cargo { set;  get; }


        public Empleados(int legajo,string nom, string ape,int carg)
        {
            legajoEmpleado= legajo;
            nombre=nom;
            apellido=ape;
            cargo=carg;
        }

        public string toString(Empleados e) 
        {
            string s = $@" Legajo: {legajoEmpleado} 
                        Nombre: {nombre}
                        Apellido: {apellido}
                        cargo:{cargo}";
            return s;
        }
    }
}
