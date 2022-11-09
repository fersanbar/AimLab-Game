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
    public partial class Modificar_Producto : Form
    {
        inventarioSQL datos = new inventarioSQL();
        public Modificar_Producto()
        {
            InitializeComponent();
            textBox1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Inventario gerente = new Inventario();
            gerente.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombre.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtusuario.Text = "INGRESE EL NUEVO PRECIO";
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox1.Visible = true;
                txtusuario.Text = "INGRESE EL NUEVO PRECIO";
                textBox1.Text = "INGRESE LA NUEVA EXISTENCIA";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtusuario.Text = "INGRESE LA NUEVA EXISTENCIA";
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox1.Visible = true;
                txtusuario.Text = "INGRESE EL NUEVO PRECIO";
                textBox1.Text = "INGRESE LA NUEVA EXISTENCIA";
            }
        }

        private void txtusuario_MouseClick(object sender, MouseEventArgs e)
        {
            txtusuario.Text = "";
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (checkBox1.Checked && checkBox2.Checked == false)
            {
                string precio = txtusuario.Text;
                if ( precio == "")
                {
                    MessageBox.Show("Ingrese el precio para continuar");
                    return;
                }

                else
                {
                    double preciofinal;
                    try
                    {
                        preciofinal = double.Parse(precio);
                    }
                    catch
                    {
                        MessageBox.Show("Unicamente son aceptados numeros para el precio");
                        return;
                    }
                    if (this.datos.actualizarPrecio(preciofinal, nombre))
                    {
                        MessageBox.Show("El precio se actualizo con exito");
                        this.Hide();
                        Inventario home = new Inventario();
                        home.Show();
                    }
                }
            }
            else
            {
                if (checkBox2.Checked && checkBox1.Checked == false)
                {
                    string existencia = txtusuario.Text;
                    if (existencia == "")
                    {
                        MessageBox.Show("Ingrese la existencia para continuar");
                        return;
                    }
                    else
                    {
                        int existenciafinal = int.Parse(existencia);
                        try
                        {
                            existenciafinal = int.Parse(existencia);
                        }
                        catch
                        {
                            MessageBox.Show("Unicamente son aceptados numeros enteros para la existencia");
                            return;
                        }
                        if (this.datos.actualizarExistencia(existenciafinal, nombre))
                        {
                            MessageBox.Show("La existencia se actualizo con exito");
                            this.Hide();
                            Inventario home = new Inventario();
                            home.Show();
                        }
                    }
                }
                else
                {
                    if (checkBox1.Checked == true && checkBox2.Checked == true)
                    {
                        string existencia = textBox1.Text;
                        string precio = txtusuario.Text;
                        if (existencia == "" && precio == "")
                        {
                            MessageBox.Show("Ingrese todos los datos para continuar");
                            return;
                        }
                        if (existencia == "")
                        {
                            MessageBox.Show("Ingrese la existencia para continuar");
                            return;
                        }
                        if (precio == "")
                        {
                            MessageBox.Show("Ingrese el precio para continuar");
                            return;
                        }

                        double preciofinal = int.Parse(precio);
                        int existenciafinal = int.Parse(existencia);
                        try
                        {
                            existenciafinal = int.Parse(existencia);
                        }
                        catch
                        {
                            MessageBox.Show("Unicamente son aceptados numeros enteros para la existencia");
                            return;
                        }
                        try
                        {
                            preciofinal = double.Parse(precio);
                        }
                        catch
                        {
                            MessageBox.Show("Unicamente son aceptados numeros para el precio");
                            return;
                        }
                        if (this.datos.actualizarAmbos(existenciafinal, preciofinal, nombre))
                        {
                            MessageBox.Show("Los datos se actualizaron con exito");
                            this.Hide();
                            Inventario home = new Inventario();
                            home.Show();
                        }
                    }
                }
            }
        }
    }
}
