﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form4 : Form
    {
        public int randomRow;
        public int randomCol;
        public int gridMinPosition = 0;
        public int gridMaxPosition;
        public string autoMoveDirection;

        public Form4()
        {
            InitializeComponent();
            autoMovementTimer.Start();
        }

        // Places the apple in a random cell in the snakeGridd
        // Controls is a class with the controls for the design
        private void PlaceControl(Control control, int row, int col)
        {
            // Remove the apple from its current position
            snakeGrid.Controls.Remove(control);

            // Insert the apple at the new position
            snakeGrid.Controls.Add(control, col, row);
        }

        private void RandomRowCol()
        {
            Random random = new Random();
            randomCol = random.Next(gridMinPosition, 10);
            randomRow = random.Next(gridMinPosition, 10);

            // Checks if the random position is teh same as the snakes posistion.
            // If true randomise again.
            if (randomCol == snakeGrid.GetColumn(snake) && randomRow == snakeGrid.GetRow(snake))
            {
                RandomRowCol();
            }
        }

        private void CheckForApple(int row, int col)
        {
            // Checks if the row its trying to move to has the apple.
            // If true changes the apple for another snake pice.
            int appleRow = snakeGrid.GetRow(apple);
            int appleCol = snakeGrid.GetColumn(apple);

            if (row == appleRow && col == appleCol)
            {
                RandomRowCol();
                snakeGrid.Controls.Remove(apple);
                PlaceControl(apple, randomRow, randomCol);
                PlaceControl(snake, appleRow, appleCol);
            }
        }

        private void Form4_Activated(object sender, EventArgs e)
        {
            autoMoveDirection = "up";
            RandomRowCol();
            PlaceControl(apple, randomCol, randomRow);
        }

        
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            //---------- Snake WSDA movement----------
            // This is for testing purposes,
            // the final product will have automatic movement with direction change.

            // Checks if the user presses W, S, D or A.
            // Then moves the snake control one column or row up or down
            // depending on what key is pressed.

            int row = snakeGrid.GetRow(snake);
            int col = snakeGrid.GetColumn(snake);

            if (e.KeyCode == Keys.W)
            {
                row--;

                // Checks if the row variable is valid.
                // If not returns to hinder a crash.
                if (row == -1)
                    return;

                // Checks if the row its trying to move to has the apple.
                CheckForApple(row, col);

                PlaceControl(snake, row, col);
            }
            else if(e.KeyCode == Keys.S)
            {
                row++;

                // Checks if the row variable is valid.
                // If not returns to hinder a crash.
                if (row >= snakeGrid.RowCount)
                    return;

                PlaceControl(snake, row, col);
            }
            else if(e.KeyCode == Keys.D)
            {
                col++;

                // Checks if the col variable is valid.
                // If not returns to hinder a crash.
                if (col >= snakeGrid.RowCount)
                    return;

                // Checks if the row its trying to move to has the apple.
                CheckForApple(row, col);

                PlaceControl(snake, row, col);
            }
            else if(e.KeyCode == Keys.A)
            {
                col--;

                // Checks if the col variable is valid.
                // If not returns to hinder a crash.
                if (col == -1)
                    return;

                // Checks if the row its trying to move to has the apple.
                CheckForApple(row, col);

                PlaceControl(snake, row, col);
            }
            //----------------------------------------

            //----------- Snake WSDA direction change ----------
            if(e.KeyCode == Keys.W)
            {
                autoMoveDirection = "up";
            }
            else if(e.KeyCode == Keys.S)
            {
                autoMoveDirection = "down";
            }
            else if (e.KeyCode == Keys.D)
            {
                autoMoveDirection = "right";
            }
            else if (e.KeyCode == Keys.A)
            {
                autoMoveDirection = "left";
            }
            //--------------------------------------------------

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int row = snakeGrid.GetRow(snake);
            int col = snakeGrid.GetColumn(snake);

            if (autoMoveDirection == "up")
            {
                Console.Write("up");
                PlaceControl(snake, (row + 1), col);
            }
            else if (autoMoveDirection == "down")
            {

            }
            else if (autoMoveDirection == "right")
            {

            }
            else if (autoMoveDirection == "left")
            {

            }
        }
    }
}
