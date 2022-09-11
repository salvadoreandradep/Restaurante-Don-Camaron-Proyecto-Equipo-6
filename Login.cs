using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Semena_6___Parcial_1
{
    public partial class Login : Form



    {
        public Login()
        {
            InitializeComponent();
        }



        OleDbConnection Conectar = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Salvador\source\repos\Semena-6---Parcial-1\basededatosaccess\Database1.mdb");


        private void button1_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text == "as" || txtpass.Text == "123456")
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

            try
            {
                Conectar.Open();
                MessageBox.Show("Online");



            }
            catch (Exception a)
            {
                MessageBox.Show("Offline" + a.ToString());
            
            
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

           Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string consulta = "select clave, usuario from usuarios where clave ='" + txtpass.Text + "' and usuario = '" + txtusuario.Text + "';";
            OleDbCommand comando = new OleDbCommand(consulta, Conectar);
            OleDbDataReader leedb;
            leedb = comando.ExecuteReader();
            Boolean existereg = leedb.HasRows;
            if (existereg)
            {
                MessageBox.Show("bienvenido al sistema: " + txtusuario.Text);
                menu_principal f1 = new menu_principal();
                f1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecto trate de nuevo");
                return;
            }
            Conectar.Close();
        }
    }
}
