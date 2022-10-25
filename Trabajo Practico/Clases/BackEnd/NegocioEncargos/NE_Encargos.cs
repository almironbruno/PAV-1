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
            string sqlInsertar = $@"INSERT INTO encargos(tipo_doc_cliente, nro_doc_cliente, fecha, id_nombrecomercial, legajo_empleado, cod_caracteristica, prioridad) VALUES ({encargoAgregar.tipoDocumento}, {encargoAgregar.nroDocumento}, '{encargoAgregar.fecha}', {encargoAgregar.nombreComercial}, {encargoAgregar.legajoEmpletado}, {encargoAgregar.codCaracteristica},{encargoAgregar.prioridad})";
            _BD.ejecutar(sqlInsertar);
        }

        public string buscarEncargo(string tipoDocumento, string nroDocumento)
        {
            if (tipoDocumento.Equals("")) tipoDocumento = "%";
            if (nroDocumento.Equals("")) nroDocumento = "%";
            string sqlBuscar = $"SELECT * FROM encargos WHERE tipo_doc_cliente LIKE'{tipoDocumento}' AND nro_doc_cliente LIKE'{nroDocumento}'";

            return sqlBuscar;
        }
        public string buscarEncargos(int tipoDocumento, int nroDocumento)
        {
            string sqlBuscar = $"SELECT * FROM encargos where tipo_doc_cliente = {tipoDocumento} and nro_doc_cliente = {nroDocumento}";
            return sqlBuscar;
        }
        public void modificarEncargo(Encargos encargo)
        {
            string sqlModificar = $"UPDATE encargos SET tipo_doc_cliente = {encargo.tipoDocumento}, nro_doc_cliente = {encargo.nroDocumento}, fecha = '{encargo.fecha}', id_nombrecomercial = {encargo.nombreComercial}, legajo_empleado = {encargo.legajoEmpletado}, cod_caracteristica = {encargo.codCaracteristica}, prioridad = {encargo.prioridad} WHERE tipo_doc_cliente = {encargo.tipoDocumento} AND nro_doc_cliente = {encargo.nroDocumento}";
            _BD.ejecutar(sqlModificar);
        }
        public void BorrarEncargo(int tipoDoc, int nroDoc, string fecha, int nombreComercial, int  nombreEmpleado, int tipoCaracterisitca, int prioridad)
        {
            string sqlBorrar = $"DELETE FROM encargos WHERE  tipo_doc_cliente ={tipoDoc} AND nro_doc_cliente = {nroDoc} AND fecha = '{fecha}' AND id_nombrecomercial = {nombreComercial} AND legajo_empleado = {nombreEmpleado} AND cod_caracteristica = {tipoCaracterisitca} AND prioridad = {prioridad}";
            _BD.Eliminar(sqlBorrar);
        }

    }
}
