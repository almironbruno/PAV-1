using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.ControlesPropios;

namespace Trabajo_Practico.Formularios.Base
{
    public partial class FormBaseModificacion : FormBaseBotones
    {
        public FormBaseModificacion()
        {
            InitializeComponent();
           
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is MaskedTextBox )
                {
                    if (item.Text.Equals("") )
                    {
                        item.Select();
                        MessageBox.Show("No puede dejar un campo vacio");
                        break;
                        
                    } 
                }
                   
            }
            
        }
    }
}
