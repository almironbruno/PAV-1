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

namespace Trabajo_Practico.Formularios.ABMC.Empleados
{
    public partial class AltaEmpleados : FormBaseAlta
    {
        public AltaEmpleados()
        {
            InitializeComponent();
        }

        private void AltaEmpleados_Load(object sender, EventArgs e)
        {
            //Acordate del cambio en el cmbbox, seria comboCargable1.cargar(ConsultaSql,"nombrecolumna","pk")

            //comboCargable1.cargar("empleados", "nombre");
            //comboCargable2.cargar("empleados","apellido");
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {

        }

        private void comboCargable1_Load(object sender, EventArgs e)
        {

        }
    }
}
