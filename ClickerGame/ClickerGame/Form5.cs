using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ClickerGame
{
    public partial class Form5 : Form
    {
        private int fallingRow = 0;

        // All the Tetrominos as arrays with all the positions of the blocks.
        //// Uses the custom class CellPosition to save the column and row for eich block.
        //private CellPosition[] piceI = new CellPosition[4]
        //{
        //    new CellPosition(0, 0),
        //    new CellPosition(1, 0),
        //    new CellPosition(2, 0),
        //    new CellPosition(3, 0)
        //};
        //private CellPosition[] piceO = new CellPosition[4]
        //{
        //    new CellPosition(0, 0),
        //    new CellPosition(1, 0),
        //    new CellPosition(0, 1),
        //    new CellPosition(1, 1)
        //};
        //private CellPosition[] piceT = new CellPosition[4]
        //{
        //    new CellPosition(1, 0),
        //    new CellPosition(0, 1),
        //    new CellPosition(1, 1),
        //    new CellPosition(2, 1)
        //};
        //private CellPosition[] piceS = new CellPosition[4]
        //{
        //    new CellPosition(1, 0),
        //    new CellPosition(2, 0),
        //    new CellPosition(0, 1),
        //    new CellPosition(1, 1)
        //};
        //private CellPosition[] piceZ = new CellPosition[4]
        //{
        //    new CellPosition(1, 1),
        //    new CellPosition(2, 1),
        //    new CellPosition(2, 2),
        //    new CellPosition(3, 2)
        //};
        //private CellPosition[] piceJ = new CellPosition[4]
        //{
        //    new CellPosition(0, 0),
        //    new CellPosition(0, 1),
        //    new CellPosition(1, 1),
        //    new CellPosition(2, 1)
        //};
        //private CellPosition[] piceL = new CellPosition[4]
        //{
        //    new CellPosition(2, 0),
        //    new CellPosition(0, 1),
        //    new CellPosition(1, 1),
        //    new CellPosition(2, 1)
        //};

        private int[] startPosition = {0, 0};

        private List<FlowLayoutPanel> fallingTetromino = new List<FlowLayoutPanel>();


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
            //MakeTetrominoInGridd(piceO, Color.Yellow);

            //TestPiceIFunc(startPosition);

            timer1.Start();
        }

    // Custom class to save a column and a row.
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

        // Function that makes the Tetromino in the playfield gridd
        // using the piceArray array
        private void MakeTetrominoInGridd(CellPosition[] pice, Color color)
        {
            // Uses a for loop to make sure it only loops 4 times couse
            // thats how many blocks all the Tetrominos are made with.
            for (int i = 0; i < 4; i++)
            {
                // Makes a new FlowLayoutPanel and setts the color to make it visible.
                FlowLayoutPanel newBlock = new FlowLayoutPanel();
                newBlock.BackColor = color;

                fallingTetromino.Add(newBlock);

                playfield.Controls.Add(newBlock, pice[i].Col, pice[i].Row);
            }
        }

        private void RemovePice(List<FlowLayoutPanel> piceToRemove)
        {
            for(int i = 0;i < piceToRemove.Count; i++)
            {
                playfield.Controls.Remove(piceToRemove[i]);
            }
        }

        private void TestPiceIFunc(int[] position)
        {
            RemovePice(fallingTetromino);
            position[0] = 0;

            for (int i = 0; i < 4; i++)
            {
                // Makes a new FlowLayoutPanel and setts the color to make it visible.
                FlowLayoutPanel newBlock = new FlowLayoutPanel();
                newBlock.BackColor = Color.Cyan;

                fallingTetromino.Add(newBlock);

                if(i >= 1)
                {
                    position[0] += 1;
                }

                playfield.Controls.Add(newBlock, position[0], position[1]);
            }
        }

        //public Stack<int> NumbersIn(int value)
        //{
        //    if (value == 0) return new Stack<int>();

        //    var numbers = NumbersIn(value / 10);

        //    numbers.Push(value % 10);

        //    return numbers;
        //}

        //int numbers = NumbersIn(987654321).ToArray();

        private void timer1_Tick(object sender, EventArgs e)
        {
            TestPiceIFunc(startPosition);
            startPosition[1] += 1;

            //int col;
            //int row;

            //for(int i = 0; i < 4; i++)
            //{
            //    playfield.Controls.Remove(fallingTetromino[i]);
            //    playfield.Controls.Add(fallingTetromino[i]);
            //}
        }
    }
}
