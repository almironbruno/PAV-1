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
using Trabajo_Practico.Formularios.ABMC.ABMC_Autos;

namespace Trabajo_Practico.Formularios.ABMC.Autos
{
    public partial class ModificarAuto : CamposAutos
    {
        
        
        public ModificarAuto(DataGridViewRow row)
        {

            string codSerie = row.Cells[0].Value.ToString();
            int id_comer = bd.SelectNumeros($"SELECT id_nombrecomercial FROM nombres_comerciales WHERE nombre_comercial LIKE '{row.Cells[1].Value.ToString()}' ");
            string añoFab = row.Cells[2].Value.ToString();
            int id_cond = bd.SelectNumeros($"SELECT id_condicion FROM condicion WHERE nombre_condicion LIKE '{row.Cells[6].Value.ToString()}' ");
            string nro_chasis = row.Cells[4].Value.ToString();
            string nro_motor = row.Cells[5].Value.ToString();
            string patente = row.Cells[3].Value.ToString();
            

            Vehiculos auto = new Vehiculos(codSerie, id_comer, añoFab, id_cond, nro_chasis, nro_motor, patente);


            cargarCampos(auto);

            InitializeComponent();

            txtPatente.Enabled = false;
            /*/
            patentevieja = autoSeleccionado.patente;
            AutoMod = autoSeleccionado;
            

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
            /*/



        }

        private void ModificarAuto_Load(object sender, EventArgs e)
        {
  
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                //Toma lo ingresado en el form
 

                NE_Autos nEauto = new NE_Autos();
                string año_Fabricacion = txtAñoFab.Text.Trim();
                int condicion = int.Parse(cmbCondicion.cmb_Cargable.SelectedValue.ToString());
                int nombreComercial = int.Parse(cmbNomComr.cmb_Cargable.SelectedValue.ToString());
                string cod_serie_fabrica = txtCodSerieFab.Text.Trim();
                string nro_Chasis = txtNroChasis.Text.Trim();
                string nro_Motor = txtNroMotor.Text.Trim();
                string patente = txtPatente.Text.Trim();

                Vehiculos auto = new Vehiculos(cod_serie_fabrica, nombreComercial, año_Fabricacion, condicion, nro_Chasis, nro_Motor, patente);

                nEauto.ModificarAuto(auto, patente);
            }
            
        }
    }
}
