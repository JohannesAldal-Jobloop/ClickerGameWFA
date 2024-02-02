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
    public partial class Form3 : Form
    {
        // Use this Random object to choose random icon for the squares
        Random random = new Random();

        // firstClicked points to the first Label control
        // that the player clicks, but it will be null
        // if the player hasn't clciked a label yet.
        Label firstCliked = null;

        // secondClicked points to the second Label control
        // that the player clicks.
        Label secondClicked = null;

        // Each of these letters is an intresting icon in the webdings font,
        // and each icon appears twice in this list.
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        public Form3()
        {
            InitializeComponent();
            AssignIconToSquares();
        }

        private void AssignIconToSquares()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if(iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        /// <summary>
        /// Every label's Click event is handled by this event handler
        /// </summary>
        /// <param name="sender">The label thats was clicked</param>
        /// <param name="e"></param>
        private void Label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if(clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed -- 
                // ignore the click.
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if(firstCliked == null)
                {
                    firstCliked = clickedLabel;
                    firstCliked.ForeColor = Color.Black;

                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();

                if (firstCliked.Text == secondClicked.Text)
                {
                    firstCliked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();

            }
        }

        private void CheckForWinner()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLable = control as Label;

                if (iconLable != null)
                {
                    if (iconLable.ForeColor == iconLable.BackColor)
                        return;
                    
                }
            }

            MessageBox.Show("Congratulations!","You won!");
            Close();
        }

        /// <summary>
        /// This timer is started when the player clicks
        /// two icons that don't match,
        /// so it counts three quarters of a second
        /// and then turns itself off and hides both icons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stp the timer.
            timer1.Stop();

            // Hide both icons.
            firstCliked.ForeColor = firstCliked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked
            // so the next time a label is
            // clciked, the program knows it's the first click.
            firstCliked = null;
            secondClicked = null;
        }
    }
}
