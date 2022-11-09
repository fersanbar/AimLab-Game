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
    public partial class Inventario : Form
    {
        ConsultasSQL consulta = new ConsultasSQL();
        Gerente gerente = new Gerente();
        VentasDesc desc = new VentasDesc();
        inventarioSQL misconsultas = new inventarioSQL();
        public Inventario()
        {
            InitializeComponent();
            dataGridView2.Visible = false;
        }
        public int inv;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (inv == 2)
            {
                Application.Exit();
            }
            else
            {
                Gerente gerente = new Gerente();
                gerente.lblfoto.ImageIndex = 1;
                gerente.c = 1;
                gerente.txtNombre.Text = "Inventario";
                this.Hide();
                gerente.Show();
            }          
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = misconsultas.selectProductos();
            dataGridView2.DataSource = desc.selectPocos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agregar_Producto producto = new Agregar_Producto();
            producto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarProducto producto = new EliminarProducto();
            producto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificar_Producto producto = new Modificar_Producto();
            producto.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
            }
            if (checkBox5.Checked)
            {
                dataGridView1.DataSource = misconsultas.selectAlfabetica();
            }
            else
            {
                dataGridView1.DataSource = desc.selectNoAlfa();
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                dataGridView1.DataSource = misconsultas.selectProductos();
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                checkBox4.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                checkBox4.Enabled = true;
            }
            if (checkBox5.Checked)
            {
                dataGridView1.DataSource = misconsultas.selectPrecio();
            }
            else
            {
                dataGridView1.DataSource = desc.selectPrecio();
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                dataGridView1.DataSource = misconsultas.selectProductos();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
            }
            if (checkBox5.Checked)
            {
                dataGridView1.DataSource = misconsultas.selectExistencia();
            }
            else
            {
                dataGridView1.DataSource = desc.selectExistencia();
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                dataGridView1.DataSource = misconsultas.selectProductos();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox4.Enabled = false;
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox4.Enabled = true;
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
            }
            if (checkBox5.Checked)
            {
                dataGridView1.DataSource = misconsultas.selectVentas();
            }
            else
            {
                dataGridView1.DataSource = desc.selectVentas();
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                dataGridView1.DataSource = misconsultas.selectProductos();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox5.Checked)
            {
                checkBox5.Text = "De Menor a Mayor";
                dataGridView1.DataSource = misconsultas.selectAlfabetica();
            }
            if (checkBox5.Checked && checkBox2.Checked)
            {
                dataGridView1.DataSource = misconsultas.selectVentas();
            }
            if (checkBox5.Checked && checkBox3.Checked)
            {
                dataGridView1.DataSource = misconsultas.selectPrecio();
            }
            if (checkBox5.Checked && checkBox4.Checked)
            {
                dataGridView1.DataSource = misconsultas.selectExistencia();
            }
            if (checkBox5.Checked)
            {
                checkBox5.Text = "De Menor a Mayor";
            }
            else
            {
                checkBox5.Text = "De Mayor a Menor";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;

            }
            else
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
            }
        }
    }
}
