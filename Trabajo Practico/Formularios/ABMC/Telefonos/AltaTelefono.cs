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
using Trabajo_Practico.Clases.BackEnd.NegocioTelefonos;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Telefonos
{
    public partial class AltaTelefono : FormBaseAlta
    {
        public AltaTelefono()
        {
            InitializeComponent();
            cmbCargableTipoDoc.cargar("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cmbCargableCaracteristica.cargar("SELECT * FROM caracteristicas_telefonicas","nombre_region","nro_caracteristica_telefonica");
            cmbFiltroCliente.Hide();
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            string numTelefono = txtNumTelefono.Text;
            string numCaracteristica = cmbCargableCaracteristica.cmb_Cargable.SelectedValue. ToString();
            string tipoDoc = cmbCargableTipoDoc.cmb_Cargable.SelectedValue.ToString();
            string[] per = cmbFiltroCliente.Text.Split('-');
            string numDoc = per[1];

            Telefono nuevoTelefono = new Telefono(numTelefono,numCaracteristica,tipoDoc,numDoc);

            MessageBox.Show("Se agrego el Nuevo Telefono");

            NE_Telefonos Telefono = new NE_Telefonos();

            Telefono.AgregarTelefono(nuevoTelefono);
            this.Close();

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            NE_Clientes filtrarCliente = new NE_Clientes();

            string filtroCliente = filtrarCliente.consultaCl(cmbCargableTipoDoc.cmb_Cargable.SelectedValue.ToString(), txtNumDocCliente.Text, "", "", "/  /", "", "", "0");

            cmbFiltroCliente.Show();

            cmbCargableTipoDoc.Enabled = false;

            cargarComboCliente(bd.Ejecutar_Select(filtroCliente));

            



        }

        private void cargarComboCliente(DataTable dataCl)
        {

            cmbFiltroCliente.Items.Clear();

            for(int i = 0; i < dataCl.Rows.Count; i++)
            {
                cmbFiltroCliente.Items.Add(dataCl.Rows[i].ItemArray[0].ToString() + "-" + dataCl.Rows[i].ItemArray[1].ToString() + "-" + dataCl.Rows[i].ItemArray[3].ToString());
            }
        }
    }
}
