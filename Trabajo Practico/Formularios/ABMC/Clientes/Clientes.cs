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

namespace Trabajo_Practico.Formularios.ABMC
{
    public partial class Clientes : FormBaseABMC
    {
        public Clientes()
        {
            consultaPrincipal = "SELECT * FROM clientes";
            InitializeComponent();
            
            // cambia los nombres de la ventana a cliente --Eliminar comentario despues--
            cambiarNombre("Clientes");
            
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
