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

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Encargos
{
    public partial class Campos_Encargos : FormBaseBotones
    {                
        public Campos_Encargos()
        {            
            InitializeComponent();
        }

        public Campos_Encargos(Trabajo_Practico.Clases.Entidades.Encargos encargo )
        {
            cargarCampos(encargo);
            cmbTipoDocumento.Enabled = false;
            txtNroDocumento.Enabled = false;
            txtFecha.Enabled = false;
            cmbNomComercial.Enabled = false;
            cmbEmpleado.Enabled = false;
            cmbTipoCaracteristica.Enabled = false;
            cmbPrioridad.Enabled = false;
        }
        protected void cargarCampos(Trabajo_Practico.Clases.Entidades.Encargos encargo)
        {
            cmbTipoDocumento.cargar("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cmbNomComercial.cargar("SELECT * FROM nombres_comerciales", "nombre_comercial", "id_nombreComercial");
            cmbPrioridad.cargar("SELECT * FROM prioridades", "nombre_prioridad", "id_prioridad");
            cmbEmpleado.cargar("SELECT * FROM empleados", "nombre", "legajo_empleado");
            cmbTipoCaracteristica.cargar("SELECT * FROM tipo_caracteristica", "nombre_tipo", "id_caracteristica");

            cmbTipoDocumento.cmb_Cargable.SelectedValue = encargo.tipoDocumento;
            txtNroDocumento.Text = encargo.nroDocumento.ToString();
            txtFecha.Text = encargo.fecha;
            cmbNomComercial.cmb_Cargable.SelectedValue = encargo.nombreComercial;
            cmbEmpleado.cmb_Cargable.SelectedValue = encargo.legajoEmpletado;
            cmbTipoCaracteristica.cmb_Cargable.SelectedValue = encargo.codCaracteristica;
            cmbPrioridad.cmb_Cargable.SelectedValue = encargo.prioridad;

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Separa el string en partes para validar
                int dia = int.Parse(txtFecha.Text.Substring(0, 2));
                int mes = int.Parse(txtFecha.Text.Substring(3, 2));
                int anio = int.Parse(txtFecha.Text.Substring(6, 4));


                if (dia > 0 & dia < 32 & mes > 0 & mes < 13)
                {
                    btn_Aceptar.Enabled = true;
                    errorProviderBase.Clear();

                }
            }
            catch (Exception)
            {
                //Deshabilita el boton Aceptar
                btn_Aceptar.Enabled = false;
                //Muestra el error en pantalla
                errorProviderBase.SetError(txtFecha, "Debe ingresar una fecha correcta");
            }
        }
    }
}
