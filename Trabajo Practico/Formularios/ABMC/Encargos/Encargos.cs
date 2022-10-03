using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.Base;
namespace Trabajo_Practico.Formularios.ABMC.Encargos
{
    public partial class Encargos : FormBaseABMC
    {
        public Encargos()
        {
            consultaPrincipal = "SELECT e.nro_encargo, t.nombre_tipo_doc, e.nro_doc_cliente, e.fecha, n.nombre_comercial, e.legajo_empleado, e.cod_caracteristica, p.nombre_prioridad from encargos e join tipo_doc_clientes as t on e.tipo_doc_cliente = t.id_doc_cliente join nombres_comerciales as n on e.id_nombrecomercial = n.id_nombrecomercial join prioridades as p on e.prioridad =  p.id_prioridad";
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
            BuscarEncargos ventana = new BuscarEncargos();
            ventana.Show();
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            ModificarEncargos ventanaMod = new ModificarEncargos(dataGridViewModificada1.FilaSeleccionada());
            ventanaMod.ShowDialog();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            
        }
        /*
BajaClientes ventana = new BajaClientes(dataGridViewModificada1.FilaSeleccionada());
            ventana.Show();
*/
    }
}
