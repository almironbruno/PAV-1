using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioMarcas;
using Trabajo_Practico.Clases.BackEnd.NegocioNombreComercial;
using Trabajo_Practico.Formularios.ABMC.Marcas;

namespace Trabajo_Practico.Formularios.ABMC.NombreComercial
{
    public partial class NombreComercial : FormBaseABMC
    {
        public NombreComercial()
        {
            consultaPrincipal = "SELECT * FROM nombres_comerciales";
            InitializeComponent();
            cambiarNombre("Nombre Comercial");
        }

        private void NombreComercial_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaNombreComercial vtnNombreComercial = new AltaNombreComercial();
            vtnNombreComercial.Show();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            string nombre_comercial = dataGridViewModificada1.FilaSeleccionada().Cells[1].Value.ToString();

            string registro = "Nombre Comercial: " + nombre_comercial + ".";


            DialogResult dialogResult = MessageBox.Show(registro, "Desea eliminar el Registro?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                NE_NombreComercial borrarNombreComercial = new NE_NombreComercial();
                borrarNombreComercial.BorrarNombreComercial(nombre_comercial);

                cargargrilla();
            }
            else
            {
               
            }
        }
    }
}
