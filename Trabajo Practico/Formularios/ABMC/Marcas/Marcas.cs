using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC
{
    public partial class Marcas : Trabajo_Practico.Formularios.FormBaseABMC
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
    }
}
