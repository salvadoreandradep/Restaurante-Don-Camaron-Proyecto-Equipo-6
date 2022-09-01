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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text == "1" || txtpass.Text == "1")
            {
                menu_principal f1 = new menu_principal();
                f1.Show();
                this.Hide();
              
            }
            else
                MessageBox.Show("usuario o contraseña incorrecta", " Nose encontro usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           Close();
        }
    }
}
