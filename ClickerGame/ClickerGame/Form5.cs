using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ClickerGame
{
    public partial class Form5 : Form
    {
        // Arrays with all the start positions of the squares of the Tetrominos.
        //private int[] piceI = {0,0, 1,0, 2,0, 3,0};
        //private int[] piceO = {0,0, 1,0, 0,1, 1,1};
        //private int[] piceT = {1,0, 0,1, 1,1, 2,1};
        //private int[] piceS = {1,0, 2,0, 0,1, 1,1};
        //private int[] piceZ = {0,0, 1,0, 1,1, 2,0};
        //private int[] piceJ = {0,0, 0,1, 1,1, 2,1};
        //private int[] piceL = {2,0, 0,1, 1,1, 2,1};

        private CellPosition[] piceI = new CellPosition[4]
        {
            new CellPosition(0, 0),
            new CellPosition(1, 0),
            new CellPosition(2, 0),
            new CellPosition(3, 0)
        };

        private CellPosition[] piceO = new CellPosition[4]
        {
            new CellPosition(0, 0),
            new CellPosition(1, 0),
            new CellPosition(0, 1),
            new CellPosition(1, 1)
        };

        private CellPosition[] piceT = new CellPosition[4]
        {
            new CellPosition(1, 0),
            new CellPosition(0, 1),
            new CellPosition(1, 1),
            new CellPosition(2, 1)
        };

        private CellPosition[] piceS = new CellPosition[4]
        {
            new CellPosition(1, 0),
            new CellPosition(2, 0),
            new CellPosition(0, 1),
            new CellPosition(1, 1)
        };

        private CellPosition[] piceZ = new CellPosition[4]
        {
            new CellPosition(1, 1),
            new CellPosition(2, 1),
            new CellPosition(2, 2),
            new CellPosition(3, 2)
        };

        private CellPosition[] piceJ = new CellPosition[4]
        {
            new CellPosition(0, 0),
            new CellPosition(0, 1),
            new CellPosition(1, 1),
            new CellPosition(2, 1)
        };

        private CellPosition[] piceL = new CellPosition[4]
        {
            new CellPosition(2, 0),
            new CellPosition(0, 1),
            new CellPosition(1, 1),
            new CellPosition(2, 1)
        };



        public Form5()
        {
            InitializeComponent();

            /*
             piceI
             piceO
             piceT
             piceS
             piceZ
             piceJ
             piceL
             */
            MakeTetrominoInGridd(piceS);
        }

    class CellPosition
        {
            public int Col {  get; }
            public int Row {  get; }

            public CellPosition(int col, int row)
            {
                Row = row;
                Col = col;
            }
        }

        private void MakeTetrominoInGridd(CellPosition[] piceArray)
        {
            for (int i = 0; i < 4; i++)
            {
                FlowLayoutPanel newBlock = new FlowLayoutPanel();
                newBlock.BackColor = Color.Cyan;
                newBlock.Dock = DockStyle.Fill;

                playfield.Controls.Add(newBlock, piceArray[i].Col, piceArray[i].Row);
            }
        }
    }
}
