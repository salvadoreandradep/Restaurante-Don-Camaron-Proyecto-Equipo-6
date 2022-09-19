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

namespace Semena_6___Parcial_1
{
    public partial class usuario : Form
    {

        public OleDbConnection miconexion;

        public string usuario_modificar;
        public usuario()
        {

            miconexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\salva\OneDrive\Escritorio\basededatosaccess\Database1.mdb");
            InitializeComponent();
        }

        private void usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.dataSet1.usuarios);
            this.usuariosTableAdapter.Fill(this.DataSet1.usuarios);
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbCommand guardar = new OleDbCommand();
                miconexion.Open();
                guardar.Connection = miconexion;
                guardar.CommandType = CommandType.Text;

                guardar.CommandText = "INSERT INTO tusuario ([nombre], [clave],[nivel]) Values('" + txtusu.Text.ToString() + "', '" + 
txtclave.Text.ToString() + "','" + txtnivel.Text.ToString() + "')";

                guardar.ExecuteNonQuery();
                miconexion.Close();

                bnuevo.Visible = true;
                bguardar.Visible = false;

                 
                txtusu.Enabled = false;
                txtclave.Enabled = false;
                txtnivel.Enabled = false;
                bnuevo.Focus();

                
                MessageBox.Show("Usuario agregado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tusuarioTableAdapter.Fill(this.sistemaDataSer.tusuario);
                this.tusuarioBindingSource.MoveLast();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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

                actualizar.CommandText = "UPDATE tusuario SET nombre = '" + nom + "', clave = '" + cla + "',nivel = '" + niv + "' WHERE nombre = '" + usuario_modificar + "'";

              

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

                    eliminar.CommandText = "DELETE FROM tusuario WHERE nombre = '" +
                    txtusu.Text.ToString() + "'";

                    eliminar.ExecuteNonQuery();
                    this.tusuarioBindingSource.MoveNext();
                    miconexion.Close();

                    //Mensaje que se guardó correctamente 
                    MessageBox.Show("Usuario eliminado con éxito", "Ok",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);  
                    this.tusuarioBindingSource.MovePrevious();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void banterior_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MovePrevious();
        }
    }
}
