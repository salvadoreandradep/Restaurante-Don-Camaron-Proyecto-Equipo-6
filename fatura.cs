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
    public partial class fatura : Form
    {
        public fatura()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("La Factura fue tomada y enviada a la base de datos.", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
