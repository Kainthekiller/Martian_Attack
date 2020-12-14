using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martian_Attack
{
    public partial class Form1 : Form
    {
        int gravity = 6;
        int PipeSpeed = -8;
        int Score = 0;
        int starSpeed = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            MainPlayer.Top = MainPlayer.Top + gravity;
            NewPipes();
            PipeMovement();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space) { 
            
                gravity = -12;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 6;
            }

        }

        public void NewPipes()
        {
            Random rando = new Random();
            if (PipeUpOne.Left < -50)
            {
                PipeUpOne.Left = rando.Next(900, 1000);
            }
            if(PipeUpTwo.Left < -50)
            {
                PipeUpTwo.Left = rando.Next(700, 800);
            }
            if (PipeDownOne.Left < -50)
            {
                PipeDownOne.Left = rando.Next(900, 1000);
            }
            if (PipeDownTwo.Left < -50)
            {
                PipeDownTwo.Left = rando.Next(700, 800);
            }
            if(Star1.Left < -10)
            {
                Star1.Left = rando.Next(800, 900);
            }
            if (Star2.Left < -10)
            {
                Star2.Left = rando.Next(800, 900);
            }
            if (Star3.Left < -10)
            {
                Star3.Left = rando.Next(800, 900);
            }
            if (Star4.Left < -10)
            {
                Star4.Left = rando.Next(800, 900);
            }
            if (Star4.Left < -10)
            {
                Star4.Left = rando.Next(800, 900);
            }
            if (Star5.Left < -10)
            {
                Star5.Left = rando.Next(800, 900);
            }
            if (Star6.Left < -10)
            {
                Star6.Left = rando.Next(800, 900);
            }
            if (Star7.Left < -10)
            {
                Star7.Left = rando.Next(800, 900);
            }
            if (Star8.Left < -10)
            {
                Star8.Left = rando.Next(800, 900);
            }
            if (Star9.Left < -10)
            {
                Star9.Left = rando.Next(800, 900);
            }
            if (Star10.Left < -10)
            {
                Star10.Left = rando.Next(800, 900);
            }

        }

        public void PipeMovement()
        {
            PipeUpOne.Left = PipeUpOne.Left + PipeSpeed;
            PipeUpTwo.Left = PipeUpTwo.Left + PipeSpeed;
            PipeDownOne.Left = PipeDownOne.Left + PipeSpeed;
            PipeDownTwo.Left = PipeDownTwo.Left + PipeSpeed;
            Star1.Left += starSpeed;
            Star2.Left += starSpeed;
            Star3.Left += starSpeed;
            Star4.Left += starSpeed;
            Star5.Left += starSpeed;
            Star6.Left += starSpeed;
            Star7.Left += starSpeed;
            Star8.Left += starSpeed;
            Star9.Left += starSpeed;
            Star10.Left += starSpeed;
        }

        private void PipeUpOne_Click(object sender, EventArgs e)
        {

        }
    }
}
