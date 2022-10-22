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
using Trabajo_Practico.Clases.BackEnd.NegocioTelefonos;
using System.Text.RegularExpressions;
using Trabajo_Practico.Formularios.ABMC.Telefonos;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Formularios.ABMC.Telefonos
{
    public partial class TelefonosPrincipal : FormBaseABMC
    {
        public TelefonosPrincipal()
        {
            InitializeComponent();

            consultaPrincipal = (@"SELECT * FROM telefonos");

            dataGridViewModificada1.forme = new InfoTelefonos();

            cambiarNombre("Telefono Principal");
        }





        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaTelefono vtnAltaTelefono = new AltaTelefono();
            vtnAltaTelefono.Show();
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {

            string nroTelefonoAActualizar = dataGridViewModificada1.FilaSeleccionada().Cells["nro_telefono"].Value.ToString().Trim();
            string regionTelefonoAActualizar = dataGridViewModificada1.FilaSeleccionada().Cells["nro_caracteristica"].Value.ToString().Trim();
            string pkNumDoc = dataGridViewModificada1.FilaSeleccionada().Cells["nro_doc_cliente"].Value.ToString().Trim();
            string pkTipoDoc = dataGridViewModificada1.FilaSeleccionada().Cells["tipo_doc_cliente"].Value.ToString().Trim();

            string registro = "Cliente: " + pkNumDoc + System.Environment.NewLine + "Quiere modificar el siguiente telefono: " + nroTelefonoAActualizar + System.Environment.NewLine + "De la region: " + regionTelefonoAActualizar;
            Trabajo_Practico.Clases.Entidades.Telefono telefono = new Trabajo_Practico.Clases.Entidades.Telefono(nroTelefonoAActualizar, regionTelefonoAActualizar,pkTipoDoc,pkNumDoc);
            DialogResult dialogResult = MessageBox.Show(registro, "MODIFICAR TELEFONO", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                ModificacionTelefono vtnModTelefono = new ModificacionTelefono(telefono);
                vtnModTelefono.Show();
            }
            else
            {
                //Nada ya que no se actualizara.
            }
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            string nroParaBorrar = dataGridViewModificada1.FilaSeleccionada().Cells["nro_telefono"].Value.ToString();
            string numDocParaBorrar = dataGridViewModificada1.FilaSeleccionada().Cells["nro_doc_cliente"].Value.ToString();


            string telefonoABorrar = "Telefono a eliminar: " + nroParaBorrar + System.Environment.NewLine + "del cliente con documento: " + numDocParaBorrar;
            DialogResult dialogResult = MessageBox.Show(telefonoABorrar, "ELIMINAR TELEFONO", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                NE_Telefonos borrarTelefono = new NE_Telefonos();
                borrarTelefono.BorrarTelefono(nroParaBorrar);
            }
            else
            {                   
                MessageBox.Show("No se eliminara ningun telefono!");              
            }

        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            ConsultaTelefono vtnConsultaTelefono = new ConsultaTelefono(this);
            vtnConsultaTelefono.Show();
        }

        private void TelefonosPrincipal_Activated(object sender, EventArgs e)
        {
            dataGridViewModificada1.forme = new InfoTelefonos();
        }
    }
}
