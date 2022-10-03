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

namespace Trabajo_Practico.Formularios.ABMC.Encargos
{
    public partial class CamposEncargos : FormBaseBotones
    {
        public CamposEncargos()
        {
            InitializeComponent();
        }

        public CamposEncargos(Trabajo_Practico.Clases.Entidades.Encargos encargo)
        {
            cargarCampos(encargo);
            cmbTipoDocumento.Enabled = false;
            txtNroDocumento.Enabled = false;
            txtFecha.Enabled = false;
            cmbNomComercial.Enabled = false;
            txtLegajo.Enabled = false;
            txtCodigo.Enabled = false;
            cmb_prioridades_now.Enabled = false;
        }


        protected void cargarCampos(Trabajo_Practico.Clases.Entidades.Encargos encargo)
        {
            cmbTipoDocumento.cargar("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cmbNomComercial.cargar("SELECT * FROM nombres_comerciales", "nombre_comercial", "id_nombreComercial");
            cmb_prioridades_now.cargar("SELECT * FROM prioridades", "nombre_prioridad", "id_prioridad");
            cmbTipoDocumento.cmb_Cargable.SelectedValue = encargo.tipoDocumento;
            cmbNomComercial.cmb_Cargable.SelectedValue = encargo.nombreComercial;
            cmb_prioridades_now.cmb_Cargable.SelectedValue = encargo.prioridad;
            txtNroDocumento.Text = encargo.nroDocumento.ToString();
            txtFecha.Text = encargo.fecha;
            txtCodigo.Text = encargo.codCaracteristica.ToString();
            txtLegajo.Text = encargo.legajoEmpletado.ToString();

        }


    }
}
