using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Encargos.Forms
{
    public partial class InfoEncargos : Campos_Encargos
    {
        public InfoEncargos()
        {
            
            // cmbCargable_Cargos.cmb_Cargable.Enabled = false;
            cmbTipoDocumento.cmb_Cargable.Enabled = false;
            txtNroDocumento.Enabled = false;
            txtFecha.Enabled = false;
            cmbNomComercial.cmb_Cargable.Enabled = false;
            cmbEmpleado.cmb_Cargable.Enabled = false;
            cmbTipoCaracteristica.cmb_Cargable.Enabled = false;
            cmbPrioridad.cmb_Cargable.Enabled = false;
            btn_LimpiarCampos.Hide();
            btn_Aceptar.Hide();
            
            InitializeComponent();

            cambiarFormaConsulta();
        }
        public override void cargarInfo(DataGridViewRow row)
        {
            cmbTipoDocumento.cargar("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cmbNomComercial.cargar("SELECT * FROM nombres_comerciales", "nombre_comercial", "id_nombreComercial");
            cmbPrioridad.cargar("SELECT * FROM prioridades", "nombre_prioridad", "id_prioridad");
            cmbEmpleado.cargar("SELECT * FROM empleados", "nombre", "legajo_empleado");
            cmbTipoCaracteristica.cargar("SELECT * FROM tipo_caracteristica", "nombre_tipo", "id_caracteristica");

            cmbTipoDocumento.cmb_Cargable.Text = row.Cells[0].Value.ToString();            
            txtNroDocumento.Text = row.Cells[1].Value.ToString();
            txtFecha.Text = row.Cells[2].Value.ToString();
            cmbNomComercial.cmb_Cargable.Text = row.Cells[3].Value.ToString();
            cmbTipoCaracteristica.cmb_Cargable.Text = row.Cells[4].Value.ToString();
            cmbPrioridad.cmb_Cargable.Text =row.Cells[5].Value.ToString();            
        }
    }
}
