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
            //Usuario para pruebas
            Usuario usuarioGenerico = new Usuario(txtNombreUsu.Text, txtContraUsu.Text);

            string usuCorrecto = "Grupo03";
            string passCorrecta = "grupo03";

            if (txtNombreUsu.Text.Equals(usuCorrecto) && txtContraUsu.Text.Equals(passCorrecta))
            {
                //Creamos el objeto del tipo formulario de la pantalla principal

                                                                //Le mando el usuario creado para que se relacione con el
                PrincipalForm principalVnt = new PrincipalForm(usuarioGenerico);
                
                //Mostramos
                principalVnt.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Alguno de los dos esta mal puesto.");
            }

        }

        private void btnRegUsu_Click(object sender, EventArgs e)
        {
            //Objeto de Formulario del nuevo usuario
            NewUsuarioForm nuevoUsuarioVtn = new NewUsuarioForm();
            //Desplegar Ventana de creacion de nuevo usuario

            nuevoUsuarioVtn.Show();
            this.Hide();
        }
    }
}
