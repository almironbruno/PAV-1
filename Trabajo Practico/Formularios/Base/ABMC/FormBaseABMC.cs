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
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios
{
    public partial class FormBaseABMC : Form
    {
        protected BE_Acceso_Datos bd;
        //Se definen la consulta para que sean genericas
        protected string sqlConsulta;
        protected string sqlInsertar;
        protected string sqlEliminar;
        protected string sqlModificar;
        //protected DataTable tabla;
        public string consultaPrincipal;
        public FormBaseABMC()
        {
            InitializeComponent();
            bd = new BE_Acceso_Datos();
            
        }
        protected void cargargrilla()
        {
            dataGridViewModificada1.cargar(bd.Ejecutar_Select(consultaPrincipal));

        }
        
        protected void cambiarNombre(string nombre)
        {
            //Cambia los nombres de todos los componentes graficos del Form 
            lbl_titulo.Text = $"Gestion de {nombre}";
            btn_Actualizar.Text = $"Actualizar"+Environment.NewLine+nombre;
            btn_Eliminar.Text = $"Eliminar" + Environment.NewLine + nombre;
            btn_Buscar.Text= $"Buscar" + Environment.NewLine + nombre;
            btn_Agregar.Text = $"Agregar" + Environment.NewLine +nombre;
            cargargrilla();
        }

        public virtual void btn_Agregar_Click(object sender, EventArgs e)
        {
            //bd.Insertar(sqlInsertar);
        }

        protected void btn_Actualizar_Click(object sender, EventArgs e)
        {
            //bd.modificar(sqlModificar);
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            //bd.Ejecutar_Select(sqlConsulta);
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            // Se crea la ventana de Baja y se le asigna la fila seleccionada del grid
            DataGridViewRow fila = dataGridViewModificada1.FilaSeleccionada();
            
           

           //bd.Eliminar(sqlEliminar);
        }

        private void FormBaseABMC_Load(object sender, EventArgs e)
        {
            //Se carga la grid cuando se carga el formulario
            dataGridViewModificada1.cargar(bd.Ejecutar_Select(consultaPrincipal));

        }

        private void lbl_advertencia_Click(object sender, EventArgs e)
        {

        }

        private void FormBaseABMC_Load_1(object sender, EventArgs e)
        {

        }
    }
}
