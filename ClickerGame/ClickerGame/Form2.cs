﻿using System;
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
    }
}