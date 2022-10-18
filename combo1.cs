using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Semena_6___Parcial_1
{
    public partial class combo1 : Form
    {


        public string cadena_conexion = @"Database=login;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5";
        public combo1()
        {
            InitializeComponent();
        }

        private void combo1_Load(object sender, EventArgs e)
        {
          
            try
            {
                string consulta = "select * from combos";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "login");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "login";
            }
            catch (MySqlException)
            {

                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    }

