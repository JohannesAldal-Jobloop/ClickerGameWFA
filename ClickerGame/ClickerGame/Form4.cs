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

namespace ClickerGame
{
    public partial class Form4 : Form
    {
        

        public Form4()
        {
            Random random = new Random();
            int randomRow = random.Next(0, 10);
            int randomCol = random.Next(0, 10);

            InitializeComponent();
            PlaceControl(apple, randomCol, randomRow);
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

        private void Form4_Activated(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomRow = random.Next(0, 10);
            int randomCol = random.Next(0, 10);

            PlaceControl(apple, randomCol, randomRow);
        }

        
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            //---------- Snake WASD movement----------
            // This is for testing purposes,
            // the final product will have automatic movement with direction change.

            // Checks if the user presses W, S, D or A.
            // Then moves the snake control one column or row up or down
            // depending on what key is pressed.
            if(e.KeyCode == Keys.W)
            {
                int row = snakeGrid.GetRow(snake);
                int col = snakeGrid.GetColumn(snake);

                row--;

                // Checks if the row variable is valid.
                // If not returns to hinder a crash.
                if (row == -1)
                    return;

                // Checks if the row its trying to move to has the apple.


                PlaceControl(snake, row, col);
            }
            else if(e.KeyCode == Keys.S)
            {
                int row = snakeGrid.GetRow(snake);
                int col = snakeGrid.GetColumn(snake);

                row++;

                // Checks if the row variable is valid.
                // If not returns to hinder a crash.
                if (row >= snakeGrid.RowCount)
                    return;

                PlaceControl(snake, row, col);
            }
            else if(e.KeyCode == Keys.D)
            {
                int row = snakeGrid.GetRow(snake);
                int col = snakeGrid.GetColumn(snake);

                col++;

                // Checks if the col variable is valid.
                // If not returns to hinder a crash.
                if (col >= snakeGrid.RowCount)
                    return;

                PlaceControl(snake, row, col);
            }
            else if(e.KeyCode == Keys.A)
            {
                int row = snakeGrid.GetRow(snake);
                int col = snakeGrid.GetColumn(snake);

                col--;

                // Checks if the col variable is valid.
                // If not returns to hinder a crash.
                if (col == -1)
                    return;

                PlaceControl(snake, row, col);
            }
            //----------------------------------------

        }
    }
}
