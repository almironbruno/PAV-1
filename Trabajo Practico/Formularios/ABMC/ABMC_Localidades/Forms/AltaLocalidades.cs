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

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms
{
    public partial class AltaLocalidades : CamposLocalidades
    {
        public AltaLocalidades()
        {
            InitializeComponent();
            txtNombreLocalidad.HidePromptOnLeave = true;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    txtNombreLocalidad.Focus();
                    string nombreLocalidad = txtNombreLocalidad.Text;

                    Trabajo_Practico.Clases.Entidades.Localidades nuevaLocalidad = new Trabajo_Practico.Clases.Entidades.Localidades(nombreLocalidad);
                    //MessageBox.Show(nuevaLocalidad.toString());

                    NE_Localidades localidad = new NE_Localidades();

                    localidad.agregarLocalidad(nuevaLocalidad);
                    this.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un problema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
