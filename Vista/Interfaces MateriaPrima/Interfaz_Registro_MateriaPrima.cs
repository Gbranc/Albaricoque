using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;

namespace Vista.Interfaces_MateriaPrima
{
    public partial class Interfaz_Registro_MateriaPrima : Form
    {
        public Interfaz_Registro_MateriaPrima()
        {
            InitializeComponent();
        }
        private void registrarMateriaPrima()
        {
            int r = 0;
            MateriaPrima objEntidad = new MateriaPrima();
            MateriaPrima_Controlador objNegocio = new MateriaPrima_Controlador();
            objEntidad.id_mp = txtIdMp.Text;
            objEntidad.nombre = txtNombre.Text;

            objEntidad.cantidad = txtCantidad.Text;
            objEntidad.unidad = cbUnidad.Text;
          //  objEntidad.costo = txtCosto.Text;
            //objEntidad.fechaCompra = dtpFechaCompra.Text;
            //objEntidad.fechaCaducidad = dtpFechaCaducidad.Text;
            //objEntidad.id_proveedor = Convert.ToInt32(cbProveedores.SelectedValue());
            // esta es // objEntidad.id_proveedor = Convert.ToString(cbProveedores.SelectedValue);
            //cmd.Parameters.AddWithValue("@id_proveedor", Convert.ToInt32(cbProveedores.SelectedValue));  

            r = objNegocio.registrarMateriaPrima(objEntidad);


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registrarMateriaPrima();
        }
        private void ListarProveedor()
        {
            

            Proveedor_Controlador obj = new Proveedor_Controlador();
            List<Proveedor> ListarProveedor;
          

            ListarProveedor = obj.ListarProveedor();
            cbProveedores.DataSource = ListarProveedor;
           
            cbProveedores.DisplayMember = "nombre";
           // cbProveedores.DisplayMember = "id_proveedor";
            
           
            cbProveedores.ValueMember = "id_proveedor";


        }
        private void Interfaz_Registro_MateriaPrima_Load(object sender, EventArgs e)
        {
            ListarProveedor();

        }

        private void cbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
