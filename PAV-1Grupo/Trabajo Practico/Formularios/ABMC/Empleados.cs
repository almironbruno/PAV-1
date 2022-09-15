using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios;

namespace Trabajo_Practico.Formularios
{
    public partial class Empleados : FormBaseABMC
    {
        public Empleados()
        {
            InitializeComponent();
            // cambia los nombres de la ventana a cliente --Eliminar comentario despues--
            cambiarNombre("Empleados");
        }
    }
}
