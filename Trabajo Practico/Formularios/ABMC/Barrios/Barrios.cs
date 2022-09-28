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
using Trabajo_Practico.Clases.BackEnd.NegocioBarrio;

namespace Trabajo_Practico.Formularios.ABMC.Barrios
{
    public partial class Barrios : FormBaseABMC
    {
        public Barrios()
        {

            //Consulta principal para ver los barrios. 
            consultaPrincipal = (@"SELECT *  from barrios ");
            InitializeComponent();
            cambiarNombre("Barrios");
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaBarrio vtnAltaBarrio = new AltaBarrio();
            vtnAltaBarrio.Show();
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {

            string barrioSeleccionado = dataGridViewModificada1.FilaSeleccionada().Cells["nombre_barrio"].Value.ToString();
            string barrioAElimiar = "Barrio a eliminar: " + barrioSeleccionado;

            DialogResult dialogResult = MessageBox.Show(barrioAElimiar,"ELIMINAR BARRIO", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                NE_Barrio borrarBarrio = new NE_Barrio();
                borrarBarrio.BorrarBarrio(barrioSeleccionado);
            }
            else
            {
                MessageBox.Show("No se eliminara ningun barrio!");
            }
        }
    }
}
