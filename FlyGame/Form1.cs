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
        int timer = 10;
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
            }
            
            
            #region Move Fly
            Random r = new Random();
            int x = r.Next(0, 500 - buttonFly.Width - 20);
            int y = r.Next(0, 500 - buttonFly.Top - 20);

            buttonFly.Left = x;
            buttonFly.Top = y;

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
                buttonFly.Enabled = false;
                if(score < 10)
                {
                    MessageBox.Show("Bad");
                }
                else if(score < 14 )
                {
                    MessageBox.Show("Normal");
                }
                else
                {
                    MessageBox.Show("Good");
                }
            }
        }
    } 
}
