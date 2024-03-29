﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabajo_Practico.Formularios.Proceso
{
    public partial class FormVenta : FormBaseBotones
    {
        private string monto;
        public FormVenta(DataGridView dtg,string legajo)
        {
            InitializeComponent();
            this.buscador1.tablaConsulta = "clientes";
            buscador1.columna = "nombre";
            txt_fecha.Text = DateTime.Now.ToShortDateString();

            txt_legajo.Text = legajo;
            txtMontoTotal.Text = 0.ToString();

            txtEstado.Text = " ";

            cmbMarca.cargarAlmacenado("GetNombres", "nombre", "id_marca");
            string sqlnombres = "SELECT DISTINCT nombres_comerciales.nombre_comercial, nombres_comerciales.id_nombrecomercial FROM autos INNER JOIN nombres_comerciales On autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial WHERE autos.estado = 'false' AND nombres_comerciales.id_marca = " + cmbMarca.cmb_Cargable.SelectedValue.ToString();

            //handle the event
            cmbModelo.cargar(sqlnombres, "nombre_comercial", "id_nombrecomercial");
            string sqlanio = "SELECT distinct año_fabricacion FROM autos join nombres_comerciales on autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial WHERE autos.estado = 'false' and nombres_comerciales.nombre_comercial='" + cmbModelo.cmb_Cargable.Text.ToString()+"'";
            cmbAño.cargar(sqlanio, "año_fabricacion", "año_fabricacion");

            string sqlgama = "SELECT gamas.id_gama, gamas.nombre_gama\r\n\t\tFROM autos INNER JOIN nombres_comerciales\r\n\t\t\tOn autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial\r\n\t\t\tINNER JOIN gamas ON nombres_comerciales.id_gama = gamas.id_gama\r\n\t\t\t\r\n\t\tWHERE autos.estado = 'false' and nombres_comerciales.nombre_comercial ='" + cmbModelo.cmb_Cargable.Text.ToString() + "'  \r\n\t\tGROUP BY gamas.id_gama, gamas.nombre_gama";
            cmbGama.cargar(sqlgama, "nombre_gama", "id_gama");


            //cmbModelo.cargarAlmacenado("GetNombresComerciales", "nombre_comercial", "id_nombrecomercial");
            cmbCondicion.cargarAlmacenado("GetCondiciones", "nombre_condicion", "id_condicion");
            //cmbGama.cargarAlmacenado("GetGamas", "nombre_gama", "id_gama");
            //cmbAño.cargarAlmacenado("GetAnoFabricacion", "año_fabricacion", "año_fabricacion");
            BE_Acceso_Datos bd = new BE_Acceso_Datos();
            CargarSugerencia();
            
            DataTable dt = bd.Ejecutar_Select("select IDENT_CURRENT('ventas') +1 as 'venta'"); 


            

            if (dt.Rows.Count > 0)
            {
                string nro = dt.Rows[0]["venta"].ToString();

                txt_nroFactura.Text = nro;;

            }
            else
            {
                MessageBox.Show("Error - nroFactura Invalido");

            }
        }


        public void CargarSugerencia()

        {

            
            try
            {
                DataTable tabla = new DataTable();
                NE_Proceso nP = new NE_Proceso();
                tabla = nP.Sugerencia();
                if (tabla.Rows.Count > 0)
                {
                    dgvDisponibles.DataSource = tabla;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta de Sugerencias");

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

            DataTable dt = new DataTable();



            try
            {
                DataTable tabla = new DataTable();
                tabla = nP.SelectVehiculoDisponible(marca, modelo, condicion, gama, año);
                if (tabla.Rows.Count > 0)
                {
                    string vigente = tabla.Rows[0]["estado"].ToString();
                    if(vigente == "False") 
                    {
                        txtEstado.Text = "Disponible";
                        dgr_autos.DataSource = tabla;


                    }
                    else
                    {
                        txtEstado.Text = "Vendido";
                        MessageBox.Show("El vehiculo Seleccionado se encuentra Vendido");
                          
                    }
                }
                //if (tabla.Rows.Count > 0)
                //{
                    //dgr_autos.DataSource = tabla;


                //}
                else
                {
                    MessageBox.Show("No se encontraron vehiculos con las caracteristicas seleccionadas");
                    cmbMarca.Focus();
                }
                colorear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta de Autos disponibles");

            }
        }
        private void colorear() 
        {
            //Colorea segun el estado
            for (int i = 0; i < dgr_autos.Rows.Count; i++)
            {
                
                if (dgr_autos.Rows[i].Cells[7].Value.ToString() == "False") 
                {
                    dgr_autos.Rows[i].Cells[7].Style.BackColor=Color.LightGreen;

                }
                else

                {
                    dgr_autos.Rows[i].Cells[7].Style.BackColor = Color.LightCoral;
                };
            }
            
        }
        private void dgr_autos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (validarEstado(dgr_autos.SelectedRows[0]))
            {
                MessageBox.Show("¡El auto está vendido, no puede comprarlo!");
                return;

            }
           if(validarInclusion(dgr_autos.SelectedRows[0].Cells[5].Value.ToString()))
            {
                MessageBox.Show("¡Ya se incluyó el auto en la factura!");
                return;
            };
            dgr_factura.Rows.Add(dgr_autos.SelectedRows[0].Cells[0].Value, 
                                    dgr_autos.SelectedRows[0].Cells[5].Value,
                                    dgr_autos.SelectedRows[0].Cells[4].Value, 
                                    dgr_autos.SelectedRows[0].Cells[1].Value, 
                                    dgr_autos.SelectedRows[0].Cells[2].Value,
                                    dgr_autos.SelectedRows[0].Cells[3].Value,
                                    dgr_autos.SelectedRows[0].Cells[6].Value);


            SumEachRows();


        }
        private bool validarEstado(DataGridViewRow c)
        {
            //Valida que no este vendido
            
                if (c.Cells[7].Value.ToString() == "True")
                {
                    return true;
                }
            
            return false;
        }
        private bool validarInclusion(string codigo)
        {
            
            
            //Controla que el codigo no este ya incluido en la factura
            for (int i = 0; i < dgr_factura.Rows.Count; i++)
            {
                if (codigo == dgr_factura.Rows[i].Cells[1].Value.ToString())
                {
                    return true;
                }
                

            }
                
                
            return false;
        }

        private void dgr_factura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Aca agarrar el valor del monto de la celda a eliminar, y restarselo al txtMontoTotal.

            decimal monto = decimal.Parse(dgr_factura.SelectedRows[0].Cells[6].Value.ToString());
            dgr_factura.Rows.Remove(dgr_factura.CurrentRow);
            SumEachRows();

         
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //validaciones
            if (!validarCampos() || dgr_factura.Rows.Count==0) return;
            Venta vta = new Venta();


      
            vta.fecha = txt_fecha.Text;
            vta.num_dni =int.Parse(buscador1.cmb_buscar.SelectedValue.ToString());
            vta.tipo_doc = int.Parse(buscador1.cmb_buscar.Text.Substring(0,1));
            vta.nro_factura = int.Parse(txt_nroFactura.Text);
            vta.legajo =int.Parse(txt_legajo.Text);
            List<string> lista = new List<string>();
            for (int i = 0; i < dgr_factura.Rows.Count; i++)
            {
                string agregar = dgr_factura.Rows[i].Cells[1].Value.ToString();
                lista.Add(agregar);
            }

            //Para probar que se reciban bien los items
            /*/
            foreach (var item in lista)
            {
                MessageBox.Show(item);
            }
            /*/


            NE_Proceso nP = new NE_Proceso();
            bool rta = nP.Venta(vta, lista);
            
            if (rta)
            {
                MessageBox.Show("Transaccion Exitosa");
                limpiarGrillas();
                this.Close();
                CargarSugerencia();
                
            }
            else
            {
                MessageBox.Show("Fallo en la Transaccion");
            }



        }

        //Sumar monto total
        private void SumEachRows()
        {
            decimal total = 0;
            if (dgr_factura.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgr_factura.Rows)
                {
                    total += Convert.ToDecimal(row.Cells[6].Value);
                    
                }
                txtMontoTotal.Text = Convert.ToString(total);
            }
            else
            {
                txtMontoTotal.Text = Convert.ToString(0);
            }
        }

        

        private void buscador1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }
        private void limpiarGrillas() 
        {
            //funcion que limpia la grilla de Autos y factura
            DataTable dt = dgr_autos.DataSource as DataTable;

            if (dt != null) 
            {
                dt.Rows.Clear();
            }
           
            dgr_factura.Rows.Clear();
            

        }

        protected void cmbMarca_SelectionChanged(object sender, EventArgs e)
        {
           if (cmbMarca.cmb_Cargable.DataSource!=null  )
            {
            string sqlnombres = "SELECT DISTINCT nombres_comerciales.nombre_comercial, nombres_comerciales.id_nombrecomercial FROM autos INNER JOIN nombres_comerciales On autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial WHERE autos.estado = 'false' AND nombres_comerciales.id_marca = " + cmbMarca.cmb_Cargable.SelectedValue.ToString();

            cmbModelo.cargar(sqlnombres, "nombre_comercial", "id_nombrecomercial");
            
            string sqlanio = "SELECT distinct año_fabricacion FROM autos join nombres_comerciales on autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial WHERE autos.estado = 'false' and nombres_comerciales.nombre_comercial='" + cmbModelo.cmb_Cargable.Text.ToString() + "'";
            cmbAño.cargar(sqlanio, "año_fabricacion", "año_fabricacion");

                string sqlgama = "SELECT gamas.id_gama, gamas.nombre_gama\r\n\t\tFROM autos INNER JOIN nombres_comerciales\r\n\t\t\tOn autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial\r\n\t\t\tINNER JOIN gamas ON nombres_comerciales.id_gama = gamas.id_gama\r\n\t\t\t\r\n\t\tWHERE autos.estado = 'false' and nombres_comerciales.nombre_comercial ='" + cmbModelo.cmb_Cargable.Text.ToString() + "'  \r\n\t\tGROUP BY gamas.id_gama, gamas.nombre_gama";
                cmbGama.cargar(sqlgama, "nombre_gama", "id_gama");
            }

        }
        protected void cmbModelo_textChanged(object sender, EventArgs e)
        {
            string sqlanio = "SELECT distinct año_fabricacion FROM autos join nombres_comerciales on autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial WHERE autos.estado = 'false' and nombres_comerciales.nombre_comercial='" + cmbModelo.cmb_Cargable.Text.ToString() + "'";
            cmbAño.cargar(sqlanio, "año_fabricacion", "año_fabricacion");
            string sqlgama = "SELECT gamas.id_gama, gamas.nombre_gama\r\n\t\tFROM autos INNER JOIN nombres_comerciales\r\n\t\t\tOn autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial\r\n\t\t\tINNER JOIN gamas ON nombres_comerciales.id_gama = gamas.id_gama\r\n\t\t\t\r\n\t\tWHERE autos.estado = 'false' and nombres_comerciales.nombre_comercial ='"+cmbModelo.cmb_Cargable.Text.ToString()+"'  \r\n\t\tGROUP BY gamas.id_gama, gamas.nombre_gama";
            cmbGama.cargar(sqlgama, "nombre_gama", "id_gama");

        }
        protected void cmbMarca_textChanged(object sender, EventArgs e) 
        {
            string sqlnombres = "SELECT DISTINCT nombres_comerciales.nombre_comercial, nombres_comerciales.id_nombrecomercial FROM autos INNER JOIN nombres_comerciales On autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial WHERE autos.estado = 'false' AND nombres_comerciales.id_marca = " + cmbMarca.cmb_Cargable.SelectedValue.ToString();

            cmbModelo.cargar(sqlnombres, "nombre_comercial", "id_nombrecomercial");

            string sqlanio = "SELECT distinct año_fabricacion FROM autos join nombres_comerciales on autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial WHERE autos.estado = 'false' and nombres_comerciales.nombre_comercial='" + cmbModelo.cmb_Cargable.Text.ToString() + "'";
            cmbAño.cargar(sqlanio, "año_fabricacion", "año_fabricacion");


        }
}
}
