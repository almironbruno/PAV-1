using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Formularios.Estadisticas.VentasXmodelos
{
    public partial class VentasXModelosEstadistica : Reportes.ReportesBase
    {
        public VentasXModelosEstadistica()
        {
            InitializeComponent();
        }

        private void VentasXModelosEstadistica_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Refresh();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT nombre_comercial, count(nombre_comercial) as cantidad_Vendidos " +
                             "FROM nombres_comerciales " +
                             " INNER JOIN autos " +
                             "ON nombres_comerciales.id_nombrecomercial = autos.id_nombrecomercial " +
                             " INNER JOIN detalle_ventas " +
                             "ON autos.cod_serie_fabrica = detalle_ventas.cod_serie_fabrica " +
                             " INNER JOIN ventas " +
                             "ON detalle_ventas.nro_factura = ventas.nro_factura " +

                             "group by nombre_comercial ";

            cargar("DatosModelosEstat", consulta);
        }
    }
}
