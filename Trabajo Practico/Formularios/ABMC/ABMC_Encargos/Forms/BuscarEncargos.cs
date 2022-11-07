using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioEncargos;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Encargos.Forms
{
    public partial class BuscarEncargos : FormBaseConsulta
    {
        private FormBaseABMC formPrincipal;
        public BuscarEncargos(FormBaseABMC form)
        {
            InitializeComponent();
            formPrincipal = form;
            cmbTipoDocumento.cargar("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cambiarNombre("Buscar encargo");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {


                // Asigno los datos que va a seleccionar nuestro usuario
                string tipoDocumento = cmbTipoDocumento.cmb_Cargable.SelectedValue.ToString().Trim();
                string nroDocumento = txtNroDocumento.Text.Trim();
                
                // Nos conectamos con Backend
                NE_Encargos en = new NE_Encargos();
                formPrincipal.consultaPrincipal = en.buscarEncargo(tipoDocumento, nroDocumento);

                // Vuelvo al formPrincipal del ABM
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un problema", "Mensaje");
            }

        }
    }
}
