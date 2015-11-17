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
        int valCel = -1, contIndexcheck=-1;
        Boolean banCel = true, banMod = false, banRegistrar=false, bnModificar=false;
        Boolean banCelCambio = true;
        public Interfaz_Mantenimiento_Categorias()
        {
            InitializeComponent();
            lblDescripcionM.Visible=false;
            lblNombreM.Visible = false;
            lblDescripcionR.Visible = false;
            lblNombreR.Visible = false;
           
        }
        //Listar categorias
        private void LiscarCategorias() 
        {
            Categorias obj = new Categorias();
            List<Categorias> ListaCategorias;
            ListaCategorias = obj.ListarCategorias();
            dgvCategorias.DataSource = ListaCategorias;                   
        }
        //Oculta la columna de ID_Categoria
        private void OcultarColumna() 
        {
            dgvCategorias.Columns[1].Visible = false;

        }
        //
        private void Interfaz_Mantenimiento_Categorias_Load(object sender, EventArgs e)
        {
            banRegistrar = false;
            Interfaz_Mantenimiento_Categorias.ActiveForm.Size = new System.Drawing.Size(700, 400);
            this.AutoSize = true;
            LiscarCategorias();
            //Eementos del panel Registrar
            txtDescripcionR.MaxLength = 40;      
            txtNombreR.MaxLength = 20;
            //Eementos del panel Modificar
            txtDescripcionM.MaxLength = 40;
            txtNombreM.MaxLength = 20;
            btnModificar.Enabled = true;
            CargarCabezeras();
            OcultarColumna();
        }
        //Cabeceras de la Tabla Categoria
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
        //Eventos de la tabla categoria
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                if (banRegistrar == true)
                {
                    MessageBox.Show("Necesita terminar el registro");
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    LiscarCategorias();
                    //foreach (DataGridViewRow row in dgvCategorias.Rows)
                       // {
                           //Get the appropriate cell using index, name or whatever and cast to DataGridViewCheckBoxCell
                          // DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                            //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                           //Compare to the true value because Value isn't boolean
                          //if (cell.Value == cell.TrueValue )
                          // {
                            //if (chk.Value == chk.TrueValue)
                            //{
                                
                            //    chk.Value = chk.FalseValue;
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Necesita terminar el registro");
                            //    chk.Value = chk.TrueValue;
                            //}
                               //MessageBox.Show("Necesita terminar el registro");
                              // Console.Write(chk.Value);
                               //Console.Write(cell.TrueValue);
                               //Console.Write("\n");
                           //}
                         
                              //The value is true
                        //}
                   
                }
                else
                {
                    //btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    foreach (DataGridViewRow row in dgvCategorias.Rows)
                    {
                       
                       
                        if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        {

                            if (banCelCambio == true && bnModificar==true)
                            {
                                //cuando se hace un cambio de celda
                                row.Cells[0].Value = false;
                                btnEliminar.Enabled = false;
                                txtNombreM.Enabled = true;
                                txtDescripcionM.Enabled = true;
                                btnModificar.Enabled = false;
                                txtNombreM.Text = row.Cells["nombre"].Value.ToString();
                                txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
                                txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
                                valCel = -1;
                                   MessageBox.Show("Entro aqui si modifico ");

                            }
                            if (banCelCambio == true && bnModificar==false)
                            {
                                //cuando se hace un cambio de celda
                                row.Cells[0].Value = false;
                                btnEliminar.Enabled = true;
                                txtNombreM.Enabled = true;
                                txtDescripcionM.Enabled = true;
                                btnModificar.Enabled = true;
                                txtNombreM.Text = row.Cells["nombre"].Value.ToString();
                                txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
                                txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
                                valCel = -1;
                                    MessageBox.Show("Entro aqui si solo cambio");

                            }
                        }
                    }
                    if (valCel == e.RowIndex && bnModificar==true)
                    {
                        
                        //cuando se selecciona la misma celda
                        valCel = -1;
                        banCel = false;
                        btnEliminar.Enabled = false;
                        btnModificar.Enabled = false;
                        banCelCambio = false;
                        txtNombreM.Text = " ";
                        txtDescripcionM.Text = " ";
                        txtNombreM.Enabled = false;
                        txtDescripcionM.Enabled = false;
                        txtIdCategoria.Text = " ";

                    }
                    if (valCel == e.RowIndex && bnModificar==false)
                    {

                        //cuando se selecciona la misma celda
                        valCel = -1;
                        banCel = false;
                        btnEliminar.Enabled = false;
                        btnModificar.Enabled = false;
                        banCelCambio = false;
                        txtNombreM.Text = " ";
                        txtDescripcionM.Text = " ";
                        txtNombreM.Enabled = false;
                        txtDescripcionM.Enabled = false;
                        txtIdCategoria.Text = " ";

                    }
                    if (valCel == -1 )
                    {
                        if (banCelCambio == true && bnModificar==true )
                        {
                            btnEliminar.Enabled = false;
                            btnModificar.Enabled = true;
                            DataGridViewRow row = this.dgvCategorias.Rows[e.RowIndex];
                            txtNombreM.Enabled = true;
                            txtDescripcionM.Enabled = true;
                            txtNombreM.Text = row.Cells["nombre"].Value.ToString();
                            txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
                            txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
                            valCel = e.RowIndex;
                            
                            //banCel = row.Cells[0].Value;
                        }
                        if (banCelCambio == true && bnModificar == false)
                        {
                            btnEliminar.Enabled = true;
                            btnModificar.Enabled = true;
                            DataGridViewRow row = this.dgvCategorias.Rows[e.RowIndex];
                            txtNombreM.Enabled = true;
                            txtDescripcionM.Enabled = true;
                            txtNombreM.Text = row.Cells["nombre"].Value.ToString();
                            txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
                            txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
                            valCel = e.RowIndex;
                            //banCel = row.Cells[0].Value;
                            Console.Write(e.RowIndex);
                        }

                        banCelCambio = true;
                    }
                    else
                    {
                        
                        //MessageBox.Show("Necesita terminar el registro");
                        //btnModificar.Enabled = false;
                        //btnEliminar.Enabled = false;

                    }


                }
            }
            
        }
        //Evento de celda seleccion(doble click)
        private void dgvCategorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                
                    //foreach (DataGridViewRow row in dgvCategorias.Rows)
                       // {
                           //Get the appropriate cell using index, name or whatever and cast to DataGridViewCheckBoxCell
                          // DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                            //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                           //Compare to the true value because Value isn't boolean
                          //if (cell.Value == cell.TrueValue )
                          // {
                            //if (chk.Value == chk.TrueValue)
                            //{
                                
                            //    chk.Value = chk.FalseValue;
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Necesita terminar el registro");
                            //    chk.Value = chk.TrueValue;
                            //}
                               //MessageBox.Show("Necesita terminar el registro");
                              // Console.Write(chk.Value);
                               //Console.Write(cell.TrueValue);
                               //Console.Write("\n");
                           //}
                         
                              //The value is true
                        //}
              
                foreach (DataGridViewRow row in dgvCategorias.Rows)
                { 
                //int cont = 0;
           
                //DataGridViewCell cell = dgvCategorias.Rows[cont].Cells[0];
                //DataGridViewCheckBoxCell chkCell = cell as DataGridViewCheckBoxCell;
                //chkCell.Value = true;
                //chkCell.FlatStyle = FlatStyle.Flat;
                //chkCell.Style.ForeColor = Color.DarkGray;
                //cell.ReadOnly = true;

                //cont++;

                //Console.Write(cont);
                     if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        {

                            if (banCelCambio == true || contIndexcheck==-1)
                            {
                                //cuando se hace un cambio de celda
                                row.Cells[0].Value = false;
                               // btnEliminar.Enabled = true;
                                txtNombreM.Enabled = true;
                                btnGuardarM.Enabled = true;
                                txtDescripcionM.Enabled = true;
                                txtNombreM.Text = row.Cells["nombre"].Value.ToString();
                                txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
                                txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
                                valCel = -1;

                            }
                            else
                            {
                                //MessageBox.Show("Necesita terminar el registro");
                                //btnModificar.Enabled = false;
                                //btnEliminar.Enabled = false;
                            }

                        }
                    }

                if (valCel == e.RowIndex || contIndexcheck == e.RowIndex)
                {
                    //cuando se selecciona la misma celda
                    //gbModificar.Visible = false;
                    txtNombreM.Enabled = false;
                    txtDescripcionM.Enabled = false;
                    valCel = -1;
                    banCel = false;
                    btnEliminar.Enabled = false;
                    btnGuardarM.Enabled = false;
                    //btnModificar.Enabled = false;
                    banCelCambio = false;
                    txtNombreM.Text = " ";
                    txtDescripcionM.Text = " ";
                    txtIdCategoria.Text = " ";
                    contIndexcheck = -1;

                }
                if (valCel == -1 )
                {
                    if (banCelCambio == true)
                    {
                        txtNombreM.Enabled = true;
                        txtDescripcionM.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnGuardarM.Enabled = true;
                      //  btnModificar.Enabled = true;
                        DataGridViewRow row = this.dgvCategorias.Rows[e.RowIndex];

                        txtNombreM.Text = row.Cells["nombre"].Value.ToString();
                        txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
                        txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
                        valCel = e.RowIndex;
                        contIndexcheck = e.RowIndex;
                    }

                    banCelCambio = true;
                }
                else
                {
                    //MessageBox.Show("Necesita terminar el registro");
                    //btnModificar.Enabled = false;
                    //btnEliminar.Enabled = false;

                }
               
            
            
            }

            //version 2
            //if (e.ColumnIndex == 0)
            //{
            //    foreach (DataGridViewRow row in dgvCategorias.Rows)
            //    {
            //        if (banRegistrar == true)
            //        {
            //            MessageBox.Show("Necesita terminar el registro");
            //            btnModificar.Enabled = false;
            //            btnEliminar.Enabled = false;
            //        }
            //        else
            //        {
            //            btnModificar.Enabled = true;
            //            btnEliminar.Enabled = true;
            //            txtNombreM.Text = row.Cells["nombre"].Value.ToString();
            //            txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
            //            txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();

            //            if (Convert.ToBoolean(row.Cells[0].Value) == true)
            //            {

            //                if (banCelCambio == true)
            //                {
            //                    //cuando se hace un cambio de celda
            //                    row.Cells[0].Value = false;
            //                    btnEliminar.Enabled = true;
            //                    btnModificar.Enabled = true;
            //                    txtNombreM.Text = row.Cells["nombre"].Value.ToString();
            //                    txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
            //                    txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
            //                    valCel = -1;

            //                }
            //                else
            //                {
            //                    MessageBox.Show("Necesita terminar el registro");
            //                    btnModificar.Enabled = false;
            //                    btnEliminar.Enabled = false;
            //                }

            //            }
            //        }
            //    }
            //    if (valCel == e.RowIndex)
            //    {
            //        //cuando se selecciona la misma celda
            //        gbModificar.Visible = false;
            //        valCel = -1;
            //        banCel = false;
            //        btnEliminar.Enabled = false;
            //        btnModificar.Enabled = false;
            //        banCelCambio = false;
            //        txtNombreM.Text = " ";
            //        txtDescripcionM.Text = " ";
            //        txtIdCategoria.Text = " ";

            //    }
            //    if (valCel == -1 && banRegistrar == true)
            //    {
            //        if (banCelCambio == true)
            //        {
            //            btnEliminar.Enabled = true;
            //            btnModificar.Enabled = true;
            //            DataGridViewRow row = this.dgvCategorias.Rows[e.RowIndex];

            //            txtNombreM.Text = row.Cells["nombre"].Value.ToString();
            //            txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
            //            txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
            //            valCel = e.RowIndex;
            //        }

            //        banCelCambio = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Necesita terminar el registro");
            //        btnModificar.Enabled = false;
            //        btnEliminar.Enabled = false;

            //    }



            //}

            //version 1
            //if (e.ColumnIndex == 0)
            //{

            //    foreach (DataGridViewRow row in dgvCategorias.Rows)
            //    {

            //        if (Convert.ToBoolean(row.Cells[0].Value) == true)
            //        {


            //            if (banCelCambio == true)
            //            {
            //                MessageBox.Show("Necesita terminar el registro");

            //                row.Cells[0].Value = false;
            //                btnEliminar.Enabled = true;
            //                btnModificar.Enabled = true;
            //                valCel = -1;

            //                txtNombreM.Text = row.Cells["nombre"].Value.ToString();
            //                txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
            //                txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
            //                Console.Write("Cambio de checkbox sobre el mismo\n");

            //            }

            //        }
            //    }
            //    if (valCel == e.RowIndex)
            //    {
            //        valCel = -1;
            //        banCel = false;
            //        btnModificar.Enabled = false;
            //        btnEliminar.Enabled = false;
            //        banCelCambio = false;
            //        txtNombreM.Text = "";
            //        txtDescripcionM.Text = "";
            //        txtIdCategoria.Text = "";

            //    }
            //    if (valCel == -1)
            //    {
            //        if (banCelCambio == true)
            //        {
            //            btnEliminar.Enabled = true;
            //            btnModificar.Enabled = true;
            //            DataGridViewRow row = this.dgvCategorias.Rows[e.RowIndex];

            //            txtNombreM.Text = row.Cells["nombre"].Value.ToString();
            //            txtIdCategoria.Text = row.Cells["id_categoria"].Value.ToString();
            //            txtDescripcionM.Text = row.Cells["descripcion"].Value.ToString();
            //            valCel = e.RowIndex;
            //            Console.Write("entre ...1\n" + valCel);
            //            valCel = e.RowIndex;
            //        }

            //        banCelCambio = true;
            //    }

            //}
            

        }
        //Validacion de Registro por nombre
        private Boolean ValidarRegistro() {
             Categorias_Controlador obj = new Categorias_Controlador();
             String Registro_buscar = txtNombreR.Text;
             return obj.ValidarRegistroC(Registro_buscar);
        }
        //validacion de Modificacion por nombre
        private Boolean ValidarRegistroMod()
        {

            Categorias_Controlador obj = new Categorias_Controlador();
            String Registro_buscar = txtNombreM.Text;
           
            return obj.ValidarRegistroC(Registro_buscar);
        }
        //Metodo para Registrar
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

        //Metodo para Modificar
        private void ModificarCategoria() 
        
        {
            int r = 0;
            Categorias objEntidad = new Categorias();
            Categorias_Controlador objNegocio = new Categorias_Controlador();
            objEntidad.id_categoria = txtIdCategoria.Text;
            objEntidad.nombre = txtNombreM.Text;
            objEntidad.descripcion = txtDescripcionM.Text;
            r = objNegocio.ModificarCategorias(objEntidad);

        }

        //Metodo para Eliminar
        private void EliminarCategoria() 
        {
            int r = 0;
            Categorias objEntidad = new Categorias();
            Categorias objNegocio = new Categorias();
            objEntidad.id_categoria = txtIdCategoria.Text;
            r = objNegocio.EliminarCategoria(objEntidad);

        }
        //Metetodos de filtrocategoria
        private void txtFiltroCategoria_KeyUp(object sender, KeyEventArgs e)
        {           
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
        }

        private void txtFiltroCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {

                Console.Write(" todo sale bien\n");
                e.Handled = true;
                return;
            }
            else
            { } 
        }

 
        //Eventos de las opciones Modificar
        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            lblDescripcionM.Visible = false;
            lblNombreM.Visible = false;
            int numerocont = 0;
            if (txtNombreM.Text == "" || txtDescripcionM.Text == "")
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

                if (banMod == true)
                {
                    MessageBox.Show("Registro Repetido");
                }
                else
                {
                    ModificarCategoria();
                    MessageBox.Show("Modificacion exitosa");
                    LiscarCategorias();
                    txtDescripcionM.Text = "";
                    txtNombreM.Text = "";
                    btnSalir.Enabled = false;
                    btnModificar.Enabled = false; ;
                    btnEliminar.Enabled = false;
                    numerocont = 0;
                    lblNombreR.Visible = false;
                    lblDescripcionR.Visible = false;
                    banMod = false;
                    bnModificar=false;

                }
            }
          

        }

        private void btnCancelarM_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Categorias.ActiveForm.Size = new System.Drawing.Size(680, 400);
            gbModificar.Visible = false;
            gbRegistrar.Visible = false;
            btnRegistrar.Enabled = true;
            btnSalir.Enabled = true;
            btnModificar.Enabled = true;
        }
        private void txtNombreM_KeyUp(object sender, KeyEventArgs e)
        {
            banMod = ValidarRegistroMod();
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

       
    //Eventos de Registrar
        private void txtNombreR_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnGuardarR_Click(object sender, EventArgs e)
        {
            banRegistrar = false;
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

                if (ValidarRegistro() == true)
                {
                    MessageBox.Show("Registro Repetido");
                    txtDescripcionR.Text = "";
                    txtNombreR.Text = "";
                }
                else
                {
                    RegistrarCategoria();
                    MessageBox.Show("Registro exitoso");
                    LiscarCategorias();
                    gbRegistrar.Visible = true;
                    txtDescripcionR.Text = "";
                    txtNombreR.Text = "";
                    //btnModificar.Enabled = false;
                    btnSalir.Enabled = false;
                    //btnModificar.Enabled = false; ;
                    //btnEliminar.Enabled = false;
                    numerocont = 0;
                    lblNombreR.Visible = false;
                    lblDescripcionR.Visible = false;
                }
            }
        }

        private void btnCancelarR_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Categorias.ActiveForm.Size = new System.Drawing.Size(680, 400);
            dgvCategorias.Enabled = true;
            gbModificar.Visible = false;
            gbRegistrar.Visible = false;
            btnRegistrar.Enabled = true;
            btnModificar.Enabled = true;
            btnSalir.Enabled = true;
            banRegistrar = false;
            bloquearSeleccion();
     
        }
    //Eventos de botones principales
        //registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bloquearSeleccion();
            dgvCategorias.Enabled = false;
            banRegistrar = true;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            Interfaz_Mantenimiento_Categorias.ActiveForm.Size = new System.Drawing.Size(980, 400);
            btnSalir.Enabled = false;
            btnEliminar.Enabled = false;

            btnModificar.Enabled = false;
            gbModificar.Visible = false;
            gbRegistrar.Visible = true;
        }
        //Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //btnModificar.CanSelect() = false;
            btnGuardarM.Enabled = false;
            Interfaz_Mantenimiento_Categorias.ActiveForm.Size = new System.Drawing.Size(980, 400);
            gbModificar.Visible = true;
            btnRegistrar.Enabled = false;
            btnEliminar.Enabled = false;
            // btnEliminar.Enabled = false;
            btnSalir.Enabled = false;
            btnModificar.Enabled = false;
            gbRegistrar.Visible = false;
            bnModificar = true;
            if(contIndexcheck==-1){
                txtDescripcionM.Enabled = false;
                txtNombreM.Enabled = false;
            }
           

        }
        //Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Confirmacion",
            MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {


                EliminarCategoria();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                txtDescripcionM.Text = "";
                txtNombreM.Text = "";
                txtDescripcionM.Enabled = false;
                txtNombreM.Enabled = false;
                valCel = -1;
                MessageBox.Show("Registro Eliminado");
                LiscarCategorias();
            }
            else {
                LiscarCategorias();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;

            }           
        }
        //Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Categorias.ActiveForm.Size = new System.Drawing.Size(680, 400);
            valCel = -1;
            this.Close();
        }

        private void dgvCategorias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }


        private Boolean bloquearSeleccion() {
            int cont = 0;
            foreach (DataGridViewRow row in dgvCategorias.Rows)
            {
                DataGridViewCell cell = dgvCategorias.Rows[cont].Cells[0];
                DataGridViewCheckBoxCell chkCell = cell as DataGridViewCheckBoxCell;
               // chkCell.Value = true;
                chkCell.FlatStyle = FlatStyle.Flat;
                chkCell.Style.ForeColor = Color.DarkGray;
                cell.ReadOnly = true;
                //if (banRegistrar == true)
                //{

                //    chkCell.FlatStyle = FlatStyle.Flat;
                //    chkCell.Style.ForeColor = Color.DarkGray;
                //    cell.ReadOnly = true;
                //}
                if (banRegistrar == false)
                {
                    cell.ReadOnly = false;
                    chkCell.FlatStyle = FlatStyle.Standard;
                    chkCell.Style.ForeColor = Color.White;
                    //chkCell.blo;
                }
              

                cont++;

                Console.Write(cont);
               
            }
            return true;
        }


    }

}
