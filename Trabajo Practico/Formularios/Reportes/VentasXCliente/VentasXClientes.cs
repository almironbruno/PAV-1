using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Formularios.Reportes.VentasXCliente
{
    public partial class VentasXClientes : ReportesBase
    {
        public VentasXClientes()
        {
            InitializeComponent();
            comboCargable1.cargar("select * from clientes where nro_doc_cliente in (select nro_doc_cliente from ventas)", "apellido", "nro_doc_cliente");
            lblAlcance.Text = "Alcance: Todas las ventas para todos los clientes";

        }

        private void VentasXClientes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string consulta = @"select v.nro_factura,convert(varchar,v.fecha,101) as fecha ,v.legajo_empleado,
                sum(dv.monto) as monto from ventas v join detalle_ventas dv on v.nro_factura=dv.nro_factura 
            group by v.nro_factura,v.fecha,v.legajo_empleado";
            cargar("ventas",consulta);
            lblAlcance.Text = "Alcance:Todos las ventas para todos los clientes";
            txtCantAutos.Text = cantidad.ToString();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string cliente = comboCargable1.cmb_Cargable.SelectedValue.ToString();



            lblAlcance.Text = "Alcance: ventas para el cliente " + comboCargable1.cmb_Cargable.Text;
            string consulta = $@"select v.nro_factura,convert(varchar,v.fecha,101) as fecha ,v.legajo_empleado,
                sum(dv.monto) as monto from ventas v join detalle_ventas dv on v.nro_factura=dv.nro_factura 
        where v.nro_doc_cliente={cliente}
            group by v.nro_factura,v.fecha,v.legajo_empleado";

            cargar("ventas", consulta);
            this.reportViewer1.RefreshReport();
            txtCantAutos.Text = cantidad.ToString();
        }
    }
}
