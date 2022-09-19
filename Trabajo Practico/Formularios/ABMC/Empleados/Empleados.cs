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
            consultaPrincipal = "SELECT * FROM empleados";
            InitializeComponent();
            // cambia los nombres de la ventana a cliente --Eliminar comentario despues--
            cambiarNombre("Empleados");
        }

        //Se sobreescribe el metodo 
        public override void btn_Agregar_Click(object sender, EventArgs e)
        {
            //Se crea la ventana de alta
            AltaEmpleados ventanaAlta= new AltaEmpleados();
            ventanaAlta.Show();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }
    }
}
