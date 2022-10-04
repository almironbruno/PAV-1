using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases.Entidades
{
    public class Encargos
    {
        public int tipoDocumento { get; set; }
        public int nroDocumento { get; set; }
        public string fecha { get; set; }
        public int nombreComercial { get; set; }
        public int legajoEmpletado { get; set; }
        public int codCaracteristica { get; set; }
        public string prioridad { get; set; }


        public Encargos(int tipoDocumento, int nroDocumento, string fecha, int nombreComercial, int legajoEmpletado, int codCaracteristica, string prioridad)
        {
            this.tipoDocumento = tipoDocumento;
            this.nroDocumento = nroDocumento;
            this.fecha = fecha;
            this.nombreComercial = nombreComercial;
            this.legajoEmpletado = legajoEmpletado;
            this.codCaracteristica = codCaracteristica;
            this.prioridad = prioridad;
        }

        public string toString()
        {
            string s = $" Tipo de documento: {tipoDocumento}\n" +
                       $" Nro. de documento: {nroDocumento}\n" +
                       $" Fecha: {fecha}\n" +
                       $" Nombre comercial: {nombreComercial} \n" +
                       $" Legajo del empleado: {legajoEmpletado} \n" +
                       $" Codigo característica: {codCaracteristica} \n" +
                       $" Prioridad: {prioridad} \n";                       
            return s;
        }

    }
}
