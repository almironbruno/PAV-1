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

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Localidades
{
    public partial class CamposLocalidades : FormBaseAlta
    {
        public CamposLocalidades()
        {
            InitializeComponent();
            txtNombreLocalidad.HidePromptOnLeave = true;
        }        
    }
}
