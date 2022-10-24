using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semena_6___Parcial_1
{
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
        }

        private void menu_principal_Load(object sender, EventArgs e)
        {

        }



        private void combosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void combo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }



        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acerdade aa = new acerdade();
            aa.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda a1 = new ayuda();
            a1.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empleados ee = new empleados();
            ee.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes cc = new clientes();
            cc.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos cc = new Productos();
            cc.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Pedidos pc = new Pedidos();
            pc.Show();
        }

        private void uGBVErdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ugb ugb = new ugb();
            ugb.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora bb = new Bitacora();
            bb.Show();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Puestos pp = new Puestos();
            pp.Show();
        }
    }
}
