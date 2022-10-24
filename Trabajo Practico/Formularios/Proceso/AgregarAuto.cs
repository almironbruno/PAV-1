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
using Trabajo_Practico.Clases.BackEnd.NegocioProceso;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.Proceso
{
    public partial class AgregarAuto : FormBaseBotones
    {
        public AgregarAuto()
        {
            InitializeComponent();


            //string sqlNombreComr = (@"SELECT * FROM nombres_comerciales where id_nombrecomercial in (SELECT id_nombrecomercial FROM autos)");
            //string sqlmarca = (@"SELECT * FROM marcas where id_marca in (SELECT id_marca FROM nombres_comerciales WHERE id_nombrecomercial IN (SELECT id_nombrecomercial FROM autos))");
            //string sqlmarca = "SELECT id_marca FROM nombres_comerciales, autos WHERE autos.id_nombrecomercial like nombres_comerciales.id_nombrecomercial";
            //cmb_nombreComercial.cargar(sqlNombreComr, "nombre_comercial", "id_nombrecomercial");

            cmb_marca.cargarAlmacenado("GetNombres", "nombre", "id_marca");
            cmb_nombreComercial.cargarAlmacenado("GetNombresComerciales", "nombre_comercial", "id_nombrecomercial");
            cmb_Condicion.cargarAlmacenado("GetCondiciones", "nombre_condicion", "id_condicion");
            cmb_gama.cargarAlmacenado("GetGamas", "nombre_gama", "id_gama");
            BE_Acceso_Datos bd = new BE_Acceso_Datos();

            cmbBoxAño.DataSource = bd.Ejecutar_Select("SELECT autos.año_fabricacion FROM autos GROUP BY año_fabricacion");
            cmbBoxAño.DisplayMember = "año_fabricacion";
            cmbBoxAño.ValueMember = "año_fabricacion";
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
            //cmb_Ano.cargar(sqlaño, "año_fabricacion", "cod_serie_fabrica");
            cmb_Condicion.cargar(sqlCondicion, "nombre_condicion", "id_condicion");
          

        }

        private void AgregarAuto_Load(object sender, EventArgs e)
        {

        }
    }
}
