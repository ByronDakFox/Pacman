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
    public partial class OPCION : Form
    {
        public OPCION()
        {
            InitializeComponent();
            Bitmap imag = new Bitmap(Application.StartupPath + @"\res\pac-man.jpg");
            this.BackgroundImage = imag;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                PACMAN j = new PACMAN();
                j.label3.Text = lblJugador.Text;
                this.Hide();
                j.ShowDialog();
            }
            catch(Exception x) { }           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
