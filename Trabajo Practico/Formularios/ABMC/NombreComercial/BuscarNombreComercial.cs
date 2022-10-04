using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioNombreComercial;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.NombreComercial
{
    public partial class BuscarNombreComercial : FormBaseConsulta
    {

        private FormBaseABMC formularioPrincipal;

        public BuscarNombreComercial(FormBaseABMC forl)
        {
            formularioPrincipal = forl;
            InitializeComponent();
            modoConsulta = true;
            cambiarFormaConsulta();

            cmbMarcaBuscar.cargarParaConsulta("SELECT * FROM marcas", "nombre", "id_marca");
            cmbGamaBuscar.cargarParaConsulta("SELECT * FROM gamas", "nombre_gama", "id_gama");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)

        {  
            string nomcom = txtNomComBuscar.Text.Trim();
            string marc = cmbMarcaBuscar.cmb_Cargable.SelectedValue.ToString();
            string gam = cmbGamaBuscar.cmb_Cargable.SelectedValue.ToString();
            
            NE_NombreComercial tl = new NE_NombreComercial();
            formularioPrincipal.consultaPrincipal = tl.consultaNomCom(nomcom, marc, gam);

            this.Close();


        }
        private void BuscarNombreComercial_Load(object sender, EventArgs e)
        {

        }

    }
}
