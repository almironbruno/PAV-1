using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Trabajo_Practico.Clases.BackEnd.NegocioClientes
{
     class NE_Clientes
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



        public string consultaCl(string tipoDoc,string nroDoc,string nombre,string apellido,string fechaNac,string calle,string nroCalle,string barrio) 
        {
            if (tipoDoc.Equals("0")) tipoDoc= "%";
            if (nroDoc.Equals("")) nroDoc = "%";
            if (nombre.Equals("")) nombre = "%";
            if (apellido.Equals("")) apellido = "%";
            if (fechaNac.Equals("/  /")) fechaNac = "%";
            else {fechaNac=fechaNac.Replace("/","-"); };
            if (calle.Equals("")) calle = "%";
            if (nroCalle.Equals("")) nroCalle = "%";
            if (barrio.Equals("0")) barrio = "%";
            string sqlConsulta = $@"SELECT * FROM clientes WHERE 
                                tipo_doc_cliente LIKE '{tipoDoc}' AND 
                                nro_doc_cliente LIKE '{nroDoc}' AND
                                nombre LIKE '{nombre}' AND 
                                apellido LIKE '{apellido}' AND 
                                fecha_nacimiento LIKE '{fechaNac}' AND
                                calle LIKE '{calle}' AND
                                nro_calle LIKE '{nroCalle}' AND
                                id_barrio LIKE '{barrio}'";
            return sqlConsulta;



        }
        
    }
}
