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
    public partial class Level : Form
    {
        IBoardPreparer boardPreparer;
        public Level(IBoardPreparer boarder)
        {
            InitializeComponent();
            boarder.PrepareBoard( boarder.Height,boarder.Width);
            Button[,] buttons=boarder.Board.Buttons;
           // this.Controls.Add(buttons);
            for (int i = 0; i < boarder.Height; i++)
            {
                for (int j = 0; j <boarder.Width; j++)
                {//
                    //buttons[i,j]= boarder.Board.Buttons[i,j];
                    this.Controls.Add(buttons[i, j]);
                }
            }
            boardPreparer= boarder;
            this.label1.Text=boarder.Description;
            this.button1.BackColor = boarder.Board.color;
        }

        private void Level_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            boardPreparer.Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
