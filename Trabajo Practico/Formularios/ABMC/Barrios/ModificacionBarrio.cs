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
using Trabajo_Practico.ControlesPropios;
using Trabajo_Practico.Clases.BackEnd;
using Trabajo_Practico.Clases.BackEnd.NegocioBarrio;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Formularios.ABMC.Barrios
{
    public partial class ModBarrio : FormBaseModificacion
    {

        Trabajo_Practico.Clases.Entidades.Barrio BarrioMod;

        public ModBarrio(Trabajo_Practico.Clases.Entidades.Barrio barrio)
        {
            InitializeComponent();
            BarrioMod = barrio;

            txtReemplazoNombreBarrio.Text = barrio.nombreBarrio.Trim();

            
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            base.btn_Aceptar_Click(sender, e);
            NE_Barrio barrio = new NE_Barrio();

            BarrioMod.nombreBarrio = txtReemplazoNombreBarrio.Text.Trim();
            barrio.ModificarBarrio(BarrioMod);
        }
    }
}
