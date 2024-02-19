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
    public partial class Form5 : Form
    {
        // Arrays with all the start positions of the squares of the Tetrominos.
        private int[] piceI = {0,0, 0,1, 0,2, 0,3};
        private int[] piceO = {0,0, 0,1, 1,0, 1,1};
        private int[] piceT = {0,1, 1,0, 1,1, 1,2};
        private int[] piceS = {0,1, 0,2, 1,0, 1,1};
        private int[] piceZ = {0,0, 0,1, 1,1, 1,2};
        private int[] piceJ = {0,0, 1,0, 1,1, 1,2};
        private int[] piceL = {0,2, 1,0, 1,1, 1,2};

        public Form5()
        {
            InitializeComponent();
        }

        private void MakeTetrominoInGridd(int[] piceArray)
        {
            for (int i = 0; i < piceArray.Length; i++)
            {
                FlowLayoutPanel newBlock = new FlowLayoutPanel();

                // Legg inn ein ny FlowLayoutPanel på neste kordinat i piceArray
            }
        }
    }
}
