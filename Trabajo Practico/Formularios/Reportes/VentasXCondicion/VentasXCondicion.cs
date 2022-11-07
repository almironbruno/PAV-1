using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Formularios.Reportes.VentasXCondicion
{
    public partial class VentasXCondicion : ReportesBase
    {
        public VentasXCondicion()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string consulta = @"SELECT C.nombre_condicion, V.nro_factura, V.fecha
                                FROM ventas V JOIN detalle_ventas DV
                                ON V.nro_factura = DV.nro_factura
                                JOIN autos A 
                                ON DV.cod_serie_fabrica = A.cod_serie_fabrica
                                JOIN condicion C 
                                ON A.id_condicion = C.id_condicion";

            cargar("tablareporteventasporcondicion", consulta);
        }

        private void VentasXCondicion_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
