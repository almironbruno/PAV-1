using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases.Entidades
{
    internal class Telefono
    {
        public string nroTelefono { get; set; }    

        public string nroCaracteristica { get; set; }  

        public string tipoDocCliente { get; set; }

        public string nroDocCliente { get; set; }

        public Telefono(string nro_Telefono, string nro_Caracteristica, string tipo_doc_Cliente, string nro_doc_Cliente)
        {
            nroTelefono = nro_Telefono;
            nroCaracteristica = nro_Caracteristica;
            tipoDocCliente = tipo_doc_Cliente;
            nroDocCliente = nro_doc_Cliente;
        }
    }
}
