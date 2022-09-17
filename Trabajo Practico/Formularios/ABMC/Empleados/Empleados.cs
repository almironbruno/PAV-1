using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.ABMC.Empleados;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios
{
    public partial class Empleados : FormBaseABMC
    {
        public Empleados()
        {
            //Asigna la tabla sobre la cual trabaja el ABM
            tablaPrincipal = "empleados";
            InitializeComponent();
            // cambia los nombres de la ventana a cliente --Eliminar comentario despues--
            cambiarNombre("Empleados");
        }
        public override void btn_Agregar_Click(object sender, EventArgs e)
        {
            AltaEmpleados ventanaAlta= new AltaEmpleados();
            ventanaAlta.Show();
        }


    }
}
