using FlyGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyGame
{
    public partial class Form1 : Form
    {
        // глобальные переменные
        int score = 0;
        int timer = 15;
        int recorde = 0;
        bool isRunning = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFly_Click(object sender, EventArgs e)
        {
            if(isRunning == false)
            {
               timerGame.Enabled = true;
                isRunning = true;
                timerGame.Start();
                if (score == 1)
                {
                    timerGame.Enabled = true;
                    timer = 15;
                    timer--;
                    labelTimer.Text = "Timer: " + timer.ToString();
                    pictureBox1.Enabled = true;
                    score++;
                    labelScore.Text = "Score: " + score.ToString();
                }
            }
            
            
            #region Move Fly
            Random r = new Random();
            int x = r.Next(0, 500 - pictureBox1.Width - 20);
            int y = r.Next(0, 500 - pictureBox1.Top - 20);

            pictureBox1.Left = x;
            pictureBox1.Top = y;

            #endregion

            score++;

            labelScore.Text = "Score: " + score.ToString();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            // уменьшаем время на 1
            
            timer--;
            labelTimer.Text = "Timer: " + timer.ToString();
            if(timer == 0)
            {
                timerGame.Enabled = false;
                pictureBox1.Enabled = false;
                if(score < 14)
                {
                    MessageBox.Show("Bad");
                }
                else if(score < 18)
                {
                    MessageBox.Show("Normal");
                }
                else
                {
                    MessageBox.Show("Good");
                }
                
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            #region Move play
            buttonPlay.Visible = false;
            labelRecorde.Visible = false;
            pictureBox1.Visible = true;
            labelScore.Visible = true;
            labelTimer.Visible = true;
            label1.Visible = false;
            buttonStop.Visible = true;
            buttonMENU.Visible = true;
            #endregion
            timerGame.Enabled = true;
            pictureBox1.Enabled = true;
        }

        private void buttonAnew_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timerGame.Stop();
            buttonEXTEND.Visible = true;
            pictureBox1.Visible = false;
            labelScore.Visible = false;
            labelTimer.Visible = false;
            buttonStop.Visible = false;
            buttonMENU.Visible = false;

        }

        private void buttonMENU_Click_1(object sender, EventArgs e)
        {
            #region Move play
            buttonPlay.Visible = true;
            labelRecorde.Visible = true;
            pictureBox1.Visible = false;
            labelScore.Visible = false;
            labelTimer.Visible = false;
            buttonStop.Visible = false;
            buttonMENU.Visible = false;
            label1.Visible = true;
            #endregion
            if (score > recorde)
            {
                recorde = score;
                labelRecorde.Text = "Рекорд: " + recorde.ToString();
            }
            score = 0;
            labelScore.Text = "Score: " + score.ToString();
            timer = 15;
            labelTimer.Text = "Timer: " + timer.ToString();
            


        }

        private void buttonEXTEND_Click(object sender, EventArgs e)
        {
            #region Move play
            buttonPlay.Visible = false;
            labelRecorde.Visible = false;
            pictureBox1.Visible = true;
            labelScore.Visible = true;
            labelTimer.Visible = true;
            buttonStop.Visible = true;
            buttonMENU.Visible = true;
            buttonEXTEND.Visible = false;
            #endregion
            timerGame.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelRecorde_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isRunning == false)
            {
                timerGame.Enabled = true;
                isRunning = true;
                timerGame.Start();
                if (score == 1)
                {
                    timerGame.Enabled = true;
                    timer = 15;
                    timer--;
                    labelTimer.Text = "Timer: " + timer.ToString();
                    pictureBox1.Enabled = true;
                    score++;
                    labelScore.Text = "Score: " + score.ToString();
                }
            }


            #region Move Fly
            Random r = new Random();
            int x = r.Next(0, 500 - pictureBox1.Width - 20);
            int y = r.Next(0, 500 - pictureBox1.Top - 20);

            pictureBox1.Left = x;
            pictureBox1.Top = y;

            #endregion

            score++;

            labelScore.Text = "Score: " + score.ToString();
        }
    } 
}
