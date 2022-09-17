using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Formularios.Base
{
    public partial class FormBaseBaja : FormBaseBotones

    {
        public FormBaseBaja(DataGridViewRow row)
        {
            InitializeComponent();
            txt_Ejemplo.cargar(row.Cells[1].Value.ToString());
        }

        private void FormBaseBaja_Load(object sender, EventArgs e)
        {
            txt_Ejemplo.cambiarTexto("texto");
        }
    }
}
