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
    public partial class ComboCargable : UserControl
    {
        public ComboCargable()
        {
            InitializeComponent();
        }
        public void cargar(string tabla, string columna)
        {
            //Se carga el combo con la tabla y la columna que se le asigna
            BE_Acceso_Datos bd = new BE_Acceso_Datos();
            DataTable tabalPrincipal =bd.Ejecutar_Select($"SELECT {columna} FROM {tabla}");
  
            cmb_Cargable.DisplayMember = columna;
            cmb_Cargable.ValueMember = columna;
            cmb_Cargable.DataSource = tabalPrincipal;
        
        }
        public void cambiarTexto(string texto)
        {
            //Se le cambia el texto al label asociado
            lbl_Nombre.Text = texto;

        }
    }
}
