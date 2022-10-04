using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Trabajo_Practico.Clases.BackEnd


{
    public class BE_Acceso_Datos
    {
        //AL definir los objetos en la zona de declaracion de la clase, pueden ser accedidos por toda la programacion posterior
        string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        

        //Conexion a la BD
        private void conectar()
        {
           
            cn.ConnectionString = cadenaConexion;
            cn.Open();
            
            cmd.Connection = cn;
            //Definimos que el cmd trabaja con un texto
            cmd.CommandType = System.Data.CommandType.Text;

        }

        //Desconexion de la BD
        private void desconectar()
        {
            cn.Close();
        }

        // Select de tabla
        public DataTable Ejecutar_Select (string sql)
        {
            conectar();
            //Comando a ejecutar, que viene de sql 
            cmd.CommandText = sql;
            
            //Definir datatable

            DataTable tabla = new DataTable();

            //Cargar en tabla el comando consultado
            try
            {
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {

                MessageBox.Show("Error en la base de datos con la consulta: " +
                     sql + " el error es: " + e.Message);

                desconectar();
                return tabla;

            }                //Comando de Lectura
            

            //Desconectar de la bd
            desconectar();

            //Devolver tabla
            return tabla;
        
        

        } 

      
        //Sirve para buscar strings de FK y devolver su equivalencia de PK, recib string y devuelve pk.
        public int SelectNumeros(string sqlBuscar)
        {
            int numero = 0;
            conectar();
            
            cmd.CommandText = sqlBuscar;
            numero = (int)cmd.ExecuteScalar();
            desconectar();
            if(numero > 0)
            {
                return numero;
            }
            else
            {
                return 0;
            }
            
        }

        
        
        


        public void Insertar(string SqlInsertar)
        {
            conectar();
            int flag = 0;
            cmd.CommandText = SqlInsertar;
            //Comando del tipo "NO CONSULTA" Insersion
            flag = cmd.ExecuteNonQuery();
            if (flag == 1)
            {
                MessageBox.Show("Registro Exitoso");
            }
            else
            {
                MessageBox.Show("El Elemento ya se encontraba registrado.");
            }
            desconectar();


        }
        public void Eliminar(string sqlEliminar) 


        {
            conectar();
            int flag = 0;
            cmd.CommandText = sqlEliminar;
            flag = cmd.ExecuteNonQuery();
            if (flag == 1)
            {
                MessageBox.Show("Eliminacion Exitosamente.");    
            }
            else
            {
                MessageBox.Show("Eliminacion Errona a falta del registro solicitado");
            }
            desconectar();
        }

        public void modificar(string sqlModificar)
        {
            conectar();
            int flag = 0;
            cmd.CommandText = sqlModificar;
            flag = cmd.ExecuteNonQuery();
            if (flag == 1)
            {
                MessageBox.Show("Modificacion Exitosamente.");
            }
            else
            {
                MessageBox.Show("Modificacion Errona");
            }
            desconectar();
        }
        public void ejecutar(string sql)
        {
            // Intenta ejecutar la operacion
            //try {

                conectar();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                desconectar();
                MessageBox.Show("Se ha realizado con exito la operacion!", "Mensaje");
            //}
            // En caso de que falle
            //catch(Exception e) 
            //{
              //  MessageBox.Show("No se pudo realizar la operacion \n " +
                //    "Motivo: "+ e.Message.ToString());
            
           // }

        }
       


        
    }

   


}
