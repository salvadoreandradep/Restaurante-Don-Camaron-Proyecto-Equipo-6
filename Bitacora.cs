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
    public partial class Bitacora : Form
    {

        public string cadena_conexion = @"Database=empleados;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5";
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

        private void Bitacora_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "select * from bitacora";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "bitacora");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "bitacora";
            }
            catch (MySqlException)
            {

                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
