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
namespace Trabajo_Practico.Formularios.ABMC.Encargos
{
    public partial class Encargos : FormBaseABMC
    {
        public Encargos()
        {
            consultaPrincipal = "SELECT * FROM encargos";
            InitializeComponent();
            cambiarNombre("Encargos");
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaEncargos ventana = new AltaEncargos();
            ventana.ShowDialog();
        }

    }
}
