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
            cmbCargableNumDoc.cargar("SELECT nro_doc_cliente FROM clientes", "nro_doc_cliente","nro_doc_cliente");
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            string numTelefono = txtNumTelefono.Text;
            string numCaracteristica = cmbCargableCaracteristica.cmb_Cargable.ToString();
            string tipoDoc = cmbCargableTipoDoc.cmb_Cargable.SelectedValue.ToString();
            string numDoc = cmbCargableNumDoc.cmb_Cargable.SelectedValue.ToString();

            Telefono nuevoTelefono = new Telefono(numTelefono,numCaracteristica,tipoDoc,numDoc);

            MessageBox.Show("Se agrego el Nuevo Telefono");

            NE_Telefonos Telefono = new NE_Telefonos();

            Telefono.AgregarTelefono(nuevoTelefono);
            this.Close();

        }
    }
}
