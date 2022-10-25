using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Localidades.Forms
{
    public partial class InfoLocalidades : CamposLocalidades
    {
        public InfoLocalidades()
        {
            txtNombreLocalidad.Enabled = false;
            btn_LimpiarCampos.Hide();
            btn_Aceptar.Hide();
            InitializeComponent();
            cambiarFormaConsulta();
        }

        public override void cargarInfo(DataGridViewRow row)
        {
            txtNombreLocalidad.Text = row.Cells[1].Value.ToString();
        }
    }
}
