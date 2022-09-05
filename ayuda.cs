using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Semena_6___Parcial_1
{
    public partial class ayuda : Form
    {
        public ayuda()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           


            StreamReader leer = new StreamReader(@"C:\Users\salva\Downloads");
            string Linea = "";

           
            try
            {
                Linea = leer.ReadLine();
                while (Linea != null)
                {
                    richTextBox1.AppendText(Linea + "\\n");
                    Linea = leer.ReadLine();
                }


            }

            catch

            {

                MessageBox.Show("Error");
            
            }



            
            txt2.Text = "";


            MessageBox.Show("Si Mensaje a sigo enviado.", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
