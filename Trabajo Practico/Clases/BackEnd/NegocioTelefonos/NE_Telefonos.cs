﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Clases.BackEnd.NegocioTelefonos
{
    internal class NE_Telefonos
    {

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();


        public void AgregarTelefono(Telefono telefonoAgregar)
        {
            string sqlInsertar = $"INSERT INTO telefonos (nro_telefono, nro_caracteristica, tipo_doc_cliente, nro_doc_cliente)" +
                                 $" VALUES ({telefonoAgregar.nroTelefono}, {telefonoAgregar.nroCaracteristica}," +
                                 $"{telefonoAgregar.tipoDocCliente}, {telefonoAgregar.nroDocCliente})";

            _BD.ejecutar(sqlInsertar);
        }


        public void BorrarTelefono(string numTel)
        {

            string sqlBorrar = "DELETE FROM telefonos WHERE nro_telefono = '" + numTel + "'";
            _BD.Eliminar(sqlBorrar);
        }


        public void ModificarTelefono(Telefono telefonoModificar, string pkVieja)
        {
            string sqlInsertar = $"UPDATE telefonos SET nro_telefono = {telefonoModificar.nroTelefono}, nro_caracteristica = {telefonoModificar.nroCaracteristica} WHERE nro_doc_cliente = {telefonoModificar.nroDocCliente} AND tipo_doc_cliente = {telefonoModificar.tipoDocCliente} AND nro_telefono = {pkVieja}";
            _BD.ejecutar(sqlInsertar);
               
        }

        public string consultaTel(string numTelCliente, string caracTelCliente, string numDocCliente, string tipoDocCliente)
        {

            string sqlConsulta = $@"SELECT * FROM telefonos WHERE
                                 nro_telefono LIKE '{numTelCliente}'
                                 AND nro_caracteristica LIKE '{caracTelCliente}' AND
                                 nro_doc_cliente LIKE '{numDocCliente}'
                                 AND tipo_doc_cliente LIKE '{tipoDocCliente}'";

            return sqlConsulta;
        }
    }
}
