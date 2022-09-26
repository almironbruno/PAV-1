using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioAutos;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.ABMC.Autos;
using Trabajo_Practico.Formularios.Base;


namespace Trabajo_Practico.Formularios
{
    public partial class Autos : FormBaseABMC
    {
        public Autos()
        {
            //Consulta para relacionar los id nombre comercial y condicion, con los diferentes tipos de nombres comerciales y condiciones
            consultaPrincipal = (@"SELECT a.cod_serie_fabrica, n.nombre_comercial, a.año_fabricacion, a.patente, a.nro_chasis, a.nro_motor, c.nombre_condicion
                FROM autos A
                JOIN nombres_comerciales AS N
                ON A.id_nombrecomercial = N.id_nombrecomercial
                JOIN condicion C
                ON A.id_condicion = C.id_condicion");



            InitializeComponent();
            cambiarNombre("Autos");
            
            
        }

        private void Autos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaAutos vtnAltaAutos = new AltaAutos();
            vtnAltaAutos.Show();
        }

        private void dataGridViewModificada1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            string codSerie = dataGridViewModificada1.FilaSeleccionada().Cells["cod_serie_fabrica"].Value.ToString().Trim();
            string idComer = dataGridViewModificada1.FilaSeleccionada().Cells["nombre_comercial"].Value.ToString();
            string añoFab = dataGridViewModificada1.FilaSeleccionada().Cells["año_fabricacion"].Value.ToString().Trim();
            string idCond = dataGridViewModificada1.FilaSeleccionada().Cells["nombre_condicion"].Value.ToString();
            string nroChasis = dataGridViewModificada1.FilaSeleccionada().Cells["nro_chasis"].Value.ToString();
            string nroMotr = dataGridViewModificada1.FilaSeleccionada().Cells["nro_motor"].Value.ToString().Trim();
            string patente = dataGridViewModificada1.FilaSeleccionada().Cells["patente"].Value.ToString().Trim();
            string regis = "Registro: Codigo de Serie del Vehiculo: " +codSerie+ System.Environment.NewLine + "Patente del Vehiculo: " + patente+".";

            NE_Autos condicionInt = new NE_Autos();


            //Obtener el valor id de los nombres registrados en los combobox 
            int cond = condicionInt.ConsultarCondicion(idCond);
            
            int comer = condicionInt.ConsultarNombreComer(idComer);


            //Crear el objeto auto a modificar y cargarlo con los valores obtenidos de los txtbox y los valores de condicion y nomcomer
            Vehiculos auto = new Vehiculos(codSerie, comer, añoFab, cond, nroChasis, nroMotr, patente );
            DialogResult dialogResult = MessageBox.Show(regis, "Desea Modificar el registro?", MessageBoxButtons.YesNo);


            if (dialogResult == DialogResult.Yes)
            {
                ModificarAuto ventanaMod = new ModificarAuto(auto);
                ventanaMod.Show();

            }
            else
            {
                // Nada ya que no se elimina, al oprimir no se cierra el txtbox
            }
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {


            string cod_serie = dataGridViewModificada1.FilaSeleccionada().Cells[0].Value.ToString();
            string patente = dataGridViewModificada1.FilaSeleccionada().Cells[3].Value.ToString();

            string registro = "Registro: Codigo de Serie del Vehiculo: " + cod_serie + System.Environment.NewLine + "Patente del Vehiculo: " + patente + ".";

            //Confirmacion de borrado
            DialogResult dialogResult = MessageBox.Show(registro, "Desea eliminar el registro?",MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                NE_Autos borrarAuto = new NE_Autos();
                borrarAuto.BorrarAuto(patente);

                //cargargrilla();
            }
            else
            {
                // Nada ya que no se elimina, al oprimir no se cierra el txtbox
            }
            
            

            


        }
    }
}
