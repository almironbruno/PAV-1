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
    }
}
