using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioEncargos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Trabajo_Practico.Formularios.ABMC.ABMC_Encargos.Forms
{
    public partial class BajaEncargos : Campos_Encargos
    {
        private int tipo_doc;
        private int nro_doc;
        private string fechaEncargo;
        private int nomComercialEncargo;
        private int nomEmpleadoEncargo;
        private int idTipoCaracteristica;
        private int prioridadEncargo;

        public BajaEncargos(DataGridViewRow row)
        {
            InitializeComponent();
            // Desactiva todos los campos            
            cmbTipoDocumento.Enabled = false;
            txtNroDocumento.Enabled = false;
            txtFecha.Enabled = false;
            cmbNomComercial.Enabled = false;
            cmbEmpleado.Enabled = false;
            cmbTipoCaracteristica.Enabled = false;
            cmbPrioridad.Enabled = false;
            btn_LimpiarCampos.Hide();

            // Toma la info de la fila selecionada 
            int tipoDocumento = bd.SelectNumeros($"SELECT id_doc_cliente FROM tipo_doc_clientes WHERE nombre_tipo_doc LIKE '{row.Cells[0].Value.ToString()}'");
            int nroDocumento = int.Parse(row.Cells[1].Value.ToString());
            string fecha = row.Cells[2].Value.ToString();
            int nombreComercial = bd.SelectNumeros($"SELECT id_nombrecomercial FROM nombres_comerciales WHERE nombre_comercial LIKE '{row.Cells[3].Value.ToString()}'");
            int nombreEmpleado = bd.SelectNumeros($"SELECT legajo_empleado FROM empleados WHERE nombre LIKE '{row.Cells[4].Value.ToString()}'");
            int tipoCaracteristica = bd.SelectNumeros($"SELECT id_caracteristica FROM tipo_caracteristica WHERE nombre_tipo LIKE '{row.Cells[5].Value.ToString()}'");
            int prioridad = bd.SelectNumeros($"SELECT id_prioridad FROM prioridades WHERE nombre_prioridad LIKE '{row.Cells[6].Value.ToString()}'");

            Trabajo_Practico.Clases.Entidades.Encargos encargo = new Trabajo_Practico.Clases.Entidades.Encargos(tipoDocumento, nroDocumento, fecha, nombreComercial, nombreEmpleado, tipoCaracteristica, prioridad);
            cargarCampos(encargo);
            /*
             
            //tomo la PK para borrar
            tipo_doc = tipoDoc.ToString();
            nro_doc = nroDoc.ToString();
             */

            // Guardamos los PK para luego ser borrados
            tipo_doc = tipoDocumento;
            nro_doc = nroDocumento;
            fechaEncargo = fecha;
            nomComercialEncargo = nombreComercial;
            nomEmpleadoEncargo = nombreEmpleado;
            idTipoCaracteristica = tipoCaracteristica;
            prioridadEncargo = prioridad;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {            

            DialogResult resultado = MessageBox.Show("¿Seguro que desea borrar este encargo ?", "Eliminar encargo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(resultado == DialogResult.Yes)
            {
                NE_Encargos encargoBorrar = new NE_Encargos();
                encargoBorrar.BorrarEncargo(tipo_doc, nro_doc, fechaEncargo, nomComercialEncargo, nomEmpleadoEncargo,idTipoCaracteristica, prioridadEncargo);                
                this.Close();
            }            
            
        }
    }
}
