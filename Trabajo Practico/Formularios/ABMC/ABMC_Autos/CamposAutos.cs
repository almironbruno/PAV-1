using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.Base;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Autos
{
    public partial class CamposAutos : FormBaseBotones
    {
        public CamposAutos()
        {
            InitializeComponent();
        }


        public CamposAutos(Trabajo_Practico.Clases.Entidades.Vehiculos auto)
        {
            cargarCampos(auto);
            txtCodSerieFab.Enabled = false;
            txtAñoFab.Enabled = false;
            txtNroChasis.Enabled = false;
            txtNroMotor.Enabled = false;
            txtPatente.Enabled = false;
        }



        public void cargarCampos(Trabajo_Practico.Clases.Entidades.Vehiculos auto)
        {
            string sqlCondicion = (@"SELECT * FROM condicion");
            string sqlNombreComr = (@"SELECT * FROM nombres_comerciales");
            cmbCondicion.cargar(sqlCondicion, "nombre_condicion", "id_condicion");
            cmbNomComr.cargar(sqlNombreComr, "nombre_comercial", "id_nombrecomercial");

            txtCodSerieFab.Text = auto.cod_serie_fabrica.Trim();
            txtAñoFab.Text = auto.año_Fabricacion.Trim();
            txtNroChasis.Text = auto.nro_Chasis.Trim();
            txtNroMotor.Text = auto.nro_Motor.Trim();
            txtPatente.Text = auto.patente.Trim();

            cmbCondicion.cmb_Cargable.SelectedValue = auto.condicion;
            cmbNomComr.cmb_Cargable.SelectedValue = auto.nombreComercial;


            
        }

        private void CamposAutos_Load(object sender, EventArgs e)
        {

        }
    }
}
