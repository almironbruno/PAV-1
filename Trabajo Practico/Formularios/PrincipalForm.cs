﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases;
using Trabajo_Practico.Formularios.ABMC;

namespace Trabajo_Practico.Formularios
{
    public partial class PrincipalForm : Form
    {

        //Seteo que reciba al usuario que se conectó como parametro
        public PrincipalForm()
        {
            InitializeComponent();
            
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados ventanaEmpleados = new Empleados();
            ventanaEmpleados.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes ventanaClientes = new Clientes();
            ventanaClientes.Show();
        }

        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autos ventanaAutos = new Autos();
            ventanaAutos.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcas ventanaMarcas = new Marcas();
            ventanaMarcas.Show();

        }
    }
}
