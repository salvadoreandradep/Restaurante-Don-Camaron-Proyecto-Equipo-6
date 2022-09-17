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
using System.Data.SqlClient;

namespace Semena_6___Parcial_1
{
    public partial class Login : Form



    {
        public Login()
        {
            InitializeComponent();
        }


        SqlConnection sqlnet = new SqlConnection("Data Source=DESKTOP-APECPOJ;Initial Catalog=login;Integrated Security=True");
        OleDbConnection Conectar = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\salva\source\repos\Semana-7-Login-con-base-de-datos\basededatosaccess\Database1.mdb");

        private void button1_Click(object sender, EventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {

            try
            {
                sqlnet.Open();
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

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
