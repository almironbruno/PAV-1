using System;
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
using Trabajo_Practico.Formularios.ABMC.Barrios;

using Trabajo_Practico.Formularios.ABMC.Marcas;
using Trabajo_Practico.Formularios.ABMC.Telefonos;
using Trabajo_Practico.Formularios.ABMC.Clientes;
using Trabajo_Practico.Formularios.ABMC.Localidades;
using Trabajo_Practico.Formularios.ABMC.Encargos;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Proceso;

namespace Trabajo_Practico.Formularios
{
    public partial class PrincipalForm : Form
    {
        private Form formLogin;
        private string legajo;

        //Seteo que reciba al usuario que se conectó como parametro
        public PrincipalForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            this.Show();
            ///Abre el login
            LoginForm login = new LoginForm();
            login.ShowDialog();
            legajo = login.buscarLeg();
            lbl_legajo.Text ="Legajo: "+ legajo;
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMC_Empleados ventanaEmpleados = new  ABMC_Empleados();
            ventanaEmpleados.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ABMC_Clientes ventanaClientes = new ABMC_Clientes();
            ventanaClientes.ShowDialog();

        }

        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMC_Autos ventanaAutos = new ABMC_Autos();
            ventanaAutos.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMC_Marcas ventanaMarcas = new ABMC_Marcas();
            ventanaMarcas.ShowDialog();

        }

        

        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Barrios ventanaBarrios = new Barrios();
            ventanaBarrios.ShowDialog();

            

            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void telefonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelefonosPrincipal ventanaTelefono = new TelefonosPrincipal();
            ventanaTelefono.ShowDialog();
	}
        private void nombreComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trabajo_Practico.Formularios.ABMC.Localidades.Localidades ventana = new Trabajo_Practico.Formularios.ABMC.Localidades.Localidades();
            ventana.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void encargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

       

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void PrincipalForm_Shown(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void encargosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Trabajo_Practico.Formularios.ABMC.Encargos.Encargos ventana = new Trabajo_Practico.Formularios.ABMC.Encargos.Encargos();
            ventana.ShowDialog();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Vacia para que el form arranque
            DataGridView dtg = new DataGridView();
            FormVenta ventanaVenta = new FormVenta(dtg,legajo);
            ventanaVenta.ShowDialog();
        }
    }
}

