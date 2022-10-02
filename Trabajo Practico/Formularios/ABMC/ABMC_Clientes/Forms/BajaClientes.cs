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
using Trabajo_Practico.Clases.BackEnd.NegocioEmpleados;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.ABMC.Empleados;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Clientes.Forms
{
    public partial class BajaClientes : CamposClientes
    {
        private string tipo_doc;
        private string nro_doc;
        public BajaClientes(DataGridViewRow row)
        {
            InitializeComponent();
            //Desactivo todos los campos
            cmbCargable_TipoDoc.Enabled = false;
            mTxt_NroDocu.Enabled = false;
            mTxt_Nombre.Enabled = false;
            mTxt_Apellido.Enabled = false;
            mTxt_FechaNac.Enabled = false;
            mtxt_Calle.Enabled = false;
            mTxt_NroCalle.Enabled = false;
            cmbCargable_Barrio.Enabled = false;
            btn_LimpiarCampos.Hide();



            //Tomo la info de la fila seleccionada
            int tipoDoc = bd.SelectNumeros($"SELECT id_doc_cliente FROM tipo_doc_clientes WHERE nombre_tipo_doc LIKE '{row.Cells[0].Value}'");
            int nroDoc = int.Parse(row.Cells[1].Value.ToString());
            string nombre = row.Cells[2].Value.ToString();
            string apellido = row.Cells[3].Value.ToString();
            string fechaNac = row.Cells[4].Value.ToString();
            string calle = row.Cells[5].Value.ToString();
            int nroCalle = int.Parse(row.Cells[6].Value.ToString());
            int barrio = bd.SelectNumeros($"SELECT id_barrios FROM barrios WHERE nombre_barrio LIKE '{row.Cells[7].Value}'");
            //Creo el objeto cliente
            Trabajo_Practico.Clases.Entidades.Clientes cliente = new Clases.Entidades.Clientes(tipoDoc, nroDoc, nombre, apellido, fechaNac, calle, nroCalle, barrio);
            //Cargos los campos con los datos del empleado
            cargarCampos(cliente);

            //tomo la PK para borrar
            tipo_doc = tipoDoc.ToString();
            nro_doc = nroDoc.ToString();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            
                NE_Clientes ClientesBorrar = new NE_Clientes();
                ClientesBorrar.BorrarCliente(tipo_doc,nro_doc);
                this.Close();
            
        }
    }
}
