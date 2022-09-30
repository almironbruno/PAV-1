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
using Trabajo_Practico.Clases.BackEnd.NegocioTelefonos;
using System.Text.RegularExpressions;
using Trabajo_Practico.Formularios.ABMC.Telefonos;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Formularios.ABMC.Telefonos
{
    public partial class TelefonosPrincipal : FormBaseABMC
    {
        public TelefonosPrincipal()
        {
            InitializeComponent();

            consultaPrincipal = (@"SELECT * FROM telefonos");
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaTelefono vtnAltaTelefono = new AltaTelefono();
            vtnAltaTelefono.Show();
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            ModificacionTelefono vtnModificarTel = new ModificacionTelefono();
            vtnModificarTel.Show();
        }
    }
}
