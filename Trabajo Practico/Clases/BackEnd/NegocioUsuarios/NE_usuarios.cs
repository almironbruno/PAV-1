using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Trabajo_Practico.Clases;
using System.Windows.Forms;

namespace Trabajo_Practico.Clases.BackEnd
{
    class NE_usuarios

    {
        //Clasificador explicito
        public enum ResultadoValidacion { existe, no_existe}
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();



        public ResultadoValidacion ValidarUsuario(string nombre, string password)
        {
            //Consulta para validar Usuarios
            string consulta = @"SELECT * FROM usuarios WHERE nombre  = '" + nombre + "'" + " AND password = '" +password+ "'";
            
            //Creamos un objeto BE con un memotecnico _BD
            
            DataTable tabla = new DataTable();
            tabla = _BD.Ejecutar_Select(consulta);

            if (tabla.Rows.Count == 1)
            {
                return ResultadoValidacion.existe;
            }
            else
            {
                return ResultadoValidacion.no_existe;
            }

        }



        
        public ResultadoValidacion ValidarEmailExistente(string email)
        {
            //Consultar para validar la existencia de email

            string consulta = @"SELECT * FROM usuarios WHERE email ='" + email + "'";

            //Crear objeto de acceso a la bd
            

            //Crear tabla
            DataTable tabla = new DataTable();

            //cargar la tabla con el resultado del objeto y la ejecucion del select
            tabla = _BD.Ejecutar_Select(consulta);

            //Consultar si la tabla tiene al menos una fila, es decir, busqueda exitosa
            if (tabla.Rows.Count == 1)
            {
                return ResultadoValidacion.existe;
            }
            else
            {
                return ResultadoValidacion.no_existe;
            }



            
        }


        //Agregar un Objeto Usuario a la BD
        public void AgregarUsuario (Usuario usuarioAgregar)
        {
            
           string sqlInsertar = @"INSERT INTO usuarios"
                                + "(nombre, apellido, password, email)"
                                + "VALUES('" 
                                + usuarioAgregar.NombreDeUsuario + "'"
                                + ", '" + usuarioAgregar.ApellidoUsuario + "'"
                                + ", '" + usuarioAgregar.Password + "'"
                                + ", '" + usuarioAgregar.EmailUsuario + "')";

            //Insertar A Travez de la funcion de BackEnd

            _BD.Insertar(sqlInsertar);
            

        }





    }
}
