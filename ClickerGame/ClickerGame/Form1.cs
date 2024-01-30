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
        int pointsPerClickBase = 1;
        int pointsPerClickMultiplicand = 1;

        int upgradePrice;
        int autoPointsPerSecond;

        bool[] upgradesBought = new bool[18];

        public Form1()
        {
            InitializeComponent();
        }

        public void SimpleActiveAnimation( Button button)
        {
            // Må endra tallet i Upgrade1 til den knappen som du vill skal ha animasjonen
            button.Font = new Font("Arial", 20, FontStyle.Bold);
            if (button.Text != "•••••")
            {
                button.Text += "•";
            }
            else
            {
                button.Text = "";
            }
        }

        // Increases the points by pointsPerClick and displayes
        // the points in ClickerCounter labes text when the button is clicked. 
        private void ClickerButton_Click(object sender, EventArgs e)
        {
            points += (pointsPerClickBase * pointsPerClickMultiplicand);
            ClickerCounter.Text = points.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (upgradesBought[0])
            {
                points += autoPointsPerSecond;
                ClickerCounter.Text = points.ToString();

                SimpleActiveAnimation(Upgrade1);
            }
            if (upgradesBought[3])
            {
                SimpleActiveAnimation(Upgrade4);
            }
        }

        // If points is bigge or equals upgradePrice you buy the upgrade
        // and start does what the upgrade is.
        // -------------------------------------------------------------
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

                autoPointsPerSecond += 1;
            }
        }

        private void Upgrade2_Click(object sender, EventArgs e)
        {
            upgradePrice = 1;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                pointsPerClickMultiplicand = 2;
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
                pointsPerClickBase *= 3;
                upgradesBought[2] = true;
                Upgrade3.Enabled = false;
            }
        }

        private void Upgrade4_Click(object sender, EventArgs e)
        {
            upgradePrice = 2;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade4.Text = "";
                Upgrade4.Enabled = false;

                autoPointsPerSecond += 3;
            }
        }

        private void Upgrade5_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade5.Enabled = false;
            }
        }
        private void Upgrade6_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade6.Enabled = false;
            }
        }
        private void Upgrade7_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade7.Enabled = false;
            }
        }
        private void Upgrade8_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade8.Enabled = false;
            }
        }
        private void Upgrade9_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade9.Enabled = false;
            }
        }
        private void Upgrade10_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade10.Enabled = false;
            }
        }
        private void Upgrade11_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade11.Enabled = false;
            }
        }
        private void Upgrade12_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade12.Enabled = false;
            }
        }
        private void Upgrade13_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade13.Enabled = false;
            }
        }
        private void Upgrade14_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade14.Enabled = false;
            }
        }
        private void Upgrade15_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade15.Enabled = false;
            }
        }
        private void Upgrade16_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade16.Enabled = false;
            }
        }
        private void Upgrade17_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade17.Enabled = false;
            }
        }
        private void Upgrade18_Click(object sender, EventArgs e)
        {
            upgradePrice = 10;

            if (points >= upgradePrice)
            {
                points -= upgradePrice;
                ClickerCounter.Text = points.ToString();
                upgradesBought[0] = true;
                Upgrade18.Enabled = false;
            }
        }
        // -------------------------------------------------------------

    }
}
