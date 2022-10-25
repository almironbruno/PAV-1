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
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms
{
    public partial class BuscarLocalidades : FormBaseConsulta
    {
        private FormBaseABMC formPrincipal;
        public BuscarLocalidades(FormBaseABMC form)
        {
            InitializeComponent();
            formPrincipal = form;
            cambiarNombre("Localidad");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreLocalidad = txtNombreLocalidad.Text.Trim();

                NE_Localidades negoLocalidad = new NE_Localidades();
                formPrincipal.consultaPrincipal = negoLocalidad.buscarLocalidad(nombreLocalidad);

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema", "Mensaje");
                throw;
            }
        }
    }
}
