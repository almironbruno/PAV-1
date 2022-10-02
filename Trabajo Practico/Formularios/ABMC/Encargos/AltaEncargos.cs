using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioAutos;
using Trabajo_Practico.Clases.BackEnd.NegocioClientes;
using Trabajo_Practico.Clases.BackEnd.NegocioEncargos;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Encargos
{
    public partial class AltaEncargos : FormBaseAlta
    {
        public AltaEncargos()
        {                        
            InitializeComponent();
            cmbTipoDocumento.cargar("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cmbNomComercial.cargar("SELECT * FROM nombres_comerciales", "nombre_comercial", "id_nombreComercial");
            cmb_prioridad.cargar("SELECT * FROM prioridades", "nombre_prioridad", "id_prioridad");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                int nro_encargo = int.Parse(txtNroEncargo.Text);
                int tipo_doc_cliente = int.Parse(cmbTipoDocumento.cmb_Cargable.SelectedValue.ToString());
                int nro_doc_cliente = int.Parse(txtNroDocumento.Text);
                string fecha = txtFecha.Text;
                int nombre_comercial = int.Parse(cmbNomComercial.cmb_Cargable.SelectedValue.ToString());
                int legajo = int.Parse(txtLegajo.Text);
                int cod_caracteristica = int.Parse(txtCodigo.Text);
                string valor = cmb_prioridad.cmb_Cargable.SelectedValue.ToString();

                int prioridad = int.Parse(cmb_prioridad.cmb_Cargable.SelectedValue.ToString());
                
                Trabajo_Practico.Clases.Entidades.Encargos nuevoEncargo = new Clases.Entidades.Encargos(nro_encargo, tipo_doc_cliente, nro_encargo, fecha, nombre_comercial, legajo, cod_caracteristica, prioridad);
                MessageBox.Show(nuevoEncargo.toString());

                NE_Encargos encargo = new NE_Encargos();
                encargo.agregarEncargo(nuevoEncargo);
            }
            else
            {
                return;
            }
        }
    }
}
