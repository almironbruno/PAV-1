using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Clases.Entidades
{
    public class Marca
    {
        public string nombreMarca { get; set; }

        public Marca(string nombreMarca)
        {
            this.nombreMarca = nombreMarca;
        }

        public string mostrar(Marca marc)
        {
            string salida = "Marca Vehicular: " + marc.nombreMarca + ".";
            return salida;
        }
    }
}
