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
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Base;


namespace Trabajo_Practico.Formularios.ABMC.Localidades
{
    public partial class AltaLocalidades : FormBaseAlta
    {
        public AltaLocalidades()
        {
            
            InitializeComponent();
            //Hace invisible el prompt
            txtNombreLocalidad.HidePromptOnLeave = true;
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    txtNombreLocalidad.Focus();
                    string nombreLocalidad = txtNombreLocalidad.Text;


                    Trabajo_Practico.Clases.Entidades.Localidades nuevaLocalidad = new Trabajo_Practico.Clases.Entidades.Localidades(nombreLocalidad);
                    MessageBox.Show(nuevaLocalidad.toString());

                    NE_Localidades Localidad = new NE_Localidades();

                    Localidad.agregarLocalidad(nuevaLocalidad);
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Mensaje");
            }
        }
    }
}

