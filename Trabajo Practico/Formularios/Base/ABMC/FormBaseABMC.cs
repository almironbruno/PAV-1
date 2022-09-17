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
        protected DataTable tabla;
        protected string tablaPrincipal;
        public FormBaseABMC()
        {
            InitializeComponent();
            bd = new BE_Acceso_Datos();
            
        }
        protected void cambiarNombre(string nombre)
        {
            //Cambia los nombres de todos los componentes graficos del Form 
            lbl_titulo.Text = $"Gestion de {nombre}";
            btn_Actualizar.Text = $"Actualizar"+Environment.NewLine+nombre;
            btn_Eliminar.Text = $"Eliminar" + Environment.NewLine + nombre;
            btn_Buscar.Text= $"Buscar" + Environment.NewLine + nombre;
            btn_Agregar.Text = $"Agregar" + Environment.NewLine +nombre;

        }

        public virtual void btn_Agregar_Click(object sender, EventArgs e)
        {
            //bd.Insertar(sqlInsertar);
        }

        protected void btn_Actualizar_Click(object sender, EventArgs e)
        {
            bd.modificar(sqlModificar);
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            bd.Ejecutar_Select(sqlConsulta);
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridViewModificada1.FilaSeleccionada();
            FormBaseBaja ventanaBaja = new FormBaseBaja(fila);
            ventanaBaja.Show();

           //bd.Eliminar(sqlEliminar);
        }

        private void FormBaseABMC_Load(object sender, EventArgs e)
        {
            dataGridViewModificada1.cargar(bd.Ejecutar_Select("SELECT * FROM "+tablaPrincipal));

        }

        private void lbl_advertencia_Click(object sender, EventArgs e)
        {

        }
    }
}
