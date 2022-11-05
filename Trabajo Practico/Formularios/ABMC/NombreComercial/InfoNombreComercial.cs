using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Formularios.Base;

namespace Trabajo_Practico.Formularios.ABMC.NombreComercial
{
    public partial class InfoNombreComercial : FormBaseBotones
    {
        public InfoNombreComercial()
        {
            InitializeComponent();
            txtNombreComercial.Enabled = false;
            txtIDNomCom.Enabled = false;
            cmbMarca.cmb_Cargable.Enabled = false;
            cmbGama.cmb_Cargable.Enabled = false;
            btn_LimpiarCampos.Hide();
            btn_Aceptar.Hide();


            cambiarFormaConsulta();
        }

        public override void cargarInfo(DataGridViewRow row)
        {
            string sqlMarca = (@"SELECT * FROM marcas");
            string sqlGama = (@"SELECT * FROM gamas");
            cmbMarca.cargar(sqlMarca, "nombre", "id_marca");
            cmbGama.cargar(sqlGama, "nombre_gama", "id_gama");

            cmbMarca.cmb_Cargable.Text = row.Cells[2].Value.ToString();
            cmbGama.cmb_Cargable.Text = row.Cells[3].Value.ToString();
            txtNombreComercial.Text = row.Cells[1].Value.ToString();
            txtIDNomCom.Text = row.Cells[0].Value.ToString();
            
        }

        private void InfoNombreComercial_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
