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
            string sqlInsertar = $@"INSERT INTO encargos VALUES ({encargoAgregar.tipoDocumento}, {encargoAgregar.nroDocumento}, CONVERT(DATE, '{encargoAgregar.fecha}',103), {encargoAgregar.nombreComercial}, {encargoAgregar.legajoEmpletado}, {encargoAgregar.codCaracteristica},{encargoAgregar.prioridad})";
            _BD.ejecutar(sqlInsertar);
        }

        public DataTable buscarEncargo(int tipoDocumento, int nroDocumento)
        {
            string sqlBuscar = $"SELECT * FROM encargos where tipo_doc_cliente = {tipoDocumento} and nro_doc_cliente = {nroDocumento}";
            return _BD.Ejecutar_Select(sqlBuscar);
        }
        public string buscarEncargos(int tipoDocumento, int nroDocumento)
        {
            string sqlBuscar = $"SELECT * FROM encargos where tipo_doc_cliente = {tipoDocumento} and nro_doc_cliente = {nroDocumento}";
            return sqlBuscar;
        }
        public void modificarEncargo(Encargos encargoModificado)
        {
            string sqlModificar = $"UPDATE encargos SET tipo_doc_cliente = {encargoModificado.tipoDocumento}, nro_doc_cliente = {encargoModificado.nroDocumento}, fecha = CONVERT(DATETIME, '{encargoModificado.fecha}',103), id_nombrecomercial = {encargoModificado.nombreComercial}, legajo_empleado = {encargoModificado.legajoEmpletado}, cod_caracteristica = {encargoModificado.codCaracteristica}, prioridad = {encargoModificado.prioridad} WHERE tipo_doc_cliente = {encargoModificado.tipoDocumento} AND  nro_doc_cliente = {encargoModificado.nroDocumento} ";
            _BD.ejecutar(sqlModificar);
        }

        public void BorrarEncargo(int nro_doc )
        {
            string sqlBorrar = $"DELETE FROM encargos WHERE nro_doc_cliente = {nro_doc}";
            _BD.Eliminar(sqlBorrar);
        }

    }
}
