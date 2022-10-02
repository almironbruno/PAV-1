using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioClientes;


namespace Trabajo_Practico.Formularios.ABMC.ABMC_Clientes.Forms
{
    
    public partial class ConsultaClientes : CamposClientes
    {
        private FormBaseABMC formularioPrincipal;
        public ConsultaClientes(FormBaseABMC fo1r)
        {
            formularioPrincipal = fo1r;
            InitializeComponent();
            modoConsulta = true;
            cambiarFormaConsulta();
            cmbCargable_TipoDoc.cargarParaConsulta("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cmbCargable_Barrio.cargarParaConsulta("SELECT * FROM barrios", "nombre_barrio", "id_barrios");


        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //Asigno los datos que selecciona el usuario
            string tipoDoc = cmbCargable_TipoDoc.cmb_Cargable.SelectedValue.ToString();
            string nroDoc = mTxt_NroDocu.Text.Trim();
            string nombre = mTxt_Nombre.Text.Trim();
            string apellido = mTxt_Apellido.Text.Trim();
            string fechaNac =mTxt_FechaNac.Text.Trim();
            string calle = mtxt_Calle.Text.Trim();
            string nroCalle = mTxt_NroCalle.Text.Trim();
            string barrio = cmbCargable_Barrio.cmb_Cargable.SelectedValue.ToString();
            //Llama al BackEnd
            NE_Clientes cl = new NE_Clientes();
            formularioPrincipal.consultaPrincipal = cl.consultaCl(tipoDoc,nroDoc, nombre, apellido, fechaNac,calle,nroCalle,barrio);

            //Vuelvo al formPrincipal del ABM
            this.Close();
        }
    }
}
