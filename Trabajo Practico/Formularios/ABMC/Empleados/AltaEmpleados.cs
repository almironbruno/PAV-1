﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico.Formularios.ABMC.Empleados
{
    public partial class AltaEmpleados : CamposEmpleados
    {
        public AltaEmpleados()
        {
            
            InitializeComponent();
            //Se carga el comboBox de Cargos
            cmbCargable_Cargos.cargar("SELECT * FROM cargos_empleados", "nombre_cargo", "id_cargo");
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
