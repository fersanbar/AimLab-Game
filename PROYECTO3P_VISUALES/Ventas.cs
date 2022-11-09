using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO3P_VISUALES.Assets;


namespace PROYECTO3P_VISUALES
{
    public partial class Ventas : Form
    {
        VentasSQL misconsultas = new VentasSQL();
        ConsultasSQL consulta = new ConsultasSQL();
        Form1 cuenta = new Form1();
        public Ventas()
        {

            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            panel4.Visible = false;


        }
        DataTable datos;
        public int d;
        int cantidad = 0;
        double total = 0;
        int sabritasinventario;
        int cocainventario;
        int doritosinventario;
        int fritosinventario;
        int spriteinventario;
        int ventasabritas;
        int ventacoca;
        int doritosventa;
        int fritosventa;
        int spriteventa;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 ventas = new Form1();
            if (d == 3)
            {
                misconsultas.ventaSabritas(ventasabritas);
                misconsultas.ventaCoca(ventacoca);
                misconsultas.ventaSprite(spriteventa);
                misconsultas.ventaFritos(fritosventa);
                misconsultas.ventaDoritos(doritosventa);
                Application.Exit();
            }
            else
            {
                misconsultas.ventaSabritas(ventasabritas);
                misconsultas.ventaCoca(ventacoca);
                misconsultas.ventaSprite(spriteventa);
                misconsultas.ventaFritos(fritosventa);
                misconsultas.ventaDoritos(doritosventa);
                Gerente gerente = new Gerente();
                gerente.lblfoto.ImageIndex = 2;
                gerente.c = 2;
                gerente.txtNombre.Text = "Ventas";
                this.Hide();
                gerente.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    Sabritas();
                    break;
                case 2:
                    CocaCola();
                    break;
                case 3:
                    Doritos();
                    break;
                case 4:
                    Fritos();
                    break;
                case 5:
                    Sprite();
                    break;
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            datos = new DataTable();
            datos.Columns.Clear();
            datos.Columns.Add("Cantidad");
            datos.Columns.Add("Producto");
            datos.Columns.Add("Precio Unitario");
            datos.Columns.Add("Precio Final");
            dataGridView1.DataSource = datos;
        }

        public void Sabritas()
        {
            lblNombre.Text = "Sabritas";
            lblPrecio.Text = misconsultas.precioSabritas().ToString();
            sabritasinventario = misconsultas.inventarioSabritas();
            this.lblInventario.Text = sabritasinventario.ToString();
        }
        public void CocaCola()
        {
            cocainventario = misconsultas.inventarioCoca();
            lblNombre.Text = "Coca Cola";
            lblPrecio.Text = misconsultas.precioCoca().ToString();
            this.lblInventario.Text = cocainventario.ToString();
        }
        public void Doritos()
        {
            lblNombre.Text = "Doritos";
            lblPrecio.Text = misconsultas.precioDoritos().ToString();
            this.lblInventario.Text = misconsultas.inventarioDoritos().ToString();
        }
        public void Fritos()
        {
            lblNombre.Text = "Fritos";
            lblPrecio.Text = misconsultas.precioFritos().ToString();
            this.lblInventario.Text = misconsultas.inventarioFritos().ToString();
        }
        public void Sprite()
        {
            lblNombre.Text = "Sprite";
            lblPrecio.Text = misconsultas.precioSprite().ToString();
            this.lblInventario.Text = misconsultas.inventarioSprite().ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sabritasinventario = misconsultas.inventarioSabritas();
            cocainventario = misconsultas.inventarioCoca();
            doritosinventario = misconsultas.inventarioDoritos();
            fritosinventario = misconsultas.inventarioFritos();
            spriteinventario = misconsultas.inventarioSprite();
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Ingresa los datos para continuar");
                return;
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingresa la cantidad para continuar");
                return;
            }
            string nombre = lblNombre.Text;
            cantidad = int.Parse(txtCantidad.Text);
            lblTotal.Text = total.ToString();
            if (comboBox1.SelectedIndex == 1)
            {
                sabritasinventario = sabritasinventario - cantidad;
                ventasabritas = ventasabritas + cantidad;
                if (this.misconsultas.modificarSabritas(sabritasinventario))
                {
                    if (sabritasinventario < 0)
                    {
                        sabritasinventario = sabritasinventario + cantidad;
                        MessageBox.Show("No hay suficientes sabritas, para completar la orden");
                        return;
                    }
                }
            }
            else
            {
                if (comboBox1.SelectedIndex == 2)
                {
                    cocainventario = cocainventario - cantidad;
                    ventacoca = ventacoca + cantidad;
                    if (this.misconsultas.modificarCoca(cocainventario))
                    {
                        if (cocainventario < 0)
                        {
                            cocainventario = cocainventario + cantidad;
                            MessageBox.Show("No hay suficientes cocas, para completar la orden");
                            return;
                        }
                    }
                }
                else
                {
                    if (comboBox1.SelectedIndex == 3)
                    {
                        doritosinventario = doritosinventario - cantidad;
                        doritosventa = doritosventa + cantidad;
                        if (this.misconsultas.modificarDoritos(doritosinventario))
                        {
                            if (doritosinventario < 0)
                            {
                                doritosinventario = doritosinventario + cantidad;
                                MessageBox.Show("No hay suficientes doritos, para completar la orden");
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (comboBox1.SelectedIndex == 4)
                        {
                            fritosinventario = fritosinventario - cantidad;
                            fritosventa = fritosventa + cantidad;
                            if (this.misconsultas.modificarFritos(fritosinventario))
                            {
                                if (fritosinventario < 0)
                                {
                                    fritosinventario = fritosinventario + cantidad;
                                    MessageBox.Show("No hay suficientes fritos, para completar la orden");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            if (comboBox1.SelectedIndex == 5)
                            {
                                spriteinventario = spriteinventario - cantidad;
                                spriteventa = spriteventa + cantidad;
                                if (misconsultas.modificarSprite(spriteinventario))
                                {
                                    if (spriteinventario < 0)
                                    {
                                        spriteinventario = spriteinventario + cantidad;
                                        MessageBox.Show("No hay suficiente sprite, para completar la orden");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            DataRow row = datos.NewRow();
            row["Cantidad"] = cantidad;
            row["Producto"] = lblNombre.Text;
            row["Precio Unitario"] = lblPrecio.Text;
            row["Precio Final"] = double.Parse(lblPrecio.Text) * cantidad;
            datos.Rows.Add(row);
            total += Convert.ToDouble(row["Precio Final"].ToString());
            lblTotal.Text = "$ " + total.ToString();
            comboBox1.SelectedIndex = 0;
            txtCantidad.Text = "";
            lblNombre.Text = "";
            lblPrecio.Text = "";
            lblInventario.Text = "";

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            txtSubtotal.Text = "$ " + total.ToString();
            txtTotal.Text = "$ " + total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double recibido;
            recibido = double.Parse(txtRecibido.Text);
            if (recibido < total )
            {
                MessageBox.Show("El importe que ingreso es menor al total de la cuenta");
                return;
            }
            else
            {
                double cambio;
                cambio = double.Parse(txtRecibido.Text) - total;
                txtCambio.Text = "$ " + cambio.ToString();

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            misconsultas.ventaSabritas(ventasabritas);
            misconsultas.ventaCoca(ventacoca);
            misconsultas.ventaSprite(spriteventa);
            misconsultas.ventaFritos(fritosventa);
            misconsultas.ventaDoritos(doritosventa);
            MessageBox.Show("Su compra se realizo con exito");

            comboBox1.SelectedIndex = 0;
            total = 0;
            lblTotal.Text = "";
            txtCantidad.Text = "";
            lblNombre.Text = "";
            lblPrecio.Text = "";
            lblInventario.Text = "";
            panel4.Visible = false;
            datos.Rows.Clear();
            txtCambio.Text = "";
            txtRecibido.Text = "";
            txtSubtotal.Text = "0";
        }
    }
}
