using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioTelefonos;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Formularios.ABMC.Telefonos
{
    public partial class BajaTelefono : InfoTelefonos
    {
        public BajaTelefono()
        {
            InitializeComponent();
            btn_Aceptar.Show();
            txtNumTelCliente.Enabled = false;
            txtCaracteristica.Enabled = false;
            txtNumDocCliente.Enabled = false;
            txtTipoDocCliente.Enabled = false;
            btn_LimpiarCampos.Hide();

        }
        public override void cargarInfo(DataGridViewRow row)
        {
            txtNumTelCliente.Text = row.Cells[0].Value.ToString();
            txtCaracteristica.Text = row.Cells[1].Value.ToString();
            txtNumDocCliente.Text = row.Cells[3].Value.ToString();
            txtTipoDocCliente.Text = row.Cells[2].Value.ToString();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //baja del telefono
            string nroTel = txtNumTelCliente.Text;
            NE_Telefonos be_telefono = new NE_Telefonos();
            be_telefono.BorrarTelefono(nroTel);
            this.Close();
        }
    }
}
