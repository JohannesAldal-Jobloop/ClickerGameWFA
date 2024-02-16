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

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && player1.Location.Y == topWallY)
            {
                player1.Location = new Point(player1.Location.X, player1.Location.Y - moveIntervall);
            }
            else if (e.KeyCode == Keys.S && player1.Location.Y == bottomWallY)
            {
                player1.Location = new Point(player1.Location.X, player1.Location.Y + moveIntervall);
            }

            if(e.KeyCode == Keys.Up)
            {
                player2.Location = new Point(player2.Location.X, player2.Location.Y - moveIntervall);
            }
            else if(e.KeyCode == Keys.Down)
            {
                player2.Location = new Point(player2.Location.X, player2.Location.Y + moveIntervall);
            }
        }
    }
}