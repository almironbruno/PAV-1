using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioAutos;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.ABMC.ABMC_Autos.Forms;
using Trabajo_Practico.Formularios.ABMC.Autos;
using Trabajo_Practico.Formularios.Base;


namespace Trabajo_Practico.Formularios
{
    public partial class ABMC_Autos : FormBaseABMC
    {
        public ABMC_Autos()
        {
            //Consulta para relacionar los id nombre comercial y condicion, con los diferentes tipos de nombres comerciales y condiciones
            consultaPrincipal = (@"SELECT a.cod_serie_fabrica, n.nombre_comercial, a.año_fabricacion, a.patente, a.nro_chasis, a.nro_motor, c.nombre_condicion, a.monto
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
            dataGridViewModificada1.forme = new InfoAutos();
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

            ModificarAuto vtnModificar = new ModificarAuto(dataGridViewModificada1.FilaSeleccionada());
            vtnModificar.Show();

        }
        

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {

            BajaAutos vtnBajaAuto = new BajaAutos(dataGridViewModificada1.FilaSeleccionada());
            vtnBajaAuto.Show();
           
           
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            BuscarAuto vtnBuscarAuto = new BuscarAuto();
            vtnBuscarAuto.Show();
        }


        private void ABMC_Autos_Activated(object sender, EventArgs e)
        {
            dataGridViewModificada1.forme = new InfoAutos();
        }
    }
}
