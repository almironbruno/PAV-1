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
            comboCargable1.cargar("empleados", "nombre");
            comboCargable2.cargar("empleados","apellido");
        }
    }
}
