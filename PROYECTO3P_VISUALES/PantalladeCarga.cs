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
    public partial class PantalladeCarga : Form
    {
        public PantalladeCarga()
        {
            InitializeComponent();
            tiempo();
        }

        public async void tiempo()
        {
            Task otask = new Task(Algo);
            otask.Start();
            await otask;
            hide();
        }

        public void Algo()
        {
            Thread.Sleep(7500);
        }

        public void hide()
        {
            if (pictureBox1 != null)
            {
                this.Hide();
                Form1 home = new Form1();
                home.Show();
            }
        }

    }
}
