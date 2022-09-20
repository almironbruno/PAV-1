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
            //TODO: Aca se le tiene que asignar la info del registro a borrar
            txt_Ejemplo.cargar(row.Cells[1].Value.ToString());
        }

        public void FormBaseBaja_Load(object sender, EventArgs e)
        {
            //Se le cambia el texto al label del componente TextBoxCargable
            txt_Ejemplo.cambiarTexto("texto");
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
