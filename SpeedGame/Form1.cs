using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedGame
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + r.Next(0,10);
            pictureBox2.Left = pictureBox1.Left + r.Next(0, 10);
            pictureBox5.Left = pictureBox1.Left + r.Next(0, 10);
            pictureBox4.Left = pictureBox1.Left + r.Next(0, 10);

            /* if(pictureBox1.Right >= button1.Right ||
                pictureBox2.Right >= button1.Right ||
                pictureBox4.Right >= button1.Right ||
                pictureBox5.Right >= button1.Right)
            {
                timerGame.Enabled = false;
            } */
            if (pictureBox1.Right >= button1.Right)
            {
                timerGame.Enabled = false;
                MessageBox.Show("CAR 2 HAS WON!");
            }
            if (pictureBox2.Right >= button1.Right)
            {
                timerGame.Enabled = false;
                MessageBox.Show("CAR 1 HAS WON!");
            }
            if (pictureBox4.Right >= button1.Right)
            {
                timerGame.Enabled = false;
                MessageBox.Show("CAR 3 HAS WON!");
            }
            if (pictureBox5.Right >= button1.Right)
            {
                timerGame.Enabled = false;
                MessageBox.Show("CAR 4 HAS WON!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerGame.Enabled = true;
        }
    }
}
