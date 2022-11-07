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

namespace Trabajo_Practico.Formularios.ABMC.Clientes
{
    public partial class Clientes : FormBaseABMC
    {
        public Clientes()
        {
            consultaPrincipal = "SELECT * FROM clientes";
            InitializeComponent();
            
            // cambia los nombres de la ventana a cliente --Eliminar comentario despues--
            cambiarNombre("Clientes");
            
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaClientes ventanaAlta = new AltaClientes();
            ventanaAlta.Show();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
                string pkParaBorrar2 = dataGridViewModificada1.FilaSeleccionada().Cells["nro_doc_cliente"].Value.ToString();
                string pkParaBorrar1 = dataGridViewModificada1.FilaSeleccionada().Cells["tipo_doc_cliente"].Value.ToString();
                string registro = "Registro: Codigo de Serie del Vehiculo: " + System.Environment.NewLine + "Patente del Vehiculo: " + ".";


                DialogResult dialogResult = MessageBox.Show(registro, "Desea eliminar el registro?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    NE_Clientes borrarCliente = new NE_Clientes();
                    borrarCliente.BorrarCliente(pkParaBorrar1, pkParaBorrar2);
                    
                }
                else
                {
                    // Nada ya que no se elimina, al oprimir no se cierra el txtbox
                }
            }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
