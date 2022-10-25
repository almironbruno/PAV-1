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
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.Proceso
{
    public partial class FormVenta : FormBaseBotones
    {
        public FormVenta(DataTable tabla)
        {
            InitializeComponent();
            this.buscador1.tablaConsulta = "clientes";
            buscador1.columna = "nombre";
            txt_fecha.Text = DateTime.Now.ToShortDateString();
        }
        protected override void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Va a borrar todos los camppos \n\t ¿Esta seguro?", "Advertencia para borrar campos", MessageBoxButtons.OKCancel);
            //Si el usuario selecciona OK, borra los campos
            if (result == DialogResult.OK)
            {
                buscador1.limpiar();
            }

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            AgregarAuto ventana = new AgregarAuto();
            ventana.Show();

        }
    }
}
