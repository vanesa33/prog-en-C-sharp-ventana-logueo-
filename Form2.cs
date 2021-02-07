using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventanalogin
{
    public partial class ventana2 : Form
    {
        public ventana2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string seleccion;
            if(checkBox1.Checked == true)
            {
                cont ++;
            }

            if(checkBox2.Checked == true)
            {
                cont++;
            }

            if(radioButton1.Checked == true)
            {
                seleccion = "tarjeta de credito";

            }
            else
            {
                seleccion = "paypal";
            }
            
            MessageBox.Show("ha seleccionado " + cont + "cursos y el metodo de pago es: " + seleccion);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ventanalogin = new Form1();


            ventanalogin.Show();

        }
    }
}
