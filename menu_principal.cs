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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login ll = new Login();
            ll.Show();

            Close();
        }

        private void combo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo1 c1 = new combo1();
            c1.Show();
        }

        private void combo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo2 c2 = new combo2();
            c2.Show();
        }

        private void combo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo3 c3 = new combo3();
            c3.Show();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bocadillosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bocadillos bb = new bocadillos();
            bb.Show();
        }

        private void heladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helado hh = new helado ();
            hh.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ayuda aa = new ayuda();
                aa.Show();
        }
    }
}
