using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Clases.BackEnd.NegocioEncargos
{
    internal class NE_Encargos
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();


        public void agregarEncargo(Encargos encargoAgregar)
        {
            string sqlInsertar = $@"INSERT INTO encargos(nro_encargo, tipo_doc_cliente,nro_doc_cliente, fecha, id_nombreComercial, legajo_empleado, cod_caracteristica, prioridad) VALUES ({encargoAgregar.nroEncargo}, {encargoAgregar.tipoDocumento}, {encargoAgregar.nroEncargo}, 'CONVERT(DATE, '{encargoAgregar.fecha}',103)', {encargoAgregar.nombreComercial}, {encargoAgregar.legajoEmpletado}, {encargoAgregar.codCaracteristica},{encargoAgregar.prioridad})";
            _BD.ejecutar(sqlInsertar);
        }


    }
}
