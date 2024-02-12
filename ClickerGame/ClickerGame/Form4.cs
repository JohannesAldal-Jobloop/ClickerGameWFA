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
    public partial class Form4 : Form
    {
        //---------- Variebles for custom grid sise ---------
        private int customGridSize = 20;
        //---------------------------------------------------

        public int randomRow;
        public int randomCol;
        public int gridMinPosition = 0;
        public int gridMaxPosition;

        public string autoMoveDirection;
        private string hitEdgeGameOverMessage = "You hit the edge!";
        private string hitSnakeGameOverMessage = "You hit your own snake body!";

        public bool gameOverShown = false;
        public bool appleFound = false;
        public bool snakeFound = false;

        private List<FlowLayoutPanel> snakeBodyPices = new List<FlowLayoutPanel>();
        private List<int> snakeMovesLoggRow = new List<int>();
        private List<int> snakeMovesLoggCol = new List<int>();

        public Form4()
        {
            InitializeComponent();

            //---------- Attemt at custom grid size ----------
            //snakeGrid.RowCount = customGridSize;
            //snakeGrid.ColumnCount = customGridSize;
            //snakeGrid.ColumnStyles(SizeType.Absolute, true);

            //for (int i = 0; i < customGridSize; i++)
            //{

            //}
            //------------------------------------------------

            gridMaxPosition = snakeGrid.ColumnCount;
        }

        //---------- MOVEMENT CHECKS ----------

        // Checks if the position the snakHead wants to move to has an apple.
        private void CheckForApple(int row, int col)
        {
            // Checks if the row its trying to move to has the apple.
            // If true changes the apple for another snake pice.
            int appleRow = snakeGrid.GetRow(apple);
            int appleCol = snakeGrid.GetColumn(apple);

            if (row == appleRow && col == appleCol)
            {
                appleFound = true;

                // Finds a random new position for the apple.
                RandomRowCol();

                // Removes the apple from its current posistion.
                snakeGrid.Controls.Remove(apple);

                // Creates a new snakeBodyPice and.
                FlowLayoutPanel newSnakeBodyPice = new FlowLayoutPanel();
                newSnakeBodyPice.BackColor = Color.LimeGreen;
                snakeBodyPices.Add(newSnakeBodyPice);

                // Moves the apple to its new random posistion.
                PlaceControl(apple, randomRow, randomCol);
                appleFound = false;

                // Moves the snakeHead and the newSnakeBodyPice to their new posistions.
                PlaceControl(snakeHead, appleRow, appleCol);
                PlaceControl(newSnakeBodyPice, snakeMovesLoggRow[0], snakeMovesLoggCol[0]);
            }
            else
            {
                appleFound = false;
            }
        } 

        // Checks the next cell the snakeHead wants to move to,
        // if there is a snakeBodyPice snakeFound = true
        private void CheckForSnake(int row, int col)
        {
            // Checks if each snakeBodyPice's posistion
            // matches the posistion the snakeHead wants to move to.
            // If true, set snakeFound to true
            foreach(FlowLayoutPanel snakeBody in snakeBodyPices)
            {
                int snakeBodyRow = snakeGrid.GetRow(snakeBody);
                int snakeBodyCol = snakeGrid.GetColumn(snakeBody);

                if( row ==  snakeBodyRow && col == snakeBodyCol)
                {
                    snakeFound = true;
                }
            }
        }

        // Collects all the nessesery checks for one move of the snake in one function.
        private void MovementChecks(int row, int col, int previousRow, int previousCol)
        {
            // Checks for an apple or a snake pice
            // in the cell it wants to move to
            if(snakeBodyPices.Count != 0)
            {
                CheckForSnake(row, col);
            }
                
            // If snakeFound is true stop the autoMovementTimer
            // and show game over message.
            if (snakeFound)
            {
                autoMovementTimer.Stop();
                GameOverMessage(hitSnakeGameOverMessage);
            }

            // Checks if the posistion the snakeHead wants to move to has an apple.
            // If true delets the apple and spwans a new snakeBodyPice.
            CheckForApple(row, col);

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

        //-------------------------------------



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

        // Testing only
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

        // Fuckction that handles everything with auto movement.
        private void AutoMovement(int row, int col, int previousRow, int previousCol)
        {
            // Checks what autoMoveDirection is and
            // tryes to move the snakeHead that direction.
            if (autoMoveDirection == "up")
            {
                row--;

                // Checks if the row variable is valid.
                // If not shows game over message and returns
                // to stop the movement that would cause a crash.
                if (row == -1)
                {
                    autoMovementTimer.Stop();
                    GameOverMessage(hitEdgeGameOverMessage);
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
                // If not shows game over message and returns
                // to stop the movement that would cause a crash.
                if (row >= snakeGrid.RowCount)
                {
                    
                    autoMovementTimer.Stop();
                    GameOverMessage(hitEdgeGameOverMessage);
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
                // If not shows game over message and returns
                // to stop the movement that would cause a crash.
                if (col >= snakeGrid.ColumnCount)
                {
                    autoMovementTimer.Stop();
                    GameOverMessage(hitEdgeGameOverMessage);
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
                // If not shows game over message and returns
                // to stop the movement that would cause a crash.
                if (col == -1)
                {
                    autoMovementTimer.Stop();
                    GameOverMessage(hitEdgeGameOverMessage);
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




        // Setts randomCol and randomRow to two random integers
        private void RandomRowCol()
        {
            Random random = new Random();
            randomCol = random.Next(gridMinPosition, gridMaxPosition);
            randomRow = random.Next(gridMinPosition, gridMaxPosition);

            // Checks if the random position is the same as the snakes posistion.
            // If true randomise again.
            CheckForSnake(randomRow, randomCol);
            if (randomCol == snakeGrid.GetColumn(snakeHead) && randomRow == snakeGrid.GetRow(snakeHead) && snakeFound)
            {
                RandomRowCol();
            }
        }

        // Shows a game over message with the text gameOverMessage to the user.
        private void GameOverMessage(string gameOverMessage)
        {
            MessageBox.Show(gameOverMessage, "Game Over");
        }

        // Gets called eich time the window gets activated.
        private void Form4_Activated(object sender, EventArgs e)
        {
            // Checks if the grids row and col count is the same.
            // If not show error and close game.
            if (snakeGrid.RowCount == snakeGrid.ColumnCount)
            {
                // Start game
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
        
        // Function that listens to keypresses.
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
            // checks for WSDA input and changes move direction acordingly

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
        
        // Gets called ech tick decided by timer1's interval.
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Gets the position of snakeHead every tick.
            int row = snakeGrid.GetRow(snakeHead);
            int col = snakeGrid.GetColumn(snakeHead);

            // Saves the previous posistions in two variables.
            int previousRow = row;
            int previousCol = col;

            // Calls AutoMovement() once every tick
            AutoMovement(row, col, previousRow, previousCol);
        }
    }
}
