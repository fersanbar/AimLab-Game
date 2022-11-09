using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO3P_VISUALES.Assets
{
    public partial class Usuarios : Form
    {
        UsuariosSQL consulta = new UsuariosSQL();
        public Usuarios()
        {
            InitializeComponent();
            mostrarDatos();
        }

        public void mostrarDatos()
        {
            dataGridView1.DataSource = consulta.selectLogistica();
            dataGridView2.DataSource = consulta.selectVendedor();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarUsuario gerente = new AgregarUsuario();
            gerente.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Gerente gerente = new Gerente();
            gerente.lblfoto.ImageIndex = 0;
            gerente.c = 0;
            gerente.txtNombre.Text = "Usuarios";
            gerente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarUsuario gerente = new EliminarUsuario();
            gerente.Show();
        }
    }
}
