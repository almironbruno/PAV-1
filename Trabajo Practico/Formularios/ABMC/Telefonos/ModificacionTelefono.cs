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
using Trabajo_Practico.Clases.BackEnd.NegocioTelefonos;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Formularios.ABMC.Telefonos
{
    public partial class ModificacionTelefono : FormBaseModificacion
    {

        Trabajo_Practico.Clases.Entidades.Telefono TelefonoMod;

        public ModificacionTelefono(Trabajo_Practico.Clases.Entidades.Telefono telefono)
        {

            TelefonoMod = telefono;
            InitializeComponent();

            cmbCargable_Region.cargar("SELECT * FROM caracteristicas_telefonicas", "nombre_region", "nro_caracteristica_telefonica");

            txtNumModificado.Text = telefono.nroTelefono.Trim();
            cmbCargable_Region.cmb_Cargable.SelectedValue = telefono.nroCaracteristica.Trim();
            txtTipoDoc.Text = telefono.tipoDocCliente.Trim();
            txtNumeroDoc.Text = telefono.nroDocCliente.Trim();
            

        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {

            //base.btn_Aceptar_Click(sender, e);
            NE_Telefonos telefono = new NE_Telefonos();
            
            TelefonoMod.nroTelefono = txtNumModificado.Text.Trim();
            TelefonoMod.nroCaracteristica = cmbCargable_Region.cmb_Cargable.SelectedValue.ToString();
            TelefonoMod.tipoDocCliente = txtTipoDoc.Text.Trim();
            TelefonoMod.nroDocCliente = txtTipoDoc.Text.Trim();
            
            telefono.ModificarTelefono(TelefonoMod);
            this.Close();


        }
    }
}
