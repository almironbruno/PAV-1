using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd;
namespace Trabajo_Practico.ControlesPropios
{
    public partial class Buscador : UserControl
    {
        private BE_Acceso_Datos bd = new BE_Acceso_Datos();
        public string tablaConsulta;
        public string columna;
        public Buscador()
        {
            InitializeComponent();
            btn_deshacer.Hide();
        }
        public Buscador(string tablaConsulta)
        {
            InitializeComponent();
            cmb_buscar.Enabled = false;
            cmb_buscar.Hide();
            btn_deshacer.Hide();
            this.tablaConsulta = tablaConsulta;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
            string texto = txt_buscar.Text;
            string consulta = $"SELECT * FROM {tablaConsulta} WHERE {columna}='{texto}'";
            DataTable tabla = bd.Ejecutar_Select(consulta);
            if (tabla.Rows.Count > 0)
            {
                cmb_buscar.Enabled = true;
                cmb_buscar.BringToFront();
                cmb_buscar.Show();
                tabla.Columns.Add("FullName", typeof(string),
                "tipo_doc_cliente + '-' + nro_doc_cliente + '-'+ nombre + ' ' + apellido");
                cmb_buscar.DataSource = tabla;
                cmb_buscar.DisplayMember = "FullName";
                cmb_buscar.SelectedItem = 1;
                btn_deshacer.Show();

            }
            else cmb_buscar.Text = "No se encontro una persona";
            
        }

        private void btn_deshacer_Click(object sender, EventArgs e)
        {
            cmb_buscar.DataSource = null;
            txt_buscar.BringToFront();
            txt_buscar.Text = "";
            btn_deshacer.Hide();
        }

        public void limpiar()
        {
            btn_deshacer.PerformClick();
        }
        
    }
}
