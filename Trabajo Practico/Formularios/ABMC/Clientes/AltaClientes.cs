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
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Clientes
{
    public partial class AltaClientes : FormBaseAlta 
    {
        public AltaClientes()
        {
            InitializeComponent();
            cmbCargable_TipoDoc.cargar("SELECT * FROM tipo_doc_clientes","nombre_tipo_doc","id_doc_cliente");
            cmbCargable_Barrio.cargar("SELECT * FROM barrios","nombre_barrio","id_barrios");
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string tipoDoc = cmbCargable_TipoDoc.cmb_Cargable.SelectedValue.ToString();
                string nroDoc = mTxt_NroDocu.Text;
                string nombre = mTxt_Nombre.Text;
                string apellido = mTxt_Apellido.Text;
                string fechaNac = mTxt_FechaNac.Text;
                string calle = mtxt_Calle.Text;
                string nroCalle = mTxt_NroCalle.Text;
                string id_Barrio = cmbCargable_Barrio.cmb_Cargable.SelectedValue.ToString();

                Trabajo_Practico.Clases.Entidades.Clientes nuevoCliente = new Trabajo_Practico.Clases.Entidades.Clientes(tipoDoc, nroDoc, nombre, apellido, fechaNac, calle, nroDoc, id_Barrio);
                MessageBox.Show(nuevoCliente.toString());

                NE_Clientes Cliente = new NE_Clientes();

                Cliente.AgregarCliente(nuevoCliente);
                this.Close();
            }
            else
            {
                return;
            }
            
        }
    }
}
