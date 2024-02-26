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

        // Function that removes the pice from the playfield.
        private void RemovePice(List<FlowLayoutPanel> piceToRemove)
        {
            // Goes thru all the items in the piceToRemove list
            // and removes eich one.
            for(int i = 0;i < piceToRemove.Count; i++)
            {
                playfield.Controls.Remove(piceToRemove[i]);
            }
        }

        //---------- Functions that make the pice at the target position ----------

        // piceI
        private void PiceIFunc(int[] position)
        {
            // Removes the FlowLayoutPannels on the previous position
            RemovePice(fallingTetromino);
            
            // setts the start position of the pice making to sero to get it to start correctly.
            position[0] = 0;

            // Goes 4 times to create all the FlowLayoutPanels needed to create the pice.
            for (int i = 0; i < 4; i++)
            {
                // Makes a new FlowLayoutPanel and setts the color to make it visible.
                FlowLayoutPanel newBlock = new FlowLayoutPanel();
                newBlock.BackColor = Color.Cyan;

                // Adds the newly created FlowLayoutPanel to an array
                fallingTetromino.Add(newBlock);

                // Changes the position to where the next FlowLayoutPanel needs to be. 
                if (i >= 1)
                {
                    position[0] += 1;
                }

                // Adds the newBlock to the playfield.
                playfield.Controls.Add(newBlock, position[0], position[1]);
            }
        }
        private void PiceOFunc(int[] position)
        {
            // Removes the FlowLayoutPannels on the previous position
            RemovePice(fallingTetromino);

            // setts the start position of the pice making to sero to get it to start correctly.
            position[0] = 0;

            // Goes 4 times to create all the FlowLayoutPanels needed to create the pice.
            for (int i = 0; i < 4; i++)
            {
                // Makes a new FlowLayoutPanel and setts the color to make it visible.
                FlowLayoutPanel newBlock = new FlowLayoutPanel();
                newBlock.BackColor = Color.Yellow;

                // Adds the newly created FlowLayoutPanel to an array
                fallingTetromino.Add(newBlock);

                // Changes the position to where the next FlowLayoutPanel needs to be.
                if(i == 1 || i == 3)
                {
                    position[0] += 1;
                }else if(i == 2)
                {
                    position[0] = 0;
                    position[1] += 1;
                }

                // Adds the newBlock to the playfield.
                playfield.Controls.Add(newBlock, position[0], position[1]);
            }
        }
        private void PiceTFunc(int[] position)
        {
            // Removes the FlowLayoutPannels on the previous position
            RemovePice(fallingTetromino);

            // setts the start position of the pice making to sero to get it to start correctly.
            position[0] = 0;

            // Goes 4 times to create all the FlowLayoutPanels needed to create the pice.
            for (int i = 0; i < 4; i++)
            {
                // Makes a new FlowLayoutPanel and setts the color to make it visible.
                FlowLayoutPanel newBlock = new FlowLayoutPanel();
                newBlock.BackColor = Color.Purple;

                // Adds the newly created FlowLayoutPanel to an array
                fallingTetromino.Add(newBlock);

                // Changes the position to where the next FlowLayoutPanel needs to be.
                if (i <= 2)
                {
                    position[0] += 1;
                }else if(i == 3)
                {
                    position[0] -= 1;
                    position[1] -= 1;
                }else if (i == 4)
                {
                    position[1] -= 1;
                }

                // Adds the newBlock to the playfield.
                playfield.Controls.Add(newBlock, position[0], position[1]);
            }
        }
        private void PiceSFunc(int[] position)
        {
            // Removes the FlowLayoutPannels on the previous position
            RemovePice(fallingTetromino);

            // setts the start position of the pice making to sero to get it to start correctly.
            position[0] = 0;

            // Goes 4 times to create all the FlowLayoutPanels needed to create the pice.
            for (int i = 0; i < 4; i++)
            {
                // Makes a new FlowLayoutPanel and setts the color to make it visible.
                FlowLayoutPanel newBlock = new FlowLayoutPanel();
                newBlock.BackColor = Color.Lime;

                // Adds the newly created FlowLayoutPanel to an array
                fallingTetromino.Add(newBlock);

                // Changes the position to where the next FlowLayoutPanel needs to be.
                if (i == 0)
                {
                    position[0] += 1;
                }
                else if (i <= 2)
                {
                    position[0] += 1;
                }
                else if (i == 3)
                {
                    position[1] += 1;
                    position[0] -= 2;
                }
                else
                {
                    position[0] += 1;
                }



                // Adds the newBlock to the playfield.
                playfield.Controls.Add(newBlock, position[0], position[1]);
            }
        }
        private void PiceZFunc(int[] position)
        {
            // Removes the FlowLayoutPannels on the previous position
            RemovePice(fallingTetromino);

            // setts the start position of the pice making to sero to get it to start correctly.
            position[0] = 0;

            // Goes 4 times to create all the FlowLayoutPanels needed to create the pice.
            for (int i = 0; i < 4; i++)
            {
                // Makes a new FlowLayoutPanel and setts the color to make it visible.
                FlowLayoutPanel newBlock = new FlowLayoutPanel();
                newBlock.BackColor = Color.Yellow;

                // Adds the newly created FlowLayoutPanel to an array
                fallingTetromino.Add(newBlock);

                // Changes the position to where the next FlowLayoutPanel needs to be.
                if (i == 1 || i == 3)
                {
                    position[0] += 1;
                }
                else if (i == 2)
                {
                    position[0] = 0;
                    position[1] += 1;
                }

                // Adds the newBlock to the playfield.
                playfield.Controls.Add(newBlock, position[0], position[1]);
            }
        }
        private void PiceJFunc(int[] position)
        {
            // Removes the FlowLayoutPannels on the previous position
            RemovePice(fallingTetromino);

            // setts the start position of the pice making to sero to get it to start correctly.
            position[0] = 0;

            // Goes 4 times to create all the FlowLayoutPanels needed to create the pice.
            for (int i = 0; i < 4; i++)
            {
                // Makes a new FlowLayoutPanel and setts the color to make it visible.
                FlowLayoutPanel newBlock = new FlowLayoutPanel();
                newBlock.BackColor = Color.Yellow;

                // Adds the newly created FlowLayoutPanel to an array
                fallingTetromino.Add(newBlock);

                // Changes the position to where the next FlowLayoutPanel needs to be.
                if (i == 1 || i == 3)
                {
                    position[0] += 1;
                }
                else if (i == 2)
                {
                    position[0] = 0;
                    position[1] += 1;
                }

                // Adds the newBlock to the playfield.
                playfield.Controls.Add(newBlock, position[0], position[1]);
            }
        }
        private void PiceLFunc(int[] position)
        {
            // Removes the FlowLayoutPannels on the previous position
            RemovePice(fallingTetromino);

            // setts the start position of the pice making to sero to get it to start correctly.
            position[0] = 0;

            // Goes 4 times to create all the FlowLayoutPanels needed to create the pice.
            for (int i = 0; i < 4; i++)
            {
                // Makes a new FlowLayoutPanel and setts the color to make it visible.
                FlowLayoutPanel newBlock = new FlowLayoutPanel();
                newBlock.BackColor = Color.Yellow;

                // Adds the newly created FlowLayoutPanel to an array
                fallingTetromino.Add(newBlock);

                // Changes the position to where the next FlowLayoutPanel needs to be.
                if (i == 1 || i == 3)
                {
                    position[0] += 1;
                }
                else if (i == 2)
                {
                    position[0] = 0;
                    position[1] += 1;
                }

                // Adds the newBlock to the playfield.
                playfield.Controls.Add(newBlock, position[0], position[1]);
            }
        }



        //-------------------------------------------------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {
            PiceSFunc(startPosition);
            startPosition[1] += 1;

        }
    }
}
