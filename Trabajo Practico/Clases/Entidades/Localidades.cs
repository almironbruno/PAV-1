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
    
    }
}
