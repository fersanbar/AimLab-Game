using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO3P_VISUALES
{
    public partial class Agregar_Producto : Form
    {
        inventarioSQL consulta = new inventarioSQL();
        public Agregar_Producto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario user = new Inventario();
            user.Show();
        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombre.Text = "";
        }

        private void txtusuario_MouseClick(object sender, MouseEventArgs e)
        {
            txtusuario.Text = "";
        }

        private void txtContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            txtContraseña.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double precio = double.Parse(txtusuario.Text);
            int existencia = int.Parse(txtContraseña.Text);
            if (nombre == "" && precio == 0 && existencia == 0)
            {
                MessageBox.Show("Ingrese los datos para continuar");
                return;
            }
            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre para continuar");
                return;
            }
            if (precio == 0)
            {
                MessageBox.Show("Ingrese el precio para continuar");
                return;
            }
            if (existencia == 0)
            {
                MessageBox.Show("Ingrese la existencia para continuar");
                return;
            }
            try
            {
                precio = double.Parse(txtusuario.Text);
            }
            catch
            {
                MessageBox.Show("El precio que ingreso no es valido");
                return;
            }
            try
            {
                existencia = int.Parse(txtContraseña.Text);
            }
            catch
            {
                MessageBox.Show("Unicamente son aceptados numeros enteros");
                return;
            }
            if (this.consulta.nuevoProducto(nombre, precio, existencia))
            {
                MessageBox.Show("Producto Agregado con exito");
                this.Hide();
                Inventario home = new Inventario();
                home.Show();
            }
        }
    }
}
