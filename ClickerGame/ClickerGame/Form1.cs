using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        // The variable that stores the points the user have
        // and how many points per click they get.
        int points = 0;
        int pointsPerClick = 1;

        int upgradePrice;
        int autoPointsPerSecond = 1;

        bool isDone = false;
        bool[] upgradesBought = new bool[18];

        public Form1()
        {
            InitializeComponent();
        }

        // Increases the points by pointsPerClick and displayes
        // the points in ClickerCounter labes text when the button is clicked. 
        private void ClickerButton_Click(object sender, EventArgs e)
        {
            points += pointsPerClick;
            ClickerCounter.Text = points.ToString();
        }

        // If points is bigge ror equals upgradePrice you start the AutoPoints funksjon.
        private void Upgrade1_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if(points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade1.Text = "";
                Upgrade1.Enabled = false;
            }
        }

        private void Upgrade2_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                pointsPerClick *= 2;
                upgradesBought[1] = true;
                Upgrade2.Enabled = false;
            }
        }

        private void Upgrade3_Click(object sender, EventArgs e)
        {
            upgradePrice = 50;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                pointsPerClick *= 3;
                upgradesBought[2] = true;
                Upgrade3.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (upgradesBought[0])
            {
                points += autoPointsPerSecond;
                ClickerCounter.Text = points.ToString();


                if (Upgrade1.Text != ".....")
                {
                    Upgrade1.Text += ".";
                }
                else
                {
                    Upgrade1.Text = "";
                }
            }
        }
    }
}
