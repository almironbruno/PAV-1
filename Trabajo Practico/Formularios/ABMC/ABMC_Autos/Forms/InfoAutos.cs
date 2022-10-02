using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.ABMC.ABMC_Autos;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Autos
{
    public partial class InfoAutos : CamposAutos
    {
        public InfoAutos()
        {


            txtCodSerieFab.Enabled = false;
            txtAñoFab.Enabled = false;
            txtNroChasis.Enabled = false;
            txtNroMotor.Enabled = false;
            txtPatente.Enabled = false;
            cmbCondicion.cmb_Cargable.Enabled = false;
            cmbNomComr.cmb_Cargable.Enabled = false;

            btn_LimpiarCampos.Hide();
            btn_Aceptar.Hide();

            InitializeComponent();

            cambiarFormaConsulta();


        }


        public override void cargarInfo(DataGridViewRow row)
        {
            string sqlCondicion = (@"SELECT * FROM condicion");
            string sqlNombreComr = (@"SELECT * FROM nombres_comerciales");
            cmbCondicion.cargar(sqlCondicion, "nombre_condicion", "id_condicion");
            cmbNomComr.cargar(sqlNombreComr, "nombre_comercial", "id_nombrecomercial");

            txtCodSerieFab.Text = row.Cells[0].Value.ToString();
            txtAñoFab.Text = row.Cells[2].Value.ToString();
            txtNroChasis.Text = row.Cells[4].Value.ToString();
            txtNroMotor.Text = row.Cells[5].Value.ToString();
            txtPatente.Text = row.Cells[3].Value.ToString();
        }
        private void InfoAutos_Load(object sender, EventArgs e)
        {

        }
    }
}
