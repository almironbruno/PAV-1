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

namespace Trabajo_Practico.Formularios.ABMC.Encargos
{
    public partial class BajaEncargos : CamposEncargos
    {
        private string tipo_doc;
        private string nro_doc;

        public BajaEncargos(DataGridViewRow row)
        {
            InitializeComponent();
            cmbTipoDocumento.Enabled = false;
            btn_LimpiarCampos.Hide();



        }
    }
}
