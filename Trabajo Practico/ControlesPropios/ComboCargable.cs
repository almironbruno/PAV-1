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

namespace Trabajo_Practico.ControlesPropios
{
    public partial class ComboCargable : UserControl
    {
        public ComboCargable()
        {
            InitializeComponent();
        }
        public void cargar(string sql, string nombreColumna, string pk)
        {
            //Combo viejo
            //Se carga el combo con la tabla y la columna que se le asigna
            BE_Acceso_Datos bd = new BE_Acceso_Datos();
            DataTable tablaPrincipal =bd.Ejecutar_Select(sql);

            //Ahora se le pasa al combo la consulta sql, de esta forma es mas reutilizable, adicional se le pasa la pk 
            // de la tabla con la cual se lo relaciona, y la columna de la cual se desea extraer los datos.
            cmb_Cargable.ValueMember = pk;
            cmb_Cargable.DisplayMember = nombreColumna;
            cmb_Cargable.DataSource = tablaPrincipal;
        
        }
        

        private void lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Cargable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
