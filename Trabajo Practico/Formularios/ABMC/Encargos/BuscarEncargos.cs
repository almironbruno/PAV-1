using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioEmpleados;
using Trabajo_Practico.Clases.BackEnd.NegocioEncargos;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Encargos
{
    public partial class BuscarEncargos : FormBaseConsulta
    {
        public BuscarEncargos()
        {
            InitializeComponent();
            cambiarNombre("Encargos");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string nroEncargo = txtNroEncargo.Text;

            NE_Encargos negoEncargo = new NE_Encargos();
            
            DataTable tabla = new DataTable();

            //bla = negoEncargo.buscarEncargo(nroEncargo);

        }
                    
    }
}
