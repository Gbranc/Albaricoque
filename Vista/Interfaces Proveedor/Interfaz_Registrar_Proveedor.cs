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
    public partial class Interfaz_Registrar_Proveedor : Form
    {
        public Interfaz_Registrar_Proveedor()
        {
            InitializeComponent();
        }
        //registrar
        private void registrarProveedor()
        {
            int r = 0;
            Proveedor objEntidad = new Proveedor();
            Proveedor_Controlador objNegocio = new Proveedor_Controlador();
            objEntidad.id_proveedor = txtIdProveedor.Text;
            objEntidad.nombreProveedor = txtNombre.Text;

            objEntidad.direccion = txtDireccion.Text;
            objEntidad.telefono = txtTelefono.Text;

            r = objNegocio.registrarProveedor(objEntidad);


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            registrarProveedor();
            MessageBox.Show("Registro exitoso");
            this.Close();
            Interfaz_Mantenimiento_Proveedor IMP = new Interfaz_Mantenimiento_Proveedor();
            IMP.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz_Mantenimiento_Proveedor IMP = new Interfaz_Mantenimiento_Proveedor();
            IMP.Show();
        }
    }
}
