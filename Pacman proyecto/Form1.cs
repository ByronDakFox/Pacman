using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_proyecto
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
            Bitmap imag = new Bitmap(Application.StartupPath + @"\res\maxresdefault.jpg");
            this.BackgroundImage = imag;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public String jugador = "";
        private void button1_Move(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
            }
            catch (Exception x) { }      

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                OPCION m = new OPCION();
                m.lblJugador.Text = txtJugador.Text;
                this.Hide();
                m.ShowDialog();

            }
            lblPorce.Text = progressBar1.Value + "%";
        }
    }
}
