using System;
using System.Collections.Generic;
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
            '{empleado.nombre}',
            '{empleado.apellido}',
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
    }
}
