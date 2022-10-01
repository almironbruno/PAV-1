using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico.Clases.BackEnd;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Clases.BackEnd.NegocioEmpleados
{
    internal class NE_Empleados
    {
        private BE_Acceso_Datos bd = new BE_Acceso_Datos();
        public void agregarEmpleados(Empleados empleado)
        {
            string sqlInsertar = $@"INSERT INTO empleados VALUES 
           ({empleado.legajoEmpleado},
            '{empleado.apellido}',
            '{empleado.nombre}',
            {empleado.cargo})";

            bd.ejecutar(sqlInsertar);
        }
        public void modificarEmpleados(Empleados empleado,string pk) 
        {
            string sqlModificar = $@"UPDATE empleados SET 
           legajo_empleado = {empleado.legajoEmpleado},
            nombre ='{empleado.nombre}',
            apellido='{empleado.apellido}',
            cargo={empleado.cargo}
            WHERE legajo_empleado={pk}";

            bd.ejecutar(sqlModificar);
        
        }

        public void bajaEmpleados(string legajo) 
        {

            string sqlBorrar = "DELETE FROM empleados WHERE legajo_empleado = " + legajo;
            bd.Eliminar(sqlBorrar);

        }

        public DataTable consultaEmpleados(string legajo,string nombre,string apellido,string cargo) 
        {
            if (legajo.Equals("")) legajo = "%";
            if (apellido.Equals("")) apellido = "%";
            if (nombre.Equals("")) nombre = "%";
            if (cargo.Equals("")) cargo = "%";
            string sqlConsulta = $"SELECT * FROM Empleados WHERE legajo_empleado LIKE'{legajo}' AND nombre LIKE'{nombre}' AND apellido LIKE'{apellido}' AND cargo LIKE'{cargo}'";
            DataTable e = bd.Ejecutar_Select(sqlConsulta);
            return e;
        }
        public string consultemp(string legajo, string nombre, string apellido, string cargo)
        {
            if (legajo.Equals("")) legajo = "%";
            if (apellido.Equals("")) apellido = "%";
            if (nombre.Equals("")) nombre = "%";
            if (cargo.Equals("0")) cargo = "%";
            string sqlConsulta = $"SELECT * FROM empleados WHERE legajo_empleado LIKE'{legajo}' AND nombre LIKE'{nombre}' AND apellido LIKE'{apellido}' AND cargo LIKE'{cargo}'";
            return sqlConsulta;

        }
    }
}
