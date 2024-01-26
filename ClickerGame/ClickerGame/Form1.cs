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
        int autoPointsPerSecond;

        public Form1()
        {
            InitializeComponent();
        }

        // Aoutomaticly increases points by pointsPerSecond per second.
        public void AutoPoints( int pointsPerSecond)
        {
            for (int i = 0; i < 10; i++)
            {
                Debug.WriteLine("loop");
                points += pointsPerSecond;
                ClickerCounter.Text = points.ToString();
                Thread.Sleep(1000);
            }
            
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
                AutoPoints(1);
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
                Upgrade3.Enabled = false;
            }
        }
    }
}
