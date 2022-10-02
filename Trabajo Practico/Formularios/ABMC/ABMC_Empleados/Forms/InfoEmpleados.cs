using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.ABMC.Empleados;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Empleados.Forms
{
    public partial class InfoEmpleados : CamposEmpleados
    {
        public InfoEmpleados()
        {
            mTxt_Nombre.Enabled = false;
            mtxt_Legajo.Enabled = false;
            mTxt_Apellido.Enabled = false;
            cmbCargable_Cargos.cmb_Cargable.Enabled = false;
            btn_LimpiarCampos.Hide();
            btn_Aceptar.Hide();
            InitializeComponent();
            //Cambia los botones al modo Consulta
            cambiarFormaConsulta();
        }
        public override void cargarInfo(DataGridViewRow row)
        {
            cmbCargable_Cargos.cargar("SELECT * FROM cargos_empleados", "nombre_cargo", "id_cargo");
            mtxt_Legajo.Text = row.Cells[0].Value.ToString();
            mTxt_Nombre.Text = row.Cells[1].Value.ToString();
            mTxt_Apellido.Text = row.Cells[2].Value.ToString();
            cmbCargable_Cargos.cmb_Cargable.Text = row.Cells[3].Value.ToString();

        }
    }
}
