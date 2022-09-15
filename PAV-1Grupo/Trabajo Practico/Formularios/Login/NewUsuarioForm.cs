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
                        //Corroborar si ya existe el email ingresado, en la bd
                        bool correoExiste = ConsultarEmailUsuario.consultarCorreo(email);

                        //Si el correo no tiene un usuario asociado
                        if (correoExiste == false)
                        {
                            try
                            {
                                    //Intentar agregar el nuevo usuario a la BD
                                if (AgregarUsuarioBd.InsertarUsuario(nombre, apellido, pass, email))
                                {
                                    MessageBox.Show("Usuario Registrado Con Exito");

                                }
                                else
                                {   //No se pudo agregar
                                    MessageBox.Show("Error al inserar un nuevo usuario");
                                }
                            }
                            catch (Exception)
                            {
                                //No se pudo agregar
                                MessageBox.Show("Error al inserar un nuevo usuario");
                                throw;

                            }
   
                        }
                        else
                        {   //El correo ingresado ya tiene un usuario asociado
                            MessageBox.Show("Ya existe un Usuario Asociado al correo: "+ email);
                        }
                    }
                
                
                }   


            }

        }





    }
}
