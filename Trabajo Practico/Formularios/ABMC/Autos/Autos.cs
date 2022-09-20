using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
            cargargrilla();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            string cod_serie = dataGridViewModificada1.FilaSeleccionada().Cells[0].Value.ToString();
            string patente = dataGridViewModificada1.FilaSeleccionada().Cells[6].Value.ToString();
            MessageBox.Show("Codigo de Serie del Vehiculo: " + 
                             cod_serie + " - Patente del Vehiculo: " + patente);
            //FALTARIA EL MENSAJE PARA VALIDAR LA CONFIRMACION DE BORRADO, 
            //AL FINAL HABIAMOS DICHO QUE NO SE IBA A DESPLEGAR UN NUEVO FORM, SINO QUE SE SELECCIONABA LO QUE SE DESEABA BORRAR
            //SE CONFIRMABA EL BORRADO, Y LUEGO SE BORRABA.
            
            
        }
    }
}
