using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Interfaces_MateriaPrima
{
    public partial class Interfaz_Mantenimiento_MateriaPrima : Form
    {
        public Interfaz_Mantenimiento_MateriaPrima()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Interfaz_Registro_MateriaPrima IRM = new Interfaz_Registro_MateriaPrima();

            IRM.MdiParent = this.MdiParent;

            IRM.Show();

            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
        private void dgvMateriaPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvMateriaPrima.Columns[2].HeaderText = "Cedula";
        }
    }
}
