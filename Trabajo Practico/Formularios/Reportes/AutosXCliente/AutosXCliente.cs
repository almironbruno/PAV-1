using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Formularios.Reportes.AutosXCliente
{
    public partial class AutosXCliente : ReportesBase
    {
        public AutosXCliente()
        {
            InitializeComponent();
            comboCargable1.cargar("select * from clientes","apellido","nro_doc_cliente");
        }

        private void AutosXCliente_Load(object sender, EventArgs e)
        {
            //refresca el reporte
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //cada vez que se carga el form, se carga el reportViewer
            string consulta = @"SELECT        A.cod_serie_fabrica, N.nombre_comercial, A.año_fabricacion, A.patente, C.nombre_condicion, A.monto
                        FROM            autos AS A INNER JOIN
                         nombres_comerciales AS N ON A.id_nombrecomercial = N.id_nombrecomercial INNER JOIN
                         condicion AS C ON A.id_condicion = C.id_condicion";

            cargar("autos", consulta);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string cliente = comboCargable1.cmb_Cargable.SelectedValue.ToString();
            
            string consulta = $@"SELECT        A.cod_serie_fabrica,cl.nro_doc_cliente,Dv.nro_factura, N.nombre_comercial, A.año_fabricacion, A.patente, C.nombre_condicion, A.monto
                        FROM            autos AS A JOIN
                         nombres_comerciales AS N ON A.id_nombrecomercial = N.id_nombrecomercial JOIN
                         condicion AS C ON A.id_condicion = C.id_condicion
						 join detalle_ventas dv on dv.cod_serie_fabrica=A.cod_serie_fabrica
						 join ventas v on v.nro_factura=dv.nro_factura
						 join clientes cl on cl.nro_doc_cliente=v.nro_doc_cliente and cl.tipo_doc_cliente=v.tipo_doc_cliente
						 where cl.nro_doc_cliente={cliente}";

            cargar("autos", consulta);
            this.reportViewer1.RefreshReport();
        }

        private void lbl_autos_Click(object sender, EventArgs e)
        {

        }
    }
}
