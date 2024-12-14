using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grava_Bianca_culori
{
    public partial class Menu : Form
    {
        public int height;
        public int width;
        public List<IBoardPreparer> possibleLevels;
        public Menu(int height, int width)
        {
            InitializeComponent();
            this.height = height;
            this.width = width;
            possibleLevels = new List<IBoardPreparer>() { new SimpleBoardPreparer(height,width), 
                new MediumBoardPreparer(height,width),
                new DifficultBoardPreparer(height,width) };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleBoardPreparer sp = (SimpleBoardPreparer) possibleLevels[0];
            Level lForm = new Level(sp);
            lForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MediumBoardPreparer mp = (MediumBoardPreparer) possibleLevels[1];
            Level lForm = new Level(mp);
            lForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DifficultBoardPreparer dp = (DifficultBoardPreparer) possibleLevels[2];
            Level lForm = new Level(dp);
            lForm.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
