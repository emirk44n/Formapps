using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy.Bird
{
    public partial class Form1 : Form
        

    {
        int pipeSpeed = 14;
        int gravity = 15;
        int score = 0;


        public Form1()

        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flappy.Top += gravity;
            pipe_up.Left -= pipeSpeed;
            pipe_down.Left -= pipeSpeed;
            scoreLabel.Text = "Score:" + score;

            if(pipe_up.Left<-150)
            {
                pipe_up.Left = 800;
                score++;

            }

            if(pipe_down.Left<-180)
            {
                pipe_down.Left = 950;
                score++;
            }

            if (flappy.Bounds.IntersectsWith(pipe_down.Bounds) ||
                (flappy.Bounds.IntersectsWith(pipe_up.Bounds) ||
                flappy.Bounds.IntersectsWith(ground.Bounds)))
            {   
                EndGame();
            }
            if (score > 5)
                pipeSpeed = 23;

            if (flappy.Top< -25)
                EndGame();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -15;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 15;

        }

        private void EndGame()
        {
            timer1.Stop();
            scoreLabel.Text += "Game Over :(";
        }
    }
}
