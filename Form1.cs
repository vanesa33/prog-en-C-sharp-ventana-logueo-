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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if(txtid.Text == "lwt" && txtcontra.Text == "123")
            {
                //MessageBox.Show("Se ha iniciado sesión");
                this.Hide(); //para ocultar el formulario 

                //creo una instancia para llamar al formulario 2
                ventana2 nuevaventana = new ventana2();

                nuevaventana.Show();


            }
            else
            {
                MessageBox.Show("Error en el id o la contraseña");

            txtid.Text=" ";
            txtcontra.Text =" ";

                txtcontra.Clear();

                txtid.Focus();


            }
        }
    }
}
