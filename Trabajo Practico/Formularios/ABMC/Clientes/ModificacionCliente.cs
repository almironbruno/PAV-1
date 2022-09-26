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

namespace Trabajo_Practico.Formularios.ABMC.Clientes
{
    public partial class ModificacionCliente : FormBaseModificacion
    {
        Trabajo_Practico.Clases.Entidades.Clientes ClienteMod;
        public ModificacionCliente(Trabajo_Practico.Clases.Entidades.Clientes  cliente)
        {
            ClienteMod = cliente;
            InitializeComponent();
            cmbCargable_TipoDoc.cargar("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cmbCargable_Barrio.cargar("SELECT * FROM barrios", "nombre_barrio", "id_barrios");
            cmbCargable_TipoDoc.cmb_Cargable.SelectedValue = cliente.tipo_doc.Trim();
            cmbCargable_Barrio.cmb_Cargable.SelectedValue = cliente.id_barrio.Trim();
            mTxt_Apellido.Text=cliente.apellido.Trim();
            mtxt_Calle.Text = cliente.calle.Trim();
            mTxt_FechaNac.Text = cliente.fecha_nacimiento.Trim();
            mTxt_Nombre.Text = cliente.nombre.Trim();
            mTxt_NroDocu.Text = cliente.nro_doc.Trim();
            mTxt_NroCalle.Text = cliente.nro_calle.Trim();
            
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            base.btn_Aceptar_Click(sender,e);
            NE_Clientes clientes = new NE_Clientes();
            ClienteMod.nombre = mTxt_Nombre.Text.Trim();
            ClienteMod.apellido= mTxt_Apellido.Text.Trim();
            ClienteMod.fecha_nacimiento = mTxt_FechaNac.Text.Trim();
            ClienteMod.calle = mtxt_Calle.Text.Trim();
            ClienteMod.nro_calle = mTxt_NroCalle.Text.Trim();
            ClienteMod.tipo_doc = cmbCargable_TipoDoc.cmb_Cargable.SelectedValue.ToString();
            ClienteMod.nro_doc= mTxt_NroDocu.Text.Trim();
            ClienteMod.id_barrio = cmbCargable_Barrio.cmb_Cargable.SelectedValue.ToString();
            clientes.ModificarCliente(ClienteMod);
        }
    }
}
