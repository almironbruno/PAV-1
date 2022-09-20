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
using Trabajo_Practico.Clases.BackEnd.NegocioAutos;


namespace Trabajo_Practico.Formularios.ABMC.Autos
{
    public partial class AltaAutos : FormBaseAlta
    {
        public AltaAutos()
        {
            InitializeComponent();
        }

        private void AltaAutos_Load(object sender, EventArgs e)
        {
            string sqlCondicion = (@"SELECT * FROM condicion");
            string sqlNombreComr = (@"SELECT * FROM nombres_comerciales");
            cmbCondicion.cargar(sqlCondicion,"nombre_condicion","id_condicion");
            cmbNomComr.cargar(sqlNombreComr,"nombre_comercial","id_nombrecomercial");
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)


        {
            string codSerie = txtCodSerieFab.Text;
            string nombComer = cmbNomComr.cmb_Cargable.SelectedValue.ToString();
            int añoFab = int.Parse(txtAñoFab.Text);
            string condicion = cmbCondicion.cmb_Cargable.SelectedValue.ToString();
            int nroChasis = int.Parse(txtNroChasis.Text);
            int nroMotor = int.Parse(txtNroMotor.Text);
            string patente = txtPatente.Text;

            Vehiculos nvoAuto = new Vehiculos(codSerie, nombComer, añoFab, condicion, nroChasis, nroMotor, patente);

            MessageBox.Show(nvoAuto.mostrar(nvoAuto));

            NE_Autos Vehiculo = new NE_Autos();

            Vehiculo.AgregarAuto(nvoAuto);
            
            

            




        }

        private void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            txtCodSerieFab.Text = "";
            cmbNomComr.cmb_Cargable.Text = "";
            txtAñoFab.Text = "";
            cmbCondicion.cmb_Cargable.Text = "";
            txtNroChasis.Text = "";
            txtNroMotor.Text = "";
            txtPatente.Text = "";
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
