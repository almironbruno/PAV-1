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

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Marcas.Forms
{
    public partial class BajaMarca : CamposMarcas
    {
        public BajaMarca(DataGridViewRow row)
        {
            //Descartivar el campo
            txtMarcaRegs.ReadOnly = true;

            //Tomar el valor de la dtgrid 
            string nomMarca = row.Cells[1].Value.ToString();

            Marca marcaAuto = new Marca(nomMarca);

            cargarCampos(marcaAuto);


            InitializeComponent();
        }

        

        private void BajaMarca_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            NE_Marcas marcaBorrar = new NE_Marcas();
            marcaBorrar.BorrarMarca(txtMarcaRegs.Text);
            this.Close();

        }
    }
}
