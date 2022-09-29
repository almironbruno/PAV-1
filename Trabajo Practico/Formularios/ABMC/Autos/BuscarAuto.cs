using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioAutos;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Autos
{
    public partial class BuscarAuto : FormBaseConsulta
    {
        public BuscarAuto()
        {
            InitializeComponent();
            cambiarNombre("Vehiculo");
        }

        private void BuscarAuto_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)

        {

            NE_Autos negoAuto = new NE_Autos();

            DataTable tabla = new DataTable();

            if (txtCodBuscar.Text.Equals("") && txtPatenteBuscar.Text.Equals(""))
            {
                MessageBox.Show("Complete al menos un campo para efectuar la busqueda");
            }
            else
            {
                if(txtCodBuscar.Text.Equals("") == false && txtPatenteBuscar.Text.Equals(""))
                {
                    string codigoPk = txtCodBuscar.Text;
                    tabla = negoAuto.BuscarAutoCodSerie(codigoPk);
                    //Si en la tabla hay un registro, es que hay un auto, entonces se muestra 
                    if (tabla.Rows.Count > 0)
                    {

                        string codS = tabla.Rows[0]["cod_serie_Fabrica"].ToString();
                        int id_comer = int.Parse(tabla.Rows[0]["id_nombrecomercial"].ToString());
                        string añoFab = tabla.Rows[0]["año_fabricacion"].ToString();
                        int id_cond = int.Parse(tabla.Rows[0]["id_condicion"].ToString());
                        string chasis = tabla.Rows[0]["nro_chasis"].ToString();
                        string motor = tabla.Rows[0]["nro_motor"].ToString();
                        string patente = tabla.Rows[0]["patente"].ToString();

                        //Se almacena todo en el objeto auto y se usa la funcion del objeto para mostrarlo
                        Vehiculos auto = new Vehiculos(codS, id_comer, añoFab, id_cond, chasis, motor, patente);

                        string salida = auto.mostrar(auto);

                        MessageBox.Show(salida);

                    }
                    else
                    {
                        MessageBox.Show("Auto con codigo de serie:" +codigoPk+ "no encotrado");
                    }
                }
                else
                {
                    if (txtPatenteBuscar.Text.Equals("") == false && txtCodBuscar.Text.Equals(""))
                    {
                        string patenteBusc = txtPatenteBuscar.Text;
                        tabla = negoAuto.BuscarAutoPatente(patenteBusc);
                        //Si en la tabla hay un registro, es que hay un auto, entonces se muestra 
                        if (tabla.Rows.Count > 0)
                        {

                            string codS = tabla.Rows[0]["cod_serie_Fabrica"].ToString();
                            int id_comer = int.Parse(tabla.Rows[0]["id_nombrecomercial"].ToString());
                            string añoFab = tabla.Rows[0]["año_fabricacion"].ToString();
                            int id_cond = int.Parse(tabla.Rows[0]["id_condicion"].ToString());
                            string chasis = tabla.Rows[0]["nro_chasis"].ToString();
                            string motor = tabla.Rows[0]["nro_motor"].ToString();
                            string patente = tabla.Rows[0]["patente"].ToString();

                            //Se almacena todo en el objeto auto y se usa la funcion del objeto para mostrarlo
                            Vehiculos auto = new Vehiculos(codS, id_comer, añoFab, id_cond, chasis, motor, patente);

                            string salida = auto.mostrar(auto);

                            MessageBox.Show(salida);

                        }
                        else
                        {
                            MessageBox.Show("Auto con Patente:" + patenteBusc + "no encotrado");
                        }



                    }
                    else
                    {
                        if(txtPatenteBuscar.Text.Equals("") == false && txtCodBuscar.Text.Equals("") == false)
                        {
                            string idBuscar = txtCodBuscar.Text;
                            string patenteBusc = txtPatenteBuscar.Text;
                            tabla = negoAuto.BuscarDobleCriterio(patenteBusc, idBuscar);
                            //Si en la tabla hay un registro, es que hay un auto, entonces se muestra 
                            if (tabla.Rows.Count > 0)
                            {

                                string codS = tabla.Rows[0]["cod_serie_Fabrica"].ToString();
                                int id_comer = int.Parse(tabla.Rows[0]["id_nombrecomercial"].ToString());
                                string añoFab = tabla.Rows[0]["año_fabricacion"].ToString();
                                int id_cond = int.Parse(tabla.Rows[0]["id_condicion"].ToString());
                                string chasis = tabla.Rows[0]["nro_chasis"].ToString();
                                string motor = tabla.Rows[0]["nro_motor"].ToString();
                                string patente = tabla.Rows[0]["patente"].ToString();

                                //Se almacena todo en el objeto auto y se usa la funcion del objeto para mostrarlo
                                Vehiculos auto = new Vehiculos(codS, id_comer, añoFab, id_cond, chasis, motor, patente);

                                string salida = auto.mostrar(auto);

                                MessageBox.Show(salida);

                            }
                            else
                            {
                                MessageBox.Show("No se encontro un Vehiculo de patente: "+ patenteBusc + System.Environment.NewLine +
                                    "y codigo de serie: "+ idBuscar);
                            }
                        }
                    }

                   
                }
            }



           
           
            
        }
    }
}
