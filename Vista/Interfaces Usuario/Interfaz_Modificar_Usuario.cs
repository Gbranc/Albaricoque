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
    public partial class Interfaz_Modificar_Usuario : Form
    {
        public Interfaz_Modificar_Usuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz_Mantenimiento_Usuarios IMU = new Interfaz_Mantenimiento_Usuarios();
            IMU.Show();
        }
        //cargar combo box
        private void ListarUsuarios()
        {
            Usuarios_controlador obj = new Usuarios_controlador();
            List<Usuarios> ListarUsuarios;
            ListarUsuarios = obj.listarUsuario();
            cbNombreBuscar.DataSource = ListarUsuarios;
            cbNombreBuscar.DisplayMember = "nombre";
            cbNombreBuscar.ValueMember = "id_usuario";


        }
        public void CargarDatosUsuario()
        {
            Usuarios_controlador obj = new Usuarios_controlador();
            
            List<Usuarios> ListarUsuarioNombre;
            ListarUsuarioNombre = obj.listarUsuarioNombre(this.cbNombreBuscar.Text);
            if (ListarUsuarioNombre.Count > 0)
            {
                txtIdUsuario.Text = ListarUsuarioNombre[0].id_usuario.ToString();
                txtNombre.Text = ListarUsuarioNombre[0].nombre.ToString();
                txtDireccion.Text = ListarUsuarioNombre[0].direccion.ToString();
                txtTelefono.Text = ListarUsuarioNombre[0].telefono.ToString();
                txtEdad.Text = ListarUsuarioNombre[0].edad.ToString();
                cbTipoUsuario.Text = ListarUsuarioNombre[0].tipo_usuario.ToString();
                txtContraseña.Text = ListarUsuarioNombre[0].contraseña.ToString();
                txtSalario.Text = ListarUsuarioNombre[0].salario.ToString();
                
            }         


        }
        private void Interfaz_Modificar_Usuario_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
            cbNombreBuscar.Text = string.Empty;

            txtIdUsuario.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEdad.Text = string.Empty;
            cbTipoUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtSalario.Text = string.Empty;



        }
        public void Limpiar()
        {
             
                txtIdUsuario.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtEdad.Text = string.Empty;
                cbTipoUsuario.Text = string.Empty;
                txtContraseña.Text = string.Empty;
                txtSalario.Text = string.Empty;



            
        
        }

        private void cbNombreBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosUsuario();
           
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void ModificarUsuario()
        {
            int r = 0;
            Usuarios objEntidad = new Usuarios();
            Usuarios_controlador objNegocio = new Usuarios_controlador();
            objEntidad.id_usuario = txtIdUsuario.Text;
            objEntidad.nombre = txtNombre.Text;
            objEntidad.edad = txtEdad.Text;
            objEntidad.direccion = txtDireccion.Text;
            objEntidad.telefono = txtTelefono.Text;           
            objEntidad.tipo_usuario = cbTipoUsuario.Text;
            objEntidad.salario = txtSalario.Text;
            objEntidad.contraseña = txtContraseña.Text;
            r = objNegocio.ModificarUsuario(objEntidad);
            //if (r > 0)
               // CargarConsulta();
            //CargarDatos();
        } 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ModificarUsuario();
            Interfaz_Mantenimiento_Usuarios IMU = new Interfaz_Mantenimiento_Usuarios();
            IMU.Show();
            MessageBox.Show("Datos modificados exitosamente");
            this.Close();
        }
    }
}
