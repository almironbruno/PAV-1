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

namespace Trabajo_Practico.Formularios.Estadisticas.AutosXMarcas
{
    public partial class AutosXMarcas : ReportesBase
    {
        public AutosXMarcas()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string consulta = "select count(distinct v.nro_factura) as Cantidad,m.nombre from ventas v join detalle_ventas d on d.nro_factura=v.nro_factura join autos a on a.cod_serie_fabrica=d.cod_serie_fabrica join nombres_comerciales n on n.id_nombrecomercial=a.id_nombrecomercial join marcas m on m.id_marca=n.id_marca group by m.nombre";
            cargar("autosMarcas",consulta);
        }

        private void AutosXMarcas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}

