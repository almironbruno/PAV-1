using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico.Clases;
using Trabajo_Practico.Formularios.ABMC;
using Trabajo_Practico.Formularios.ABMC.Barrios;

using Trabajo_Practico.Formularios.ABMC.Marcas;
using Trabajo_Practico.Formularios.ABMC.Telefonos;
using Trabajo_Practico.Formularios.ABMC.Clientes;
using Trabajo_Practico.Formularios.ABMC.ABMC_Encargos;
using Trabajo_Practico.Formularios.ABMC.ABMC_Localidades;
using Trabajo_Practico.Clases.Entidades;
using Trabajo_Practico.Formularios.Proceso;
using Trabajo_Practico.Clases.BackEnd;
using Trabajo_Practico.Formularios.Reportes;

using Trabajo_Practico.Formularios.Reportes.AutosXCliente;
using Trabajo_Practico.Formularios.Reportes.VentasXCliente;

namespace Trabajo_Practico.Formularios {

public partial class PrincipalForm : Form
{
    private Form formLogin;
    private string legajo;

    //Seteo que reciba al usuario que se conectó como parametro
    public PrincipalForm()
    {
        InitializeComponent();

        WindowState = FormWindowState.Maximized;
        
    }

    private void PrincipalForm_Load(object sender, EventArgs e)
    {
        this.Show();
        ///Abre el login
        LoginForm login = new LoginForm();
        login.ShowDialog();
        legajo = login.buscarLeg();
        lbl_legajo.Text ="Legajo: "+ legajo;
        dgrMisVentas.ShowCellToolTips = true;
        CargarVentas(legajo);
        
        
        ;


    }

    private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ABMC_Empleados ventanaEmpleados = new  ABMC_Empleados();
        ventanaEmpleados.ShowDialog();
    }

    private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
    {

        ABMC_Clientes ventanaClientes = new ABMC_Clientes();
        ventanaClientes.ShowDialog();

    }

    private void autosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ABMC_Autos ventanaAutos = new ABMC_Autos();
        ventanaAutos.ShowDialog();
    }

    private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ABMC_Marcas ventanaMarcas = new ABMC_Marcas();
        ventanaMarcas.ShowDialog();

    }

    

    private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Barrios ventanaBarrios = new Barrios();
        ventanaBarrios.ShowDialog();

        

        
    }

    public void CargarVentas(string legajo)

    {
        
        string consulta = (@"SELECT nro_factura, tipo_doc_cliente, nro_doc_cliente, fecha FROM ventas WHERE legajo_empleado = '"+legajo+"'");
        try
        {
            DataTable tabla = new DataTable();
            BE_Acceso_Datos bd = new BE_Acceso_Datos();
            tabla = bd.Ejecutar_Select(consulta);
            if (tabla.Rows.Count > 0)
            {
                dgrMisVentas.DataSource = tabla;
            }
            
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error en la consulta de Ventas Realizadas");

        }
        for (int i = 0; i < dgrMisVentas.Rows.Count; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                dgrMisVentas.Rows[i].Cells[j].ToolTipText = "Doble Click para mostrar el detalle";
            }
          
            
        }
    }

    private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
        
    }
    private void telefonosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        TelefonosPrincipal ventanaTelefono = new TelefonosPrincipal();
        ventanaTelefono.ShowDialog();
	}
    private void nombreComercialToolStripMenuItem_Click(object sender, EventArgs e)
    {
        
    }

    private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // Llammos a la clase ABMC_Localidades para poder realizar las distintas peticiones.
        ABMC_Localidades ventanaLocalidad = new ABMC_Localidades();
        ventanaLocalidad.ShowDialog();
        
    }

    private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void encargosToolStripMenuItem_Click(object sender, EventArgs e)
    {
       
    }

   

    private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void PrincipalForm_Shown(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Maximized;
    }

    private void encargosToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        ABMC_Encargos ventanaEncargo = new ABMC_Encargos();
        ventanaEncargo.ShowDialog();
    }

    private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //Vacia para que el form arranque
        DataGridView dtg = new DataGridView();
        FormVenta ventanaVenta = new FormVenta(dtg,legajo);
        ventanaVenta.ShowDialog();
    }

    private void btnRefreshVentas_Click(object sender, EventArgs e)
    {
        CargarVentas(legajo);
    }

    private void dgrMisDetalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dgrMisVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        
        var fila = dgrMisVentas.CurrentRow;
        if (fila != null)
        {
            int nroFactura = int.Parse(fila.Cells[0].Value.ToString());
            string consulta = "SELECT * FROM detalle_ventas WHERE nro_factura = '" + nroFactura +"'";
            BE_Acceso_Datos db = new BE_Acceso_Datos();
            DataTable dt = new DataTable();
            dgrMisDetalles.DataSource = db.Ejecutar_Select(consulta); ;

        }
        else
        {
            MessageBox.Show("Fila Vacia!");
        }
        




    }

    private void PrincipalForm_Activated(object sender, EventArgs e)
    {
        //carga las grillas cuando se graba 
        CargarVentas(legajo);
    }

    private void clientesToolStripMenuItem3_Click(object sender, EventArgs e)
    {
        VentasXClientes ventana = new VentasXClientes();
        ventana.Show();
    }

    private void autosToolStripMenuItem3_Click(object sender, EventArgs e)
    {
         AutosXCliente ventana = new AutosXCliente();
         ventana.Show();
    }
    
   }
}

