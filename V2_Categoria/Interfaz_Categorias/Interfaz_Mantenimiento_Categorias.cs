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
using System.Data.SqlClient;

namespace Vista.Interfaz_Categorias
{
    public partial class Interfaz_Mantenimiento_Categorias : Form
    {
        int valCel = -1;
        Boolean banCel = true;
        Boolean banCelCambio = true;
        public Interfaz_Mantenimiento_Categorias()
        {
            InitializeComponent();
            lblDescripcionM.Visible=false;
            lblNombreM.Visible = false;
            lblDescripcionR.Visible = false;
            lblNombreR.Visible = false;
           
        }
        private void LiscarCategorias() 
        {

            Categorias obj = new Categorias();
            List<Categorias> ListaCategorias;
            ListaCategorias = obj.ListarCategorias();
            dgvCategorias.DataSource = ListaCategorias;
            
        
        
        
        }
        private void OcultarColumna() 
        {
            dgvCategorias.Columns[1].Visible = false;
        
        
        
        
        }
        private void Interfaz_Mantenimiento_Categorias_Load(object sender, EventArgs e)
        {

            Interfaz_Mantenimiento_Categorias.ActiveForm.Size = new System.Drawing.Size(700, 400);
            //Interfaz_Mantenimiento_Categorias.ActiveForm.Resize = false;
            this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LiscarCategorias();
            txtDescripcionR.MaxLength = 40;
           
            txtNombreR.MaxLength = 20;
            txtDescripcionM.MaxLength = 40;

            txtNombreM.MaxLength = 20;

            CargarCabezeras();
            OcultarColumna();
        }
        private void CargarCabezeras()
        {
       
            dgvCategorias.Columns[2].HeaderText = "NOMBRE";
            dgvCategorias.Columns[2].Width =180;
            dgvCategorias.Columns[2].ReadOnly = true;
            dgvCategorias.Columns[2].Resizable =
    DataGridViewTriState.False;
            dgvCategorias.Columns[3].Resizable =
    DataGridViewTriState.False;

            dgvCategorias.Columns[3].ReadOnly = true;
            dgvCategorias.Columns[3].Width = 345;
            dgvCategorias.Columns[3].HeaderText = "DESCRIPCION";
   
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // limitar seleccion de checkbox
           // Console.Write("Inicia ........................\n");
           // Console.Write(valCel+"\n");

            //Console.Write(e.RowIndex + "\n");
            if (e.ColumnIndex == 0)
            {
               
                foreach (DataGridViewRow row in dgvCategorias.Rows)
                {
                   // Convert.ToString(row.Cells[0].Value) = "Select";
                    //if (Convert.ToBoolean(row.Cells[0].Value == "Select"))
                    //{
                    //    btnEliminar.Enabled = true;
                    //    MessageBox.Show("holis");
                    //}
                    if (Convert.ToBoolean(row.Cells[0].Value) == true  )
                    {

                        if (banCelCambio==true)
                        {
                            row.Cells[0].Value = false;
                            btnEliminar.Enabled = true;
                            valCel = -1;
                         
                           
                        }

                    }
                }
                if (valCel == e.RowIndex ) {
                    valCel = -1;
                    banCel = false;
                    btnEliminar.Enabled = false;
                    banCelCambio = false;
                    
                }
                if (valCel == -1 )
                {
                    if ( banCelCambio == true)
                    {
                        btnEliminar.Enabled = true;
                        DataGridViewRow row = this.dgvCategorias.Rows[e.RowIndex];

                        txtNombreCategoria.Text = row.Cells["nombre"].Value.ToString();
                        txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
                        txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
                        valCel = e.RowIndex;
                        valCel = e.RowIndex;
                    }
                 
                    banCelCambio = true;
                }

      
            //    if (valCel == e.RowIndex)
            //    {
            //        btnEliminar.Enabled = false;
            //        valCel = -1;
            //        Console.Write("entre ...Valor repetido\n" + valCel);
            //        banCel = false;


            //    }
            //    if (e.RowIndex >= 0 && banCel==true)
            //    {
            //        btnEliminar.Enabled = true;

                   
                  
            //        if (valCel == -1)
            //        {
            //            DataGridViewRow row = this.dgvCategorias.Rows[e.RowIndex];

            //            txtNombreCategoria.Text = row.Cells["nombre"].Value.ToString();
            //            txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
            //            txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
            //            valCel = e.RowIndex;
            //            Console.Write("entre ...siguele\n" + valCel);
            //        }


            //    }
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Categorias.ActiveForm.Size = new System.Drawing.Size(980, 400);

            gbModificar.Visible = true;
            btnRegistrar.Enabled = false;
            btnEliminar.Enabled = false;
            btnSalir.Enabled = false;

            gbRegistrar.Visible = false;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Categorias.ActiveForm.Size = new System.Drawing.Size(680, 400);

            gbModificar.Visible = false;
            gbRegistrar.Visible = false;

            btnModificar.Enabled = true;
            btnSalir.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Categorias.ActiveForm.Size = new System.Drawing.Size(680, 400);

            gbModificar.Visible = false;
            btnRegistrar.Enabled = true;
            btnEliminar.Enabled = true;
            btnSalir.Enabled = true;
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            Interfaz_Mantenimiento_Categorias.ActiveForm.Size = new System.Drawing.Size(980, 400);
            btnSalir.Enabled = false;
            btnEliminar.Enabled = false;

            btnModificar.Enabled = false;
            gbModificar.Visible = false;
            gbRegistrar.Visible = true;
        }
        private Boolean ValidarRegistro() {

             Categorias_Controlador obj = new Categorias_Controlador();
             String Registro_buscar = txtNombreR.Text;

             return obj.ValidarRegistro1(Registro_buscar);
        }
        private void RegistrarCategoria() 
        {

            int r = 0;
            Categorias objEntidad = new Categorias();
            Categorias_Controlador objNegocio = new Categorias_Controlador();
            objEntidad.id_categoria = txtId.Text;
            objEntidad.nombre = txtNombreR.Text;

            objEntidad.descripcion = txtDescripcionR.Text;
      

            r = objNegocio.RegistrarCategoria(objEntidad);
        
        
        
        
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            lblDescripcionR.Visible = false;
            lblNombreR.Visible = false;
            int numerocont = 0;
            if (txtNombreR.Text == "" || txtDescripcionR.Text == "")
            {

                if (txtNombreR.Text == "")
                {
                    lblNombreR.Visible = true;
                    numerocont = numerocont + 1;
                }
                if (txtDescripcionR.Text == "")
                {
                    lblDescripcionR.Visible = true;
                    numerocont = numerocont + 1;
                }
                if (numerocont == 1)
                {
                    MessageBox.Show("Campo faltante");
                }
                if (numerocont > 1)
                {
                    MessageBox.Show("Campos faltantes");
                }


            }
            else
            {
               
                if (ValidarRegistro() == true) {
                    MessageBox.Show("Registro Repetido");
                    txtDescripcionR.Text = "";
                    txtNombreR.Text = "";
                }
                if (ValidarRegistro() == false)
                {
                    RegistrarCategoria();
                    MessageBox.Show("Registro exitoso");
                    LiscarCategorias();
                    gbRegistrar.Visible = true;
                    txtDescripcionR.Text = "";
                    txtNombreR.Text = "";
                    btnModificar.Enabled = false;
                    btnSalir.Enabled = false;
                    btnModificar.Enabled = false; ;
                    btnEliminar.Enabled = false;
                    numerocont = 0;
                    lblNombreR.Visible = false;
                    lblDescripcionR.Visible = false;
                }
            }
        }

        private void ModificarCategoria() 
        
        {
            int r = 0;
            Categorias objEntidad = new Categorias();
            Categorias_Controlador objNegocio = new Categorias_Controlador();
            objEntidad.id_categoria = txtIdCategoria.Text;
            objEntidad.nombre = txtNombreCategoria.Text;
            objEntidad.descripcion = txtDescripcionM.Text;

            //  objEntidad.id_mp = Convert.ToString(cbMP.SelectedValue);
            


            r = objNegocio.ModificarCategorias(objEntidad);
        
        
        
        }
        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            lblDescripcionM.Visible = false;
            lblNombreM.Visible = false;
            int numerocont= 0;
            if (txtNombreM.Text == "" || txtDescripcionR.Text == "")
            {

                if (txtNombreM.Text == "")
                {
                    lblNombreM.Visible = true;
                    numerocont = numerocont + 1;
                }
                if (txtDescripcionM.Text == "")
                {
                    lblDescripcionM.Visible = true;
                    numerocont = numerocont + 1;
                }
                if (numerocont == 1)
                {
                    MessageBox.Show("Campo faltante");
                }
                if (numerocont > 1)
                {
                    MessageBox.Show("Campos faltantes");
                }


            }
            else
            {
                ModificarCategoria();
                MessageBox.Show("Modificacion exitosa");

                LiscarCategorias();
                gbModificar.Visible = false;
                numerocont = 0;
                lblNombreM.Visible = false;
                lblDescripcionM.Visible = false;
            }
          

        }
        //public void MostrarCategoria()
        //{
        //    Categorias_Controlador obj = new Categorias_Controlador();
        //    List<Categorias> ListaCategorias;
            
        //    if (txtFiltroCategoria.Text.CompareTo("")==0)
        //    {
        //        LiscarCategorias();
        //        Console.Write("Holis toda la ista");

        //    }
        //    else
        //    {
        //        ListaCategorias = obj.buscarCategoriaNombre(this.txtFiltroCategoria.Text);
        //        dgvCategorias.DataSource = ListaCategorias;
        //        Console.Write("Holis especifico");


               

        //        // dgvProveedores.DataSource = listaProveedor;
        //        //dgvCategorias.DataSource = ListaCategorias;
        //    }
        //}
        //private void txtFiltroCategoria_TextChanged(object sender, EventArgs e)
        //{

            //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            //{
            //    //MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}
            //else
            //{

            //}
            
    //        SqlConnection miconexion = new SqlConnection("Data Source=GIBRAN\\APS; Initial Catalog=Albaricoque; Integrated Security=Yes");
    //        miconexion.Open();
    //        string CadenaSQL = "SELECT * from tblCategoria";
    //        SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaSQL, miconexion);
    //        DataSet DS = new DataSet();
    //        Adaptador.Fill(DS);
    //        dgvCategorias.DataSource = DS.Tables[0];
    //        //
    //        dgvCategorias.Columns[1].Visible = false;
    //        dgvCategorias.Columns[2].HeaderText = "NOMBRE";
    //        dgvCategorias.Columns[2].Width = 180;
    //        dgvCategorias.Columns[2].ReadOnly = true;
    //        dgvCategorias.Columns[2].Resizable =
    //DataGridViewTriState.False;
    //        dgvCategorias.Columns[3].Resizable =
    //DataGridViewTriState.False;

    //        dgvCategorias.Columns[3].ReadOnly = true;
    //        dgvCategorias.Columns[3].Width = 345;
    //        dgvCategorias.Columns[3].HeaderText = "DESCRIPCION";
   


    //        dgvCategorias.DataSource = DS.Tables[0].DefaultView.RowFilter = ("nombre like '" + txtFiltroCategoria.Text + "%'");
    //        dgvCategorias.DataSource = dgvCategorias.DataSource = DS.Tables[0].DefaultView;

        //}
        private void EliminarCategoria() 
        {


            int r = 0;
            Categorias objEntidad = new Categorias();
            Categorias objNegocio = new Categorias();

            objEntidad.id_categoria = txtIdCategoria.Text;

            r = objNegocio.EliminarCategoria(objEntidad);
        
        
        
        
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (dgvCategorias.Columns.seSelected)
            //{
            //    MessageBox.Show("Selecciona registro");
            //}
            //else
            //{
                DialogResult dialog = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Confirmacion",
                MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {


                    EliminarCategoria();
                    btnEliminar.Enabled = false;
                    valCel = -1;

                    // MessageBox.Show("Registro Exitoso");
                    //MessageBox.Show("Modificacion Exitosa");
                    MessageBox.Show("Registro Eliminado");
                    LiscarCategorias();
                }
                else { }
            //}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Categorias.ActiveForm.Size = new System.Drawing.Size(680, 400);
            valCel = -1;
            this.Close();
        }

        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                //MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Tab)
            {

            }
        }



        private void txtFiltroCategoria_KeyUp(object sender, KeyEventArgs e)
        {

            //Console.Write(txtFiltroCategoria.Text + e.KeyData.ToString() + "\n");

            //if (!(char.IsLetter(e.KeyCode)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            //{
            //    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}
        //    //if (e.KeyChar == (char)Keys.Tab)
        //    //{

        //    //}
            //if (e.KeyData.ToString() != "NumPad0" || e.KeyData.ToString() == "NumPad1" || e.KeyData.ToString() != "NumPad2" || txtFiltroCategoria.Text == "3"
            //    || e.KeyData.ToString() != "NumPad4" || e.KeyData.ToString() != "NumPad5" || e.KeyData.ToString() != "NumPad6" || txtFiltroCategoria.Text == "7"
            //    || e.KeyData.ToString() != "NumPad8" || e.KeyData.ToString() != "NumPad9" || txtFiltroCategoria.Text == "-" || txtFiltroCategoria.Text == "+")
            //{
            //    Console.Write("No debo de entrar aqui\n");
            //    e.Handled = true;
            //    txtFiltroCategoria.Undo();
            //}
            //else
            //{
                Categorias_Controlador obj = new Categorias_Controlador();
                List<Categorias> ListaCategorias;
                string Palabra_buscar;
                Console.Write(txtFiltroCategoria + "lalal2\n");
                Palabra_buscar = txtFiltroCategoria.Text;
                //Console.Write(Palabra_buscar + "\n");
                ListaCategorias = obj.buscarCategoriaNombre(Palabra_buscar);
                dgvCategorias.DataSource = ListaCategorias;
                Console.Write(ListaCategorias + "listas\n");
                if (ListaCategorias.Equals(""))
                {
                    MessageBox.Show("no se encontro registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
            }


            //}
        }




 

        private void txtFiltroCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Categorias_Controlador obj = new Categorias_Controlador();
            //List<Categorias> ListaCategorias;
            //string Palabra_buscar;
            ////Console.Write(txtFiltroCategoria + "lalal2\n");
            //Palabra_buscar = txtFiltroCategoria.Text;
            ////Console.Write(Palabra_buscar + "\n");
            //ListaCategorias = obj.buscarCategoriaNombre(Palabra_buscar);
            //dgvCategorias.DataSource = ListaCategorias;

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {

                Console.Write(" todo sale bien\n");
            
                //MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else
            {

                //Palabra_buscar = txtFiltroCategoria.Text;
                //Console.Write(Palabra_buscar+"\n");
                //ListaCategorias = obj.buscarCategoriaNombre(Palabra_buscar);
                //dgvCategorias.DataSource = ListaCategorias;
                //Console.Write("Holis especifico");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // limitar seleccion de checkbox
            // Console.Write("Inicia ........................\n");
            // Console.Write(valCel+"\n");

            //Console.Write(e.RowIndex + "\n");
            if (e.ColumnIndex == 0)
            {

                foreach (DataGridViewRow row in dgvCategorias.Rows)
                {
                    // Convert.ToString(row.Cells[0].Value) = "Select";
                    //if (Convert.ToBoolean(row.Cells[0].Value == "Select"))
                    //{
                    //    btnEliminar.Enabled = true;
                    //    MessageBox.Show("holis");
                    //}
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        MessageBox.Show("holis");

                        if (banCelCambio == true)
                        {
                            row.Cells[0].Value = false;
                            btnEliminar.Enabled = true;
                            valCel = -1;
                            // banCelCambio = true;
                            Console.Write("Cambio de checkbox sobre el mismo\n");

                        }

                    }
                }
                if (valCel == e.RowIndex)
                {
                    valCel = -1;
                    banCel = false;
                    btnEliminar.Enabled = false;
                    banCelCambio = false;
                    // MessageBox.Show("Hoooola yo gano");

                }
                if (valCel == -1)
                {
                    if (banCelCambio == true)
                    {
                        btnEliminar.Enabled = true;
                        DataGridViewRow row = this.dgvCategorias.Rows[e.RowIndex];

                        txtNombreCategoria.Text = row.Cells["nombre"].Value.ToString();
                        txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
                        txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
                        valCel = e.RowIndex;
                        Console.Write("entre ...1\n" + valCel);
                        valCel = e.RowIndex;
                    }

                    banCelCambio = true;
                }


                //    if (valCel == e.RowIndex)
                //    {
                //        btnEliminar.Enabled = false;
                //        valCel = -1;
                //        Console.Write("entre ...Valor repetido\n" + valCel);
                //        banCel = false;


                //    }
                //    if (e.RowIndex >= 0 && banCel==true)
                //    {
                //        btnEliminar.Enabled = true;



                //        if (valCel == -1)
                //        {
                //            DataGridViewRow row = this.dgvCategorias.Rows[e.RowIndex];

                //            txtNombreCategoria.Text = row.Cells["nombre"].Value.ToString();
                //            txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
                //            txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
                //            valCel = e.RowIndex;
                //            Console.Write("entre ...siguele\n" + valCel);
                //        }


                //    }
            }
            

        }



    }
}
