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
    public partial class Form5 : Form
    {
        // Arrays with all the start positions of the squares of the Tetrominos.
        private int[] PiceI = {0,0, 0,1, 0,2, 0,3};
        private int[] PiceO = {0,0, 0,1, 1,0, 1,1};
        private int[] PiceT = {0,1, 1,0, 1,1, 1,2};
        private int[] PiceS = {0,1, 0,2, 1,0, 1,1};
        private int[] PiceZ = {0,0, 0,1, 1,1, 1,2};
        private int[] PiceJ = {0,0, 1,0, 1,1, 1,2};
        private int[] PiceL = {0,2, 1,0, 1,1, 1,2};

        public Form5()
        {
            InitializeComponent();
        }
    }
}
