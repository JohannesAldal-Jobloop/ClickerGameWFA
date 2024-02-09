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
        public bool appleFound = false;
        public bool snakeFound = false;

        private List<FlowLayoutPanel> snakeBodyPices = new List<FlowLayoutPanel>();
        private List<int> snakeMovesLoggRow = new List<int>();
        private List<int> snakeMovesLoggCol = new List<int>();

        public Form4()
        {
            InitializeComponent();

            gridMaxPosition = snakeGrid.ColumnCount;

            
            
        }

        // ---------- MOVEMENT CHECKS ----------

        private void CheckForApple(int row, int col)
        {
            // Checks if the row its trying to move to has the apple.
            // If true changes the apple for another snake pice.
            int appleRow = snakeGrid.GetRow(apple);
            int appleCol = snakeGrid.GetColumn(apple);

            if (row == appleRow && col == appleCol)
            {
                appleFound = true;

                RandomRowCol();
                snakeGrid.Controls.Remove(apple);

                FlowLayoutPanel newSnakeBodyPice = new FlowLayoutPanel();
                newSnakeBodyPice.BackColor = Color.LimeGreen;
                snakeBodyPices.Add(newSnakeBodyPice);

                PlaceControl(apple, randomRow, randomCol);
                appleFound = false;

                PlaceControl(snakeHead, appleRow, appleCol);
                PlaceControl(newSnakeBodyPice, snakeMovesLoggRow[0], snakeMovesLoggCol[0]);
            }
            else
            {
                appleFound = false;
            }
        }

        // Checks the next cell the snakeHead wants to,
        // if there is a snakeBodyPice there or the snakeHead
        private void CheckForSnake(int row, int col)
        {
            // Checks if the row its trying to move to has a snake pice.
            // If true changes the apple for another snake pice.
            int snakeRow = snakeGrid.GetRow(snakeHead);
            int snakeCol = snakeGrid.GetColumn(snakeHead);

            int snakebodycount = snakeBodyPices.Count;

            for (int i = 0; i < snakeBodyPices.Count; i++)
            {
                if (snakeMovesLoggRow[i] == row && snakeMovesLoggCol[i] == col)
                {
                    snakeFound = true;
                }
                else
                {
                    snakeFound = false;
                }
            }

            if (row == snakeRow && col == snakeCol)
            {
                snakeFound = true;
            }
            else
            {
                snakeFound = false;
            }
        }

        // Collects all the nessesery checks for one move of the snake in one function.
        private void MovementChecks(int row, int col, int previousRow, int previousCol)
        {
            // Checks for an apple or a snake pice
            // in the cell it wants to move to
            CheckForSnake(row, col);
            CheckForApple(row, col);

            if (snakeFound)
            {
                GameOverMessage();
            }

            // If none of the checks results in a game over logg the move.
            LoggPreviousMoves(previousRow, previousCol);

            // Moves the snakeHead
            PlaceControl(snakeHead, row, col);

            // If the snakeBodyPices has elements inn it move the pices
            if (snakeBodyPices.Count != 0)
            {
                MoveSnakebody();
            }
        }

        //--------------------------------------



        //---------- FUNCTIONS FOR MOVEMENT ----------

        // Places the apple in a random cell in the snakeGridd
        // Controls is a class with the controls for the design
        private void PlaceControl(Control control, int row, int col)
        {
            // Remove the control from its current position
            snakeGrid.Controls.Remove(control);

            // Insert the control at the new position
            snakeGrid.Controls.Add(control, col, row);
        }


        // Loggs the previous posistion to snakeHead when it moves.
        private void LoggPreviousMoves(int preRow, int preCol)
        {
            // If snakeMovesLoggCol and snakeMovesLoggRow's count is 0
            // add the previous row and col into them since its the first move.
            if (snakeMovesLoggCol.Count == 0 && snakeMovesLoggRow.Count == 0)
            {
                snakeMovesLoggRow.Add(preRow);
                snakeMovesLoggCol.Add(preCol);
            }
            else // Inserts the previous rom and col in the beginning of
                 // snakeMovesLoggCol and snakeMovesLoggRow.
            {
                snakeMovesLoggRow.Insert(0, preRow);
                snakeMovesLoggCol.Insert(0, preCol);
            }
        }

        // Moves the snakes body by moving each Control in snakePices with its
        // matching posistion in the logged moves.
        private void MoveSnakebody()
        {
            for (int i = 0; i < snakeBodyPices.Count; i++)
            {
                PlaceControl(snakeBodyPices[i], snakeMovesLoggRow[i], snakeMovesLoggCol[i]);
            }
        }

        private void WSDATestMovement(KeyEventArgs e)
        {
            int row = snakeGrid.GetRow(snakeHead);
            int col = snakeGrid.GetColumn(snakeHead);

            int previousRow = row;
            int previousCol = col;

            if (e.KeyCode == Keys.W)
            {
                row--;

                // Checks if the row variable is valid.
                // If not returns to hinder a crash.
                if (row == -1)
                    return;

                // Checks if the row its trying to move to has the apple.
                MovementChecks(row, col, previousRow, previousCol);
            }
            else if (e.KeyCode == Keys.S)
            {
                row++;

                // Checks if the row variable is valid.
                // If not returns to hinder a crash.
                if (row >= snakeGrid.RowCount)
                    return;

                MovementChecks(row, col, previousRow, previousCol);
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

                MovementChecks(row, col, previousRow, previousCol);
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

                MovementChecks(row, col, previousRow, previousCol);
            }
        } // Testing only

        private void AutoMovement(int row, int col, int previousRow, int previousCol)
        {
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
                // Checks if the row its trying to move to has the apple.
                // Moves snake body if there are any pices.
                MovementChecks(row, col, previousRow, previousCol);
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

                // Checks if there is a snake in the row its trying to move to.
                // Game Over if true.
                // Checks if the row its trying to move to has the apple.
                // Moves snake body if there are any pices.
                MovementChecks(row, col, previousRow, previousCol);
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

                // Checks if there is a snake in the row its trying to move to.
                // Game Over if true.
                // Checks if the row its trying to move to has the apple.
                // Moves snake body if there are any pices.
                MovementChecks(row, col, previousRow, previousCol);
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

                // Checks if there is a snake in the row its trying to move to.
                // Game Over if true.
                // Checks if the row its trying to move to has the apple.
                // Moves snake body if there are any pices.
                MovementChecks(row, col, previousRow, previousCol);
            }

        }

        //--------------------------------------------




        // setts randomCol and randomRow to two random intesgers
        private void RandomRowCol()
        {
            Random random = new Random();
            randomCol = random.Next(gridMinPosition, gridMaxPosition);
            randomRow = random.Next(gridMinPosition, gridMaxPosition);

            // Checks if the random position is teh same as the snakes posistion.
            // If true randomise again.
            CheckForSnake(randomRow, randomCol);
            if (randomCol == snakeGrid.GetColumn(snakeHead) && randomRow == snakeGrid.GetRow(snakeHead) && snakeFound)
            {
                RandomRowCol();
            }
        }

        private void GameOverMessage()
        {
            if (!gameOverShown)
            {
                MessageBox.Show("Game Over", "Game Over");
                gameOverShown = true;
            } else if (gameOverShown)
            {
                return;
            }
            
        }

        private void Form4_Activated(object sender, EventArgs e)
        {
            

            if (snakeGrid.RowCount == snakeGrid.ColumnCount)
            {
                autoMovementTimer.Start();
                autoMoveDirection = "up";
                RandomRowCol();
                PlaceControl(apple, randomCol, randomRow);
            }
            else
            {
                MessageBox.Show("Grid is not symetrical!", "ERROR");
                Close();
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
            // checks for WSDA input and changes its move direction acordingly

            if (e.KeyCode == Keys.W && autoMoveDirection != "down")
            {
                autoMoveDirection = "up";
            }
            else if (e.KeyCode == Keys.S && autoMoveDirection != "up")
            {
                autoMoveDirection = "down";
            }
            else if (e.KeyCode == Keys.D && autoMoveDirection != "left")
            {
                autoMoveDirection = "right";
            }
            else if (e.KeyCode == Keys.A && autoMoveDirection != "right")
            {
                autoMoveDirection = "left";
            }
            //--------------------------------------------------

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            int row = snakeGrid.GetRow(snakeHead);
            int col = snakeGrid.GetColumn(snakeHead);

            int previousRow = row;
            int previousCol = col;

            AutoMovement(row, col, previousRow, previousCol);
        }
    }
}
