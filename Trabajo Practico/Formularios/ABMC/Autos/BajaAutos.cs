using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.Base;
using Trabajo_Practico.Formularios.ABMC.Autos;
using Trabajo_Practico.Clases.BackEnd;



namespace Trabajo_Practico.Formularios.ABMC.Autos
{
    public partial class BajaAutos : Form
    {
        protected BE_Acceso_Datos bd;
        public BajaAutos(DataGridView row)
        {
            InitializeComponent();
            bd = new BE_Acceso_Datos();
            dtgvAutosParaEliminar.cargar(bd.Ejecutar_Select("SELECT * FROM autos"));
            //txtCodSerie.cargar(dtgvAutosParaEliminar.row)

        }

        private void dtgvAutosParaEliminar_Load(object sender, EventArgs e)
        {

        }

        private void BajaAutos_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_CancelarElim_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            txtCodSerie.txt_cargable.Text = "";
            txtNroChas.txt_cargable.Text = "";
            txtNroMotr.txt_cargable.Text = "";
            txtPatenteElm.txt_cargable.Text = "";

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            dtgvAutosParaEliminar.cargar(bd.Ejecutar_Select("SELECT * FROM autos"));
        }
    }
}
