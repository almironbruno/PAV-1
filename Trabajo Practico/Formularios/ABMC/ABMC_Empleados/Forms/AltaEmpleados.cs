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
    public partial class AltaEmpleados : CamposEmpleados
    {
        public AltaEmpleados()
        {
            
            InitializeComponent();
            //Se carga el comboBox de Cargos
            cmbCargable_Cargos.cargar("SELECT * FROM cargos_empleados", "nombre_cargo", "id_cargo");
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
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
                nE_Empleados.agregarEmpleados(empleado);
                this.Close();

            }

            

        }

        private void AltaEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
