using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioMarcas;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Marcas
{
    public partial class ModificarMarca : FormBaseModificacion 
    {
        Marca marcaMod;
        string nombreViejo;
        public ModificarMarca(Marca marcamod)
        {
            marcaMod = marcamod;
            nombreViejo = marcamod.nombreMarca;
            InitializeComponent();

            mtxtNombreMarca.Text = marcamod.nombreMarca.Trim();
        }

        private void ModificarMarca_Load(object sender, EventArgs e)
        {
            


        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            NE_Marcas negoMarc = new NE_Marcas();

            marcaMod.nombreMarca = mtxtNombreMarca.Text;

            negoMarc.ModificarMarca(marcaMod,nombreViejo);
        }
    }
}
