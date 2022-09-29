using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioAutos;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Base;
using Trabajo_Practico.ControlesPropios;


namespace Trabajo_Practico.Formularios.ABMC.Autos
{
    public partial class ModificarAuto : FormBaseModificacion
    {
        Vehiculos AutoMod;
        string patentevieja;
        
        public ModificarAuto(Vehiculos autoSeleccionado)
        {
            patentevieja = autoSeleccionado.patente;
            AutoMod = autoSeleccionado;
            InitializeComponent();

            string sqlCondicion = (@"SELECT * FROM condicion");
            string sqlNombreComr = (@"SELECT * FROM nombres_comerciales");
            mcmbCondicion.cargar(sqlCondicion, "nombre_condicion", "id_condicion");
            mcmbNomComr.cargar(sqlNombreComr, "nombre_comercial", "id_nombrecomercial");

            mcmbNomComr.cmb_Cargable.SelectedValue = autoSeleccionado.nombreComercial;
            mcmbCondicion.cmb_Cargable.SelectedValue = autoSeleccionado.condicion;
            mtxtPatente.Text = autoSeleccionado.patente.Trim();
            mtxtAñoFab.Text = autoSeleccionado.año_Fabricacion.Trim();
            mtxtNroChasis.Text = autoSeleccionado.nro_Chasis.Trim();
            mtxtNroMotor.Text = autoSeleccionado.nro_Motor.Trim();
            MtxtCodSerieFab.Text = autoSeleccionado.cod_serie_fabrica.Trim();




        }

        private void ModificarAuto_Load(object sender, EventArgs e)
        {
  
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            
            NE_Autos auto = new NE_Autos();
            AutoMod.año_Fabricacion = mtxtAñoFab.Text.Trim();
            AutoMod.condicion = int.Parse(mcmbCondicion.cmb_Cargable.SelectedValue.ToString());
            AutoMod.nombreComercial = int.Parse(mcmbNomComr.cmb_Cargable.SelectedValue.ToString());
            AutoMod.cod_serie_fabrica = MtxtCodSerieFab.Text.Trim();
            AutoMod.nro_Chasis = mtxtNroChasis.Text.Trim();
            AutoMod.nro_Motor = mtxtNroMotor.Text.Trim();
            AutoMod.patente = mtxtPatente.Text.Trim();

            auto.ModificarAuto(AutoMod,patentevieja);
        }
    }
}
