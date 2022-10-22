using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Empleados
{
    public partial class CamposEmpleados : FormBaseBotones
    {
        public CamposEmpleados()
        {
            //El proposio de este form es reutilizar los campos y la funcion cargarCampos 
            // para ahorrar codigo
            InitializeComponent();
            
        }
        public CamposEmpleados(Trabajo_Practico.Clases.Entidades.Empleados empleado)
        {
            cargarCampos(empleado);
            mtxt_Legajo.Enabled = false;
            mTxt_Apellido.Enabled = false;
            mTxt_Nombre.Enabled = false;
            cmbCargable_Cargos.Enabled = false;

        }

        protected void cargarCampos(Trabajo_Practico.Clases.Entidades.Empleados empleado)
        {
            cmbCargable_Cargos.cargar("SELECT * FROM cargos_empleados","nombre_cargo","id_cargo");
            //Funcion generica para cargar los datos en el form
            mtxt_Legajo.Text = empleado.legajoEmpleado.ToString();
            mTxt_Nombre.Text = empleado.nombre;
            mTxt_Apellido.Text = empleado.apellido;
            cmbCargable_Cargos.cmb_Cargable.SelectedValue = empleado.cargo;
        }

        private void CamposEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
