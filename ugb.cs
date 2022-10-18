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
    public partial class ugb : Form
    {
        public ugb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            participa pa = new participa();
            pa.Show();
        }
    }
}
