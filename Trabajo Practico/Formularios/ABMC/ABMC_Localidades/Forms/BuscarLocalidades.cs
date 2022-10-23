using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioLocalidades;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms
{
    public partial class BuscarLocalidades : CamposLocalidades
    {
        public BuscarLocalidades()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreLocalidad.Focus();
                string codigoPostal = txtNombreLocalidad.Text;
                NE_Localidades negoLocalidad = new NE_Localidades();

                DataTable tabla = new DataTable();
                tabla = negoLocalidad.buscarLocalidad(codigoPostal);

                if (tabla.Rows.Count > 0)
                {
                    string nombreLocalidad = tabla.Rows[0]["nombre_localidad"].ToString();

                    Trabajo_Practico.Clases.Entidades.Localidades localidad = new Trabajo_Practico.Clases.Entidades.Localidades(nombreLocalidad);
                    string salida = localidad.toString();

                    MessageBox.Show("Se se ha encontrado la localidad buscada: " + "\n" + salida, "Mensaje");
                }
                else
                {
                    MessageBox.Show("Localidad no encontrada");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema", "Mensaje");

            }
        }
    }
}
