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
using System.Data.SqlClient;

namespace Vista.Interfaces_Proveedor
{
    public partial class Interfaz_Mantenimiento_Proveedor : Form
    {
        int valCel = -1;
        Boolean banCel = true, banMod = false;

        Boolean banCelCambio = true;
        public Interfaz_Mantenimiento_Proveedor()
        {
            InitializeComponent();
            lblDireccionR.Visible = false;
            lblNombreM.Visible = false;
            lblDireccionM.Visible = false;
            lblNombreR.Visible = false;
            lblTelM.Visible = false;
            lblTelR.Visible = false;
        }
        private void ListarProveedor()
        {
            Proveedor obj = new Proveedor();
            List<Proveedor> ListarProveedor;
            ListarProveedor = obj.ListarProveedor();
            dgvProveedores.DataSource = ListarProveedor;




        }
        private void OcultarColumna()
        {
            dgvProveedores.Columns[1].Visible = false;

        }
        private void Interfaz_Mantenimiento_Proveedor_Load(object sender, EventArgs e)
        {

            Interfaz_Mantenimiento_Proveedor.ActiveForm.Size = new System.Drawing.Size(700, 400);
            //Interfaz_Mantenimiento_Categorias.ActiveForm.Resize = false;
            this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ListarProveedor();
            txtNombreR.MaxLength = 20;
            txtNombreM.MaxLength = 20;
            txtDireccionR.MaxLength = 40;
            txtDireccionM.MaxLength = 40;
            txtTelR.MaxLength = 20;
            txtTelM.MaxLength = 20;



            CargarCabezeras();
            OcultarColumna();
        }
        private void CargarCabezeras()
        {
            dgvProveedores.Columns[2].HeaderText = "Nombre";
            dgvProveedores.Columns[2].Width = 180;
            dgvProveedores.Columns[2].ReadOnly = true;
            dgvProveedores.Columns[2].Resizable =
    DataGridViewTriState.False;

            dgvProveedores.Columns[3].HeaderText = "Direccion";
            dgvProveedores.Columns[3].ReadOnly = true;
            dgvProveedores.Columns[3].Width = 250;
            dgvProveedores.Columns[3].Resizable =
   DataGridViewTriState.False;

            dgvProveedores.Columns[4].HeaderText = "Telefono";
            dgvProveedores.Columns[4].ReadOnly = true;
            dgvProveedores.Columns[4].Width = 100;
            dgvProveedores.Columns[4].Resizable =
   DataGridViewTriState.False;


        }
        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {


                foreach (DataGridViewRow row in dgvProveedores.Rows)
                {
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    txtNombreM.Text = row.Cells["nombreProveedor"].Value.ToString();
                    txtIdproveedor.Text = row.Cells["id_proveedor"].Value.ToString();
                    txtDireccionM.Text = row.Cells["direccion"].Value.ToString();
                    txtTelM.Text = row.Cells["telefono"].Value.ToString();

                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {

                        if (banCelCambio == true)
                        {
                            //cuando se hace un cambio de celda
                            row.Cells[0].Value = false;
                            btnEliminar.Enabled = true;
                            btnModificar.Enabled = true;
                            txtNombreM.Text = row.Cells["nombreProveedor"].Value.ToString();
                            txtIdproveedor.Text = row.Cells["id_proveedor"].Value.ToString();
                            txtDireccionM.Text = row.Cells["direccion"].Value.ToString();
                            txtTelM.Text = row.Cells["telefono"].Value.ToString();


                            valCel = -1;


                        }

                    }
                }
                if (valCel == e.RowIndex)
                {
                    //cuando se selecciona la misma celda
                    valCel = -1;
                    banCel = false;
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    banCelCambio = false;
                    txtNombreM.Text = "";
                    txtDireccionM.Text = "";
                    txtIdproveedor.Text = "";
                    txtTelM.Text = "";

                }
                if (valCel == -1)
                {
                    if (banCelCambio == true)
                    {
                        btnEliminar.Enabled = true;
                        btnModificar.Enabled = true;
                        DataGridViewRow row = this.dgvProveedores.Rows[e.RowIndex];

                        txtNombreM.Text = row.Cells["nombreProveedor"].Value.ToString();
                        txtIdproveedor.Text = row.Cells["id_proveedor"].Value.ToString();
                        txtDireccionM.Text = row.Cells["direccion"].Value.ToString();
                        txtTelM.Text = row.Cells["telefono"].Value.ToString();
                        valCel = e.RowIndex;
                    }

                    banCelCambio = true;
                }
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            Interfaz_Mantenimiento_Proveedor.ActiveForm.Size = new System.Drawing.Size(980, 400);
            btnSalir.Enabled = false;
            btnEliminar.Enabled = false;

            btnModificar.Enabled = false;
            gbModificar.Visible = false;
            gbRegistrar.Visible = true;
        }
        private void btnCancelarR_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Proveedor.ActiveForm.Size = new System.Drawing.Size(680, 400);

            gbModificar.Visible = false;
            gbRegistrar.Visible = false;
            btnRegistrar.Enabled = true;
            //btnModificar.Enabled = true;
            btnSalir.Enabled = true;
            //btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Proveedor.ActiveForm.Size = new System.Drawing.Size(980, 400);

            gbModificar.Visible = true;
            btnRegistrar.Enabled = false;
            // btnEliminar.Enabled = false;
            btnSalir.Enabled = false;

            gbRegistrar.Visible = false;
        }
        private void btnCancelarM_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Proveedor.ActiveForm.Size = new System.Drawing.Size(680, 400);

            gbModificar.Visible = false;
            gbRegistrar.Visible = false;
            btnRegistrar.Enabled = true;
            //btnModificar.Enabled = true;
            btnSalir.Enabled = true;
        }
        private Boolean ValidarRegistro()
        {

            Proveedor_Controlador obj = new Proveedor_Controlador();
            String Registro_buscar = txtNombreR.Text;

            return obj.ValidarRegistro1(Registro_buscar);
        }
        private Boolean ValidarRegistroMod()
        {

            Proveedor_Controlador obj = new Proveedor_Controlador();
            String Registro_buscar = txtNombreM.Text;

            return obj.ValidarRegistro1(Registro_buscar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Interfaz_Eliminar_Proveedor IEP = new Interfaz_Eliminar_Proveedor();
            IEP.Show();
            this.Close();
        }
        private void RegistrarCategoria()
        {

            int r = 0;
            Proveedor objEntidad = new Proveedor();
            Proveedor_Controlador objNegocio = new Proveedor_Controlador();
            objEntidad.id_proveedor = txtId.Text;
            objEntidad.nombreProveedor = txtNombreR.Text;
            objEntidad.telefono = txtTelR.Text;
            objEntidad.direccion = txtDireccionR.Text;


            r = objNegocio.registrarProveedor(objEntidad);




        }
        private void ModificarProveedor()
        {
         //   MessageBox.Show("holis");
            int r = 0;
            Proveedor objEntidad = new Proveedor();
            Proveedor_Controlador objNegocio = new Proveedor_Controlador();
            objEntidad.id_proveedor = txtIdproveedor.Text;
            objEntidad.nombreProveedor = txtNombreM.Text;
            objEntidad.telefono = txtTelM.Text;
            objEntidad.direccion = txtDireccionM.Text;

            //  objEntidad.id_mp = Convert.ToString(cbMP.SelectedValue);



            r = objNegocio.ModificarProveedor(objEntidad);



        }
        private void btnGuardarR_Click(object sender, EventArgs e)
        {
            lblDireccionR.Visible = false;
            lblNombreR.Visible = false;
            lblTelR.Visible = false;
            int numerocont = 0;
            if (txtNombreR.Text == "" || txtDireccionR.Text == "" || txtTelR.Text=="")
            {

                if (txtNombreR.Text == "")
                {
                    lblNombreR.Visible = true;
                    numerocont = numerocont + 1;
                }
                if (txtDireccionR.Text == "")
                {
                    lblDireccionR.Visible = true;
                    numerocont = numerocont + 1;
                }
                if (txtTelR.Text == "")
                {
                    lblTelR.Visible = true;
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
                    txtDireccionR.Text = "";
                    txtNombreR.Text = "";
                }
                else
                {
                    RegistrarCategoria();
                    MessageBox.Show("Registro exitoso");
                    ListarProveedor();
                    gbRegistrar.Visible = true;
                    txtDireccionR.Text = "";
                    txtNombreR.Text = "";
                    txtTelR.Text = "";
                    //btnModificar.Enabled = false;
                    btnSalir.Enabled = false;
                    //btnModificar.Enabled = false; ;
                    //btnEliminar.Enabled = false;
                    numerocont = 0;
                    lblNombreR.Visible = false;
                    lblDireccionR.Visible = false;
                    lblTelR.Visible = false;
                }
            }

        }
        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            lblDireccionM.Visible = false;
            lblNombreM.Visible = false;
            lblTelM.Visible = false;
            int numerocont = 0;
            if (txtNombreM.Text == "" || txtDireccionM.Text == "" || txtTelM.Text == "")
            {
                if (txtNombreM.Text == "")
                {
                    lblNombreM.Visible = true;
                    numerocont = numerocont + 1;
                }
                if (txtDireccionM.Text == "")
                {
                    lblDireccionM.Visible = true;
                    numerocont = numerocont + 1;
                }
                if (txtTelM.Text == "")
                {
                    lblTelM.Visible = true;
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
                    ModificarProveedor();
                    MessageBox.Show("Modificacion exitosa");
                    ListarProveedor();
                    //gbRegistrar.Visible = true;
                    txtDireccionM.Text = "";
                    txtNombreM.Text = "";
                    txtTelM.Text = "";
                    // btnModificar.Enabled = false;
                    btnSalir.Enabled = false;
                    btnModificar.Enabled = false; ;
                    btnEliminar.Enabled = false;
                    numerocont = 0;
                    lblNombreM.Visible = false;
                    lblDireccionM.Visible = false;
                    lblTelM.Visible = false;
                    banMod = false;
                }
            }
          
        }
        private void EliminarProveedor()
        {


            int r = 0;
            Proveedor objEntidad = new Proveedor();
            Proveedor objNegocio = new Proveedor();

            objEntidad.id_proveedor = txtIdproveedor.Text;

            r = objNegocio.EliminarProveedor(objEntidad);




        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
              DialogResult dialog = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Confirmacion",
                MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {


                    EliminarProveedor();
                    btnEliminar.Enabled = false;
                    valCel = -1;

                    // MessageBox.Show("Registro Exitoso");
                    //MessageBox.Show("Modificacion Exitosa");
                    MessageBox.Show("Registro Eliminado");
                    ListarProveedor();
                }
                else { }

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Proveedor.ActiveForm.Size = new System.Drawing.Size(680, 400);
            valCel = -1;
            this.Close();
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
        private void txtFiltroProveedor_KeyUp(object sender, KeyEventArgs e)
        {

            Proveedor_Controlador obj = new Proveedor_Controlador();
            List<Proveedor> ListaProveedor;
            string Palabra_buscar;
            Palabra_buscar = txtFiltroProveedor.Text;
            ListaProveedor = obj.buscarProveedorNombre(Palabra_buscar);
            dgvProveedores.DataSource = ListaProveedor;
            Console.Write(ListaProveedor + "listas\n");
            if (ListaProveedor.Equals(""))
            {
                MessageBox.Show("no se encontro registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


            //}
        }
        private void txtFiltroProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {

              //  Console.Write(" todo sale bien\n");

                e.Handled = true;
                return;
            }
            else
            {

              

            }
        }
        private void txtNombreM_KeyUp(object sender, KeyEventArgs e)
        {
            banMod = ValidarRegistroMod();
        }
        private void dgvProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {

                foreach (DataGridViewRow row in dgvProveedores.Rows)
                {

                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {


                        if (banCelCambio == true)
                        {
                            row.Cells[0].Value = false;
                            btnEliminar.Enabled = true;
                            btnModificar.Enabled = true;
                            valCel = -1;
                            txtNombreM.Text = row.Cells["nombreProveedor"].Value.ToString();
                            txtIdproveedor.Text = row.Cells["id_proveedor"].Value.ToString();
                            txtDireccionM.Text = row.Cells["direccion"].Value.ToString();
                            txtTelM.Text = row.Cells["telefono"].Value.ToString();

                            Console.Write("Cambio de checkbox sobre el mismo\n");

                        }

                    }
                }
                if (valCel == e.RowIndex)
                {
                    valCel = -1;
                    banCel = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    banCelCambio = false;
                    txtNombreM.Text = "";
                    txtDireccionM.Text = "";
                    txtIdproveedor.Text = "";
                    txtTelM.Text = "";

                    // MessageBox.Show("Hoooola yo gano");

                }
                if (valCel == -1)
                {
                    if (banCelCambio == true)
                    {
                        btnEliminar.Enabled = true;
                        btnModificar.Enabled = true;
                        DataGridViewRow row = this.dgvProveedores.Rows[e.RowIndex];
                        txtNombreM.Text = row.Cells["nombreProveedor"].Value.ToString();
                        txtIdproveedor.Text = row.Cells["id_proveedor"].Value.ToString();
                        txtDireccionM.Text = row.Cells["direccion"].Value.ToString();
                        txtTelM.Text = row.Cells["telefono"].Value.ToString();

                        valCel = e.RowIndex;
                        Console.Write("entre ...1\n" + valCel);
                        valCel = e.RowIndex;
                    }

                    banCelCambio = true;
                }
            }

        }

  

//aqui voy




    }
}
