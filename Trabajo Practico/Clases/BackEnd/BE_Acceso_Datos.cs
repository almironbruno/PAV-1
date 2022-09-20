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

        public DataTable Ejecutar_Select (string sql)
        {
            conectar();
            //Comando a ejecutar, que viene de sql 
            cmd.CommandText = sql;
            
            //Definir datatable

            DataTable tabla = new DataTable();

            //Cargar en tabla el comando consultado
                           //Comando de Lectura
            tabla.Load(cmd.ExecuteReader());

            //Desconectar de la bd
            desconectar();

            //Devolver tabla
            return tabla;
        
        
        } 


        

        public void Insertar(string SqlInsertar)
        {
            conectar();

            cmd.CommandText = SqlInsertar;
            //Comando del tipo "NO CONSULTA" Insersion
            cmd.ExecuteNonQuery();

            desconectar();


        }
        public void Eliminar(string sqlEliminar) 
        {
            int flag = 0;
            cmd.CommandText = sqlEliminar;
            flag = cmd.ExecuteNonQuery();
            if (flag == 1)
            {
                MessageBox.Show("Eliminado Exitosamente. Actualice para Visualizar los cambios");    
            }
            else
            {
                MessageBox.Show("Vehiculo Inexistente para ser Eliminado.");
            }
        }
        public void modificar(string sqlModificar)
        {
            cmd.CommandText = sqlModificar;
            cmd.ExecuteNonQuery();
        }


        
    }

   


}
