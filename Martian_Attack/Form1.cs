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


        }

        public void PipeMovement()
        {
            PipeUpOne.Left = PipeUpOne.Left + PipeSpeed;
            PipeUpTwo.Left = PipeUpTwo.Left + PipeSpeed;
            PipeDownOne.Left = PipeDownOne.Left + PipeSpeed;
            PipeDownTwo.Left = PipeDownTwo.Left + PipeSpeed;
        }

        private void PipeUpOne_Click(object sender, EventArgs e)
        {

        }
    }
}
