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

namespace Trabajo_Practico.Formularios.Estadisticas.VentasXCondicion
{
    public partial class VentasXCondicionEstadisticas : ReportesBase
    {
        public VentasXCondicionEstadisticas()
        {
            InitializeComponent();
        }

        private void VentasXCondicionEstadisticas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Refresh();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string consulta = @"SELECT COUNT(C.id_condicion), C.nombre_condicion
                                FROM ventas V JOIN detalle_ventas DV
                                ON V.nro_factura = DV.nro_factura
                                JOIN autos A 
                                ON DV.cod_serie_fabrica = A.cod_serie_fabrica
                                JOIN condicion C 
                                ON A.id_condicion = C.id_condicion
								group by C.nombre_condicion";

            cargar("DBEstadisticaVentaXCondicionnnn", consulta);
        }
    }
}
