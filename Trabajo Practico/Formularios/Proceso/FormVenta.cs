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
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.Proceso
{
    public partial class FormVenta : FormBaseBotones
    {
        public FormVenta(DataGridView dtg)
        {
            InitializeComponent();
            this.buscador1.tablaConsulta = "clientes";
            buscador1.columna = "nombre";
            txt_fecha.Text = DateTime.Now.ToShortDateString();


            cmbMarca.cargarAlmacenado("GetNombres", "nombre", "id_marca");
            cmbModelo.cargarAlmacenado("GetNombresComerciales", "nombre_comercial", "id_nombrecomercial");
            cmbCondicion.cargarAlmacenado("GetCondiciones", "nombre_condicion", "id_condicion");
            cmbGama.cargarAlmacenado("GetGamas", "nombre_gama", "id_gama");
            cmbAño.cargarAlmacenado("GetAnoFabricacion", "año_fabricacion", "año_fabricacion");
            BE_Acceso_Datos bd = new BE_Acceso_Datos();
            
            DataTable dt = bd.Ejecutar_Select("select IDENT_CURRENT('ventas') +1 as 'venta'"); 

 

            if (dt.Rows.Count > 0)
            {
                string nro = dt.Rows[0]["venta"].ToString();

                txt_nroFactura.Text = nro;

                MessageBox.Show(nro);

            }
            else
            {
                MessageBox.Show("error");

            }
        }
        protected override void btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Va a borrar todos los camppos \n\t ¿Esta seguro?", "Advertencia para borrar campos", MessageBoxButtons.OKCancel);
            //Si el usuario selecciona OK, borra los campos
            if (result == DialogResult.OK)
            {
                buscador1.limpiar();
            }

        }

        /*/private void btn_Agregar_Click(object sender, EventArgs e)
        {
            AgregarAuto ventana = new AgregarAuto();
            ventana.Show();
            this.Hide();

        }
        /*/


        private void FormVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NE_Proceso nP = new NE_Proceso();

            int marca = int.Parse(cmbMarca.cmb_Cargable.SelectedValue.ToString());
            int gama = int.Parse(cmbGama.cmb_Cargable.SelectedValue.ToString());
            int año = int.Parse(cmbAño.cmb_Cargable.SelectedValue.ToString());
            int condicion = int.Parse(cmbCondicion.cmb_Cargable.SelectedValue.ToString());
            int modelo = int.Parse(cmbModelo.cmb_Cargable.SelectedValue.ToString());

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
                    cmbMarca.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta de Autos disponibles");

            }
        }

        private void dgr_autos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgr_factura.Rows.Add(dgr_autos.SelectedRows[0].Cells[0].Value, 
                                    dgr_autos.SelectedRows[0].Cells[5].Value,
                                    dgr_autos.SelectedRows[0].Cells[4].Value, 
                                    dgr_autos.SelectedRows[0].Cells[1].Value, 
                                    dgr_autos.SelectedRows[0].Cells[2].Value,
                                    dgr_autos.SelectedRows[0].Cells[3].Value,
                                    dgr_autos.SelectedRows[0].Cells[6].Value);

        }

        private void dgr_factura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            dgr_factura.Rows.Remove(dgr_factura.CurrentRow);
            //For Each r As DataGridViewRow In DataGridViewRow1.SelectedRows
            //DataGridViewRow1.Rows.Remove(r)
            //Next//
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Venta vta = new Venta();


            vta.legajo = 0;
            vta.fecha = txt_fecha.Text;
            vta.num_dni = 33232;
            vta.tipo_doc = 1;
            vta.nro_factura = int.Parse(txt_nroFactura.Text);

            List<string> lista = new List<string>();
            for (int i = 0; i < dgr_factura.Rows.Count; i++)
            {
                string agregar = dgr_factura.Rows[i].Cells[1].Value.ToString();
                lista.Add(agregar);
            }

            foreach (var item in lista)
            {
                MessageBox.Show(item);
            }

            NE_Proceso nP = new NE_Proceso();
            bool rta = nP.Venta(vta, lista);
            
            if (rta)
            {
                MessageBox.Show("Funciona");
            }
            else
            {
                MessageBox.Show("No funciona");
            }



        }

        private void buscador1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
