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

namespace Trabajo_Practico.Formularios.Estadisticas.VentasXGamas
{
    public partial class VentasXGamasEstadisticas : ReportesBase
    {
        public VentasXGamasEstadisticas()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string consulta = @"SELECT COUNT(G.id_gama), G.nombre_gama
                                FROM ventas V JOIN detalle_ventas DV
                                ON V.nro_factura = DV.nro_factura
                                JOIN autos A 
                                ON DV.cod_serie_fabrica = A.cod_serie_fabrica
                                JOIN nombres_comerciales NC 
                                ON A.id_nombrecomercial = NC.id_nombrecomercial
                                JOIN gamas G ON NC.id_gama = G.id_gama
								group by G.nombre_gama";

            cargar("estadisticaVenXGama", consulta);
        }

        private void VentasXGamasEstadisticas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Refresh();
        }
    }
}
