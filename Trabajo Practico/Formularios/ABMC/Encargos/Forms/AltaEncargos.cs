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
            cmbPrioridad.cargar("SELECT * FROM prioridades", "nombre_prioridad", "id_prioridad");
            cmbEmpleado.cargar("SELECT * FROM empleados", "nombre", "legajo_empleado");
            cmbTipoCaracteristica.cargar("SELECT * FROM tipo_caracteristica","nombre_tipo","id_caracteristica");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    cmbTipoDocumento.Focus();
                    int tipo_doc_cliente = int.Parse(cmbTipoDocumento.cmb_Cargable.SelectedValue.ToString());
                    int nro_doc_cliente = int.Parse(txtNroDocumento.Text);
                    string fecha = txtFecha.Text.Trim();
                    int nombre_comercial = int.Parse(cmbNomComercial.cmb_Cargable.SelectedValue.ToString());
                    int legajo = int.Parse(cmbEmpleado.cmb_Cargable.SelectedValue.ToString());                    
                    int cod_caracteristica = int.Parse(cmbTipoCaracteristica.cmb_Cargable.SelectedValue.ToString());
                    int prioridad = int.Parse(cmbPrioridad.cmb_Cargable.SelectedValue.ToString());


                    Trabajo_Practico.Clases.Entidades.Encargos nuevoEncargo = new Clases.Entidades.Encargos(tipo_doc_cliente, nro_doc_cliente, fecha, nombre_comercial, legajo, cod_caracteristica, prioridad);                    

                    NE_Encargos encargo = new NE_Encargos();
                    encargo.agregarEncargo(nuevoEncargo);
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay un campo ingresado que no coincide correctamente");                
            }
        }
    }
}
