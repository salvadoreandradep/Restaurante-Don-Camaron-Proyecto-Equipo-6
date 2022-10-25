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
    public partial class Pedidos : Form
    {
        public string cadena_conexion = @"Database=empleados;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5";
        public Pedidos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "select * from pedidos";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "pedidos");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "pedidos";
            }
            catch (MySqlException)
            {

                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Creado el dato en la tabla Pedidos");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha modificado el dato en la tabla Pedidos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Eliminado el dato en la tabla Pedidos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
            string myInsertQuery = "INSERT INTO clientes(Nombre,Apellido,Dui, Fecha_de_Nacimiento ,Telefono,Direccion) Values(?Nombre, ?Apellido, ?Dui, ?Fecha_de_Nacimiento, ?Telefono, ?Direccion";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

            myCommand.Parameters.Add("?Nombre", MySqlDbType.VarChar, 50).Value = txtnombre.Text;
            myCommand.Parameters.Add("?Apellido", MySqlDbType.VarChar, 50).Value = txtapellido.Text;
            myCommand.Parameters.Add("?Dui", MySqlDbType.VarChar, 50).Value = txtproducto.Text;
            myCommand.Parameters.Add("?Fecha_de_Nacimiento", MySqlDbType.VarChar, 50).Value = txtcanti.Text;
            myCommand.Parameters.Add("?Telefono", MySqlDbType.VarChar, 50).Value = txtordent.Text;
            

            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            MessageBox.Show("Producto agregado con éxito", "Ok", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            string consulta = "select * from clientes";

            MySqlConnection conexion = new MySqlConnection(cadena_conexion);
            MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
            System.Data.DataSet ds = new System.Data.DataSet();
            comando.Fill(ds, "empleados");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "empleados";



        

            MessageBox.Show("Se ha Guardado el dato en la tabla Pedidos");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
