using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioMarcas;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Marcas
{
    public partial class BuscarMarca : FormBaseConsulta
    {
        public BuscarMarca()
        {
            InitializeComponent();
            cambiarNombre("Marca");
        }

        private void BuscarMarca_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            
            
            NE_Marcas negoMarca = new NE_Marcas();

            DataTable tabla = new DataTable();



            if (txtMarcBuscar.Text.Equals("") && txtIdMarca.Text.Equals(""))
            {
                MessageBox.Show("Complete al menos un campo para hacer la busqueda de una marca.");
            }
            else
            {
                if (txtMarcBuscar.Text.Equals("") && txtIdMarca.Text.Equals("") == false)
                {
                    string idString = txtIdMarca.Text.TrimStart(new char[] { '0' });
                    int idNum = int.Parse(idString);

                    if (idNum > 0)
                    {
                        tabla = negoMarca.BuscarMarcaId(idNum);

                        if (tabla.Rows.Count > 0)
                        {
                            string nombre = tabla.Rows[0]["nombre"].ToString();
                            string id = tabla.Rows[0]["id_marca"].ToString();

                            MessageBox.Show("Marca encontrada:" + System.Environment.NewLine +
                                "ID de marca: " + id + " | Nombre de la marca: " + nombre);

                        }
                        else
                        {
                            MessageBox.Show("No se encontro la Marca de Id: " + txtIdMarca.Text);
                        }

                    }
               
                }
                 
                else
                {
                    if (txtMarcBuscar.Text.Equals("") == false && txtIdMarca.Text.Equals(""))
                    {
                        tabla = negoMarca.BuscarMarcaNombre(txtMarcBuscar.Text);
                        
                        if (tabla.Rows.Count > 0)
                        {
                            string nombre = tabla.Rows[0]["nombre"].ToString();
                            string id = tabla.Rows[0]["id_marca"].ToString();

                            MessageBox.Show("Marca encontrada:" + System.Environment.NewLine +
                                "ID de marca: " + id + " | Nombre de la marca: " + nombre);

                        }
                        else
                        {
                            MessageBox.Show("No se encontro la Marca de nombre: " + txtMarcBuscar.Text);
                        }
                    }
                }
               
                if(txtMarcBuscar.Text.Equals("") == false && txtIdMarca.Text.Equals("") == false)
                {
                    string idString = txtIdMarca.Text.TrimStart(new char[] { '0' });
                    int idNum = int.Parse(idString);


                    if (idNum > 0)
                    {
                        tabla = negoMarca.BuscarDobleCriterio(txtMarcBuscar.Text, idNum);

                        if (tabla.Rows.Count > 0)
                        {
                            string nombre = tabla.Rows[0]["nombre"].ToString();
                            string id = tabla.Rows[0]["id_marca"].ToString();

                            MessageBox.Show("Marca encontrada:" + System.Environment.NewLine +
                                "ID de marca: " + id + " | Nombre de la marca: " + nombre);

                        }
                        else
                        {
                            MessageBox.Show("No se encontro una marca con Id: " + idNum + System.Environment.NewLine +
                                " y nombre: " + txtMarcBuscar.Text);
                        }

                    }

                }

            }

           


            

            


        }
    }
}
