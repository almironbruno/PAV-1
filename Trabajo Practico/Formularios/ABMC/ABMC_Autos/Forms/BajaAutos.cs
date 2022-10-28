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
using Trabajo_Practico.Formularios.ABMC.Autos;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Autos.Forms
{
    public partial class BajaAutos : CamposAutos
    {
        public BajaAutos(DataGridViewRow row)
        {
            //desactivar los campos
            btn_LimpiarCampos.Enabled = false;
            txtCodSerieFab.ReadOnly = true;
            txtAñoFab.ReadOnly = true;
            txtNroChasis.ReadOnly = true;
            txtNroMotor.ReadOnly = true;
            txtPatente.ReadOnly = true;
            txtPrecioAuto.ReadOnly = true;
            cmbCondicion.Enabled = false;
            cmbNomComr.Enabled = false;
            btn_LimpiarCampos.Hide();

            //tomar la info de los campos
            string codSerie = row.Cells[0].Value.ToString();
            int id_comer = bd.SelectNumeros($"SELECT id_nombrecomercial FROM nombres_comerciales WHERE nombre_comercial LIKE '{row.Cells[1].Value.ToString()}' ");
            string añoFab = row.Cells[2].Value.ToString();
            int id_cond = bd.SelectNumeros($"SELECT id_condicion FROM condicion WHERE nombre_condicion LIKE '{row.Cells[6].Value.ToString()}' ");
            string nro_chasis = row.Cells[4].Value.ToString();
            string nro_motor = row.Cells[5].Value.ToString();
            string patente = row.Cells[3].Value.ToString();
            string monto = row.Cells[7].Value.ToString();
            //Estado de Venta..

            bool vendido = false;


            //Crear Objeto Auto

            Vehiculos auto = new Vehiculos(codSerie, id_comer, añoFab, id_cond, nro_chasis, nro_motor, patente,monto,vendido);

            //cargar los campos con los datos del auto

            cargarCampos(auto);


            InitializeComponent();
        }

        private void BajaAutos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            NE_Autos autoBorrar = new NE_Autos();
            autoBorrar.BorrarAuto(txtPatente.Text);
            this.Close();
        }
    }
}
