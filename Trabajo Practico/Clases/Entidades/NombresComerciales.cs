using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico.Clases.BackEnd.NegocioNombreComercial;
using Trabajo_Practico.Formularios.ABMC;

namespace Trabajo_Practico.Clases.Entidades
{
    public class NombresComerciales
    {
        public string nombre_comercial { get; set; }
        public int marca { get; set; }
        public  int gama { get; set; }

        public NombresComerciales(string nombre_comercial, int marca, int gama)
        {
            this.nombre_comercial = nombre_comercial;
            this.marca = marca;
            this.gama = gama;
        }

        public string mostrar(NombresComerciales nomcom)
        {
            string salida = "Nombre Comercial: " + nomcom.nombre_comercial + " - ID Marca: " + nomcom.marca + " - ID Gama: " + nomcom.gama +  ".";
            return salida;
        }
    }
}
