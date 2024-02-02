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

        // Each of these letters is an intresting icon in the webdings font,
        // and each icon appears twice in this list
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        public Form3()
        {
            InitializeComponent();
        }
    }
}
