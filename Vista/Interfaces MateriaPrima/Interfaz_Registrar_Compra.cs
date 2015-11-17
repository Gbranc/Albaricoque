using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Interfaces_MateriaPrima
{
    public partial class Interfaz_Registrar_Compra : Form
    {
        public Interfaz_Registrar_Compra()
        {
            InitializeComponent();
        }

        private void ListarProveedor()
        {
            Proveedor_Controlador obj = new Proveedor_Controlador();
            List<Proveedor> ListarProveedor;
            ListarProveedor = obj.ListarProveedor();
            cbProveedor.DataSource = ListarProveedor;
            cbProveedor.DisplayMember = "nombre";
            cbProveedor.ValueMember = "id_proveedor";


        }
        private void ListarMateriaPrima()
        {
            MateriaPrima_Controlador obj = new MateriaPrima_Controlador();
            List<MateriaPrima> ListarMateriaPrima;
            ListarMateriaPrima = obj.listarMateriaPrima();
            cbMP.DataSource = ListarMateriaPrima;
            cbMP.DisplayMember = "nombre";
            cbMP.ValueMember = "id_mp";
            


        }
        private void CargarMP() 
        {
           MateriaPrima_Controlador obj = new MateriaPrima_Controlador();

            List<MateriaPrima> listarMPNombre;
            listarMPNombre = obj.listarMPnombre(this.cbMP.Text);
            if (listarMPNombre.Count > 0)
            {

                registrarCompras1();
                calcularCantidad();

            }
            else 
            {
                registrarMateriaPrima();
                registrarCompras2();
                
            
            
            
            
            }

        
        
        
        
        }

        private void Interfaz_Registrar_Compra_Load(object sender, EventArgs e)
        {
            ListarProveedor();
            ListarMateriaPrima();
            /*
            //string conexion = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection miconexion = new SqlConnection("Data Source=PAVLOFF-PC\\SQLEXPRESS14; Initial Catalog=albaricoque; Integrated Security=Yes");
            miconexion.Open();
            string CadenaSQL = "SELECT MAX(id_mp)+1 as Contador FROM tblMateriaPrima";
            SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaSQL, miconexion);
            DataSet DS = new DataSet();
            Adaptador.Fill(DS);
            txtIdMp.Text = CadenaSQL = "SELECT MAX(id_mp)+1 as Contador FROM tblMateriaPrima";
            //textbox1.Text = dt.Rows(0)("Contador")
           * */
            contador();


        }
        private void registrarCompras1()
        {
            int r = 0;
            Compras objEntidad = new Compras();
            Compras_controlador objNegocio = new Compras_controlador();
            objEntidad.id_compra = txtIdCompra.Text;
            objEntidad.fechaCompra = dtpFechaCompra.Text;
            //objEntidad.id_mp = cbMP.Text;
            objEntidad.id_mp = Convert.ToString(cbMP.SelectedValue);
            //objEntidad.id_proveedor = Convert.ToString(cbProveedores.SelectedValue);

            objEntidad.caducidad = dtpCaducidad.Text;
            //objEntidad.id_proveedor = cbProveedor.Text;
            objEntidad.id_proveedor = Convert.ToString(cbProveedor.SelectedValue);
            objEntidad.unidad = cbUnidad.Text;
            objEntidad.cantidad = txtCantidad.Text;
            
            objEntidad.costo = txtCosto.Text;
            objEntidad.claveCompra = txtClaveCompra.Text;
          

            r = objNegocio.registrarCompra(objEntidad);


        }
        private void registrarCompras2()
        {
            int r = 0;
            Compras objEntidad = new Compras();
            Compras_controlador objNegocio = new Compras_controlador();
            objEntidad.id_compra = txtIdCompra.Text;
            objEntidad.fechaCompra = dtpFechaCompra.Text;
            objEntidad.id_mp = txtIdMp.Text;


            objEntidad.caducidad = dtpCaducidad.Text;
            //objEntidad.id_proveedor = cbProveedor.Text;
            objEntidad.id_proveedor = Convert.ToString(cbProveedor.SelectedValue);
            objEntidad.unidad = cbUnidad.Text;
            objEntidad.cantidad = txtCantidad.Text;

            objEntidad.costo = txtCosto.Text;
            objEntidad.claveCompra = txtClaveCompra.Text;



            r = objNegocio.registrarCompra(objEntidad);


        }

        private void contador() {
            
            MateriaPrima_Controlador obj = new MateriaPrima_Controlador();
            List<MateriaPrima> listarContador;
            //List<MateriaPrima> listarContador;
           // listarContador = obj.listarContador();
            //txtIdMp.Text = listarContador[0].id_mp.ToString();

            listarContador = obj.listarContador();
            if (listarContador.Count > 0)
            {
                txtIdMp.Text = listarContador[0].Contador.ToString();
                


                //CargarDatos();
            }
            
           // dgvProveedores.DataSource = listaProveedor;
            /*
             * 
             * /*
             * Proveedor_Controlador obj = new Proveedor_Controlador();
            List<Proveedor> listaProveedor;
            listaProveedor = obj.listarProveedor();
            dgvProveedores.DataSource = listaProveedor;

             * /
             * */





        }

      

        private void registrarMateriaPrima()
        {
            int r = 0;
            MateriaPrima objEntidad = new MateriaPrima();
            MateriaPrima_Controlador objNegocio = new MateriaPrima_Controlador();
            objEntidad.id_mp = txtIdMp.Text;
            objEntidad.nombre = cbMP.Text;

            objEntidad.cantidad = txtCantidad.Text;
            objEntidad.unidad = cbUnidad.Text;
            objEntidad.descripcion = txtDescripcion.Text;
            //  objEntidad.costo = txtCosto.Text;
            //objEntidad.fechaCompra = dtpFechaCompra.Text;
            //objEntidad.fechaCaducidad = dtpFechaCaducidad.Text;
            //objEntidad.id_proveedor = Convert.ToInt32(cbProveedores.SelectedValue());
            // esta es // objEntidad.id_proveedor = Convert.ToString(cbProveedores.SelectedValue);
            //cmd.Parameters.AddWithValue("@id_proveedor", Convert.ToInt32(cbProveedores.SelectedValue));  

            r = objNegocio.registrarMateriaPrima(objEntidad);


        }

        private void Guardar() 
        { 
                // registrarCompras1();
                // calcularCantidad();
            
            
            
                registrarMateriaPrima();
                registrarCompras2();
                
            
            
           





        }

        private void calcularCantidad() 
        {
            int r = 0;
            MateriaPrima objEntidad = new MateriaPrima();
            MateriaPrima_Controlador objNegocio = new MateriaPrima_Controlador();
            objEntidad.id_mp = cbMP.ValueMember;
            objEntidad.id_mp = Convert.ToString(cbMP.SelectedValue);
            objEntidad.cantidad = txtCantidad.Text;
            

            r = objNegocio.calcularCantidad(objEntidad);
            //if (r > 0)
                //CargarDatos();
        
        
        
        
        
        
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Datos Ingresados correctamente, ¿Desea Continuar?","Confirmacion",
             MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
               // Guardar();
                CargarMP();
                this.Close();
                Interfaz_MatenimientoMP MMP = new Interfaz_MatenimientoMP();
                MMP.Show();

             
            }
            else if (dialog == DialogResult.Cancel)
            {

                // e.Cancel = true;


            }

            
            //registrarMateriaPrima();
            //registrarCompras();

           

        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        { /*
            if(sender == rbNo)
            {
                cbMateriaPrima.Visible = false;
                cbMateriaPrima.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                label12.Enabled = true;
                label10.Enabled = true;
                label9.Enabled = true;

                txtIdMp.Enabled = false;
                txtNombre.Enabled = true;
                cbUnidad.Enabled=true;
                txtCantidad.Enabled = true;
                txtCosto.Enabled = true;
                txtDescripcion.Enabled = true;
                cbProveedor.Enabled = true;
                dtpCaducidad.Enabled = true;

                label3.Visible = true;
                label5.Visible = true;
                txtDescripcion.Visible = true;
                txtIdMp.Visible = true;
            }
           * */
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        { /*
            if (sender == rbSi)
            {
                cbMateriaPrima.Visible = true;
                cbMateriaPrima.Enabled = true;
                label3.Visible = false;
                label4.Enabled = true;
                label5.Visible = false;
                label6.Enabled = true;
                label7.Enabled = true;
                label12.Enabled = true;
                label10.Enabled = true;
                label9.Enabled = true;

                txtIdMp.Visible = false;
                txtNombre.Enabled = true;
                cbUnidad.Enabled = true;
                txtCantidad.Enabled = true;
                txtCosto.Enabled = true;
                txtDescripcion.Visible = false;
                cbProveedor.Enabled = true;
                dtpCaducidad.Enabled = true;
            }
           * */
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Interfaz_MatenimientoMP MMP = new Interfaz_MatenimientoMP();
            MMP.Show();

        }

        private void txtIdMp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
