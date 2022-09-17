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
//using System.Data.SqlClient;
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

            NE_usuarios usuario = new NE_usuarios();

            //Expresion Programada
            //if(usuario.ValidarUsuario(txtNombreUsu.Text, txtContraUsu.Text) == NE_usuarios.ResultadoValidacion.existe)
            //{
                PrincipalForm vtnPrincipal = new PrincipalForm();
                vtnPrincipal.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario Inexistente o Datos Incorrectos");
            //}


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
