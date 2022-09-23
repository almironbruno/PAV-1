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
    public partial class FormBaseBotones : Form
    {
        public FormBaseBotones()
        {
            InitializeComponent();
        }

        protected virtual void btn_Aceptar_Click(object sender, EventArgs e)
        {

        }

        private  void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Va a salir \n\t ¿Esta seguro?", "Salir", MessageBoxButtons.OKCancel);
            //Si el usuario selecciona OK, borra los campos
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

         private void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Va a borrar todos los camppos \n\t ¿Esta seguro?","Advertencia para borrar campos", MessageBoxButtons.OKCancel);
            //Si el usuario selecciona OK, borra los campos
            if (result == DialogResult.OK)
            {
                //Recorre los controles del form y borra los TextBox - MaskedTextBox
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = "";

                    }
                }
            }
            

        }
    }
}
