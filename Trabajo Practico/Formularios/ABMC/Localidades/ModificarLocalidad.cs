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
using Trabajo_Practico.Clases.BackEnd.NegocioMarcas;
using Trabajo_Practico.Formularios.Base;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Formularios.ABMC.Localidades
{
    public partial class ModificarLocalidad : FormBaseModificacion
    {
        Trabajo_Practico.Clases.Entidades.Localidades localidadMod;
        string nomLocalidad;

        public ModificarLocalidad(Trabajo_Practico.Clases.Entidades.Localidades localidadModificado)
        {
            localidadMod = localidadModificado;
            nomLocalidad = localidadModificado.nombreLocalidad;
            InitializeComponent();

            txtNombreLocalidad.Text = localidadModificado.nombreLocalidad;
        }


        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtNombreLocalidad.Focus();
                NE_Localidades modLocalidad = new NE_Localidades();
                localidadMod.nombreLocalidad = txtNombreLocalidad.Text;

                modLocalidad.modificarLocalidad(localidadMod, nomLocalidad);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema", "Mensaje");
            }
        }
    }
}
