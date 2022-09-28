using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioBarrio;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Formularios.ABMC.Barrios
{
    public partial class AltaBarrio : Form
    {
        public AltaBarrio()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

            string nombreBarrio = txtNombreNuevoBarrio.Text;

            Barrio nvoBarrio = new Barrio(nombreBarrio);

            MessageBox.Show(nvoBarrio.Mostrar(nvoBarrio));

            NE_Barrio Barrio = new NE_Barrio();

            Barrio.AgregarBarrio(nvoBarrio);

            LimpiarCampos();
        }

        private void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNombreNuevoBarrio.Text = "";
        }
    }
}
