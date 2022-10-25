﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases.BackEnd.NegocioEncargos;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.Encargos
{
    public partial class ModificarEncargos : FormBaseModificacion
    {
        public ModificarEncargos(DataGridViewRow row)
        {
            InitializeComponent();
            // se cargan los comboBox
            cmbTipoDocumento.cargar("SELECT * FROM tipo_doc_clientes", "nombre_tipo_doc", "id_doc_cliente");
            cmbNomComercial.cargar("SELECT * FROM nombres_comerciales", "nombre_comercial", "id_nombreComercial");
            cmb_prioridades_now.cargar("SELECT * FROM prioridades", "nombre_prioridad", "id_prioridad");
            cmbTipoDocumento.cmb_Cargable.SelectedValue = bd.SelectNumeros($"SELECT id_doc_cliente FROM tipo_doc_clientes WHERE nombre_tipo_doc LIKE '{row.Cells[0].Value.ToString()}'");
            txtNroDocumento.Text = row.Cells[1].Value.ToString();
            txtFecha.Text = row.Cells[2].Value.ToString().Trim();
            cmbNomComercial.cmb_Cargable.SelectedValue = bd.SelectNumeros($"SELECT id_nombrecomercial FROM nombres_comerciales WHERE nombre_comercial LIKE '{row.Cells[3].Value.ToString()}'");
            txtLegajo.Text = row.Cells[4].Value.ToString();
            txtCodigo.Text = row.Cells[5].Value.ToString();
            cmb_prioridades_now.cmb_Cargable.SelectedValue = bd.SelectNumeros($"SELECT id_prioridad FROM prioridades WHERE nombre_prioridad LIKE '{row.Cells[6].Value.ToString()}'");




        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    cmbTipoDocumento.Focus();
                    // Toma lo ingresado en el formulario
                    int tipo_doc_cliente = int.Parse(cmbTipoDocumento.cmb_Cargable.SelectedValue.ToString());
                    int nro_doc_cliente = int.Parse(txtNroDocumento.Text);
                    string fecha = txtFecha.Text.Trim();
                    int nombre_comercial = int.Parse(cmbNomComercial.cmb_Cargable.SelectedValue.ToString());
                    int legajo = int.Parse(txtLegajo.Text);
                    int cod_caracteristica = int.Parse(txtCodigo.Text);
                    string prioridad = cmb_prioridades_now.cmb_Cargable.SelectedValue.ToString();


                    Trabajo_Practico.Clases.Entidades.Encargos nuevoEncargo = new Clases.Entidades.Encargos(tipo_doc_cliente, nro_doc_cliente, fecha, nombre_comercial, legajo, cod_caracteristica, prioridad);

                    NE_Encargos encargo = new NE_Encargos();
                    encargo.modificarEncargo(nuevoEncargo);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un problema", "Mensaje");
                }
            }
        }        
    }
}