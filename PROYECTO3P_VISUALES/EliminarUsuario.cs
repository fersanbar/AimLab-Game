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
    public partial class EliminarUsuario : Form
    {
        UsuariosSQL consulta = new UsuariosSQL();
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtNombre.Text;
            if (this.consulta.eliminarCuentaVendedor(user))
            {
                MessageBox.Show("Cuenta eliminada con exito");
                this.Hide();
                Usuarios usuario = new Usuarios();
                usuario.Show();
            }
            else
            {
                if (this.consulta.eliminarCuentaLogistica(user))
                {
                    MessageBox.Show("Cuenta eliminada con exito");
                    this.Hide();
                    Usuarios back = new Usuarios();
                    back.Show();
                }
                else
                {
                    MessageBox.Show("No se encontro la cuenta");
                }
            }
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
    }
}
