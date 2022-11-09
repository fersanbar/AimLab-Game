using System;
using PROYECTO3P_VISUALES.Assets;
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
    public partial class AgregarUsuario : Form
    {
        UsuariosSQL consulta = new UsuariosSQL();
        public AgregarUsuario()
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
            Usuarios user = new Usuarios();
            user.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Text = "Vendedor";
            }
            else
            {
                checkBox2.Text = "Logistica";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string user = txtusuario.Text;
            string contraseña = txtContraseña.Text;
            if (nombre == "" && user == "" && contraseña == "")
            {
                MessageBox.Show("Ingrese los datos para continuar");
                return;
            }
            if (nombre == "")
            {
                MessageBox.Show("Ingrese todos los datos para continuar");
                return;
            }
            if (user == "")
            {
                MessageBox.Show("Ingrese todos los datos para continuar");
                return;
            }
            if (contraseña == "")
            {
                MessageBox.Show("Ingrese todos los datos para continuar");
                return;
            }
            if (checkBox2.Checked)
            {
                if (this.consulta.nuevoUsuarioVendedor(nombre, user, contraseña))
                {
                    MessageBox.Show("Cuenta creada con exito");
                    this.Hide();
                    Usuarios home = new Usuarios();
                    home.Show();
                }
            }
            else
            {
                if (this.consulta.nuevoUsuarioLogistica(nombre, user, contraseña))
                {
                    MessageBox.Show("Cuenta creada con exito");
                    this.Hide();
                    Usuarios home = new Usuarios();
                    home.Show();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
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
            string text = txtContraseña.Text;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.Text = text;
        }

        private void txtusuario_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtusuario.Text = "";
        }

        private void txtContraseña_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtContraseña.Text = "";
            string text = txtContraseña.Text;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.Text = text;
        }
    }
}
