using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioEmpleados;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Formularios.ABMC.Empleados
{
    public partial class ModificacionEmpleados : CamposEmpleados
    {
        public ModificacionEmpleados(DataGridViewRow row)
        {
            //Tomo la info de la fila seleccionada
            int legajo = int.Parse(row.Cells[0].Value.ToString());
            string nombre = row.Cells[1].Value.ToString();
            string apellido= row.Cells[2].Value.ToString();
            int cargo= int.Parse(row.Cells[3].Value.ToString());
            //Creo el objeto empleado
            Trabajo_Practico.Clases.Entidades.Empleados empleado = new Trabajo_Practico.Clases.Entidades.Empleados(legajo,nombre,apellido,cargo);
            //Cargos los campos con los datos del empleado
            cargarCampos(empleado);

            InitializeComponent();
            mtxt_Legajo.Enabled = false;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //Valida los campos
            if (validarCampos())
            {

                //Toma lo ingresado en el form
                int legajo = int.Parse(mtxt_Legajo.Text.Trim());
                string nombre = mTxt_Nombre.Text.Trim();
                string apellido = mTxt_Apellido.Text.Trim();
                int cargo = int.Parse(cmbCargable_Cargos.cmb_Cargable.SelectedValue.ToString());

                //Crea el objeto Empleado
                NE_Empleados nE_Empleados = new NE_Empleados();
                Trabajo_Practico.Clases.Entidades.Empleados empleado = new Trabajo_Practico.Clases.Entidades.Empleados(legajo, nombre, apellido, cargo);
                nE_Empleados.modificarEmpleados(empleado,legajo.ToString());
                this.Close();

            }

        }
    }
}
