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


namespace Trabajo_Practico.Formularios.ABMC.ABMC_Localidades
{
    public partial class ABMC_Localidades : FormBaseABMC
    {
        public ABMC_Localidades()
        {
            // Realizamos la consulta correspondiente para obtener todos los datos de la tabla Localidades.
            consultaPrincipal = "SELECT * FROM Localidades";
            InitializeComponent();
            // Cambiamos el nombre de la Pantalla principal de localidades.
            cambiarNombre("Localidad");
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            // Llamamos a la clase Alta de localidades para cargar localidades a la BD.
            Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms.AltaLocalidades vtnAltaLocalidades = new Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms.AltaLocalidades();
            vtnAltaLocalidades.ShowDialog();
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            // Ejecutamos las acciones de modificar/ actualizar los campos que solicite el usuario de Localidades.
            string nombreLocalidad = dataGridViewModificada1.FilaSeleccionada().Cells["nombre_localidad"].Value.ToString().Trim();
            Trabajo_Practico.Clases.Entidades.Localidades localidad = new Trabajo_Practico.Clases.Entidades.Localidades(nombreLocalidad);
            DialogResult dialogResult = MessageBox.Show("Desea Modificar este registro", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                // Llamamos al formluario de Actualizar Localidadades.
                Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms.ModificarLocalidades vtnModificarLocalidades = new Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms.ModificarLocalidades(localidad);
                vtnModificarLocalidades.ShowDialog();
            }
        }
        private void ABMC_Localidades_Activated(object sender, EventArgs e)
        {
            dataGridViewModificada1.forme = new InfoLocalidades();

        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            // Llamamos al formulario buscar localidades.
            BuscarLocalidades vtnBuscarLocalidades = new BuscarLocalidades(this);
            vtnBuscarLocalidades.ShowDialog();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms.BajaLocalidades vtnBajaLocalidades = new Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms.BajaLocalidades(dataGridViewModificada1.FilaSeleccionada());
            vtnBajaLocalidades.ShowDialog();
        }

        private void ABMC_Localidades_Activated_1(object sender, EventArgs e)
        {
            dataGridViewModificada1.forme = new InfoLocalidades();
        }
    }
}
