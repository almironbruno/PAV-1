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
using Trabajo_Practico.Clases.BackEnd.NegocioNombreComercial;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.NombreComercial
{
    public partial class AltaNombreComercial : FormBaseAlta
    {
        public AltaNombreComercial()
        {
            InitializeComponent();
        }

        private void AltaNombreComercial_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreComercial_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            string nom = txtNombreComercial.Text;
            int marc = int.Parse(txtIDMarca.Text);
            int gam = int.Parse(txtIDGama.Text);

            NombresComerciales nomcom = new NombresComerciales(nom, marc, gam);

            NE_NombreComercial nomcomAgregar = new NE_NombreComercial();

            nomcomAgregar.AgregarNombreComercial(nomcom);
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIDMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDGama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
