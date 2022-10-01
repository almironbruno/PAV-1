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
using Trabajo_Practico.Formularios.ABMC.Empleados;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Empleados
{
    public partial class BajaEmpleado : CamposEmpleados
    {
        public BajaEmpleado(DataGridViewRow row)
        {
            //Desactivo todos los campos
            btn_LimpiarCampos.Enabled = false;
            mTxt_Apellido.ReadOnly = true;
            mtxt_Legajo.Enabled = false;
            mTxt_Nombre.Enabled = false;
            mTxt_Apellido.Enabled = false;
            cmbCargable_Cargos.Enabled = false;
            btn_LimpiarCampos.Hide();

            //Tomo la info de la fila seleccionada
            int legajo = int.Parse(row.Cells[0].Value.ToString());
            string nombre = row.Cells[1].Value.ToString();
            string apellido = row.Cells[2].Value.ToString();
            int cargo = bd.SelectNumeros($"SELECT id_cargo FROM cargos_empleados WHERE nombre_cargo LIKE '{row.Cells[3].Value.ToString()}'"); 
            //Creo el objeto empleado
            Trabajo_Practico.Clases.Entidades.Empleados empleado = new Trabajo_Practico.Clases.Entidades.Empleados(legajo, nombre, apellido, cargo);
            //Cargos los campos con los datos del empleado
            cargarCampos(empleado);


            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            NE_Empleados empleadosBorrar = new NE_Empleados();
            empleadosBorrar.bajaEmpleados(mtxt_Legajo.Text);
            this.Close();
        }
    }
}
