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
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Semena_6___Parcial_1
{
    public partial class usuario : Form
    {

        public OleDbConnection miconexion;

        public string usuario_modificar;

        public string cadena_conexion = @"Database=login;Data Source=localhost;User Id=AndradePeña;Password=Huaweiz5";
        public usuario()
        {
            
            miconexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\salva\OneDrive\Escritorio\basededatosaccess\Database1.mdb");
            InitializeComponent();
        }

        private void usuario_Load(object sender, EventArgs e)
        {

            this.usuariosTableAdapter.Fill(this.dataSet1.usuarios);

            txtusu.Enabled = false;
            txtclave.Enabled = false;
            txtnivel.Enabled = false;

            this.usuariosTableAdapter.Fill(this.dataSet1.usuarios);
            try
            {
                string consulta = "select * from usuario";
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

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "INSERT INTO usuario(usuario,clave,nivel) Values(?usuario,?clave,?nivel)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?nusuario", MySqlDbType.VarChar, 40).Value = txtusu.Text;
                myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 45).Value = txtclave.Text;
                myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 4).Value = txtnivel.Text;

                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                string consulta = "select * from usuario";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "login");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "login";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro 
            txtusu.Enabled = false;
            txtclave.Enabled = false;
            txtnivel.Enabled = false;
            bnuevo.Focus();

        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusu.Enabled = true;
            txtclave.Enabled = true;
            txtnivel.Enabled = true;
            txtusu.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtusu.Text.ToString();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand actualizar = new OleDbCommand();
                miconexion.Open();
                actualizar.Connection = miconexion;
                actualizar.CommandType = CommandType.Text;

                string nom = txtusu.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = txtnivel.Text;

                actualizar.CommandText = "UPDATE tusuario SET usuario = '" + nom + "', clave = '" + cla + "',nivel = '" + niv + "' WHERE usuario = '" + usuario_modificar + "'";

              

                actualizar.ExecuteNonQuery();
                miconexion.Close();

                bmodificar.Visible = true;
                bactualizar.Visible = false;

                txtusu.Enabled = false;
                txtclave.Enabled = false;
                txtnivel.Enabled = false;

           
                MessageBox.Show("Usuario actualizado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    OleDbCommand eliminar = new OleDbCommand();
                    miconexion.Open();
                    eliminar.Connection = miconexion;
                    eliminar.CommandType = CommandType.Text;

                    eliminar.CommandText = "DELETE FROM tusuario WHERE usuario = '" +
                    txtusu.Text.ToString() + "'";

                    eliminar.ExecuteNonQuery();
                    this.usuariosBindingSource.MoveNext();
                    miconexion.Close();

                  
                    MessageBox.Show("Usuario eliminado con éxito", "Ok",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.usuariosBindingSource.MovePrevious();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void banterior_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.MovePrevious();
        }

        private void bprimero_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.MoveFirst();
        }

        private void bsiguiente_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.MoveNext();
        }

        private void bultimo_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.MoveLast();
        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            bnuevo.Visible = false;
            bguardar.Visible = true;
            txtusu.Enabled = true;
            txtclave.Enabled = true;
            txtnivel.Enabled = true;
            txtusu.Text = "";
            txtclave.Text = "";
            txtnivel.Text = "Seleccione nivel";
            txtusu.Focus();
          
            
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            login ll = new login();
            ll.Show(); 
            this.Hide();
        }
    }
}
