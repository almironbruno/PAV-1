using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Clases.BackEnd.NegocioNombreComercial;
using Trabajo_Practico.Formularios.ABMC.NombreComercial;
using Trabajo_Practico.Formularios.Base;


namespace Trabajo_Practico.Formularios.ABMC.NombreComercial
{
    public partial class NombreComercial : FormBaseABMC
    {
        public NombreComercial()
        {
            consultaPrincipal = "SELECT * FROM nombres_comerciales";
            InitializeComponent();
            dataGridViewModificada1.forme = new InfoNombreComercial();
            cambiarNombre("Nombre Comercial");
        }

        private void NombreComercial_Load(object sender, EventArgs e)
        {
            dataGridViewModificada1.forme = new InfoNombreComercial();
        }


        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaNombreComercial vtnAltaNombreComercial = new AltaNombreComercial();
            vtnAltaNombreComercial.Show();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            string nomcomSeleccionado = dataGridViewModificada1.FilaSeleccionada().Cells["nombre_comercial"].Value.ToString();
            string nomcomAElimiar = "Nombre Comercial a eliminar: " + nomcomSeleccionado;

            DialogResult dialogResult = MessageBox.Show(nomcomAElimiar, "ELIMINAR NOMBRE COMERCIAL", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                NE_NombreComercial borrarNombreComercial = new NE_NombreComercial();
                borrarNombreComercial.BorrarNombreComercial(nomcomSeleccionado);
            }
            else
            {
                MessageBox.Show("No se eliminara ningun nombre comercial!");
            }
            

        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            BuscarNombreComercial ventana = new BuscarNombreComercial(this);
            ventana.Show();
        }


    }
}
