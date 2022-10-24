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
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Creado el dato en la tabla Bitacora");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Guardado el dato en la tabla Bitacora");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Modificado el dato la tabla Bitacora");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Eliminado el dato de la tabla Bitacora");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
