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

namespace Vista.Interfaces_Usuario
{
    public partial class Interfaz_Eliminar_Usuario : Form
    {
        public Interfaz_Eliminar_Usuario()
        {
            InitializeComponent();
        }

        private void ListarUsuarios()
        {
            Usuarios_controlador obj = new Usuarios_controlador();
            List<Usuarios> ListarUsuarios;
            ListarUsuarios = obj.listarUsuario();
            cbNombreBuscar.DataSource = ListarUsuarios;
            cbNombreBuscar.DisplayMember = "id_usuario";
            
            cbNombreBuscar.ValueMember = "id_usuario";


        }

        private void Interfaz_Eliminar_Usuario_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        //metodo eliminar usuarios
        private void EliminarRegistroUsuario()
        {
            int r = 0;
            Usuarios objEntidad = new Usuarios();
            Usuarios_controlador objNegocio = new Usuarios_controlador();
            objEntidad.id_usuario = cbNombreBuscar.Text;             
            r = objNegocio.EliminarUsuario(objEntidad);
          

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistroUsuario();
            this.Close();
            Interfaz_Mantenimiento_Usuarios IMU = new Interfaz_Mantenimiento_Usuarios();
            IMU.Show();
            MessageBox.Show("El registro se ha eliminado exitosamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz_Mantenimiento_Usuarios IMU = new Interfaz_Mantenimiento_Usuarios();
            IMU.Show();
        }
    }
}
