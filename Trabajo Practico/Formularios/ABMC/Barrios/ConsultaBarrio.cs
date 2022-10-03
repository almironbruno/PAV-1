using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioBarrio;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Barrios
{
    public partial class ConsultaBarrio : FormBaseConsulta
    {

        private FormBaseABMC formularioPrincipal;
        public ConsultaBarrio(FormBaseABMC forl)
        {
            formularioPrincipal = forl;
            InitializeComponent();
            modoConsulta = true;
            cambiarFormaConsulta();


            
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string nombreBarrio = txtNombreBarrioABuscar.Text.Trim();

            NE_Barrio cl = new NE_Barrio();
            formularioPrincipal.consultaPrincipal = cl.consutaCl(nombreBarrio);

            this.Close();

        }
    }
}
