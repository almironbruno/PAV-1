using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases.Entidades
{
    internal class Empleados
    {

        private int legajoEmpleado { set; get; }
        private string nombre;
        private string apellido;
        private int cargo;


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
