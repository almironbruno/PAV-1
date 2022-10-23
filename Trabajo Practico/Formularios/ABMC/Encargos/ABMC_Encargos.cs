using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioEncargos;
using Trabajo_Practico.Formularios.Base;
namespace Trabajo_Practico.Formularios.ABMC.Encargos
{
    public partial class ABMC_Encargos : FormBaseABMC
    {
        public ABMC_Encargos()
        {
            consultaPrincipal = "SELECT d.nombre_tipo_doc as 'Tipo Doc.', e.nro_doc_cliente as 'Nro. Doc.', e.fecha as 'Fecha', c.nombre_comercial as 'Nombre Comercial', l.nombre as 'Nombre Empleado', t.nombre_tipo as 'Tipo Característica', p.nombre_prioridad as 'Prioridad'  FROM encargos e \r\njoin tipo_doc_clientes d on e.tipo_doc_cliente = d.id_doc_cliente\r\njoin nombres_comerciales c on e.id_nombrecomercial = c.id_nombrecomercial\r\njoin empleados l on e.legajo_empleado = l.legajo_empleado\r\njoin tipo_caracteristica t on e.cod_caracteristica = t.id_caracteristica\r\njoin prioridades p on e.prioridad = p.id_prioridad";
            InitializeComponent();
            cambiarNombre("Encargos");
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaEncargos ventana = new AltaEncargos();
            ventana.ShowDialog();
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            BuscarEncargos ventana = new BuscarEncargos(this);
            ventana.Show();            
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            ModificarEncargos ventanaMod = new ModificarEncargos(dataGridViewModificada1.FilaSeleccionada());
            ventanaMod.ShowDialog();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {            
            string tipo_doc = dataGridViewModificada1.FilaSeleccionada().Cells[0].Value.ToString();
            int nro_doc = int.Parse(dataGridViewModificada1.FilaSeleccionada().Cells[1].Value.ToString());
            // Confirmamos si desea realmente borra este registro
            DialogResult dialogResult = MessageBox.Show("Desea eliminar el registro seleccionado", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                NE_Encargos borrarEncargo = new NE_Encargos();
                borrarEncargo.BorrarEncargo(nro_doc);
            }
        
        
        }
        

    }
}
