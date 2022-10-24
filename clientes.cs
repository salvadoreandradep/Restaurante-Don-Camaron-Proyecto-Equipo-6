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


    public partial class clientes : Form
    {
        public string cadena_conexion = @"Database=empleados;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5";

        public clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clientes_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "select * from clientes";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "clientes");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "clientes";
            }
            catch (MySqlException)
            {

                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Creado el dato en la tabla Clientes");
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha guardado el dato en la tabla Clientes");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Modificado el dato en la tabla Clientes");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Eliminado el dato en la tabla Clientes");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
