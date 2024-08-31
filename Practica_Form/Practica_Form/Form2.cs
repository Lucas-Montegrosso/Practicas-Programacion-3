using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese los datos solicitados por favor");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbApellido.Text == "")
                tbApellido.BackColor = Color.Red;
            else tbApellido.BackColor = Color.YellowGreen;

            if (tbNombre.Text == "")
                tbNombre.BackColor = Color.Red;
            else tbNombre.BackColor = Color.YellowGreen;

            if (tbEdad.Text == "")
                tbEdad.BackColor = Color.Red;
            else tbEdad.BackColor = Color.YellowGreen;

            if (tbDomicilio.Text == "")
                tbDomicilio.BackColor = Color.Red;
            else tbDomicilio.BackColor = Color.YellowGreen;

            string apellido = tbApellido.Text;
            lvResultado.Items.Add("Apellido: " + apellido);
            string nombre = tbNombre.Text;
            lvResultado.Items.Add("Nombre: " + nombre);
            string edad = tbEdad.Text;
            lvResultado.Items.Add("Edad: " + edad);
            string domicilio = tbDomicilio.Text;
            lvResultado.Items.Add("Domicilio: " + domicilio);


        }

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
