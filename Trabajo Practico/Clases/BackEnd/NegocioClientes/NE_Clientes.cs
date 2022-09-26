using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Clases.BackEnd.NegocioClientes
{
    internal class NE_Clientes
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void AgregarCliente(Clientes clienteAgregar)
        {

            string sqlInsertar = $"INSERT INTO clientes (tipo_doc_cliente, nro_doc_cliente, nombre, apellido, fecha_nacimiento, calle, nro_calle, id_barrio) VALUES ({clienteAgregar.tipo_doc}, {clienteAgregar.nro_doc}, '{clienteAgregar.nombre}','{clienteAgregar.apellido}', CONVERT(DATE, '{clienteAgregar.fecha_nacimiento}',103),'{clienteAgregar.calle}',{clienteAgregar.nro_calle},{clienteAgregar.id_barrio})";
                     

            //Insertar A Travez de la funcion de BackEnd
            _BD.ejecutar(sqlInsertar);


        }
        public void BorrarCliente(string tipoDocCliente,string idCliente)
        {
            string sqlBorrar = "DELETE FROM clientes WHERE tipo_doc_cliente = '" +tipoDocCliente+ "'" +" AND nro_doc_cliente = '"+idCliente+"'";
            _BD.Eliminar(sqlBorrar);
        }

        public void ModificarCliente(Clientes clienteModificar) 
        {

            string sqlInsertar = $"UPDATE clientes SET tipo_doc_cliente = {clienteModificar.tipo_doc}, nro_doc_cliente = {clienteModificar.nro_doc}, nombre = '{clienteModificar.nombre}' , apellido = '{clienteModificar.apellido}', fecha_nacimiento = CONVERT(DATETIME, '{clienteModificar.fecha_nacimiento}',103), calle = '{clienteModificar.calle}', nro_calle ={clienteModificar.nro_calle} , id_barrio = {clienteModificar.id_barrio} WHERE tipo_doc_cliente = {clienteModificar.tipo_doc} AND  nro_doc_cliente = {clienteModificar.nro_doc} ";
            _BD.ejecutar(sqlInsertar);
        }
    }
}
