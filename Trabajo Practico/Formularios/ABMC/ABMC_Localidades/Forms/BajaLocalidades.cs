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
    public partial class BajaLocalidades : CamposLocalidades
    {
        string nomLocalidad;
        public BajaLocalidades(Trabajo_Practico.Clases.Entidades.Localidades localidad)
        {
            nomLocalidad = localidad.nombreLocalidad;
            InitializeComponent();
            txtNombreLocalidad.Text = localidad.nombreLocalidad;
            txtNombreLocalidad.Enabled = false;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea eliminar esta localidad ?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NE_Localidades negoLocalidad = new NE_Localidades();
                    negoLocalidad.borrarLocalidad(nomLocalidad);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema", "Mensaje");
            }
        }
    }
}
