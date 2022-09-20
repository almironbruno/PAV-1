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
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Clases.BackEnd.NegocioMarcas;
using Trabajo_Practico.Formularios.ABMC.Marcas;


namespace Trabajo_Practico.Formularios.ABMC.Marcas
{
    public partial class AltaMarcas : FormBaseAlta
    {
        public AltaMarcas()
        {
            InitializeComponent();
        }

        private void AltaMarcas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            string nombremarca = txtMarcaRegs.Text;

            Marca marc = new Marca(nombremarca);

            NE_Marcas marcAgregar = new NE_Marcas();

            marcAgregar.AgregarMarca(marc);


            
            
            

        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
