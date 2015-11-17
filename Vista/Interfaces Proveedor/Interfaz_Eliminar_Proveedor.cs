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
    public partial class Interfaz_Eliminar_Proveedor : Form
    {
        public Interfaz_Eliminar_Proveedor()
        {
            InitializeComponent();
        }
        private void ListarProveedor()
        {
            Proveedor_Controlador obj = new Proveedor_Controlador();
            List<Proveedor> ListarProveedor;
            ListarProveedor = obj.ListarProveedor();
            cbNombreBuscar.DataSource = ListarProveedor;
            cbNombreBuscar.DisplayMember = "nombreProveedor";
            cbNombreBuscar.ValueMember = "id_proveedor";


        }



        private void Interfaz_Eliminar_Proveedor_Load(object sender, EventArgs e)
        {
            ListarProveedor();
        }
        private void EliminarProveedor()
        {
            int r = 0;
            Proveedor objEntidad = new Proveedor();
            Proveedor_Controlador objNegocio = new Proveedor_Controlador();
            objEntidad.nombreProveedor = cbNombreBuscar.Text;
            r = objNegocio.EliminarProveedor(objEntidad);


        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProveedor();
            MessageBox.Show("El registro se ha eliminado correctamente");
            this.Close();

            Interfaz_Mantenimiento_Proveedor IMP = new Interfaz_Mantenimiento_Proveedor();
            IMP.Show();
        }
    }
}
