using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases.Entidades
{
    public class Clientes
    {
        public int tipo_doc {  set; get; }
        public int nro_doc {  set; get; }
        public string nombre {  set; get; }
        public string apellido {  set; get; }
        public string fecha_nacimiento {  set; get; }
        public string calle {  set; get; }
        public int nro_calle {  set; get; }
        public int id_barrio {  set; get; }


        public Clientes(int tipo_docu,int nro_docu,string nom,string ape,string fechNac,string unaCalle,int nro_Call,int barrio) 
        { 
            tipo_doc = tipo_docu;
            nro_doc = nro_docu;
            nombre = nom;
            apellido = ape;
            fecha_nacimiento = fechNac;
            calle = unaCalle;
            nro_calle = nro_Call;
            id_barrio = barrio;

        }
        public string toString() 
        {
            string s=$@"Tipo Documento: {tipo_doc}
                        Nro. Documento: {nro_doc}
                        Nombre: {nombre}
                        Apellido: {apellido}
                        Fecha de Nacimiento: {fecha_nacimiento}
                        Calle: {calle}
                        Nro_Calle: {nro_calle}
                        Barrio: {id_barrio}";
                        
            return s;
        }

    }
}