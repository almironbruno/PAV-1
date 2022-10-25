using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.ABMC.ABMC_Clientes.Forms;
using Trabajo_Practico.Formularios.ABMC.ABMC_Empleados;
using Trabajo_Practico.Formularios.ABMC.ABMC_Encargos.Forms;
using Trabajo_Practico.Formularios.ABMC.Autos;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Encargos
{
    public partial class ABMC_Encargos : FormBaseABMC
    {
        public ABMC_Encargos()
        {
            consultaPrincipal = @"SELECT d.nombre_tipo_doc as 'Tipo Doc.', 
                                e.nro_doc_cliente as 'Nro. Doc.', 
                                e.fecha as 'Fecha', 
                                c.nombre_comercial as 'Nombre Comercial', 
                                l.nombre as 'Nombre Empleado', 
                                t.nombre_tipo as 'Tipo Característica', 
                                p.nombre_prioridad as 'Prioridad'  
                                    FROM encargos e join tipo_doc_clientes d on e.tipo_doc_cliente = d.id_doc_cliente 
                                    join nombres_comerciales c on e.id_nombrecomercial = c.id_nombrecomercial 
                                    join empleados l on e.legajo_empleado = l.legajo_empleado 
                                    join tipo_caracteristica t on e.cod_caracteristica = t.id_caracteristica 
                                    join prioridades p on e.prioridad = p.id_prioridad";
            InitializeComponent();
            cambiarNombre("Encargo");
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaEncargos ventana = new AltaEncargos();
            ventana.ShowDialog();
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            ModificarEncargos ventanaMod = new ModificarEncargos(dataGridViewModificada1.FilaSeleccionada());
            ventanaMod.ShowDialog();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            BajaEncargos ventana = new BajaEncargos(dataGridViewModificada1.FilaSeleccionada());
            ventana.ShowDialog();
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            BuscarEncargos ventana = new BuscarEncargos(this);
            ventana.ShowDialog();
        }

        private void ABMC_Encargos_Activated_1(object sender, EventArgs e)
        {
            dataGridViewModificada1.forme = new InfoEncargos();
        }
    }
}
