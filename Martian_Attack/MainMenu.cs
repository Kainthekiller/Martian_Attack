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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            var player = new System.Media.SoundPlayer(@"C:\Users\phill\Documents\GitHub\Martian_Attack\Martian_Attack\Alien.wav");
            player.PlayLooping();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 F1 = new Form1();
            F1.ShowDialog();
            this.Close();
            
        }
    }
}
