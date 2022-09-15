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
using Trabajo_Practico.Formularios;
using System.Data.SqlClient;
using Trabajo_Practico.Clases.BackEnd;

namespace Trabajo_Practico
{
    public partial class LoginForm : Form
    {
        

        public LoginForm()
        {
            InitializeComponent();
        }

        //Validar btn inicioSesion
        private void btnIniciarSS_Click(object sender, EventArgs e)
        {

            string nombre = txtNombreUsu.Text;
            string pass = txtContraUsu.Text;
            //Usuario para pruebas
            Usuario usuario = new Usuario(nombre, pass);

           
            

            if (ValidarUsuarioBd.ValidarUsuario(usuario.NombreDeUsuario, usuario.Password))
            {
                //Creamos el objeto del tipo formulario de la pantalla principal

                                                                //Le mando el usuario creado para que se relacione con el
                PrincipalForm principalVnt = new PrincipalForm(usuario);
                
                //Mostramos
                principalVnt.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Nombre O Contraseña Incorrectos");
            }

        }

        private void btnRegUsu_Click(object sender, EventArgs e)
        {
            //Objeto de Formulario del nuevo usuario
            NewUsuarioForm nuevoUsuarioVtn = new NewUsuarioForm();
            //Desplegar Ventana de creacion de nuevo usuario

            nuevoUsuarioVtn.Show();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
