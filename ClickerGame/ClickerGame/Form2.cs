using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form2 : Form
    {
        // Trying to make an array with all the game forms
        //public [] gameArray = {Form1};

        public Form1 game1 = new Form1();
        public Form3 game2 = new Form3();
        public Form4 game3 = new Form4();
        public Form5 game4 = new Form5();
        public Form6 game5 = new Form6();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Changes form to the clicker game.
            // (Form2 -> Form1)
            game1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Changes form to the memory game.
            // (Form2 -> Form3)
            game2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Changes form to the Snake game.
            // (Form2 -> Form4)
            game3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Changes form to the Tetris game.
            // (Form2 -> Form5)
            game4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Changes form to the Pong game.
            // (Form2 -> Form6)
            game5.ShowDialog();
        }
    }
}
