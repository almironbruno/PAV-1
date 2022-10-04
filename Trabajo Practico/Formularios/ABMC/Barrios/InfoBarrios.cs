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

namespace Trabajo_Practico.Formularios.ABMC.Barrios
{
    public partial class InfoBarrios : FormBaseBotones
    {
        public InfoBarrios()
        {
            InitializeComponent();

            txtNombreBarrio.Enabled = false;
            txtIdBarrio.Enabled = false;
            btn_LimpiarCampos.Hide();
            btn_Aceptar.Hide();

            cambiarFormaConsulta();
        }

        public override void cargarInfo(DataGridViewRow row)
        {

            txtIdBarrio.Text = row.Cells[0].Value.ToString();
            txtNombreBarrio.Text = row.Cells[1].Value.ToString();
        }
    }
}
