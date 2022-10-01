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
using Trabajo_Practico.Clases.BackEnd.NegocioClientes;
using Trabajo_Practico.Formularios.ABMC.ABMC_Empleados;
using Trabajo_Practico.Formularios.ABMC.ABMC_Clientes.Forms;

namespace Trabajo_Practico.Formularios.ABMC.Clientes
{
    public partial class ABMC_Clientes : FormBaseABMC
    {
        public ABMC_Clientes()
        {
            consultaPrincipal = @"SELECT T.nombre_tipo_doc AS 'Tipo Documento',
                                C.nro_doc_cliente AS 'Numero',
                                C.nombre as 'Nombre',
                                C.apellido as 'Apellido',
                                C.fecha_nacimiento AS 'Fecha Nacimiento',
                                C.calle AS 'Calle',
                                C.nro_calle AS 'Numero Calle',
                                B.nombre_barrio as 'Barrio' 
                                    FROM clientes C JOIN tipo_doc_clientes T
                                            ON C.tipo_doc_cliente=T.id_doc_cliente
                                    JOIN barrios B on C.id_barrio = B.id_barrios";
            InitializeComponent();
            
            // cambia los nombres de la ventana a cliente --Eliminar comentario despues--
            cambiarNombre("Clientes");

            
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dataGridViewModificada1.forme = new InfoClientes();
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaClientes ventanaAlta = new AltaClientes();
            ventanaAlta.Show();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            //string pkParaBorrar2 = dataGridViewModificada1.FilaSeleccionada().Cells["nro_doc_cliente"].Value.ToString();
            //string pkParaBorrar1 = dataGridViewModificada1.FilaSeleccionada().Cells["tipo_doc_cliente"].Value.ToString();
            //string registro = "Registro: Codigo de Serie del Vehiculo: " + System.Environment.NewLine + "Patente del Vehiculo: " + ".";


            //DialogResult dialogResult = MessageBox.Show(registro, "Desea eliminar el registro?", MessageBoxButtons.YesNo);

            //if (dialogResult == DialogResult.Yes)
            //{
            //    NE_Clientes borrarCliente = new NE_Clientes();
            //    borrarCliente.BorrarCliente(pkParaBorrar1, pkParaBorrar2);

            //}
            //else
            //{
            //    Nada ya que no se elimina, al oprimir no se cierra el txtbox
            //    }

            BajaClientes ventana = new BajaClientes(dataGridViewModificada1.FilaSeleccionada());
            ventana.Show();
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            //string tipoDoc = dataGridViewModificada1.FilaSeleccionada().Cells["tipo_doc_cliente"].Value.ToString().Trim();
            //int nroDoc = int.Parse(dataGridViewModificada1.FilaSeleccionada().Cells["nro_doc_cliente"].Value.ToString().Trim());
            //string nombre = dataGridViewModificada1.FilaSeleccionada().Cells["nombre"].Value.ToString().Trim();
            //string apellido = dataGridViewModificada1.FilaSeleccionada().Cells["apellido"].Value.ToString().Trim();
            //string fechaNac = dataGridViewModificada1.FilaSeleccionada().Cells["fecha_nacimiento"].Value.ToString();
            //int barrio = int.Parse(dataGridViewModificada1.FilaSeleccionada().Cells["id_barrio"].Value.ToString().Trim());
            //string calle = dataGridViewModificada1.FilaSeleccionada().Cells["calle"].Value.ToString().Trim();
            //int nroCalle = int.Parse(dataGridViewModificada1.FilaSeleccionada().Cells["nro_calle"].Value.ToString().Trim());
            //Cambiar
            //string regis = "Registro: Codigo de Serie del Vehiculo: " + System.Environment.NewLine + "Patente del Vehiculo: " + ".";

            //Trabajo_Practico.Clases.Entidades.Clientes cliente = new Trabajo_Practico.Clases.Entidades.Clientes(tipoDoc, nroDoc, nombre, apellido, fechaNac, calle, nroCalle, barrio);
            //DialogResult dialogResult = MessageBox.Show(regis, "Desea Modificar el registro?", MessageBoxButtons.YesNo);

            //if (dialogResult == DialogResult.Yes)
            //{
               ModificacionCliente ventanaMod = new ModificacionCliente(dataGridViewModificada1.FilaSeleccionada());
                ventanaMod.Show();

            //}
            //else
            //{
                // Nada ya que no se elimina, al oprimir no se cierra el txtbox
            //}
        }

        private void ABMC_Clientes_Activated(object sender, EventArgs e)
        {
            dataGridViewModificada1.forme = new InfoClientes();
        }
    }
}
