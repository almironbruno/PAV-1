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

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Empleados.Forms
{
    public partial class Consulta : CamposEmpleados
    {
        public Consulta()
        {
            InitializeComponent();
            cmbCargable_Cargos.cargar("SELECT * FROM cargos_empleados", "nombre_cargo", "id_cargo");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
          //Terminar de implementar
        }
    }
}
