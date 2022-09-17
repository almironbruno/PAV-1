using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd;

namespace Trabajo_Practico.ControlesPropios
{
    public partial class TextBoxCargable : UserControl
    {
        public TextBoxCargable()
        {
            InitializeComponent();
        }

        public void cargar(string texto)
        {
            txt_cargable.Text= texto;   

        }
        public void cambiarTexto(string texto)
        {
            lbl_nombre.Text = texto;

        }
    }
}
