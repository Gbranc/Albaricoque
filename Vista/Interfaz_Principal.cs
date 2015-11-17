using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;
using Vista.Interfaces_Usuario;
using Vista.Interfaces_Proveedor;
using Vista.Interfaces_MateriaPrima;
using Vista.Interfaz_Menu;


using Vista.Punto_De_Venta;
using Vista.Interfaz_Categorias;
using Vista.Interfaz_Cortes_Venta;


namespace Vista
{
     
    public partial class Interfaz_Principal : Form
    {
        public Interfaz_Principal()
        {

            InitializeComponent();
          

        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

          
            
        }

        private void Interfaz_Principal_Load(object sender, EventArgs e)
        {
            CargarDatos();
            WindowState = FormWindowState.Maximized;
           
        }
        /*
         *  private void CargarDatosMantenerProveedor2()
        {
            Controlador_Proveedor obj = new Controlador_Proveedor();
            List<Proveedor_Modelo> listaProveedor;
            listaProveedor = obj.listarProveedor();
            dgvConsultaProveedores.DataSource = listaProveedor;



        }
         * */
        private void CargarDatos()
        {
            Proveedor_Controlador obj = new Proveedor_Controlador();
            List<Proveedor> listaProveedor;
            listaProveedor = obj.ListarProveedor();
           //dataGridView1.DataSource = listaProveedor;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.MdiParent = this.MdiParent;

            form1.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Usuarios IMU = new Interfaz_Mantenimiento_Usuarios();
            IMU.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Proveedor IMP = new Interfaz_Mantenimiento_Proveedor();
            IMP.Show();
        }

        private void btnMateriaPrima_Click(object sender, EventArgs e)
        {
            Interfaz_MatenimientoMP IMM = new Interfaz_MatenimientoMP();
            IMM.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Menu MM = new Interfaz_Mantenimiento_Menu();
            MM.Show();
        }

        private void btnPuntodeVenta_Click(object sender, EventArgs e)
        {
            Interfaz_Punto_Venta PV = new Interfaz_Punto_Venta();
            PV.Show();


        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Categorias MCS = new Interfaz_Mantenimiento_Categorias();
            MCS.Show();
        }

        private void btnCortesdeVenta_Click(object sender, EventArgs e)
        {
            Cortes_Veta ICV = new Cortes_Veta();
            ICV.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Menu MM = new Interfaz_Mantenimiento_Menu();
            MM.Show();
        }

        private void MateriaPrima_Click(object sender, EventArgs e)
        {
            Interfaz_MatenimientoMP IMM = new Interfaz_MatenimientoMP();
            IMM.Show();
        }

        private void Categorias_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Categorias MCS = new Interfaz_Mantenimiento_Categorias();
            MCS.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Proveedor IMP = new Interfaz_Mantenimiento_Proveedor();
            IMP.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Interfaz_Punto_Venta PV = new Interfaz_Punto_Venta();
            PV.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cortes_Veta ICV = new Cortes_Veta();
            ICV.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Usuarios IMU = new Interfaz_Mantenimiento_Usuarios();
            IMU.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
