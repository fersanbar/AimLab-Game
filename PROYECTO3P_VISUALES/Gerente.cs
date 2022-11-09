using PROYECTO3P_VISUALES.Assets;
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
    public partial class Gerente : Form
    {
        public int c = 0;
        public Gerente()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (c < 2)
                {
                    c++;
                }
                else
                {
                    c = 0;
                }
                ImgChange(c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (c > 0)
                {
                    c--;
                }
                else
                {
                    c = 2;
                }
                ImgChange(c);
            }
        }

        public void ImgChange(int c)
        {
            switch (c)
            {
                case 0:
                    this.lblfoto.ImageIndex = c;
                    this.txtNombre.Text = "Usuarios";
                    break;
                case 1:
                    this.lblfoto.ImageIndex = c;
                    this.txtNombre.Text = "Inventario";
                    break;
                case 2:
                    this.lblfoto.ImageIndex = c;
                    txtNombre.Text = "Ventas";
                    break;
            }
        }

        private void lblfoto_Click(object sender, EventArgs e)
        {
            if (lblfoto.ImageIndex == 0)
            {
                this.Hide();
                Usuarios usuarios = new Usuarios();
                usuarios.Show();
            }
            else
            {
                if (lblfoto.ImageIndex == 1)
                {
                    this.Hide();
                    Inventario inventario = new Inventario();
                    inventario.Show();
                }
                else
                {
                    if (lblfoto.ImageIndex == 2)
                    {
                        this.Hide();
                        Ventas ventas = new Ventas();
                        ventas.Show();
                    }
                }
            }
        }
    }
}
