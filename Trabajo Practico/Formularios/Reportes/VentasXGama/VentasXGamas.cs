using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Formularios.Reportes.VentasXGama
{
    public partial class VentasXGamas : ReportesBase
    {
        public VentasXGamas()
        {
            InitializeComponent();
        }

        private void VentasXGama_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string consulta = @"SELECT V.nro_factura, G.nombre_gama,V.fecha
                                FROM ventas V JOIN detalle_ventas DV
                                ON V.nro_factura = DV.nro_factura
                                JOIN autos A 
                                ON DV.cod_serie_fabrica = A.cod_serie_fabrica
                                JOIN nombres_comerciales NC 
                                ON A.id_nombrecomercial = NC.id_nombrecomercial
                                JOIN gamas G ON NC.id_gama = G.id_gama";

            cargar("tablareporteventaporgamas", consulta);
        }
    }
}
