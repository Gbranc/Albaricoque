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
    public partial class Interfaz_MatenimientoMP : Form
    {
        
        public Interfaz_MatenimientoMP()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Interfaz_Registrar_Compra RC = new Interfaz_Registrar_Compra();
            RC.Show();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            Interfaz_Registrar_Compra RC = new Interfaz_Registrar_Compra();
            RC.Show();
            this.Close();
        }
        public void CargarCompras() 
        {
           // MateriaPrima entity2 = new MateriaPrima();
           //Proveedor entity3 = new Proveedor();
           //Compras entity = new Compras();
           List<Compras> compras2 = new List<Compras>();
           List<MateriaPrima> mp2 = new List<MateriaPrima>();
           List<Proveedor> pro2 = new List<Proveedor>();

            

            Compras_controlador obj = new Compras_controlador();
            //List<Compras> listaCompras;
            //listaCompras = obj.listarCompras();
            //dgvCompras.DataSource = listaCompras;
           // dgvCompras.DataSource = obj.listarCompras();
         //   obj.listarCompras();

            //dgvCompras.DataSource = obj.listarCompras();
            
        
        
        }


        private void AdjustColumnOrder()
        {
            //dgvCompras.Columns["CustomerID"].Visible = false;
            dgvCompras.Columns["fechaCompra"].DisplayIndex = 1;
            dgvCompras.Columns["nombreProveedor"].DisplayIndex = 7;
            dgvCompras.Columns["nombre"].DisplayIndex = 2;
            dgvCompras.Columns["costo"].DisplayIndex = 5;
            dgvCompras.Columns["cantidad"].DisplayIndex = 3;
            dgvCompras.Columns["caducidad"].DisplayIndex = 6;
            dgvCompras.Columns["unidad"].DisplayIndex = 4;
           // dgvCompras.Columns["Eliminar"].DisplayIndex = 8;
            dgvCompras.Columns["Seleccion"].DisplayIndex = 0;

        }
        //prueba para agregar imagen a boton
     
        //

        private void cargarIDcompra() 
        {

            Compras_controlador obj = new Compras_controlador();

            List<Compras> listarCompraClave;
            listarCompraClave = obj.listarCompraClave(this.txtClaveCompra.Text);
            if (listarCompraClave.Count > 0)
            {
                
                txtIdCompra.Text = listarCompraClave[0].id_compra.ToString();


            }
        
        
        
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
            cbMateriaPrima.DataSource = ListarMateriaPrima;
            cbMateriaPrima.DisplayMember = "nombre";
            cbMateriaPrima.ValueMember = "id_mp";



        }

        private void contador() 
        {

            //this.dgvCompras.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.dgvCompras_DataBindingComplete);
            //this.label18.Text = this.dgvCompras.RowCount.ToString();
            //label18.Text = dgvCompras.RowCount.ToString();
        
        
        
        }
        private void Interfaz_MatenimientoMP_Load(object sender, EventArgs e)
        {
           // cargarIDcompra();

            

            contador();

            ListarProveedor();
            ListarMateriaPrima();

            //this.label18.Text = this.dgvCompras.RowCount.ToString();
            contador();




            CargarCompras();
            listarMateriaPrima();

           // Mitabla = Compras.GetAllProducts;


          
            
           

            //mostrar compras
            SqlConnection miconexion = new SqlConnection("Data Source=PAVLOFF-PC\\SQLEXPRESS14; Initial Catalog=Albaricoque; Integrated Security=Yes");
            miconexion.Open();
            string CadenaSQL = "SELECT  c.claveCompra, c.fechaCompra, m.nombre, c.unidad, c.cantidad, c.Caducidad, c.costo, p.nombreProveedor from tblCompras c INNER JOIN tblMateriaPrima m ON m.id_mp=c.id_mp INNER JOIN tblProveedor p ON c.id_proveedor=p.id_proveedor";
            SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaSQL, miconexion);
            DataSet DS = new DataSet();
            Adaptador.Fill(DS);
            dgvCompras.DataSource = DS.Tables[0];





            //nombrar titulode columnas
         //   dgvCompras.Columns[0].HeaderText = "Modificar";
            dgvCompras.Columns[0].HeaderText = "Seleccion";
            dgvCompras.Columns[1].HeaderText = "Clave de Compra";
            dgvCompras.Columns[2].HeaderText = "Fecha";
            dgvCompras.Columns[4].HeaderText = "Unidad";
            dgvCompras.Columns[6].HeaderText = "Caducidad";
            dgvCompras.Columns[5].HeaderText = "Cantidad";
            dgvCompras.Columns[3].HeaderText = "Nombre";
            dgvCompras.Columns[7].HeaderText = "Costo";
            dgvCompras.Columns[8].HeaderText = "Proveedor";



            
            AdjustColumnOrder();

            ocultarColumnas();
          
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cargarIDcompra();
            //contador();

           // esta this.label18.Text = this.dgvCompras.RowCount.ToString();
            //label18.Text = dgvCompras.RowCount.ToString();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCompras.Rows[e.RowIndex];

                cbMateriaPrima.Text = row.Cells["nombre"].Value.ToString();
                dtpCaducidad.Text = row.Cells["caducidad"].Value.ToString();
                
                cbUnidad.Text = row.Cells["unidad"].Value.ToString();
                txtCantidad.Text = row.Cells["cantidad"].Value.ToString();
                txtCosto.Text = row.Cells["costo"].Value.ToString();
                dtpFechaCompra.Text = row.Cells["fechaCompra"].Value.ToString();
                cbProveedor.Text = row.Cells["nombreProveedor"].Value.ToString();
                txtClaveCompra.Text = row.Cells["claveCompra"].Value.ToString();





            }
        }

        private void EliminarCompra()
        {
            string valor1 = (string)dgvCompras.CurrentRow.Cells["fechaCompra"].Value;
            string valor2 = (string)dgvCompras.CurrentRow.Cells["caducidad"].Value;
            int valor3 = (int)dgvCompras.CurrentRow.Cells["cantidad"].Value;

            int r = 0;
            Compras objEntidad = new Compras();
            Compras_controlador objNegocio = new Compras_controlador();
            objEntidad.fechaCompra = valor1.ToString();
            objEntidad.caducidad = valor2.ToString();
            objEntidad.cantidad = valor1.ToString();
            r = objNegocio.eliminarCompra(objEntidad);


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string valor1 = (string)dgvCompras.CurrentRow.Cells["fechaCompra"].Value;
            string valor2 = (string)dgvCompras.CurrentRow.Cells["caducidad"].Value;
            int valor3 = (int)dgvCompras.CurrentRow.Cells["cantidad"].Value;

            DialogResult dialog = MessageBox.Show("¿Desea Eliminar esta compra?"+valor1+" "+valor2+" "+valor3, "Confirmacion",
            MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                //EliminarCompra();

                int r = 0;
                Compras objEntidad = new Compras();
                Compras_controlador objNegocio = new Compras_controlador();
                objEntidad.fechaCompra = valor1.ToString();
                objEntidad.caducidad = valor2.ToString();
                objEntidad.cantidad = valor3.ToString();
                r = objNegocio.eliminarCompra(objEntidad);


                //mostrar compras
                SqlConnection miconexion = new SqlConnection("Data Source=PAVLOFF-PC\\SQLEXPRESS14; Initial Catalog=Albaricoque; Integrated Security=Yes");
                miconexion.Open();
                string CadenaSQL = "SELECT  c.claveCompra, c.fechaCompra, m.nombre, c.unidad, c.cantidad, c.Caducidad, c.costo, p.nombreProveedor from tblCompras c INNER JOIN tblMateriaPrima m ON m.id_mp=c.id_mp INNER JOIN tblProveedor p ON c.id_proveedor=p.id_proveedor";
                SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaSQL, miconexion);
                DataSet DS = new DataSet();
                Adaptador.Fill(DS);
                dgvCompras.DataSource = DS.Tables[0];





                //Guardar();
                //this.Close();
               // Interfaz_MatenimientoMP MMP = new Interfaz_MatenimientoMP();
                //MMP.Show();


            }
            else if (dialog == DialogResult.Cancel)
            {

                // e.Cancel = true;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            gbModificar.Visible = true;
            btnRegistrarCompra.Enabled = false;
            btnEliminar.Enabled = false;
            btnSalir.Enabled = false;

            //cargarIDcompra();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void listarMateriaPrima() 
        {
            MateriaPrima_Controlador obj = new MateriaPrima_Controlador();
            List<MateriaPrima> listaMateriaPrima;
            listaMateriaPrima = obj.listarMateriaPrima();
            dgvMateriaPrima.DataSource = listaMateriaPrima;
        
        
        
        }
        private void ocultarColumnas() 
        {
            //ocultar columnas
          // dgvMateriaPrima.Columns[0].Visible = false;
          //  dgvMateriaPrima.Columns[4].Visible = false;

            this.dgvMateriaPrima.Columns[1].Visible = false;
           this.dgvMateriaPrima.Columns[6].Visible = false;

        
        
        }
        private void dgvMateriaPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // limitar seleccion de checkbox

            if (e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgvMateriaPrima.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }

            //mandar datos a controles
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMateriaPrima.Rows[e.RowIndex];
                
                txtNombreMP.Text = row.Cells["nombre"].Value.ToString();
                txtIdMp.Text = row.Cells["id_mp"].Value.ToString();

                txtDescripcion.Text = row.Cells["descripcion"].Value.ToString();
                cbUnidadMP.Text = row.Cells["unidad"].Value.ToString();
                txtCantidadMP.Text = row.Cells["cantidad"].Value.ToString();
                





            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnModificarMateriaPrima_Click(object sender, EventArgs e)
        {
            gbMateriaPrima.Enabled = true;
            gbMateriaPrima.Visible = true;

            btnEliminarMP.Enabled = false;
            btnSalir2.Enabled = false;

            txtDescripcion.Enabled = true;
           // cbUnidadMP.Enabled = true;
            txtMerma.Enabled = true;

            label8.Enabled = true;
            label11.Enabled = true;

            btnCancelarModificacion.Enabled = true;
            btnGuardarModificacion.Enabled = true;

            btnEliminarMP.Enabled = false;

            
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            gbMateriaPrima.Visible = false;

            btnEliminarMP.Enabled = true;
            btnSalir2.Enabled = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
             
        }

        private void ModificarCompra() 
        {

            int r = 0;
            Compras objEntidad = new Compras();
            Compras_controlador objNegocio = new Compras_controlador();
            objEntidad.id_compra = txtIdCompra.Text;

            //  objEntidad.id_mp = Convert.ToString(cbMP.SelectedValue);
            objEntidad.id_mp = Convert.ToString(cbMateriaPrima.SelectedValue);
            objEntidad.caducidad= dtpCaducidad.Text;
            objEntidad.unidad= cbUnidad.Text;
            objEntidad.cantidad=  txtCantidad.Text;
            objEntidad.costo = txtCosto.Text;
            objEntidad.fechaCompra = dtpFechaCompra.Text;
            objEntidad.id_proveedor = Convert.ToString(cbProveedor.SelectedValue);
            objEntidad.claveCompra = txtClaveCompra.Text; 
            

            r = objNegocio.modificarCompra(objEntidad);
        
        
        
        
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ModificarCompra();
            MessageBox.Show("Modificacion exitosa");
            //mostrar compras
            SqlConnection miconexion = new SqlConnection("Data Source=PAVLOFF-PC\\SQLEXPRESS14; Initial Catalog=Albaricoque; Integrated Security=Yes");
            miconexion.Open();
            string CadenaSQL = "SELECT  c.claveCompra, c.fechaCompra, m.nombre, c.unidad, c.cantidad, c.Caducidad, c.costo, p.nombreProveedor from tblCompras c INNER JOIN tblMateriaPrima m ON m.id_mp=c.id_mp INNER JOIN tblProveedor p ON c.id_proveedor=p.id_proveedor";
            SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaSQL, miconexion);
            DataSet DS = new DataSet();
            Adaptador.Fill(DS);
            dgvCompras.DataSource = DS.Tables[0];

            gbModificar.Visible = false;

            btnEliminar.Enabled = true;
            btnSalir.Enabled = true;
            btnRegistrarCompra.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

           

           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            SqlConnection miconexion = new SqlConnection("Data Source=PAVLOFF-PC\\SQLEXPRESS14; Initial Catalog=Albaricoque; Integrated Security=Yes");
            miconexion.Open();
            string CadenaSQL = "SELECT  c.claveCompra, c.fechaCompra, m.nombre, c.unidad, c.cantidad, c.Caducidad, c.costo, p.nombreProveedor from tblCompras c INNER JOIN tblMateriaPrima m ON m.id_mp=c.id_mp INNER JOIN tblProveedor p ON c.id_proveedor=p.id_proveedor";
            SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaSQL, miconexion);
            DataSet DS = new DataSet();
            Adaptador.Fill(DS);
            dgvCompras.DataSource = DS.Tables[0];

            dgvCompras.DataSource = DS.Tables[0].DefaultView.RowFilter = ("nombre like '" + txtNombreBuscar.Text + "%'");
            dgvCompras.DataSource = dgvCompras.DataSource = DS.Tables[0].DefaultView;

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dtpFechaCompraBuscar_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection miconexion = new SqlConnection("Data Source=PAVLOFF-PC\\SQLEXPRESS14; Initial Catalog=Albaricoque; Integrated Security=Yes");
            miconexion.Open();
            string CadenaSQL = "SELECT  c.claveCompra, c.fechaCompra, m.nombre, c.unidad, c.cantidad, c.Caducidad, c.costo, p.nombreProveedor from tblCompras c INNER JOIN tblMateriaPrima m ON m.id_mp=c.id_mp INNER JOIN tblProveedor p ON c.id_proveedor=p.id_proveedor";
            SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaSQL, miconexion);
            DataSet DS = new DataSet();
            Adaptador.Fill(DS);
            dgvCompras.DataSource = DS.Tables[0];
            dgvCompras.DataSource = DS.Tables[0].DefaultView.RowFilter = ("fechaCompra like '" + dtpFechaCompraBuscar.Text + "%'");
            dgvCompras.DataSource = dgvCompras.DataSource = DS.Tables[0].DefaultView;
        }

        private void txtProveedorBuscar_TextChanged(object sender, EventArgs e)
        { 

            //
            SqlConnection miconexion = new SqlConnection("Data Source=PAVLOFF-PC\\SQLEXPRESS14; Initial Catalog=Albaricoque; Integrated Security=Yes");
            miconexion.Open();
            string CadenaSQL = "SELECT  c.claveCompra, c.fechaCompra, m.nombre, c.unidad, c.cantidad, c.Caducidad, c.costo, p.nombreProveedor from tblCompras c INNER JOIN tblMateriaPrima m ON m.id_mp=c.id_mp INNER JOIN tblProveedor p ON c.id_proveedor=p.id_proveedor";
            SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaSQL, miconexion);
            DataSet DS = new DataSet();
            Adaptador.Fill(DS);
            dgvCompras.DataSource = DS.Tables[0];
            //
            
            dgvCompras.DataSource = DS.Tables[0].DefaultView.RowFilter = ("nombreProveedor like '" + txtProveedorBuscar.Text + "%'");
            dgvCompras.DataSource = dgvCompras.DataSource = DS.Tables[0].DefaultView;

        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "Materia Prima:")
            {
                txtNombreBuscar.Visible = true;
                dtpFechaCompraBuscar.Visible = false;
                txtProveedorBuscar.Visible = false;
                btnMostrarTodo.Visible = false;
            
            }
            if (cbFiltro.Text == "Fecha:") 
            {
                txtNombreBuscar.Visible = false;
                dtpFechaCompraBuscar.Visible = true;
                txtProveedorBuscar.Visible = false;
                btnMostrarTodo.Visible = true;
                
            
            
            }
            if (cbFiltro.Text == "Proveedor:")
            {
                txtNombreBuscar.Visible = false;
                dtpFechaCompraBuscar.Visible = false;
                txtProveedorBuscar.Visible = true;
                btnMostrarTodo.Visible = false;


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            SqlConnection miconexion = new SqlConnection("Data Source=PAVLOFF-PC\\SQLEXPRESS14; Initial Catalog=Albaricoque; Integrated Security=Yes");
            miconexion.Open();
            string CadenaSQL = "SELECT  c.claveCompra, c.fechaCompra, m.nombre, c.unidad, c.cantidad, c.Caducidad, c.costo, p.nombreProveedor from tblCompras c INNER JOIN tblMateriaPrima m ON m.id_mp=c.id_mp INNER JOIN tblProveedor p ON c.id_proveedor=p.id_proveedor";
            SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaSQL, miconexion);
            DataSet DS = new DataSet();
            Adaptador.Fill(DS);
            dgvCompras.DataSource = DS.Tables[0];

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbModificar.Visible = false;

            btnRegistrarCompra.Enabled = true;
            btnEliminar.Enabled = true;
            btnSalir.Enabled = true;
            txtIdCompra.Text = string.Empty;
        }

        private void gbModificar_Enter(object sender, EventArgs e)
        {
            //cargarIDcompra();
        }

        private void txtClaveCompra_TextChanged(object sender, EventArgs e)
        {
            cargarIDcompra();
        }

        private void dgvCompras_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            //validarseleccion de un solo checkbox
            if (e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgvCompras.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }

            //
            if (e.RowIndex >= 0 )
            {
                DataGridViewRow row = this.dgvCompras.Rows[e.RowIndex];

                cbMateriaPrima.Text = row.Cells["nombre"].Value.ToString();
                dtpCaducidad.Text = row.Cells["caducidad"].Value.ToString();

                cbUnidad.Text = row.Cells["unidad"].Value.ToString();
                txtCantidad.Text = row.Cells["cantidad"].Value.ToString();
                txtCosto.Text = row.Cells["costo"].Value.ToString();
                dtpFechaCompra.Text = row.Cells["fechaCompra"].Value.ToString();
                cbProveedor.Text = row.Cells["nombreProveedor"].Value.ToString();
                txtClaveCompra.Text = row.Cells["claveCompra"].Value.ToString();





            }
        }

        private void calcularMerma()
        {
            int r = 0;
            MateriaPrima objEntidad = new MateriaPrima();
            MateriaPrima_Controlador objNegocio = new MateriaPrima_Controlador();
            objEntidad.id_mp = txtIdMp.Text;
            
            objEntidad.cantidad = txtMerma.Text;


            r = objNegocio.calcularMerma(objEntidad);
            //if (r > 0)
            //CargarDatos();



        }
        private void ModificarMateriaPrima()
        {

            int r = 0;
            MateriaPrima objEntidad = new MateriaPrima();
            MateriaPrima_Controlador objNegocio = new MateriaPrima_Controlador();
            objEntidad.id_mp = txtIdMp.Text;

            
            objEntidad.nombre = txtNombreMP.Text;
            objEntidad.cantidad = txtCantidadMP.Text;
            
            objEntidad.unidad = cbUnidadMP.Text;
            
            objEntidad.descripcion = txtDescripcion.Text;


            r = objNegocio.modificarMateriaPrima(objEntidad);





        }
        private void btnGuardarModificacion_Click(object sender, EventArgs e)
        {

            if (txtMerma.Text == "0")
            {
                ModificarMateriaPrima();
                MessageBox.Show("Modificacion Exitosa");
                gbMateriaPrima.Visible = false;
                btnEliminarMP.Enabled = true;
                btnSalir2.Enabled = true;
                listarMateriaPrima();





            }
            else 
            {
               // calcularMerma();

                ModificarMateriaPrima();
                calcularMerma();
                MessageBox.Show("Modificacion Exitosa");
                gbMateriaPrima.Visible = false;
                btnEliminarMP.Enabled = true;
                btnSalir2.Enabled = true;
                listarMateriaPrima();
            
            }
            
            
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMateriaPrimaBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void eliminarMP() 
        {

            int r = 0;
            MateriaPrima objEntidad = new MateriaPrima();
            MateriaPrima_Controlador objNegocio = new MateriaPrima_Controlador();

            objEntidad.id_mp = txtIdMp.Text;

            r = objNegocio.eliminarMateriaPrima(objEntidad);
        
        
        }

        private void txtMateriaPrimaBuscar_TextChanged(object sender, EventArgs e)
        {
            //
            SqlConnection miconexion = new SqlConnection("Data Source=PAVLOFF-PC\\SQLEXPRESS14; Initial Catalog=Albaricoque; Integrated Security=Yes");
            miconexion.Open();
            string CadenaSQL = "SELECT * from tblMateriaPrima";
            SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaSQL, miconexion);
            DataSet DS = new DataSet();
            Adaptador.Fill(DS);
            dgvCompras.DataSource = DS.Tables[0];
            //

            dgvCompras.DataSource = DS.Tables[0].DefaultView.RowFilter = ("nombre like '" + txtMateriaPrimaBuscar.Text + "%'");
            dgvCompras.DataSource = dgvMateriaPrima.DataSource = DS.Tables[0].DefaultView;
        }

        private void btnEliminarMP_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Confirmacion",
            MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {



                eliminarMP();

                // MessageBox.Show("Registro Exitoso");
                //MessageBox.Show("Modificacion Exitosa");
                MessageBox.Show("Registro Eliminado");
                listarMateriaPrima();
            }
            else { }
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
