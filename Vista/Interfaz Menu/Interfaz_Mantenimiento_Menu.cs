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

namespace Vista.Interfaz_Menu
{
    public partial class Interfaz_Mantenimiento_Menu : Form
    {
        public Interfaz_Mantenimiento_Menu()
        {
            InitializeComponent();
        }

        private void CargarComboProductos() 
        
        {
            Menu_Controlador ob = new Menu_Controlador();
            List<Menuu> listaMenu;
            listaMenu = ob.ListarMenu();

            cbNombreProducto.DataSource = listaMenu;
            cbNombreProducto.DisplayMember = "nombre";
            cbNombreProducto.ValueMember = "id_producto";
        
        
        
        }
        private void ListarIngredientesNombre() 
        {
            Ingredientes_Controlador obj = new Ingredientes_Controlador();
            List<Ingredientes> listaIngredientesNombre;
            listaIngredientesNombre = obj.ListarIngredientesNombre(this.textBox1.Text);
            dgvIngredientes.DataSource = listaIngredientesNombre;
            
        
        
        
        }

        private void Interfaz_Mantenimiento_Menu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            contador();
            CargarComboProductos();
            
            ListarCategorias();
            ListarMateriaPrima();
            ListarMP2();
            ListarMP3();
            ListarMP4();
            ListarMP5();
            ListarMP6();
        }

        private void ListarMP2() 
        {
            MateriaPrima_Controlador ob = new MateriaPrima_Controlador();
            List<MateriaPrima> listarMateriaPrima;
            listarMateriaPrima = ob.listarMateriaPrima();

            cbIngrediente2.DataSource = listarMateriaPrima;
            cbIngrediente2.DisplayMember = "nombre";
            cbIngrediente2.ValueMember = "id_mp";
        
        }
        private void ListarMP3() 
        {
            MateriaPrima_Controlador ob = new MateriaPrima_Controlador();
            List<MateriaPrima> listarMateriaPrima;
            listarMateriaPrima = ob.listarMateriaPrima();

            cbIngrediente3.DataSource = listarMateriaPrima;
            cbIngrediente3.DisplayMember = "nombre";
            cbIngrediente3.ValueMember = "id_mp";
        
        
        
        }

        private void ListarMP4()
        {
            MateriaPrima_Controlador ob = new MateriaPrima_Controlador();
            List<MateriaPrima> listarMateriaPrima;
            listarMateriaPrima = ob.listarMateriaPrima();

            cbIngrediente4.DataSource = listarMateriaPrima;
            cbIngrediente4.DisplayMember = "nombre";
            cbIngrediente4.ValueMember = "id_mp";
        
        
        }
        private void ListarMP5() 
        {
            MateriaPrima_Controlador ob = new MateriaPrima_Controlador();
            List<MateriaPrima> listarMateriaPrima;
            listarMateriaPrima = ob.listarMateriaPrima();

            cbIngrediente5.DataSource = listarMateriaPrima;
            cbIngrediente5.DisplayMember = "nombre";
            cbIngrediente5.ValueMember = "id_mp";
        }
        private void ListarMP6() 
        {
            MateriaPrima_Controlador ob = new MateriaPrima_Controlador();
            List<MateriaPrima> listarMateriaPrima;
            listarMateriaPrima = ob.listarMateriaPrima();

            cbIngrediente6.DataSource = listarMateriaPrima;
            cbIngrediente6.DisplayMember = "nombre";
            cbIngrediente6.ValueMember = "id_mp";
        }

        private void ListarMateriaPrima() 
        {
            MateriaPrima_Controlador ob = new MateriaPrima_Controlador();
            List<MateriaPrima> listarMateriaPrima;
            listarMateriaPrima = ob.listarMateriaPrima();
            cbIngrediente1.DataSource = listarMateriaPrima;
            cbIngrediente1.DisplayMember = "nombre";
            cbIngrediente1.ValueMember = "id_mp";

            
        
        }

        private void ListarCategorias() 
        {
            Categorias_Controlador obj = new Categorias_Controlador();
            List<Categorias> ListarCategorias;
            ListarCategorias = obj.ListarCategorias();
            cbCategorias.DataSource = ListarCategorias;
            cbCategorias.DisplayMember = "nombre";
            cbCategorias.ValueMember = "id_categoria";




        
        
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void RegistrarMenu() 
        {
            int r = 0;
            Menuu objEntidad2 = new Menuu();
            Menu_Controlador objNegocio2 = new Menu_Controlador();

            objEntidad2.id_producto = txtId.Text;
            objEntidad2.nombre = txtNombre.Text;

            objEntidad2.descripcion = txtDescripcion.Text;
            objEntidad2.precio = txtPrecio.Text;
            //objEntidad.id_mp = Convert.ToString(cbMP.SelectedValue);
            objEntidad2.id_categoria = Convert.ToString(cbCategorias.SelectedValue);
            


            r = objNegocio2.RegistrarMenu(objEntidad2);

            
           
        
        
        
        }
        private void RegistrarIngrediente1() 
        {
            int r = 0;
            Ingredientes objEntidad3 = new Ingredientes();
            Ingredientes_Controlador objNegocio3 = new Ingredientes_Controlador();

            

            objEntidad3.id_salida = txtIdSalida1.Text;
            objEntidad3.id_producto = txtId.Text;
            //objEntidad.id_mp = Convert.ToString(cbMP.SelectedValue);
            objEntidad3.id_mp= Convert.ToString(cbIngrediente1.SelectedValue);
            objEntidad3.cantidad = txtCantidad1.Text;
            objEntidad3.unidad = cbUnidad1.Text;
            r = objNegocio3.RegistrarIngrediente(objEntidad3);
                
        }

        private void RegistrarIngrediente2()
        {
            int r = 0;
            Ingredientes objEntidad4 = new Ingredientes();
            Ingredientes_Controlador objNegocio4 = new Ingredientes_Controlador();



            objEntidad4.id_salida = txtIdSalida2.Text;
            objEntidad4.id_producto = txtId.Text;
            //objEntidad.id_mp = Convert.ToString(cbMP.SelectedValue);
            objEntidad4.id_mp = Convert.ToString(cbIngrediente2.SelectedValue);
            objEntidad4.cantidad = txtCantidad2.Text;
            objEntidad4.unidad = cbUnidad2.Text;
            r = objNegocio4.RegistrarIngrediente(objEntidad4);

        }

        private void RegistrarIngrediente3()
        {
            int r = 0;
            Ingredientes objEntidad5 = new Ingredientes();
            Ingredientes_Controlador objNegocio5 = new Ingredientes_Controlador();



            objEntidad5.id_salida = txtIdSalida3.Text;
            objEntidad5.id_producto = txtId.Text;
            //objEntidad.id_mp = Convert.ToString(cbMP.SelectedValue);
            objEntidad5.id_mp = Convert.ToString(cbIngrediente3.SelectedValue);
            objEntidad5.cantidad = txtCantidad3.Text;
            objEntidad5.unidad = cbUnidad3.Text;
            r = objNegocio5.RegistrarIngrediente(objEntidad5);

        }


        private void contador()
        {

            Menu_Controlador obj = new Menu_Controlador();
            List<Menuu> listarContador;
            //List<MateriaPrima> listarContador;
            // listarContador = obj.listarContador();
            //txtIdMp.Text = listarContador[0].id_mp.ToString();

            listarContador = obj.listarContador();
            if (listarContador.Count > 0)
            {
                txtId.Text = listarContador[0].Contador.ToString();



                //CargarDatos();
            }
        }

        private void limpiar() 
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text=string.Empty;
            txtPrecio.Text = string.Empty;
            cbCategorias.Text = string.Empty;
            txtId.Text = string.Empty;

            txtIdSalida1.Text = string.Empty;
            txtIdSalida2.Text = string.Empty;
            txtIdSalida3.Text = string.Empty;

            cbIngrediente1.Text = string.Empty;
            cbIngrediente2.Text = string.Empty;
            cbIngrediente3.Text = string.Empty;
            cbIngrediente4.Text = string.Empty;
            cbIngrediente5.Text = string.Empty;
            cbIngrediente6.Text = string.Empty;

            txtCantidad1.Text = "0";
            txtCantidad2.Text = "0";
            txtCantidad3.Text = "0";

            cbUnidad1.Text = string.Empty;
            cbUnidad2.Text = string.Empty;
            cbUnidad3.Text = string.Empty;

            label11.Enabled = false;
            label12.Enabled = false;
            label13.Enabled = false;

            txtCantidad2.Enabled = false;
            cbIngrediente2.Enabled = false;
            cbUnidad2.Enabled = false;

            label14.Enabled = false;
            label15.Enabled = false;
            label16.Enabled = false;

            txtCantidad3.Enabled = false;
            cbIngrediente3.Enabled = false;
            cbUnidad3.Enabled = false;

               

        
        
        
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCantidad2.Text == "0")
            {
                RegistrarMenu();

                RegistrarIngrediente1();
                
                MessageBox.Show("Registro exitoso");
                limpiar();
                contador();



            }
            else {
                if (txtCantidad3.Text == "0")
                {
                    RegistrarMenu();

                    RegistrarIngrediente1();
                    RegistrarIngrediente2();
                    MessageBox.Show("Registro exitoso");
                    limpiar();
                    contador();

                }
                else 
                {
                    if(txtCantidad4.Text== "0")
                    {
                        RegistrarMenu();

                        RegistrarIngrediente1();
                        RegistrarIngrediente2();
                        RegistrarIngrediente3();
                        MessageBox.Show("Registro exitoso");
                        limpiar();
                        contador();


                    
                    
                    
                    }
                
                
                
                
                
                }
               
            
            
            }
            //RegistrarMenu();

           

            //RegistrarIngrediente1();
        }

        private void btnAgregarOtro1_Click(object sender, EventArgs e)
        {
            //RegistrarMenu();

           // RegistrarIngrediente1();

            label11.Enabled = true;
            label12.Enabled = true;
            label13.Enabled = true;

            txtCantidad2.Enabled = true;
            cbIngrediente2.Enabled = true;
            cbUnidad2.Enabled = true;

            btnAgregarOtro2.Enabled = true;

        }

        private void btnAgregarOtro2_Click(object sender, EventArgs e)
        {
            label14.Enabled = true;
            label15.Enabled = true;
            label16.Enabled = true;

            cbIngrediente3.Enabled = true;
            txtCantidad3.Enabled = true;
            cbUnidad3.Enabled = true;

            btnAgregar3.Enabled = true;
        }

        private void cbNombreProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           // ListarIngredientesNombre();
        }
        private void ListarIdMenu() 
        {
            Menu_Controlador obj = new Menu_Controlador();
            List<Menuu> ListaMenuId;
            ListaMenuId = obj.ListarIdMenu(this.cbNombreProducto.Text);
            if (ListaMenuId.Count > 0) {


                textBox1.Text = ListaMenuId[0].id_producto.ToString();
            }
            

        
        
        
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //ListarIngredientesNombre();
            ListarIdMenu();

            ListarIngredientesNombre();
        }
    }
}
