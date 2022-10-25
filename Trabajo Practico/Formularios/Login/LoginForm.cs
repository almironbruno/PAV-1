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
             if (ValidarEmail.ValidarCorreo(txtEmailUsu.Text) == true)
             {
                 //Expresion Programada
                 if (usuario.ValidarUsuario(txtEmailUsu.Text, txtContraUsu.Text) == NE_usuarios.ResultadoValidacion.existe)
                 {

                    this.Visible = false ;

                 }
                 else
                 {
                     MessageBox.Show("Usuario Inexistente o Datos Incorrectos");
                 }
             }
             else
             {
                 MessageBox.Show("Ingrese un email en formato valido");
             }


        }

        private void btnRegUsu_Click(object sender, EventArgs e)
        {
            //Objeto de Formulario del nuevo usuario
            NewUsuarioForm nuevoUsuarioVtn = new NewUsuarioForm();
            //Desplegar Ventana de creacion de nuevo usuario

            nuevoUsuarioVtn.Show();
            
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Visible)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir del sistema", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Environment.Exit(1);
                }
                else
                {
                    e.Cancel = true;
                }

            }
            
        }
        public string buscarLeg() 
        {
            NE_usuarios usuario = new NE_usuarios();
            
            return usuario.buscarLegajo(txtEmailUsu.Text);

        }
    }
}
