using System;
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
    public partial class Form6 : Form
    {
        private int moveIntervall = 10;
        private int bottomWallY = 338;
        private int topWallY = 12;
        private int ballMoveDirection = 1;

        private Point player1StartLocation = new Point(50, 163);
        private Point player2StartLocation = new Point(520, 163);

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            player1.Location = player1StartLocation; 
            player2.Location = player2StartLocation;
            WindowState = FormWindowState.Maximized;
            timer1.Start();
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                player1.Location = new Point(player1.Location.X, player1.Location.Y - moveIntervall);
            }
            else if (e.KeyCode == Keys.S)
            {
                player1.Location = new Point(player1.Location.X, player1.Location.Y + moveIntervall);
            }

            if (e.KeyCode == Keys.Up)
            {
                player2.Location = new Point(player2.Location.X, player2.Location.Y - moveIntervall);
            }
            else if (e.KeyCode == Keys.Down)
            {
                player2.Location = new Point(player2.Location.X, player2.Location.Y + moveIntervall);
            }
        }

        private void Form6_KeyDownPlayer1(object sender, KeyEventArgs e)
        {
        }

        private void Form6_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point newBallPoint = new Point(ball.Location.X + ballMoveDirection, ball.Location.Y);

            //if()
            //{
            //    ballMoveDirection *= -1;
            //}


            //if(ball.Location.Y == player1.Location.Y && ball.Location.X == player1.Location.X)
            //{
            //    ballMoveDirection = 1;
            //}
            //else if (ball.Location.Y == player2.Location.Y && ball.Location.X == player2.Location.X)
            //{
            //    ballMoveDirection = -1;
            //}

            ball.Location = newBallPoint;
        }
    }
}