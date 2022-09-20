using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.ABMC.Autos;
using Trabajo_Practico.Formularios.Base;


namespace Trabajo_Practico.Formularios
{
    public partial class Autos : FormBaseABMC
    {
        public Autos()
        {
            consultaPrincipal = "SELECT * FROM autos";
            InitializeComponent();
            cambiarNombre("Autos");
        }

        private void Autos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaAutos vtnAltaAutos = new AltaAutos();
            vtnAltaAutos.Show();
        }

        private void dataGridViewModificada1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            cargargrilla();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            BajaAutos vtnBaja = new BajaAutos();
            vtnBaja.Show();
        }
    }
}
