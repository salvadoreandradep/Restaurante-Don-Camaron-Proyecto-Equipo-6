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
    public partial class Productos : Form
    {


        public string cadena_conexion = @"Database=login;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5";
        public Productos()
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


        private void button1_Click(object sender, EventArgs e)
        {
            txtnombre.Visible = true;
            txtdis.Visible = true;
            txtdes.Visible = true;
            txtid.Visible = true;

            button2.Visible = true;



            MessageBox.Show("Ya puedes crear un nuevo registro");
        }





        private void button2_Click_1(object sender, EventArgs e)
        {

            MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
            string myInsertQuery = "INSERT INTO combos(Nombre,Distribuidor,Disponibles) Values(?Nombre,?Distribuidor,?Disponibles)";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

            myCommand.Parameters.Add("?Nombre", MySqlDbType.VarChar, 40).Value = txtnombre.Text;
            myCommand.Parameters.Add("?Distribuidor", MySqlDbType.VarChar, 45).Value = txtdis.Text;
            myCommand.Parameters.Add("?Disponibles", MySqlDbType.VarChar, 50).Value = txtdes.Text;

            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            MessageBox.Show("Producto agregado con éxito", "Ok", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            string consulta = "select * from combos";

            MySqlConnection conexion = new MySqlConnection(cadena_conexion);
            MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
            System.Data.DataSet ds = new System.Data.DataSet();
            comando.Fill(ds, "login");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "login";


            MessageBox.Show("Se ha guardado el dato en la tabla Productos");

        }


    










        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "";
                if (myConnectionString == "")
                {
                    myConnectionString = @"Database = login; Data Source = localhost; User Id = AndradePeña; Password = Huaweiz5";} 
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                    string myInsertQuery = "UPDATE `combos` SET `Nombre` = "+ txtnombre + "`Distribuidor` = "+ txtdis + " `Disponibles` =" + txtdes + " WHERE `combos`.`Codigo` ="+ txtid + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
              

                myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();
           

                string cad = @"Database=login;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5";
                string query = "select * from combos";
                MySqlConnection cnn = new MySqlConnection(cad);
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "login");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "login";
            }
            catch (System.Exception)
            {

               
            }

            MessageBox.Show("Se ha Modificado el dato en la tabla Productos");

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            try
            {
                string myConnectionString = "";
                if (myConnectionString == "")
                {
                    myConnectionString = @"Database=login;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5"; ;
                }
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string myInsertQuery = "DELETE FROM combos WHERE `combos`.`Codigo` = " + txtid.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();



                string cad = @"Database=login;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5";
                string query = "select * from combos";
                MySqlConnection cnn = new MySqlConnection(cad);
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "login");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "login";
            }
            catch (System.Exception)
            {
                MessageBox.Show("No se ha podido hacer la eliminacion");

            }



        }
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

