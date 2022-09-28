﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.ABMC.Marcas;
using Trabajo_Practico.Clases.BackEnd.NegocioMarcas;
using Trabajo_Practico.Clases.Entidades;

namespace Trabajo_Practico.Formularios
{
    public partial class Marcas : FormBaseABMC
    {
        public Marcas()
        {
            consultaPrincipal = "SELECT * FROM marcas";
            InitializeComponent();
            cambiarNombre("Marcas");
            
        }

        private void Marcas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            AltaMarcas vtnAltaMarcas = new AltaMarcas();
            vtnAltaMarcas.Show();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            string nombre = dataGridViewModificada1.FilaSeleccionada().Cells[1].Value.ToString();

            string registro = "Nombre de la Marca Automotriz: " + nombre + ".";


            DialogResult dialogResult = MessageBox.Show(registro, "Desea eliminar el Registro?", MessageBoxButtons.YesNo);
            
            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    NE_Marcas borrarMarca = new NE_Marcas();
                    borrarMarca.BorrarMarca(nombre);

                    cargargrilla();
                }
                else
                {
                    // Nada ya que no se elimina, al oprimir no se cierra el txtbox
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede borrar la marca ya que esta vinculada a un modelo de vehiculo");
                
            }
            
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            string nombreMarca = dataGridViewModificada1.FilaSeleccionada().Cells["nombre"].Value.ToString().Trim();
            string regis = "Marca Automotriz: " + nombreMarca;
            DialogResult dialogResult = MessageBox.Show(regis, "Desea Modificar el registro?", MessageBoxButtons.YesNo);

            Marca marca = new Marca(nombreMarca);

            if (dialogResult == DialogResult.Yes)
            {
                ModificarMarca vtnModificar = new ModificarMarca(marca);
                vtnModificar.Show();

            }
            else
            {
                // Nada ya que no se elimina, al oprimir no se cierra el txtbox
            }
           

        }
    }
}
