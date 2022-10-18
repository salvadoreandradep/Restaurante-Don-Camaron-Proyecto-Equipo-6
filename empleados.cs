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
    public partial class empleados : Form
    {

        public string cadena_conexion = @"Database=empleados;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5";
        public empleados()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void empleados_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "select * from empleados";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "empleados");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "empleados";
            }
            catch (MySqlException)
            {

                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
