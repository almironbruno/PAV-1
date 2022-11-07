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
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.ABMC.ABMC_Marcas.Forms;

namespace Trabajo_Practico.Formularios
{
    public partial class ABMC_Marcas : FormBaseABMC
    {
        public ABMC_Marcas()
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

            BajaMarca vtnBajaMarca = new BajaMarca(dataGridViewModificada1.FilaSeleccionada());
            vtnBajaMarca.Show();


        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            string nombreMarca = dataGridViewModificada1.FilaSeleccionada().Cells["nombre"].Value.ToString().Trim();
            string regis = "Marca Automotriz: " + nombreMarca;
            DialogResult dialogResult = MessageBox.Show(regis, "Desea Modificar el registro?", MessageBoxButtons.YesNo);

            Marca marca = new Marca(nombreMarca);

            if (dialogResult == DialogResult.Yes)
            {
                ModificarMarca vtnModificar = new ModificarMarca(marca);
                vtnModificar.Show();
            }
            else
            {
                // Nada ya que no se elimina, al oprimir no se cierra el txtbox
            }
           

        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            BuscarMarca vtnBuscarMarca = new BuscarMarca();
            vtnBuscarMarca.Show();
        }
    }
}
