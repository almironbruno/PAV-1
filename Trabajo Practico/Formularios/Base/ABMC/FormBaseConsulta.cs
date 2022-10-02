﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.ABMC.Empleados;

namespace Trabajo_Practico.Formularios.Base
{
    public partial class FormBaseConsulta : FormBaseBotones
    {
        public FormBaseConsulta()
        {
            InitializeComponent();
            
        }


        protected void cambiarNombre(string nombre)
        {
            //Cambia los nombres de todos los componentes graficos del Form 
            lbl_buscar.Text = $"Busqueda de {nombre}";
            

        }

        private void FormBaseConsulta_Load(object sender, EventArgs e)
        {

        }
        //public virtual void cargarInfo(DataGridViewRow row) { }
    }
}
