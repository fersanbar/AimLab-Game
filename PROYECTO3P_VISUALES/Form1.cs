using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PROYECTO3P_VISUALES
{
    public partial class Form1 : Form
    {
        Gerente gerente = new Gerente();
        ConsultasSQL consulta = new ConsultasSQL();
        public string user;
        public string pass;

        public Form1()
        {
            InitializeComponent();
        }


        private void txtContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            txtContraseña.Text = "";
            string text = txtContraseña.Text;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.Text = text;
        }

        private void txtusuario_MouseEnter(object sender, EventArgs e)
        {
            txtusuario.Text = "";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            user = txtusuario.Text;
            pass = txtContraseña.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Ingresa todos los datos para continuar");
                return;
            }
            if (consulta.ingresa_gerente(user, pass))
            {
                this.Hide();
                gerente.lblfoto.ImageIndex = 0;
                gerente.txtNombre.Text = "Usuarios";
                gerente.c = 0;
                gerente.Show();
            }
            else
            {
                if (consulta.ingresa_logistica(user, pass))
                {
                    this.Hide();
                    Inventario inventario = new Inventario();
                    inventario.inv = 2;
                    inventario.Show();
                }
                else
                {
                    if (consulta.ingresa_vendedor(user, pass))
                    {
                        this.Hide();
                        Ventas ventas = new Ventas();
                        ventas.d = 3;
                        ventas.Show();
                    }
                    else
                    {
                        MessageBox.Show("La cuenta que escribio no existe");
                        return;
                    }
                }
            }
        }
    }
}
