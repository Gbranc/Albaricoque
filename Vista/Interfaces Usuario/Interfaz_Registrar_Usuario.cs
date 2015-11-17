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

namespace Vista.Interfaces_Usuario
{
    public partial class Interfaz_Registrar_Usuario : Form
    {
        public Interfaz_Registrar_Usuario()
        {
            InitializeComponent();
        }
        //Metodo registrar
        private void registrarUsuario()
        {
            int cont = 0;
            int id = cont+11;
            int r = 0;
            Usuarios objEntidad = new Usuarios();
            Usuarios_controlador objNegocio = new Usuarios_controlador();
            objEntidad.id_usuario = id.ToString();
            //objEntidad.id_usuario = txtIdUsuario.Text;
            objEntidad.nombre = txtNombre.Text;
            objEntidad.direccion = txtDireccion.Text;
            objEntidad.telefono = txtTelefono.Text;
            objEntidad.edad = txtEdad.Text;           
            objEntidad.tipo_usuario = cbTipoUsuario.Text;          
            objEntidad.contraseña = txtContraseña.Text;
            objEntidad.salario = txtSalario.Text;
            r = objNegocio.registrarUsuario(objEntidad);


        }
        
       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Usuarios IM = new Interfaz_Mantenimiento_Usuarios();
            

            
            registrarUsuario();
            IM.Show();
            
            this.Close();
            MessageBox.Show("Registro Exitoso");
        }

        private void Interfaz_Registrar_Usuario_Load(object sender, EventArgs e)
        {
            int x = 0;
            for(x=0; x<=1; x++){}
            int cont = 0;
            int id = cont + 11;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz_Mantenimiento_Usuarios IMU = new Interfaz_Mantenimiento_Usuarios();
            IMU.Show();
        }

        private void lblIdUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistrarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblDireccionUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
