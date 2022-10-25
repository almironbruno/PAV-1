using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioLocalidades;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms
{
    public partial class BajaLocalidades : CamposLocalidades
    {        
        public BajaLocalidades(DataGridViewRow row)
        {
            // Deshabilita el campo nombre de localidad.
            txtNombreLocalidad.ReadOnly = true;

            // Toma el valor que contiene la grilla.
            string nomLocalidad = row.Cells[1].Value.ToString();

            Localidades localidad = new Localidades(nomLocalidad);

            cargarCampos(localidad);
            //nomLocalidad = localidad.nombreLocalidad;
            InitializeComponent();
            //txtNombreLocalidad.Text = localidad.nombreLocalidad;
            //txtNombreLocalidad.Enabled = false;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿ Desea eliminar esta localidad del sistema ?", "Eliminar Localidad", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(resultado == DialogResult.OK)
            {
                NE_Localidades localidadBorrar = new NE_Localidades();
                localidadBorrar.borrarLocalidad(txtNombreLocalidad.Text);
                this.Close();
            }                                  
        }
    }
}
