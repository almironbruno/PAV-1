using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.Proceso
{
    public partial class AgregarAuto : FormBaseBotones
    {
        public AgregarAuto()
        {
            InitializeComponent();

            
            string sqlNombreComr = (@"SELECT * FROM nombres_comerciales where id_nombrecomercial in (SELECT id_nombrecomercial FROM autos)");
            string sqlmarca = (@"SELECT * FROM marcas where id_marca in (SELECT id_marca FROM nombres_comerciales WHERE id_nombrecomercial IN (SELECT id_nombrecomercial FROM autos))");
           
            
            
            //cmb_nombreComercial.cargar(sqlNombreComr, "nombre_comercial", "id_nombrecomercial");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string marca = cmb_marca.cmb_Cargable.SelectedValue.ToString();
            string sqlgama = (@"SELECT * FROM gamas where id_gama in (SELECT id_gama FROM nombres_comerciales WHERE id_nombrecomercial IN (SELECT id_nombrecomercial FROM autos))");
            string sqlaño = (@"SELECT * FROM autos where año_fabricacion in (SELECT año_fabricacion FROM autos)");
            string sqlCondicion = (@"SELECT * FROM condicion where id_condicion in (SELECT id_condicion FROM autos)");
            string sqlNombreComr = ($"SELECT * FROM nombres_comerciales where id_marca ={marca} and id_nombrecomercial in (SELECT id_nombrecomercial FROM autos)");
            cmb_nombreComercial.cargar(sqlNombreComr, "nombre_comercial", "id_nombrecomercial");

            cmb_gama.cargar(sqlgama, "nombre_gama", "id_gama");
            cmb_Ano.cargar(sqlaño, "año_fabricacion", "cod_serie_fabrica");
            cmb_Condicion.cargar(sqlCondicion, "nombre_condicion", "id_condicion");
          

        }
    }
}
