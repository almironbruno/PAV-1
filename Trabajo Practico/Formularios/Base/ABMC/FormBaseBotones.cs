using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd;

namespace Trabajo_Practico.Formularios.Base
{
    
    public partial class FormBaseBotones : Form
    {
        protected bool modoConsulta = false;
        protected BE_Acceso_Datos bd = new BE_Acceso_Datos();
        public FormBaseBotones()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //if(!modoConsulta && !validarCampos()) return;
        }

        private  void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Va a salir \n\t ¿Esta seguro?", "Salir", MessageBoxButtons.OKCancel);
            //Si el usuario selecciona OK, borra los campos
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

         protected virtual void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Va a borrar todos los camppos \n\t ¿Esta seguro?","Advertencia para borrar campos", MessageBoxButtons.OKCancel);
            //Si el usuario selecciona OK, borra los campos
            if (result == DialogResult.OK)
            {
                //Recorre los controles del form y borra los TextBox - MaskedTextBox
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.Text = "";

                    }
                }
                errorProviderBase.Clear();
            }

        }

        protected bool validarCampos()
        {
            //Devuelve true si la vadilacion da que los campos estan completos

            bool hayErrores = false; //Bandera 
            errorProviderBase.Clear(); //Limpia la pantalla 

            //Recorre los controles del formulario y pregunta si es TextBox o MaskedTextbox
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    //Si el control está vacio
                    if (item.Text.Equals(""))
                    {
                        //Pone el icono de error al lado del control (control, mensaje a mostrar)
                        item.Focus();
                        errorProviderBase.SetError(item, "No puede estar vacio");
                        hayErrores = true;
                    }

                }
                //Control para mtextbox de tipo fechas
                if (item is MaskedTextBox)
                {
                    //Hace la conversion a tipo mtxtbox para poder usar el campo ValidatingType(para preguntar si es de tipo fecha)
                    MaskedTextBox maskedTextBox = (MaskedTextBox)item;
                    //MaskCompleted controla si la mascara está completa 
                    if (!maskedTextBox.MaskCompleted && maskedTextBox.ValidatingType == typeof(DateTime))
                    {
                        item.Focus(); // Mueve el cursor al campo
                        errorProviderBase.SetError(item, "No puede ingresar una fecha incompleta");
                        hayErrores = true;
                    }

                }

            }
            if (hayErrores)
            {
                return false;
            }
            else
            {
                //No hay errores
                return true;
            }
            


        }

        //Obliga a los hijos a implementar este metodo, llenando el form que corresponda
        public virtual void cargarInfo(DataGridViewRow row) { }

        public void cambiarFormaConsulta()
        {
            //Metodo que cambia los botones al "Modo Consulta"
            btn_Cancelar.Text = "Volver";
            //.Hide();
            modoConsulta = true;
            
        }
        

        private void FormBaseBotones_Load(object sender, EventArgs e)
        {

        }
    }
}
