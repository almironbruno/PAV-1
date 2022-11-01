using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico.Clases.BackEnd.NegocioAutos;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Clases.BackEnd.NegocioProceso
{
    class NE_Proceso
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable SelectVehiculoDisponible(int marca, int modelo, int condicion, int gama, int anoFab)
        {
			string consulta = (@"SELECT marcas.nombre,
				nombres_comerciales.nombre_comercial,
				condicion.nombre_condicion,
				gamas.nombre_gama,
				autos.año_fabricacion,
                autos.cod_serie_fabrica,
                autos.monto,
                autos.estado
                

				FROM autos
			
				INNER JOIN nombres_comerciales
				On autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial
				INNER JOIN marcas on nombres_comerciales.id_marca = marcas.id_marca
				INNER JOIN gamas on nombres_comerciales.id_gama = gamas.id_gama
				INNER JOIN condicion on autos.id_condicion = condicion.id_condicion


				WHERE marcas.id_marca = '" + marca+"' and " +
                "nombres_comerciales.id_nombrecomercial = '"+modelo+"' and  " +
                "condicion.id_condicion = '"+condicion+"' and " +
                "gamas.id_gama = '"+gama+"' and " +
                "autos.año_fabricacion = '"+anoFab+"'");


            try
            {
                DataTable tabla = new DataTable();
                tabla = _BD.Ejecutar_Select(consulta);
                return tabla;
            }
            catch (Exception ex)
            {

                throw;
            }

			


        }
        public DataTable Sugerencia()
        {
            string consulta = (@"SELECT marcas.nombre,
				nombres_comerciales.nombre_comercial,
				condicion.nombre_condicion,
				gamas.nombre_gama,
                autos.año_fabricacion,
			    autos.monto
                
                

				FROM autos
			
				INNER JOIN nombres_comerciales
				On autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial
				INNER JOIN marcas on nombres_comerciales.id_marca = marcas.id_marca
				INNER JOIN gamas on nombres_comerciales.id_gama = gamas.id_gama
				INNER JOIN condicion on autos.id_condicion = condicion.id_condicion


				WHERE autos.estado = 'false'");


            try
            {
                DataTable tabla = new DataTable();
                tabla = _BD.Ejecutar_Select(consulta);
                return tabla;
            }
            catch (Exception ex)
            {

                throw;
            }




        }



        public bool Venta(Venta vta,List<string> ListaSerie)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlTransaction objTransaccion = null; 

            SqlConnection cn = new SqlConnection(cadenaConexion);


            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "INSERT INTO ventas(tipo_doc_cliente,nro_doc_cliente,fecha,legajo_empleado) values (@tipo_doc, @nro_doc, @fecha,@legajo)";

                cmd.Parameters.Clear();

                
                cmd.Parameters.AddWithValue("@tipo_doc", vta.tipo_doc);
                cmd.Parameters.AddWithValue("@nro_doc", vta.num_dni);
                cmd.Parameters.AddWithValue("@fecha", vta.fecha);
                cmd.Parameters.AddWithValue("@legajo", vta.legajo);



                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                
                //select IDENT_CURRENT('condicion') +1


                cn.Open();
                objTransaccion = cn.BeginTransaction("Venta"); //NUEVO

                //Se tiene que asignar luego de que se hizo el beggein transaccion
                cmd.Transaction = objTransaccion; 


                cmd.Connection = cn;
                //Devuelve valor numerico casteando a Int
                cmd.ExecuteNonQuery();



                foreach (var codSerie in ListaSerie)
                {
                    BE_Acceso_Datos bd = new BE_Acceso_Datos();
                    DataTable tabla = new DataTable();
                    tabla = bd.Ejecutar_Select("SELECT monto FROM autos WHERE autos.cod_serie_fabrica like '" + codSerie + "'");



                    string consultaAutoPorFactura = "INSERT INTO detalle_ventas (nro_factura,cod_serie_fabrica, monto) values (@nro_factura,@cod_serie, @monto)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nro_factura", vta.nro_factura);
                    cmd.Parameters.AddWithValue("@monto", tabla.Rows[0]["monto"].ToString());
                    cmd.Parameters.AddWithValue("@cod_serie", codSerie);

                    NE_Autos nE_a = new NE_Autos();
                    nE_a.AutoVendido(codSerie);



                    cmd.CommandText = consultaAutoPorFactura;

                    cmd.ExecuteNonQuery();
                }

                objTransaccion.Commit();

                return true;

            }
            catch (Exception ex)
            {
                objTransaccion.Rollback();
                return false;

            }
            finally
            {
                cn.Close();
            }

        }




    }
    
}
