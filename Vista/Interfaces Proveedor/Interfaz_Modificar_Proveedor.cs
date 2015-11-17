using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Interfaces_Proveedor
{
    public partial class Interfaz_Modificar_Proveedor : Form
    {
        public Interfaz_Modificar_Proveedor()
        {
            InitializeComponent();
        }
        private void ListarProveedor()
        {
            Proveedor_Controlador obj = new Proveedor_Controlador();
            List<Proveedor> ListarProveedor;
            ListarProveedor = obj.ListarProveedor();
            cbNombreBuscar.DataSource = ListarProveedor;
            cbNombreBuscar.DisplayMember = "nombre";
            cbNombreBuscar.ValueMember = "id_proveedor";


        }
        private void Interfaz_Modificar_Proveedor_Load(object sender, EventArgs e)
        {
            ListarProveedor();

            cbNombreBuscar.Text = string.Empty;

            txtIdProveedor.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
           

        }
        public void CargarDatosProveedor()
        {
            Proveedor_Controlador obj = new Proveedor_Controlador();

            List<Proveedor> listarProveedorNombre;
            listarProveedorNombre = obj.buscarProveedorNombre(this.cbNombreBuscar.Text);
            if (listarProveedorNombre.Count > 0)
            {
                txtIdProveedor.Text = listarProveedorNombre[0].id_proveedor.ToString();
                txtNombre.Text = listarProveedorNombre[0].nombreProveedor.ToString();
                txtDireccion.Text = listarProveedorNombre[0].direccion.ToString();
                txtTelefono.Text = listarProveedorNombre[0].telefono.ToString();
                

            }


        }
        private void cbNombreBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosProveedor();
        }

        public void Limpiar() 
        {
            cbNombreBuscar.Text = string.Empty;

            txtIdProveedor.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            
        
        
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ModificarProveedor()
        {
            int r = 0;
            Proveedor objEntidad = new Proveedor();
            Proveedor_Controlador objNegocio = new Proveedor_Controlador();
            objEntidad.id_proveedor = txtIdProveedor.Text;
            objEntidad.nombreProveedor = txtNombre.Text;
            
            objEntidad.direccion = txtDireccion.Text;
            objEntidad.telefono = txtTelefono.Text;
            
            r = objNegocio.ModificarProveedor(objEntidad);
          
        } 

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ModificarProveedor();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz_Mantenimiento_Proveedor IMP = new Interfaz_Mantenimiento_Proveedor();
            IMP.Show();
        }
    }
}
