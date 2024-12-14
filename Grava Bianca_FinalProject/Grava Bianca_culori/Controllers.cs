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
    public interface IBoardPreparer
    {
        string Description { get; }
        int Width {  get; }
        int Height { get; }
        Board Board { get; }
        void PrepareBoard( int height, int width);
        void Reset();
    }

    class SimpleBoardPreparer : IBoardPreparer
    {
        int width;
        int height;
        Board board;
        public SimpleBoardPreparer(int Height, int Width)
        {
            width=Width;
            height=Height;
        }
        public void PrepareBoard( int height, int width)
        {
            board= new Board( height, width, Color.RoyalBlue);
        }

        public void Reset()
        {
            board.initialColorReset();
        }

        string IBoardPreparer.Description => "level1";
        int IBoardPreparer.Width => width;
        int IBoardPreparer.Height => height;
        Board IBoardPreparer.Board => board;
    }

    class MediumBoardPreparer : IBoardPreparer
    {
        int width;
        int height;
        Board board;
        public MediumBoardPreparer( int Height, int Width)
        {
            width = Width;
            height = Height;
        }
        public void PrepareBoard( int height, int width)
        {
            board= new Board( height,width, Color.SeaGreen);
            if (width == 2 || height==2)
            {
                board.Buttons[0, width-1].BackColor = Color.SeaGreen;
            }
            else if (width >= 3&&height>=3)
            {
                board.Buttons[0, width-1].BackColor = Color.SeaGreen;
                board.Buttons[1, width - 1].BackColor = Color.SeaGreen;
                board.Buttons[1, width - 2].BackColor = Color.SeaGreen;
                board.Buttons[2, width-1].BackColor = Color.SeaGreen;
            }
        }

        public void Reset()
        {
            board.initialColorReset();

            if (width == 2 || height == 2)
            {
                board.Buttons[0, width - 1].BackColor = Color.SeaGreen;
            }
            else if (width >= 3 && height >= 3)
            {
                board.Buttons[0, width - 1].BackColor = Color.SeaGreen;
                board.Buttons[1, width - 1].BackColor = Color.SeaGreen;
                board.Buttons[1, width - 2].BackColor = Color.SeaGreen;
                board.Buttons[2, width - 1].BackColor = Color.SeaGreen;
            }
        }

        string IBoardPreparer.Description => "level2";
        int IBoardPreparer.Width => width;
        int IBoardPreparer.Height => height;
        Board IBoardPreparer.Board => board;
    }

    class DifficultBoardPreparer : IBoardPreparer
    {
        int width;
        int height;
        Board board;
        public DifficultBoardPreparer( int Height, int Width) {
            width = Width;
            height = Height;
        }
        public void PrepareBoard( int height, int width) {
            board= new Board( height,width,Color.Violet);
            int i, j;
            int y;
            Random rnd;
            rnd = new Random();
            for (i = 0; i <height; i++)
                for (j = 0; j <width; j++)
                {
                    y = rnd.Next(0, 2);
                    if (y == 1)
                    {
                        board.Buttons[i, j].BackColor = Color.Violet;
                    }
                }
        }

        public void Reset()
        {
            board.initialColorReset();

            int y;
            Random rnd;
            rnd = new Random();
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    y = rnd.Next(0, 2);
                    if (y == 1)
                    {
                        board.Buttons[i, j].BackColor = Color.Violet;
                    }
                }
        }

        string IBoardPreparer.Description => "level3";
        int IBoardPreparer.Width => width;
        int IBoardPreparer.Height => height;
        Board IBoardPreparer.Board => board; 
    }
}
