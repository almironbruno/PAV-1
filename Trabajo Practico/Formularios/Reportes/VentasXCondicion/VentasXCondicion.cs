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
            comboCargable1.cargar("select * from condicion", "nombre_condicion", "id_condicion");
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

            txtCantCondiciones.Text = cantidad.ToString();
        }

        private void VentasXCondicion_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = comboCargable1.cmb_Cargable.SelectedValue.ToString();

            string consulta = $@"SELECT C.nombre_condicion, V.nro_factura, V.fecha
                                FROM ventas V JOIN detalle_ventas DV
                                ON V.nro_factura = DV.nro_factura
                                JOIN autos A 
                                ON DV.cod_serie_fabrica = A.cod_serie_fabrica
                                JOIN condicion C 
                                ON A.id_condicion = C.id_condicion
                                where C.id_condicion = {condicion}";

            cargar("tablareporteventasporcondicion", consulta);
            this.reportViewer1.RefreshReport();

            if(condicion == "1")
            {
                lblCondicion.Text = "Alcance de las ventas de los autos Nuevos.";
            }
            else 
            {
                lblCondicion.Text = "Alcance de las ventas de los autos Usados.";
            }

            txtCantCondiciones.Text = cantidad.ToString();

        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            string consulta = @"SELECT C.nombre_condicion, V.nro_factura, V.fecha
                                FROM ventas V JOIN detalle_ventas DV
                                ON V.nro_factura = DV.nro_factura
                                JOIN autos A 
                                ON DV.cod_serie_fabrica = A.cod_serie_fabrica
                                JOIN condicion C 
                                ON A.id_condicion = C.id_condicion";

            cargar("tablareporteventasporcondicion", consulta);

            this.reportViewer1.RefreshReport();
            lblCondicion.Text = "Alcance de las ventas de todas las Condiciones";

            txtCantCondiciones.Text = cantidad.ToString();
        }

    }
}
