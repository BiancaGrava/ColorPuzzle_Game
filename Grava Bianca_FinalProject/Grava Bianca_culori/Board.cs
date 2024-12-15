using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class Board
    {
        public Button[,] Buttons;
        public Color color;
        private Color defaultColor = Color.AliceBlue;
        private int width;
        private int height;
        public Board(int height, int width, Color colour)
        {
            this.width = width;
            this.height = height;
            Button[,] b = new Button[height, width];
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    b[i, j] = new Button();
                    b[i, j].Size = new Size(80, 80);//stabilire dimensiuni buton
                    b[i, j].Location = new Point(15 + (80 + 10) * j, 13 + (80 + 10) * i); // Adjust position with spacing
                    b[i, j].Enabled = true;
                    b[i, j].BackColor = defaultColor;
                    b[i, j].Click += new System.EventHandler(buton_clic);
                }
            Buttons = b;
            color = colour;
        }
        public void initialColorReset()
        {
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    Buttons[i, j].Enabled = true;
                    Buttons[i, j].BackColor = defaultColor;
                }
        }
        public void buton_clic(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < height; i++)
                for (j = 0; j < width; j++)
                    if (Buttons[i, j] == sender)
                    {
                        changeColor(Buttons[i, j]);
                        if (i > 0) changeColor(Buttons[i - 1, j]);
                        if (i < height - 1) changeColor(Buttons[i + 1, j]);
                        if (j > 0) changeColor(Buttons[i, j - 1]);
                        if (j < width - 1) changeColor(Buttons[i, j + 1]);
                        if (won_game())
                        {
                            Winner winner = new Winner();
                            winner.Show();
                            for (i = 0; i < height; i++)
                                for (j = 0; j < width; j++)
                                {

                                    Buttons[i, j].Enabled = false;//dezactivare buton
                                }
                        }
                    }
        }
        public void changeColor(Button x)
        {
            if (x.BackColor == defaultColor)
                x.BackColor = color;
            else
                x.BackColor = defaultColor;
        }
        private bool won_game()
        {
            int i, j;
            for (i = 0; i < height; i++)
                for (j = 0; j < width; j++)
                    if (Buttons[i, j].BackColor == defaultColor)
                        return false;
            return true;
        }
    }
}
