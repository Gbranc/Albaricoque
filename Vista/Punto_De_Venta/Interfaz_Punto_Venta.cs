using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Punto_De_Venta
{
    public partial class Interfaz_Punto_Venta : Form
    {
        public Interfaz_Punto_Venta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interfaz_Cobrar IC = new Interfaz_Cobrar();
            IC.Show();
        }
    }
}
