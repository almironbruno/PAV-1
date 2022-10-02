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
using Trabajo_Practico.Formularios.ABMC.ABMC_Empleados.Forms;
using Trabajo_Practico.Formularios.ABMC.Empleados;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios
{
    public partial class ABMC_Empleados : FormBaseABMC
    {
        public ABMC_Empleados()
        {
            
            //Asigna la tabla sobre la cual trabaja el ABM
            consultaPrincipal = @"SELECT E.legajo_empleado AS 'Legajo', 
                                    E.nombre AS 'Nombre', 
                                    E.apellido AS 'Apellido', 
                                    C.nombre_cargo AS 'Cargo'
                                FROM empleados E JOIN cargos_empleados C
                                    ON E.cargo=C.id_cargo";
            InitializeComponent();
            // cambia los nombres de la ventana a cliente --Eliminar comentario despues--
            cambiarNombre("Empleados");
            //dataGridViewModificada1.formularioDatosCompletos = new InfoEmpleados();
        }

        //Se sobreescribe el metodo 
        public override void btn_Agregar_Click(object sender, EventArgs e)
        {
            //Se crea la ventana de alta
            AltaEmpleados ventanaAlta= new AltaEmpleados();
            ventanaAlta.Show();
           
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            dataGridViewModificada1.forme = new InfoEmpleados();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            BajaEmpleado ventana = new BajaEmpleado(dataGridViewModificada1.FilaSeleccionada());
            ventana.Show();
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            ModificacionEmpleados ventana =  new ModificacionEmpleados(dataGridViewModificada1.FilaSeleccionada());
            ventana.Show();
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            Consulta ventana = new Consulta(this);
            ventana.Show();
            
        }

        private void ABMC_Empleados_Activated(object sender, EventArgs e)
        {
            dataGridViewModificada1.forme = new InfoEmpleados();
        }

        private void dataGridViewModificada1_Load(object sender, EventArgs e)
        {

        }
    }
}
