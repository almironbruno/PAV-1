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
using Trabajo_Practico.ControlesPropios;
using Trabajo_Practico.Clases.BackEnd;
using Trabajo_Practico.Clases.BackEnd.NegocioClientes;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.ABMC.ABMC_Clientes;

namespace Trabajo_Practico.Formularios.ABMC.Clientes
{
    public partial class ModificacionCliente : CamposClientes
    {
        
        public ModificacionCliente(DataGridViewRow row)
        {
            InitializeComponent();
            //Se cargan los CombosBox
            cmbCargable_TipoDoc.cargar("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cmbCargable_Barrio.cargar("SELECT * FROM barrios", "nombre_barrio", "id_barrios");
            cmbCargable_TipoDoc.cmb_Cargable.SelectedValue = bd.SelectNumeros($"SELECT id_doc_cliente FROM tipo_doc_clientes WHERE nombre_tipo_doc LIKE '{row.Cells[0].Value.ToString()}'");
            mTxt_NroDocu.Text = row.Cells[1].Value.ToString() ;
            mTxt_Nombre.Text = row.Cells[2].Value.ToString();
            mTxt_Apellido.Text = row.Cells[3].Value.ToString(); 
            mTxt_FechaNac.Text = row.Cells[4].Value.ToString().Trim();
            mtxt_Calle.Text = row.Cells[5].Value.ToString();
            mTxt_NroCalle.Text = row.Cells[6].Value.ToString();
            
            cmbCargable_Barrio.cmb_Cargable.SelectedValue = bd.SelectNumeros($"SELECT id_barrios FROM barrios WHERE nombre_barrio LIKE '{row.Cells[7].Value.ToString()}'");

        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {

            if (validarCampos())
            {
                //Toma lo ingresado en el form
                int tipo_doc = int.Parse(cmbCargable_TipoDoc.cmb_Cargable.SelectedValue.ToString());
                int nro_doc = int.Parse(mTxt_NroDocu.Text.Trim());
                string nombre = mTxt_Nombre.Text.Trim();
                string apellido= mTxt_Apellido.Text.Trim();
                string fecha_nacimiento = mTxt_FechaNac.Text.Trim();
                string calle = mtxt_Calle.Text.Trim();
                string nro_calle = mTxt_NroCalle.Text.Trim();
                int id_barrio = int.Parse(cmbCargable_Barrio.cmb_Cargable.SelectedValue.ToString());

                //Crea el objeto cliente
                Trabajo_Practico.Clases.Entidades.Clientes cliente = new Clases.Entidades.Clientes(tipo_doc, nro_doc, nombre, apellido, fecha_nacimiento, calle, nro_doc, id_barrio);
                NE_Clientes clientes = new NE_Clientes(); 
                clientes.ModificarCliente(cliente);

                

            }


        }

        private void ModificacionCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
