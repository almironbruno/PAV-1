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
using Trabajo_Practico.Clases.BackEnd;


namespace Trabajo_Practico.Formularios
{
    public partial class NewUsuarioForm : Form
    {
        public NewUsuarioForm()
        {
            InitializeComponent();
        }
        //Crear Nuevo usuario
        private void NewUsuarioForm_Load(object sender, EventArgs e)
        {

        }


        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

            string nombre = txtNomNewUsu.Text.Trim();

            string apellido = txtApeNewUsu.Text.Trim();

            string pass = txtPassNewUsu.Text.Trim();

            string rpPass = txtRepPassNewUsu.Text.Trim();

            string email = txtCorreoNewUsu.Text.Trim();


            bool iguales = false;
            if (pass.Equals(rpPass))
            {
                iguales = true;
            }

            //Validar campos vacios

            if (nombre.Equals("") || apellido.Equals("") ||
                pass.Equals("") || rpPass.Equals("") || email.Equals(""))
            {
                MessageBox.Show("Complete TODOS los campos antes de continuar..");
            }
            else
            {
                //Validar formato del correo
                if (ValidarEmail.ValidarCorreo(email) == false)
                {
                    MessageBox.Show("Ingrese un formato de Email Valido; Por ejemplo: Usuario@gmail.com");
                }
                else
                { //Validar que la contraseña y la repeticion de la misma coincidan
                   if(iguales == false)
                    {
                        MessageBox.Show("Las contraseñas deben Coincidir..");
                    }

                    else
                    {

                        //A travez de la funcionalidad De negocio, valdiar que no se duplique el correo
                        NE_usuarios usuarioEmail = new NE_usuarios();

                        if (usuarioEmail.ValidarEmailExistente(txtCorreoNewUsu.Text) == NE_usuarios.ResultadoValidacion.existe)
                        {
                            MessageBox.Show("El correo ingresado ya se encuentra adherido a un usuario");

                        }
                        else
                        {

                            //Crear nuevo objeto usuario
                            Usuario usuarioAgregar = new Usuario(nombre, apellido, pass, email);


                            //Crear nuevo usuario negocio
                            NE_usuarios usuario = new NE_usuarios();

                            //Al usuario Negocio, mandarle el usuario a agregar
                            usuario.AgregarUsuario(usuarioAgregar);

                            MessageBox.Show("Usuario Creado Exitosamente");
                            
                        }

                        
                       
                    }
                
                
                }   


            }

        }





    }
}
