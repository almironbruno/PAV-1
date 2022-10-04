using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases.Entidades
{
    public class NombresComerciales
    {
        public string nombre_comercial { get; set; }
        public int id_marca { get; set; }
        public  int id_gama { get; set; }

        public NombresComerciales(string nombre_comercial, int id_marca, int id_gama)
        {
            this.nombre_comercial = nombre_comercial;
            this.id_marca = id_marca;
            this.id_gama = id_gama;
        }

        public string mostrar(NombresComerciales nomcom)
        {
            string salida = "Nombre Comercial: " + nomcom.nombre_comercial + " - ID Marca: " + nomcom.id_marca + " - ID Gama: " + nomcom.id_gama +  ".";
            return salida;
        }
    }
}
