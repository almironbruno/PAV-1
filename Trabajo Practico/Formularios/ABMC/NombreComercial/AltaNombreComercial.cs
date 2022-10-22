using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioNombreComercial;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.NombreComercial
{
    public partial class AltaNombreComercial : FormBaseAlta
    {
        public AltaNombreComercial()
        {
            InitializeComponent();
        }

        private void AltaNombreComercial_Load(object sender, EventArgs e)
        {
            string sqlMarca = (@"SELECT * FROM marcas");
            string sqlGama = (@"SELECT * FROM gamas");
            cmbMarca.cargar(sqlMarca, "nombre", "id_marca");
            cmbGama.cargar(sqlGama, "nombre_gama", "id_gama");
        }

        private void comboCargable2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bool vacios = false;
                foreach (Control item in this.Controls)
                {

                    if (item is TextBox || item is MaskedTextBox)
                    {
                        if (item.Text.Equals(""))
                        {
                            item.Select();
                            vacios = true;
                            break;

                        }
                    }

                }
                if (vacios == false)
                {
                    string nombre_comercial = txtNombreComercial.Text;
                    int marca = int.Parse(cmbMarca.cmb_Cargable.SelectedValue.ToString());
                    int gama = int.Parse(cmbGama.cmb_Cargable.SelectedValue.ToString());
                    
                    NombresComerciales nvoNombreComercial = new NombresComerciales(nombre_comercial,marca,gama);

                    //MessageBox.Show(nvoNombreComercial.mostrar(nvoNombreComercial));

                    NE_NombreComercial NombresComerciales = new NE_NombreComercial();

                    NombresComerciales.AgregarNombreComercial(nvoNombreComercial);
                }
                else
                {
                    MessageBox.Show("Complete todos los campos para registrar un Nombre Comercial");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ya se encuentra registrado el Nombre Comercial");
            }

        }
    }
    
}
