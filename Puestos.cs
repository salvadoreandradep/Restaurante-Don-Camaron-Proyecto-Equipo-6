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
    public partial class Puestos : Form
    {

        public string cadena_conexion = @"Database=empleados;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5";
        public Puestos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Puestos_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "select * from puesto";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "puesto");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "puesto";
            }
            catch (MySqlException)
            {

                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Modificado el dato en la tabla Puestos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Creado el dato en la tabla Puestos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
            string myInsertQuery = "INSERT INTO Puesto(Nombre,Apellido,DUI, Correo,Genero,Puesto) Values(?Nombre, ?Apellido, ?DUI, ?Correo, ?Genero, ?Puesto";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

            myCommand.Parameters.Add("?Nombre", MySqlDbType.VarChar, 50).Value = txtnombre.Text;
            myCommand.Parameters.Add("?Apellido", MySqlDbType.VarChar, 50).Value = txtapellido.Text;
            myCommand.Parameters.Add("?DUI", MySqlDbType.VarChar, 50).Value = txtdui.Text;
            myCommand.Parameters.Add("?Correo", MySqlDbType.VarChar, 50).Value = txtcorreo.Text;
            myCommand.Parameters.Add("?Genero", MySqlDbType.VarChar, 50).Value = txtgenero.Text;
            myCommand.Parameters.Add("?Puesto", MySqlDbType.VarChar, 50).Value = txtpuesto.Text;

            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            MessageBox.Show("Producto agregado con éxito", "Ok", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            string consulta = "select * from Puesto";

            MySqlConnection conexion = new MySqlConnection(cadena_conexion);
            MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
            System.Data.DataSet ds = new System.Data.DataSet();
            comando.Fill(ds, "empleados");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "empleados";



            MessageBox.Show("Se ha guardado el dato en la tabla Puestos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Eliminado el dato en la tabla Puestos");
        }
    }
}
