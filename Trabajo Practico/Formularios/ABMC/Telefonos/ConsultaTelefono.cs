using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioTelefonos;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Telefonos
{
    public partial class ConsultaTelefono : FormBaseConsulta
    {

        private FormBaseABMC formularioPrincipal;

        public ConsultaTelefono(FormBaseABMC forl)
        {
            formularioPrincipal = forl;
            InitializeComponent();
            modoConsulta = true;
            cambiarFormaConsulta();

            cmbCargableCarac.cargarParaConsulta("SELECT * FROM caracteristicas_telefonicas","nombre_region","nro_caracteristica_telefonica");
            cmbCargableTipoDoc.cargarParaConsulta("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)

        {   //Asigno los datos que carga el usuario
            string numTelCliente = txtNumTelCliente.Text.Trim();
            string caracTelCliente = cmbCargableCarac.cmb_Cargable.SelectedValue.ToString();
            string numDocCliente = txtNumDocCliente.Text.Trim();
            string tipoDocCliente = cmbCargableTipoDoc.cmb_Cargable.SelectedValue.ToString();

            //Llamo al BackEnd
            NE_Telefonos tl = new NE_Telefonos();
            formularioPrincipal.consultaPrincipal = tl.consultaTel(numTelCliente, caracTelCliente, numDocCliente, tipoDocCliente);

            this.Close();

             
        }
    }
}
