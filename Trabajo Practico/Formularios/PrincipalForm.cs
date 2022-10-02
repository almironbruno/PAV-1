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
using Trabajo_Practico.Formularios.ABMC.Gamas;
using Trabajo_Practico.Formularios.ABMC.Marcas;
using Trabajo_Practico.Formularios.ABMC.Telefonos;
using Trabajo_Practico.Formularios.ABMC.Clientes;
using Trabajo_Practico.Clases.Entidades;

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
            ABMC_Empleados ventanaEmpleados = new ABMC_Empleados();
            ventanaEmpleados.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ABMC_Clientes ventanaClientes = new ABMC_Clientes();
            ventanaClientes.Show();
=======
            //Clientes ventanaClientes = new Clientes();
            //ventanaClientes.Show();
>>>>>>> a2dc30fa7fe77ac4a016789b3208b71d94e51834
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

        private void gamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gamas ventanaGamas = new Gamas();
            ventanaGamas.Show();
        }

        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Barrios ventanaBarrios = new Barrios();
            ventanaBarrios.Show();

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm vtnLogin = new LoginForm();
            vtnLogin.Show();

        }

        private void telefonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelefonosPrincipal ventanaTelefono = new TelefonosPrincipal();
            ventanaTelefono.Show();
        }
    }
}
