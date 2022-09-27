using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            cargargrilla();
        }
    }
}
