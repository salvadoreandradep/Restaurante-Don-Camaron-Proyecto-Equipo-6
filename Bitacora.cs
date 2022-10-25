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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
            string myInsertQuery = "INSERT INTO bitacora(Fecha,Tarea,Operario, Descripcion,Observaciones,Aprobacion) Values(?Fecha, ?Tarea, ?Operario, ?Descripcion, ?Observaciones, ?Aprobacion)";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

            myCommand.Parameters.Add("?Fecha", MySqlDbType.VarChar, 50).Value = txtfecha.Text;
            myCommand.Parameters.Add("?Tarea", MySqlDbType.VarChar, 50).Value = txttarea.Text;
            myCommand.Parameters.Add("?Operario", MySqlDbType.VarChar, 50).Value = txtoperario.Text;
            myCommand.Parameters.Add("?Descripcion", MySqlDbType.VarChar, 50).Value = txtdescrip.Text;
            myCommand.Parameters.Add("?Observaciones", MySqlDbType.VarChar, 50).Value = txtobs.Text;
            myCommand.Parameters.Add("?Aprobacion", MySqlDbType.VarChar, 50).Value = txtapro.Text;

            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            MessageBox.Show("Producto agregado con éxito", "Ok", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            string consulta = "select * from bitacora";

            MySqlConnection conexion = new MySqlConnection(cadena_conexion);
            MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
            System.Data.DataSet ds = new System.Data.DataSet();
            comando.Fill(ds, "empleados");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "empleados";



            MessageBox.Show("Se ha Guardado el dato en la tabla Bitacora");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Modificado el dato la tabla Bitacora");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "";
                if (myConnectionString == "")
                {
                    myConnectionString = @"Database=empleados;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5"; ;
                }
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string myInsertQuery = "DELETE FROM bitacora WHERE `bitacora`.`Codigo` = " + txtid.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();



                string cad = @"Database=empleados;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5";
                string query = "select * from bitacora";
                MySqlConnection cnn = new MySqlConnection(cad);
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "empleados");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "empleados";
            }
            catch (System.Exception)
            {
                MessageBox.Show("No se ha podido hacer la eliminacion");

            }
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
