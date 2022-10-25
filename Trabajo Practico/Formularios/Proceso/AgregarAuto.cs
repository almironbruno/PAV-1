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
            cmbAñoFab.cargarAlmacenado("GetAnoFabricacion", "año_fabricacion", "año_fabricacion");
            BE_Acceso_Datos bd = new BE_Acceso_Datos();

            //cmbBoxAño.DataSource = bd.Ejecutar_Select("SELECT autos.año_fabricacion FROM autos GROUP BY año_fabricacion");
            //cmbBoxAño.DisplayMember = "año_fabricacion";
            //cmbBoxAño.ValueMember = "año_fabricacion";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            NE_Proceso nP = new NE_Proceso();

            int marca = int.Parse(cmb_marca.cmb_Cargable.SelectedValue.ToString());
            int gama = int.Parse(cmb_gama.cmb_Cargable.SelectedValue.ToString());
            int año = int.Parse(cmbAñoFab.cmb_Cargable.SelectedValue.ToString());
            int condicion = int.Parse(cmb_Condicion.cmb_Cargable.SelectedValue.ToString());
            int modelo = int.Parse(cmb_nombreComercial.cmb_Cargable.SelectedValue.ToString());

            try
            {
                DataTable tabla = new DataTable();
                tabla = nP.SelectVehiculoDisponible(marca, modelo, condicion, gama, año);
                if (tabla.Rows.Count > 0)
                {
                    dgr_autos.DataSource = tabla;
                }
                else
                {
                    MessageBox.Show("No se encontraron vehiculos con las caracteristicas seleccionadas");
                    cmb_marca.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta de Autos disponibles");
                
            }
            

        }

        private void AgregarAuto_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        { //Aca se supone que debeira poderse enviar los datos al form ventas
            if (dgr_autos.Rows.Count > 0)
            {
                DataTable tabla = dgr_autos.DataSource as DataTable;
                
                
            }
        }

        private void dgr_autos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int idfila = e.RowIndex;
            }
               
                
            }
        }
    }
}
