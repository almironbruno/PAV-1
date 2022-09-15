using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases;

namespace Trabajo_Practico.Formularios
{
    public partial class FormBaseABMC : Form
    {
        public FormBaseABMC()
        {
            InitializeComponent();
        }
        protected void cambiarNombre(string nombre)
        {
            //Cambia los nombres de todos los componentes graficos del Form 
            lbl_titulo.Text = $"Gestion de {nombre}";
            btn_Actualizar.Text = $"Actualizar"+Environment.NewLine+nombre;
            btn_Eliminar.Text = $"Eliminar" + Environment.NewLine + nombre;
            btn_Buscar.Text= $"Buscar" + Environment.NewLine + nombre;
            btn_Agregar.Text = $"Agregar" + Environment.NewLine +nombre;

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //TODO: comportamiento de los botones
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void FormBaseABMC_Load(object sender, EventArgs e)
        {

        }
    }
}
