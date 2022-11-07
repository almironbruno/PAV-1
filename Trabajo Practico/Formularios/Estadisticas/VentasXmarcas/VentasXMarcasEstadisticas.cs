using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Formularios.Estadisticas.VentasXmarcas
{
    public partial class VentasXMarcasEstadisticas : Reportes.ReportesBase
    {
        public VentasXMarcasEstadisticas()
        {
            InitializeComponent();
        }

        private void VentasXMarcasEstadisticas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Refresh();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT nombre, count(nombre) as cantidad_Vendidos FROM marcas " +
                " INNER JOIN nombres_comerciales " +
                "on marcas.id_marca = nombres_comerciales.id_marca " +
                " INNER JOIN autos " +
                "on autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial " +
                " INNER JOIN detalle_ventas " +
                "on detalle_ventas.cod_serie_fabrica = autos.cod_serie_fabrica " +
                " INNER JOIN ventas " +
                "on ventas.nro_factura = detalle_ventas.nro_factura " +
                "group by nombre ";

            cargar("DatosEstadisticasXmarcas", consulta);
        }
    }
}
