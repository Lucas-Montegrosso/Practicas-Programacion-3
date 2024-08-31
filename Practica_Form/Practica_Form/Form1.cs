using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Form
{
    public partial class Practica1 : Form
    {
        public Practica1()
        {
            InitializeComponent();
        }

        private void Practica1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void Practica1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Gracias por utilizar nuestra app...");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atencion");
            // this.BackColor = Color.SeaGreen;
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void Practica1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presionó el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presionó el botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presionó el botón del Medio", "Atención");
            {
                
            }
        }

        private void lbFormulario_MouseMove(object sender, MouseEventArgs e)
        {
            lbFormulario.BackColor = Color.Red;
            lbFormulario.Cursor = Cursors.Hand;
          
        }

        private void lbFormulario_MouseLeave(object sender, EventArgs e)
        {
            lbFormulario.BackColor = System.Drawing.SystemColors.Control;
            lbFormulario.Cursor = Cursors.Arrow;
        
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
