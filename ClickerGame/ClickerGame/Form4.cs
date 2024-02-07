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
        public int randomRow;
        public int randomCol;
        public int gridMinPosition = 0;
        public int gridMaxPosition;
        public string autoMoveDirection;

        public bool gameOverShown = false;

        private List<FlowLayoutPanel> snakePices = new List<FlowLayoutPanel>();
        private List<int> snakeMovesLoggRow = new List<int>();
        private List<int> snakeMovesLoggCol = new List<int>();

        public Form4()
        {
            InitializeComponent();
            autoMovementTimer.Start();
            snakePices.Add(snake);
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

                FlowLayoutPanel newSnakePice = new FlowLayoutPanel();
                newSnakePice.BackColor = Color.LimeGreen;
                snakePices.Add(newSnakePice);

                PlaceControl(apple, randomRow, randomCol);
                PlaceControl(snake, appleRow, appleCol);
                PlaceControl(newSnakePice,0,0);
            }
        }

        private void CheckForSnake(int row, int col)
        {
            // Checks if the row its trying to move to has the apple.
            // If true changes the apple for another snake pice.
            int snakeRow = snakeGrid.GetRow(snake);
            int snakeCol = snakeGrid.GetColumn(snake);

            if (row == snakeRow && col == snakeCol)
            {
                GameOverMessage();
            }
        }

        private void GameOverMessage()
        {
            if (!gameOverShown)
            {
                MessageBox.Show("Game Over", "Game Over");
                autoMovementTimer.Stop();
                gameOverShown = true;
            }
            
        }

        private void LoggPreviuosMoves(int preRow, int preCol)
        {
            if (snakePices.Count > 1)
            {
                if(snakeMovesLoggCol.Count == 0 && snakeMovesLoggRow.Count == 0)
                {
                    snakeMovesLoggRow.Add(preRow);
                    snakeMovesLoggCol.Add(preCol);
                    Console.WriteLine(snakeMovesLoggRow.First() + ", " + snakeMovesLoggCol.First() + ": " + snakeMovesLoggCol.Count);
                }
                else
                {
                    snakeMovesLoggRow.Insert(0, preRow);
                    snakeMovesLoggCol.Insert(0, preCol);
                    Console.WriteLine(snakeMovesLoggRow.First() + ", " + snakeMovesLoggCol.First() + ": " + snakeMovesLoggCol.Count);
                }
                
            }
        }

        private void Form4_Activated(object sender, EventArgs e)
        {
            autoMoveDirection = "up";
            RandomRowCol();
            PlaceControl(apple, randomCol, randomRow);
        }

        private void WSDATestMovement(KeyEventArgs e)
        {
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
            else if (e.KeyCode == Keys.S)
            {
                row++;

                // Checks if the row variable is valid.
                // If not returns to hinder a crash.
                if (row >= snakeGrid.RowCount)
                    return;

                PlaceControl(snake, row, col);
            }
            else if (e.KeyCode == Keys.D)
            {
                col++;

                // Checks if the col variable is valid.
                // If not returns to hinder a crash.
                if (col >= snakeGrid.ColumnCount)
                    return;

                // Checks if the row its trying to move to has the apple.
                CheckForApple(row, col);

                PlaceControl(snake, row, col);
            }
            else if (e.KeyCode == Keys.A)
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
        }
        
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            //---------- Snake WSDA movement----------
            // This is for testing purposes,
            // the final product will have automatic movement with direction change.

            // Checks if the user presses W, S, D or A.
            // Then moves the snake control one column or row up or down
            // depending on what key is pressed.

            //WSDATestMovement(e);
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

            int previousRow = row;
            int previousCol = col;

            if (autoMoveDirection == "up")
            {
                row--;

                // Checks if the row variable is valid.
                // If not returns to hinder a crash.
                if (row == -1)
                {
                    //GameOverMessage();
                    autoMovementTimer.Stop();
                    return;
                }
                    


                // Checks if there is a snake in the row its trying to move to.
                // Game Over if true.
                //CheckForSnake(row, col);
                    

                // Checks if the row its trying to move to has the apple.
                CheckForApple(row, col);

                LoggPreviuosMoves(previousRow, previousCol);
                
                PlaceControl(snake, row, col);
            }
            else if (autoMoveDirection == "down")
            {
                row++;

                // Checks if the row variable is valid.
                // If not returns to hinder a crash.
                if (row >= snakeGrid.RowCount)
                {
                    //GameOverMessage();
                    autoMovementTimer.Stop();
                    return;
                }

                // Checks if the row its trying to move to has the apple.
                CheckForApple(row, col);

                LoggPreviuosMoves(previousRow, previousCol);

                PlaceControl(snake, row, col);
            }
            else if (autoMoveDirection == "right")
            {
                col++;

                // Checks if the row variable is valid.
                // If not returns to hinder a crash.
                if (col >= snakeGrid.ColumnCount)
                {
                    //GameOverMessage();
                    autoMovementTimer.Stop();
                    return;
                }

                // Checks if the row its trying to move to has the apple.
                CheckForApple(row, col);

                LoggPreviuosMoves(previousRow, previousCol);

                PlaceControl(snake, row, col);
            }
            else if (autoMoveDirection == "left")
            {
                col--;

                // Checks if the row variable is valid.
                // If not returns to hinder a crash.
                if (col == -1)
                {
                    //GameOverMessage();
                    autoMovementTimer.Stop();
                    return;
                }

                // Checks if the row its trying to move to has the apple.
                CheckForApple(row, col);

                LoggPreviuosMoves(previousRow, previousCol);

                PlaceControl(snake, row, col);
            }
        }
    }
}
