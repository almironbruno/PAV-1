using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.ABMC.Marcas;
using Trabajo_Practico.Clases.BackEnd.NegocioMarcas;

namespace Trabajo_Practico.Formularios
{
    public partial class Marcas : FormBaseABMC
    {
        public Marcas()
        {
            consultaPrincipal = "SELECT * FROM marcas";
            InitializeComponent();
            cambiarNombre("Marcas");
            
        }

        private void Marcas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaMarcas vtnAltaMarcas = new AltaMarcas();
            vtnAltaMarcas.Show();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            string nombre = dataGridViewModificada1.FilaSeleccionada().Cells[1].Value.ToString();

            string registro = "Nombre de la Marca Automotriz: " + nombre + ".";


            DialogResult dialogResult = MessageBox.Show(registro, "Desea eliminar el Registro?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                NE_Marcas borrarMarca = new NE_Marcas();
                borrarMarca.BorrarMarca(nombre);

                cargargrilla();
            }
            else
            {
                // Nada ya que no se elimina, al oprimir no se cierra el txtbox
            }
        }
    }
}
