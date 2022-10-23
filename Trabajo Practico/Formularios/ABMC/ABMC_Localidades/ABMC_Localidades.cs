using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.ABMC.ABMC_Empleados.Forms;
using Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms;
using Trabajo_Practico.Formularios.ABMC.Localidades;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Localidades
{
    public partial class ABMC_Localidades : FormBaseABMC
    {
        public ABMC_Localidades()
        {
            consultaPrincipal = "SELECT * FROM Localidades";
            InitializeComponent();
            cambiarNombre("Localidades");
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms.AltaLocalidades vtnAltaLocalidades = new Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms.AltaLocalidades();
            vtnAltaLocalidades.ShowDialog();
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            string nombreLocalidad = dataGridViewModificada1.FilaSeleccionada().Cells["nombre_localidad"].Value.ToString().Trim();
            Trabajo_Practico.Clases.Entidades.Localidades localidad = new Trabajo_Practico.Clases.Entidades.Localidades(nombreLocalidad);
            DialogResult dialogResult = MessageBox.Show("Desea Modificar este registro", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms.ModificarLocalidades vtnModificarLocalidades = new Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms.ModificarLocalidades(localidad);
                vtnModificarLocalidades.ShowDialog();
            }
        }

        private void ABMC_Localidades_Load(object sender, EventArgs e)
        {
            dataGridViewModificada1.forme = new InfoLocalidades();
        }
        private void ABMC_Localidades_Activated(object sender, EventArgs e)
        {
            dataGridViewModificada1.forme = new InfoLocalidades();

        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms.BuscarLocalidades vtnBuscarLocalidades = new Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms.BuscarLocalidades();
            vtnBuscarLocalidades.ShowDialog();
        }
    }
}
