using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioEmpleados;
using Trabajo_Practico.Clases.BackEnd.NegocioEncargos;
using Trabajo_Practico.Formularios.Base;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabajo_Practico.Formularios.ABMC.Encargos
{
    public partial class BuscarEncargos : FormBaseConsulta
    {
        private FormBaseABMC formPrincipal;
        public BuscarEncargos(FormBaseABMC form)
        {
            InitializeComponent();
            formPrincipal = form;
            cmbTipoDocumento.cargar("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cambiarNombre("Encargos");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

            try
            {
                NE_Encargos negocioEncargos = new NE_Encargos();
                DataTable tabla = new DataTable();

                if (cmbTipoDocumento.TabIndex == -1 && txtNroDocumento.Equals(""))
                {
                    MessageBox.Show("Porfavor ingrese un campo a buscar", "Mensaje");
                    return;
                }
                else
                {
                    if (cmbTipoDocumento.TabIndex != -1 && txtNroDocumento.Equals(""))
                    {
                        MessageBox.Show("Porfavor ingrese el campo nro. de documento a buscar", "Mensaje");
                    }
                    else
                    {
                        cmbTipoDocumento.Focus();
                        int tipoDocumento = int.Parse(cmbTipoDocumento.cmb_Cargable.SelectedValue.ToString());
                        int nroDocumento = int.Parse(txtNroDocumento.Text);
                        formPrincipal.consultaPrincipal = negocioEncargos.buscarEncargos(tipoDocumento, nroDocumento);

                        tabla = negocioEncargos.buscarEncargo(tipoDocumento, nroDocumento);

                        if (tabla.Rows.Count > 0)
                        {
                            int tipo_doc_cliente = int.Parse(tabla.Rows[0]["nro_encargo"].ToString());
                            int nro_doc_cliente = int.Parse(tabla.Rows[0]["nro_doc_cliente"].ToString());
                            string fecha = tabla.Rows[0]["fecha"].ToString();
                            int nombre_comercial = int.Parse(tabla.Rows[0]["id_nombrecomercial"].ToString());
                            int legajo = int.Parse(tabla.Rows[0]["legajo_empleado"].ToString());
                            int cod_caracteristica = int.Parse(tabla.Rows[0]["cod_caracteristica"].ToString());
                            string prioridad = tabla.Rows[0]["prioridad"].ToString();


                            Trabajo_Practico.Clases.Entidades.Encargos nuevoEncargo = new Clases.Entidades.Encargos(tipo_doc_cliente, nro_doc_cliente, fecha, nombre_comercial, legajo, cod_caracteristica, prioridad);
                            MessageBox.Show("Si se encuentró el registro buscado", "Información");
                            MessageBox.Show(nuevoEncargo.toString(), "Mensaje");
                           
                        }
                        else
                        {
                            MessageBox.Show("No se encontro un Encargo con el tipo documento: " + tipoDocumento + System.Environment.NewLine +
                                        "y Nro. de documento: " + nroDocumento + " ingresado.", "Mensaje");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un problema", "Mensaje");
            }




        }
    }
}
