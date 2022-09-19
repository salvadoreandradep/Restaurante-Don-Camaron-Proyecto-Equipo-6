using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Semena_6___Parcial_1
{
    public partial class login : Form
    {

        SqlConnection sqlnet = new SqlConnection("Data Source=DESKTOP-APECPOJ;Initial Catalog=login;Integrated Security=True");
        OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\salva\OneDrive\Escritorio\basededatosaccess\Database1.mdb");
        public login()
        {
            InitializeComponent();

        }



        private void login_Load(object sender, EventArgs e)
        {
            try
            {

                sqlnet.Open();
                conexion.Open();
                MessageBox.Show("Se ha conectado a los servidores de manera exitosa");

            }
            catch (Exception a)
            {

                MessageBox.Show("Error por: " + a.ToString());

            }


        }

      

      

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Saliendo", " Aviso ", MessageBoxButtons.OK);


            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string consulta = "select clave, usuario from usuarios where clave ='" + txtpass.Text + "' and usuario = '" + txtusuario.Text + "';";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
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
            conexion.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sqlconsulta = "select clave, usuario from usuarios where clave ='" + txtpass.Text + "' and usuario = '" + txtusuario.Text + "';";
            SqlCommand comandosql = new SqlCommand(sqlconsulta, sqlnet);
            SqlDataReader sqldb;
            sqldb = comandosql.ExecuteReader();
            Boolean existereg = sqldb.HasRows;
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
            sqlnet.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usuario us = new usuario();
            us.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menu_principal f1 = new menu_principal();
            f1.Show();
            this.Hide();

        }
    }
}

