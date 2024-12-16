using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Grava_Bianca_culori
{
    public interface IBoardPreparer
    {
        /// <summary>
        /// Gets the description of the board preparation level.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the width of the board.
        /// </summary>
        int Width { get; }

        /// <summary>
        /// Gets the height of the board.
        /// </summary>
        int Height { get; }

        /// <summary>
        /// Gets the current board instance.
        /// </summary>
        Board Board { get; }

        /// <summary>
        /// Prepares the game board with specified dimensions and settings for the level.
        /// </summary>
        /// <param name="height">The height (number of rows) of the game board.</param>
        /// <param name="width">The width (number of columns) of the game board.</param>
        void PrepareBoard(int height, int width);

        /// <summary>
        /// Resets the game board to its initial state.
        /// </summary>
        void Reset();
    }

    class SimpleBoardPreparer : IBoardPreparer
    {
        //board information
        int width;
        int height;
        Board board;
        IColorer colorer;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleBoardPreparer"/> class with the specified height and width.
        /// </summary>
        /// <param name="Height">The height (number of rows) of the game board.</param>
        /// <param name="Width">The width (number of columns) of the game board.</param>
        public SimpleBoardPreparer(int Height, int Width, IColorer colourer)
        {
            width = Width;
            height = Height;
            colorer= colourer;
        }

        /// <summary>
        /// Prepares the game board for level 1 by creating a board with the given dimensions and a predefined color.
        /// </summary>
        /// <param name="height">The height (number of rows) of the game board.</param>
        /// <param name="width">The width (number of columns) of the game board.</param>
        public void PrepareBoard(int height, int width)
        {
            board = new Board(height, width, Color.RoyalBlue,colorer);
        }

        /// <summary>
        /// Resets the game board to its initial state with all buttons in the default color.
        /// </summary>
        public void Reset()
        {
            board.initialColorReset();
        }

        /// <summary>
        /// Gets the description of the board level, which is "level1".
        /// </summary>
        string IBoardPreparer.Description => "level1";

        /// <summary>
        /// Gets the width of the board.
        /// </summary>
        int IBoardPreparer.Width => width;

        /// <summary>
        /// Gets the height of the board.
        /// </summary>
        int IBoardPreparer.Height => height;

        /// <summary>
        /// Gets the current board instance.
        /// </summary>
        Board IBoardPreparer.Board => board;
    }

    class MediumBoardPreparer : IBoardPreparer
    {
        //board information
        int width;
        int height;
        Board board;
        IColorer colorer;

        /// <summary>
        /// Initializes a new instance of the <see cref="MediumBoardPreparer"/> class with the specified height and width.
        /// </summary>
        /// <param name="Height">The height (number of rows) of the game board.</param>
        /// <param name="Width">The width (number of columns) of the game board.</param>
        public MediumBoardPreparer(int Height, int Width, IColorer colourer)
        {
            width = Width;
            height = Height;
            colorer = colourer;
        }

        /// <summary>
        /// Prepares the game board for level 2 by creating a board with the specified dimensions and a predefined color,
        /// and applies additional initial configurations based on the board size.
        /// </summary>
        /// <param name="height">The height (number of rows) of the game board.</param>
        /// <param name="width">The width (number of columns) of the game board.</param>
        public void PrepareBoard(int height, int width)
        {
            board = new Board(height, width, Color.SeaGreen,colorer);

            // Apply different color configurations based on the board dimensions
            if (width == 2 || height == 2)
            {
                board.Buttons[0, width - 1].BackColor = Color.SeaGreen;
            }
            else if (width >= 3 && height >= 3)
            {
                colorer.coloring(board, 1, width - 1);
            }
        }

        /// <summary>
        /// Resets the game board to its initial state with all buttons in the default color.
        /// It also re-applies the initial configurations based on the board size.
        /// </summary>
        public void Reset()
        {
            board.initialColorReset();

            // Reapply initial color configurations based on the dimensions of the board
            if (width == 2 || height == 2)
            {
                board.Buttons[0, width - 1].BackColor = Color.SeaGreen;
            }
            else if (width >= 3 && height >= 3)
            {
                colorer.coloring(board, 1, width - 1);
            }
        }

        /// <summary>
        /// Gets the description of the board level, which is "level2".
        /// </summary>
        string IBoardPreparer.Description => "level2";

        /// <summary>
        /// Gets the width of the board.
        /// </summary>
        int IBoardPreparer.Width => width;

        /// <summary>
        /// Gets the height of the board.
        /// </summary>
        int IBoardPreparer.Height => height;

        /// <summary>
        /// Gets the current board instance.
        /// </summary>
        Board IBoardPreparer.Board => board;
    }

    class DifficultBoardPreparer : IBoardPreparer
    {
        //board information
        int width;
        int height;
        Board board;
        IColorer colorer;

        /// <summary>
        /// Initializes a new instance of the <see cref="DifficultBoardPreparer"/> class with the specified height and width.
        /// </summary>
        /// <param name="Height">The height (number of rows) of the game board.</param>
        /// <param name="Width">The width (number of columns) of the game board.</param>
        public DifficultBoardPreparer(int Height, int Width, IColorer colourer)
        {
            width = Width;
            height = Height;
            colorer = colourer;
        }

        /// <summary>
        /// Prepares the game board for level 3 by creating a randomized board layout with some buttons pre-colored.
        /// The top-left corner is left in the default color to avoid an initial win condition.
        /// </summary>
        /// <param name="height">The height (number of rows) of the game board.</param>
        /// <param name="width">The width (number of columns) of the game board.</param>
        public void PrepareBoard(int height, int width)
        {
            board = new Board(height, width, Color.Violet, colorer);
            int i, j;
            int y;
            Random rnd = new Random();

            // Ensure the top-left corner is not pre-colored
            for (i = 0; i < height; i++)
                for (j = 0; j < width; j++)
                {
                    y = rnd.Next(0, 2);  // Randomly decide if the button should be colored
                    if (y == 1 && (i != 0 || j != 0))
                    {
                        board.Buttons[i, j].BackColor = Color.Violet;
                    }
                }
        }

        /// <summary>
        /// Resets the game board to its initial state, ensuring the top-left corner remains in the default color.
        /// </summary>
        public void Reset()
        {
            board.initialColorReset();

            int y;
            Random rnd = new Random();

            // Reapply the randomized color setup with the top-left corner left in the default color
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    y = rnd.Next(0, 2);  // Randomly decide if the button should be colored
                    if (y == 1 && (i != 0 || j != 0))
                    {
                        board.Buttons[i, j].BackColor = Color.Violet;
                    }
                }
        }

        /// <summary>
        /// Gets the description of the board level, which is "level3".
        /// </summary>
        string IBoardPreparer.Description => "level3";

        /// <summary>
        /// Gets the width of the board.
        /// </summary>
        int IBoardPreparer.Width => width;

        /// <summary>
        /// Gets the height of the board.
        /// </summary>
        int IBoardPreparer.Height => height;

        /// <summary>
        /// Gets the current board instance.
        /// </summary>
        Board IBoardPreparer.Board => board;
    }
}
