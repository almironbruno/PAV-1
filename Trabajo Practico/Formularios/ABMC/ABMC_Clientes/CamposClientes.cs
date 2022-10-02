using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Clientes
{
    public partial class CamposClientes : FormBaseBotones
    {
        public CamposClientes()
        {
            InitializeComponent();
           
        }

        public CamposClientes(Trabajo_Practico.Clases.Entidades.Clientes cliente) 
        {
           
            cargarCampos(cliente);
            cmbCargable_TipoDoc.Enabled = false;
            mTxt_Nombre.Enabled = false;
            mTxt_Apellido.Enabled = false;
            mTxt_FechaNac.Enabled = false;
            mtxt_Calle.Enabled = false;
            mTxt_NroCalle.Enabled = false;
            cmbCargable_Barrio.Enabled = false;
        }
        protected void cargarCampos(Trabajo_Practico.Clases.Entidades.Clientes cliente) 
        {
            cmbCargable_TipoDoc.cargar("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cmbCargable_Barrio.cargar("SELECT * FROM barrios", "nombre_barrio", "id_barrios");
            cmbCargable_TipoDoc.cmb_Cargable.SelectedValue = cliente.tipo_doc;
            mTxt_NroDocu.Text = cliente.nro_doc.ToString();
            mTxt_Nombre.Text = cliente.nombre;
            mTxt_Apellido.Text = cliente.apellido;
            mTxt_FechaNac.Text = cliente.fecha_nacimiento;
            mtxt_Calle.Text = cliente.calle;
            mTxt_NroCalle.Text = cliente.nro_calle.ToString();
            cmbCargable_Barrio.cmb_Cargable.SelectedValue = cliente.id_barrio;


        }
    }
}
