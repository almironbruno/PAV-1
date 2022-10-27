using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.Base;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Clases.BackEnd.NegocioAutos;
using Trabajo_Practico.Formularios.ABMC.ABMC_Autos;

namespace Trabajo_Practico.Formularios.ABMC.Autos
{
    public partial class AltaAutos : CamposAutos

    {
        public AltaAutos()
        {
            InitializeComponent();
        }

        private void AltaAutos_Load(object sender, EventArgs e)
        {
            string sqlCondicion = (@"SELECT * FROM condicion");
            string sqlNombreComr = (@"SELECT * FROM nombres_comerciales");
            cmbCondicion.cargar(sqlCondicion,"nombre_condicion","id_condicion");
            cmbNomComr.cargar(sqlNombreComr,"nombre_comercial","id_nombrecomercial");
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)


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
                    string codSerie = txtCodSerieFab.Text;
                    int nombComer = int.Parse(cmbNomComr.cmb_Cargable.SelectedValue.ToString());
                    string añoFab = txtAñoFab.Text;
                    int condicion = int.Parse(cmbCondicion.cmb_Cargable.SelectedValue.ToString());
                    string nroChasis = txtNroChasis.Text;
                    string nroMotor = txtNroMotor.Text;
                    string patente = txtPatente.Text;
                    string precio = txtPrecioAuto.Text;
                    //Al ser un nuevo auto, su estado de vendido es false.
                    bool vendido = false;

                    Vehiculos nvoAuto = new Vehiculos(codSerie, nombComer, añoFab, condicion, nroChasis, nroMotor, patente,precio,vendido);

                    //MessageBox.Show(nvoAuto.mostrar(nvoAuto));

                    NE_Autos Vehiculo = new NE_Autos();

                    Vehiculo.AgregarAuto(nvoAuto);
                }
                else
                {
                    MessageBox.Show("Complete todos los campos para registrar un Vehiculo");
                }
 
            }
            catch (Exception)
            {

                MessageBox.Show("Ya se encuentra registrado el vehiculo");
            }
           
        }

        private void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {

        }

        
    }
}
