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
        }
        public void cargar(DataTable unaTabla)
        {
            dgr_Principal.DataSource=unaTabla;

        }
        public DataGridViewRow FilaSeleccionada() {
            return dgr_Principal.SelectedRows[0];
        
        }
    }
}
