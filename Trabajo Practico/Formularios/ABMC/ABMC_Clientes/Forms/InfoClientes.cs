using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Clientes.Forms
{
    public partial class InfoClientes : CamposClientes
    {
        public InfoClientes()
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
            btn_Aceptar.Hide();

            InitializeComponent();

            //Cambia los botones al modo Consulta
            cambiarFormaConsulta();

        }
        public override void cargarInfo(DataGridViewRow row)
        {
            cmbCargable_TipoDoc.cmb_Cargable.SelectedValue = bd.SelectNumeros($"SELECT id_doc_cliente FROM tipo_doc_clientes WHERE nombre_tipo_doc LIKE '{row.Cells[0].Value}'");
            mTxt_NroDocu.Text = row.Cells[1].Value.ToString();
            mTxt_Nombre.Text = row.Cells[2].Value.ToString();
            mTxt_Apellido.Text = row.Cells[3].Value.ToString();
            mTxt_FechaNac.Text = row.Cells[4].Value.ToString();
            mtxt_Calle.Text= row.Cells[5].Value.ToString();
            mTxt_NroCalle.Text = row.Cells[6].Value.ToString();
            cmbCargable_Barrio.cmb_Cargable.SelectedValue = bd.SelectNumeros($"SELECT id_barrios FROM barrios WHERE nombre_barrio LIKE '{row.Cells[7].Value}'");
            

        }

        private void InfoClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
