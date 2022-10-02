using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases.Entidades
{
    public class Encargos
    {
        public int nroEncargo { get; set; }
        public int tipoDocumento { get; set; }
        public int nroDocumento { get; set; }
        public string fecha { get; set; }
        public int nombreComercial { get; set; }
        public int legajoEmpletado { get; set; }
        public int codCaracteristica { get; set; }
        public int prioridad { get; set; }


        public Encargos(int nroEncargo, int tipoDocumento, int nroDocumento, string fecha, int nombreComercial, int legajoEmpletado, int codCaracteristica, int prioridad)
        {
            this.nroEncargo = nroEncargo;
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
            string s = $"Nro. de encargo: {nroEncargo}" +
                       $" Tipo de documento: {tipoDocumento}" +
                       $" Nro. de documento: {nroDocumento}" +
                       $" Fecha: {fecha}" +
                       $" Nombre comercial: {nombreComercial}" +
                       $" Legajo del empleado: {legajoEmpletado}" +
                       $" Codigo característica: {codCaracteristica}" +
                       $" Prioridad: {prioridad}";
            return s;
        }
    }
}
