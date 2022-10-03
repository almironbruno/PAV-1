using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioEmpleados;
using Trabajo_Practico.Clases.BackEnd.NegocioEncargos;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Encargos
{
    public partial class BuscarEncargos : FormBaseConsulta
    {
        public BuscarEncargos()
        {
            InitializeComponent();
            cmbTipoDocumento.cargar("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cambiarNombre("Encargos");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            int tipo_documento = int.Parse(cmbTipoDocumento.cmb_Cargable.SelectedValue.ToString());
            int nro_documento = int.Parse(txtNroDocumento.Text);

            NE_Encargos negoEncargo = new NE_Encargos();
            
            DataTable tabla = new DataTable();

            tabla = negoEncargo.buscarEncargo(tipo_documento, nro_documento);

            if(tabla.Rows.Count > 0)
            {
                string tipo_documento_cliente = tabla.Rows[0]["tipo_doc_cliente"].ToString();
                string nro_documento_cliente = tabla.Rows[1]["nro_doc_cliente"].ToString();

                //Trabajo_Practico.Clases.Entidades.Encargos encargo = new Trabajo_Practico.Clases.Entidades.Encargos(tipo_documento_cliente, nro_documento_cliente);
            }
        }

        /*
         string codigoPostal = txtNombreLocalidad.Text;

            NE_Localidades negoLocalidad = new NE_Localidades();

            DataTable tabla = new DataTable();
            tabla = negoLocalidad.buscarLocalidad(codigoPostal);

            if (tabla.Rows.Count > 0)
            {
                string nombreLocalidad = tabla.Rows[0]["nombre_localidad"].ToString();

                Trabajo_Practico.Clases.Entidades.Localidades localidad = new Trabajo_Practico.Clases.Entidades.Localidades(nombreLocalidad);
                string salida = localidad.toString();

                MessageBox.Show("Se se ha encontrado la localidad buscada: " + "\n" + salida, "Mensaje");
            }
            else
            {
                MessageBox.Show("Localidad no encontrada");
            }
         */
    }
}
