using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioAutos;
using Trabajo_Practico.Clases.BackEnd.NegocioLocalidades;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Localidades
{
    public partial class Localidades : FormBaseABMC
    {
        public Localidades()
        {
            consultaPrincipal = "SELECT * FROM localidades";
            InitializeComponent();
            cambiarNombre("Localidades");
        }

        private void btn_Agregar_Click_2(object sender, EventArgs e)
        {
            AltaLocalidades ventana = new AltaLocalidades();
            ventana.ShowDialog();
        }

        private void btn_Actualizar_Click_2(object sender, EventArgs e)
        {
            string nombreLocalidad = dataGridViewModificada1.FilaSeleccionada().Cells["nombre_localidad"].Value.ToString().Trim();
            string regis = "Registro: Localidad " + System.Environment.NewLine;
            Trabajo_Practico.Clases.Entidades.Localidades localidad = new Trabajo_Practico.Clases.Entidades.Localidades(nombreLocalidad);
            DialogResult dialogResult = MessageBox.Show(regis, "Desea Modificar el registro?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ModificarLocalidad ventana = new ModificarLocalidad(localidad);
                ventana.Show();
            }
        }

        private void btn_Buscar_Click_2(object sender, EventArgs e)
        {
            BuscarLocalidades ventana = new BuscarLocalidades();
            ventana.Show();
        }

        private void btn_Eliminar_Click_2(object sender, EventArgs e)
        {
            string nombreLocalidad = dataGridViewModificada1.FilaSeleccionada().Cells[1].Value.ToString();
            string registro = "Registro: Nombre de localidad " + nombreLocalidad + ".";
            DialogResult dialogResult = MessageBox.Show(registro, "Desea eliminar el registro?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                NE_Localidades localidades = new NE_Localidades();
                localidades.borrarLocalidad(nombreLocalidad);

            }
        }
    }
}
