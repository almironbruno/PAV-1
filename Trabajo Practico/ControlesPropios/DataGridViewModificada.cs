using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.ABMC.ABMC_Empleados.Forms;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico
{
    public partial class DataGridViewModificada : UserControl
    {
        public FormBaseBotones forme;

        public DataGridViewModificada()
        {
            InitializeComponent();
            dgr_Principal.ShowCellToolTips = true;
            dgr_Principal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void cargar(DataTable unaTabla)
        {
            //Si la tabla esta vacia se muestra un mensaje
            if (unaTabla.Rows.Count==0)
            {
                unaTabla.Columns.Clear();
                unaTabla.Columns.Add("No hay registros");
            }
            //Se carga la grilla con los datos de la tabla
            dgr_Principal.DataSource=unaTabla;

        }
        public DataGridViewRow FilaSeleccionada() 
        {
            //Retorna la fila que seleccionamos, se usa para la baja o modificacion
            return dgr_Principal.SelectedRows[0];
        
        }

         
        private void dgr_Principal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llama al form que se define en cada ABM
            FormBaseBotones ventana =  forme;
            ventana.cargarInfo(FilaSeleccionada());
            ventana.Show();
        }

        private void dgr_Principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgr_Principal.Columns.Count; i++)
            {
                dgr_Principal.SelectedRows[0].Cells[i].ToolTipText = "Doble Click para mas informacion";
            }


        }

        /*/
        private void dgr_Principal_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
                
            
            


            
        //        //Establece los toolTips para cada celda
        //        for (int i = 0; i < dgr_Principal.Columns.Count; i++)
        //        {
        //            if (dgr_Principal.Rows.Count>0)
        //            dgr_Principal.SelectedRows[0].Cells[i].ToolTipText = "Doble Click para mas informacion";
        //        }
            
            


        }
        /*/

    }
}
