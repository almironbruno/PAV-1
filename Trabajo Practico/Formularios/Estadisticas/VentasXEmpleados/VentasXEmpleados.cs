using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.Reportes;

namespace Trabajo_Practico.Formularios.Estadisticas.VentasXEmpleados
{
    public partial class VentasXEmpleados : ReportesBase
    {
        public VentasXEmpleados()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string consulta = "select count(distinct v.nro_factura) as Cantidad ,e.nombre,e.apellido from ventas v right join empleados e on e.legajo_empleado=v.legajo_empleado group by e.nombre,e.apellido";
            cargar("ventasEmpleados",consulta);
        }

        private void VentasXEmpleados_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
