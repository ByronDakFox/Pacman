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
    public partial class PACMAN : Form
    {


        int x = 0;
        //variables de inicio
        bool arriba;
        bool abajo;
        bool dere;
        bool izq;
        int velo = 20;
        // variable fantasmas y pacman
        int fant1 = 11;
        int fant2 = 10;
        //fantasma loco
        int fant3 = 10;
        int fant4x = 8;
        int fant4y = 8;

        //puntaje
        int score = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Score: " + score;

            if (izq || pacm2.Bounds.IntersectsWith(pictureBox31.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox54.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox60.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox36.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox81.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox78.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox85.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox82.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox89.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox86.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox69.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox79.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox77.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox55.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox74.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox63.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox61.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox53.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox72.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox52.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox75.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox51.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox50.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox37.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox80.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox32.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox33.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox57.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox82.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox39.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox37.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox69.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox79.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox77.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox55.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox74.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox63.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox61.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox53.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox72.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox52.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox75.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox51.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox50.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox37.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox80.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox32.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox33.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox57.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox89.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox30.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox85.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox69.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox79.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox77.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox55.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox74.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox63.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox61.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox53.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox72.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox52.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox75.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox51.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox50.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox37.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox80.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox32.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox33.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox57.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox58.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox56.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox35.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox69.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox79.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox77.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox55.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox74.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox63.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox61.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox53.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox72.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox52.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox75.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox51.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox50.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox37.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox80.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox32.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox33.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox57.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox46.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox59.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox92.Bounds) || //45
                pacm2.Bounds.IntersectsWith(pictureBox48.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox44.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox47.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox34.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox45.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox42.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox43.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox41.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox38.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox40.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox29.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox106.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox90.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox94.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox67.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox90.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox94.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox92.Bounds) || //8
                pacm2.Bounds.IntersectsWith(pictureBox71.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox68.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox99.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox107.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox98.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox106.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox97.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox96.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox95.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox102.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox100.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox105.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox103.Bounds))
            {
                pacm2.Left -= velo;
            }
            if (dere || pacm2.Bounds.IntersectsWith(pictureBox31.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox31.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox54.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox60.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox36.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox81.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox78.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox85.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox82.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox89.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox86.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox69.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox79.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox77.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox55.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox74.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox63.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox61.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox53.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox72.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox52.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox75.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox51.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox50.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox37.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox80.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox32.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox33.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox57.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox82.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox39.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox37.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox69.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox79.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox77.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox55.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox74.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox63.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox61.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox53.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox72.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox52.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox75.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox51.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox50.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox37.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox80.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox32.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox33.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox57.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox89.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox30.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox85.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox69.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox79.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox77.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox55.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox74.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox63.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox61.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox53.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox72.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox52.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox75.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox51.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox50.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox37.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox80.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox32.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox33.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox57.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox58.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox56.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox35.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox69.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox79.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox77.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox55.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox74.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox63.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox61.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox53.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox72.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox52.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox75.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox51.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox50.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox37.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox80.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox32.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox33.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox57.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox34.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox59.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox67.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox46.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox59.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox93.Bounds) || //45
                pacm2.Bounds.IntersectsWith(pictureBox48.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox44.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox47.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox34.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox45.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox42.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox43.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox41.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox38.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox40.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox29.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox106.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox90.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox94.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox92.Bounds) || //8
                pacm2.Bounds.IntersectsWith(pictureBox71.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox68.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox99.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox107.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox98.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox106.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox97.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox96.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox95.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox102.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox100.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox105.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox103.Bounds))
            {
                pacm2.Left += velo;
            }

            if (arriba || pacm2.Bounds.IntersectsWith(pictureBox36.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox49.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox60.Bounds)
                || pacm2.Bounds.IntersectsWith(pictureBox59.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox93.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox69.Bounds)
                || pacm2.Bounds.IntersectsWith(pictureBox63.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox62.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox61.Bounds)
                || pacm2.Bounds.IntersectsWith(pictureBox81.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox78.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox14.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox13.Bounds)
                || pacm2.Bounds.IntersectsWith(pictureBox57.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox55.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox67.Bounds)
                || pacm2.Bounds.IntersectsWith(pictureBox87.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox88.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox57.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox55.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox56.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox30.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox84.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox95.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox96.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox97.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox100.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox101.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox102.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox27.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox28.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox26.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox25.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox24.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox23.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox22.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox21.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox20.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox19.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox18.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox17.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox16.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox15.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox101.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox83.Bounds) || //5
                pacm2.Bounds.IntersectsWith(pictureBox98.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox106.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox99.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox107.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox93.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox92.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox71.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox68.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox94.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox90.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox79.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox105.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox102.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox104.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox103.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox100.Bounds))
            {
                pacm2.Top -= velo;
            }
            if (abajo || pacm2.Bounds.IntersectsWith(pictureBox1.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox3.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox2.Bounds)
                || pacm2.Bounds.IntersectsWith(pictureBox5.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox4.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox11.Bounds)
                || pacm2.Bounds.IntersectsWith(pictureBox10.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox9.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox8.Bounds)
                || pacm2.Bounds.IntersectsWith(pictureBox7.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox6.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox14.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox13.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox49.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox36.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox57.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox55.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox67.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox66.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox65.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox69.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox88.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox87.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox89.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox86.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox55.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox67.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox76.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox75.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox88.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox84.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox85.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox95.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox96.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox97.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox83.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox16.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox15.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox101.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox83.Bounds) || //5
                pacm2.Bounds.IntersectsWith(pictureBox98.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox106.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox99.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox107.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox93.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox92.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox71.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox68.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox94.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox90.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox79.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox105.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox102.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox104.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox103.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox100.Bounds) ||
                pacm2.Bounds.IntersectsWith(pictureBox58.Bounds) || pacm2.Bounds.IntersectsWith(pictureBox64.Bounds))
            {
                pacm2.Top += velo;
            }
            //
            ////
            fantRojo.Left += fant1;
            fantRosa.Left += fant2;
            fantAmarillo.Top += fant3;



            //fantasma1
            if (fantRojo.Bounds.IntersectsWith(pictureBox81.Bounds))
            {
                fant1 = -fant1;
            }
            else if (fantRojo.Bounds.IntersectsWith(pictureBox78.Bounds))
            {
                fant1 = -fant1;
            }
            //fantasma2
            if (fantRosa.Bounds.IntersectsWith(pictureBox86.Bounds))
            {
                fant2 = -fant2;
            }
            else if (fantRosa.Bounds.IntersectsWith(pictureBox48.Bounds))
            {
                fant2 = -fant2;
            }
            //fantasma3
            if (fantAmarillo.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                fant3 = -fant3;
            }
            else if (fantAmarillo.Bounds.IntersectsWith(pictureBox28.Bounds))
            {
                fant3 = -fant3;
            }
            //
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "fantasma")
                {
                    if (((PictureBox)j).Bounds.IntersectsWith(pacm2.Bounds) || score == 80)
                    {
                        pacm2.Left = 0;
                        pacm2.Top = 25;
                        label2.Text = "GAME OVER";
                        label2.Visible = true;
                        timer1.Stop();

                    }
                }
                //***********************************************************
                if (j is PictureBox && j.Tag == "paredOs")
                {
                    if (((PictureBox)j).Bounds.IntersectsWith(pacm2.Bounds))
                    {
                        pacm2.Left = pacm2.Right;
                        //pacm2.Right = pacm2.Left;
                    }
                }

                /**************************************************************/
                if (j is PictureBox && j.Tag == "moneda" || j.Tag == "bonus")
                {
                    if (((PictureBox)j).Bounds.IntersectsWith(pacm2.Bounds))
                    {
                        this.Controls.Remove(j);

                        if (score == 75)
                        {
                            label2.Text = "WINNER";
                            label2.Visible = true;
                            timer1.Stop();

                        }
                        score++;
                    }
                }


            }

            //movimiento fantasma loco
            fantasLoco.Left += fant4x;
            fantasLoco.Top += fant4y;

            if (fantasLoco.Bounds.IntersectsWith(pictureBox94.Bounds))
            {
                fant4x = -fant4x;
            }
            else if (fantasLoco.Bounds.IntersectsWith(pictureBox99.Bounds))
            {
                fant4x = -fant4x;
            }
            if (fantasLoco.Bounds.IntersectsWith(pictureBox23.Bounds)|| fantasLoco.Bounds.IntersectsWith(pictureBox99.Bounds))
            {
                fant4y = -fant4y;
            }
            else if (fantasLoco.Bounds.IntersectsWith(pictureBox88.Bounds))
            {
                fant4y = -fant4y;
            }
        }

        public PACMAN()
        {
            InitializeComponent();
            label2.Visible = false;
            Bitmap imag = new Bitmap(Application.StartupPath + @"\res\fondo1.jpg");
            this.BackgroundImage = imag;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            x = pacm2.Location.X;

        }



        private void lblJugador_Click(object sender, EventArgs e)
        {

        }

        /*public int[,] tablero(int op)
        {
            int[,] aux = new int[15, 14];

            if (op == 1)
            {
                int[,] matrix = {
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},//1
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},//2
        {1,0,1,1,0,0,1,1,0,0,1,1,1,0,1},//3
        {1,0,0,0,0,1,1,1,1,0,1,1,1,0,1},//4
        {1,0,1,1,0,0,0,0,0,0,1,1,1,0,1},//5
        {1,0,0,0,0,1,0,0,1,0,0,0,0,0,1},//6
        {0,0,1,1,0,1,0,0,1,0,1,1,1,0,1},//7
        {1,0,1,1,0,1,1,1,1,0,0,0,0,0,1},//8
        {1,0,0,0,0,0,0,0,0,0,1,1,1,0,1},//9
        {1,0,1,1,0,1,0,0,1,0,0,0,0,0,1},//10
        {1,0,0,0,0,1,0,0,0,0,1,1,1,0,1},//11
        {1,0,1,1,0,1,0,0,1,0,1,1,1,0,1},//12
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},//13
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},//14
        };
                return matrix;
            }
            if (op == 2)
            {
                int[,] matrix = {
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},//1
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},//2
        {1,0,1,1,0,0,1,1,0,0,1,1,1,0,1},//3
        {1,0,0,0,0,1,1,1,1,0,1,1,1,0,1},//4
        {1,0,1,1,0,0,0,0,0,0,1,1,1,0,1},//5
        {1,0,0,0,0,1,0,0,1,0,0,0,0,0,1},//6
        {0,0,1,1,0,1,0,0,1,0,1,1,1,0,1},//7
        {1,0,1,1,0,1,1,1,1,0,0,0,0,0,1},//8
        {1,0,0,0,0,0,0,0,0,0,1,1,1,0,1},//9
        {1,0,1,1,0,1,0,0,1,0,0,0,0,0,1},//10
        {1,0,0,0,0,1,0,0,0,0,1,1,1,0,1},//11
        {1,0,1,1,0,1,0,0,1,0,1,1,1,0,1},//12
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},//13
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},//14
        };
                return matrix;
            }
            if (op == 3)
            {
                int[,] matrix = {
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},//1
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},//2
        {1,0,1,1,0,0,1,1,0,0,1,1,1,0,1},//3
        {1,0,0,0,0,1,1,1,1,0,1,1,1,0,1},//4
        {1,0,1,1,0,0,0,0,0,0,1,1,1,0,1},//5
        {1,0,0,0,0,1,0,0,1,0,0,0,0,0,1},//6
        {0,0,1,1,0,1,0,0,1,0,1,1,1,0,1},//7
        {1,0,1,1,0,1,1,1,1,0,0,0,0,0,1},//8
        {1,0,0,0,0,0,0,0,0,0,1,1,1,0,1},//9
        {1,0,1,1,0,1,0,0,1,0,0,0,0,0,1},//10
        {1,0,0,0,0,1,0,0,0,0,1,1,1,0,1},//11
        {1,0,1,1,0,1,0,0,1,0,1,1,1,0,1},//12
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},//13
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},//14
        };

                return matrix;
            }
            return aux;
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                izq = true;
                pacm2.Image = Properties.Resources.PACM2;
            }

            if (e.KeyCode == Keys.Right)
            {
                dere = true;
                pacm2.Image = Properties.Resources.PACM1;
            }

            if (e.KeyCode == Keys.Up)
            {
                arriba = true;
                pacm2.Image = Properties.Resources.PACM3;
            }

            if (e.KeyCode == Keys.Down)
            {
                abajo = true;
                pacm2.Image = Properties.Resources.PACM4;
            }
        }

        private void Juego_Load(object sender, EventArgs e)
        {

        }

        private void Juego_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                izq = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                dere = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                arriba = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                abajo = false;
            }
        }
        ////////
    }
}

