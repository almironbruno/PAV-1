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
using Trabajo_Practico.Formularios.ABMC.Empleados;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Empleados.Forms
{
    public partial class Consulta : CamposEmpleados
    {
        private FormBaseABMC form1;
        public Consulta(FormBaseABMC fo1r)
        {
            form1 = fo1r;
            modoConsulta = true;
            InitializeComponent();
            //Cambia el form a modo consulta
            cambiarFormaConsulta();
            cmbCargable_Cargos.cargar("SELECT * FROM cargos_empleados", "nombre_cargo", "id_cargo");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string legajo = mtxt_Legajo.Text.Trim();
            string nombre = mTxt_Nombre.Text.Trim();
            string apellido = mTxt_Apellido.Text.Trim();
            string cargo = "";//cmbCargable_Cargos.cmb_Cargable.SelectedValue.ToString();
            //Terminar de implementar
            NE_Empleados em = new NE_Empleados();
            form1.consultaPrincipal = em.consultemp(legajo,nombre,apellido,cargo);
            

        }
    }
}
