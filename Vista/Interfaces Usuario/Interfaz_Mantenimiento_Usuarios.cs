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
    public partial class Interfaz_Mantenimiento_Usuarios : Form
    {
        public Interfaz_Mantenimiento_Usuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Interfaz_Registrar_Usuario IRU = new Interfaz_Registrar_Usuario();

            IRU.MdiParent = this.MdiParent;

            IRU.Show();
            this.Close();
        }

        private void ListarUsuarios()
        {
            Usuarios_controlador obj = new Usuarios_controlador();
            List<Usuarios> ListarUsuarios;
            ListarUsuarios = obj.listarUsuario();
            dgvUsuarios.DataSource = ListarUsuarios;


        }

        private void Interfaz_Mantenimiento_Usuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Interfaz_Modificar_Usuario IM = new Interfaz_Modificar_Usuario();
            IM.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Interfaz_Eliminar_Usuario IEU = new Interfaz_Eliminar_Usuario();
            IEU.Show();
            this.Close();
        }
    }
}
