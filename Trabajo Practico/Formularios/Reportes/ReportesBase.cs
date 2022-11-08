using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Trabajo_Practico.Clases.BackEnd.NegocioReporte;
using Microsoft.Reporting.WinForms;

namespace Trabajo_Practico.Formularios.Reportes
{
    public partial class ReportesBase : Form
    {
        //Quedaron obsoletos estos atributos - no sirven
        protected string consulta;
        protected string reporte;
        protected int cantidad;
        protected DataTable tabla;
        public ReportesBase( )
        {
            InitializeComponent();


        }
     
        
        protected void cargar(string reporte,string sql)
        {
            //Funcion que carga el reporte
            // param1: nombre del dataset
            // param2: consulta para cargar el reporte


            //Crea una instancia de BackEnd para consultar la bd
            NE_reporte bd_reporte = new NE_reporte();

            //carga la tabla con la funcion generica cargarReporte()
            DataTable dt = new DataTable();
            dt = bd_reporte.cargarReporte(sql);

            //Crea un DataSource de reporte para el reportViewer
            ReportDataSource ds = new ReportDataSource(reporte, dt);

            //Asigna el DataSource al reportViewer
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();

            
            this.cantidad = dt.Rows.Count;

        }
        protected void ReportesBase_Load(object sender, EventArgs e)
        {
           //No hace nada
        }

        private void ReportesBase_Load_1(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
