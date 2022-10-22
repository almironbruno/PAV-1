 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd;
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

            if (validarExisBarrio())
            {
                MessageBox.Show("Ya existe el barrio: " + txtNombreNuevoBarrio.Text);
                return; 
            }
            
            string nombreBarrio = txtNombreNuevoBarrio.Text;

            Barrio nvoBarrio = new Barrio(nombreBarrio);

            MessageBox.Show(nvoBarrio.Mostrar(nvoBarrio));

            NE_Barrio Barrio = new NE_Barrio();

            Barrio.AgregarBarrio(nvoBarrio);

            LimpiarCampos();

            this.Close();
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

        private bool validarExisBarrio()
        {
            string consulta = $"SELECT * FROM barrios WHERE nombre_barrio = '{txtNombreNuevoBarrio.Text}'";

            BE_Acceso_Datos bd = new BE_Acceso_Datos();


            DataTable dt = bd.Ejecutar_Select(consulta);

            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
