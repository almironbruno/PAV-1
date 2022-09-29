using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico
{
    public partial class DataGridViewModificada : UserControl
    {
       
        public DataGridViewModificada()
        {
            InitializeComponent();
            
            dgr_Principal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void cargar(DataTable unaTabla)
        {
            //Se carga la grilla con los datos de la tabla
            dgr_Principal.DataSource=unaTabla;

        }
        public DataGridViewRow FilaSeleccionada() 
        {
            //Retorna la fila que seleccionamos, se usa para la baja o modificacion
            return dgr_Principal.SelectedRows[0];
        
        }
        
    }
}
