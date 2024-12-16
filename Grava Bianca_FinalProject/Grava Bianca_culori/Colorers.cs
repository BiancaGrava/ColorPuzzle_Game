using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grava_Bianca_culori
{
    /// <summary>
    /// Represents an interface for defining coloring strategies on a game board.
    /// Classes implementing this interface must provide a method for coloring
    /// specific cells on the board and describe the coloring behavior.
    /// </summary>
    public interface IColorer
    {
        /// <summary>
        /// Gets the description of the coloring strategy.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Applies the coloring strategy to the specified cell and potentially its neighbors.
        /// </summary>
        /// <param name="board">The game board where the coloring strategy is applied.</param>
        /// <param name="i">The row index of the targeted cell.</param>
        /// <param name="j">The column index of the targeted cell.</param>
        void coloring(Board board, int i, int j);
    }

    /// <summary>
    /// Implements a coloring strategy that changes the color of the selected button and its four immediate neighbors
    /// (above, below, left, and right) on the game board.
    /// </summary>
    public class Color4Neighbours : IColorer
    {
        /// <summary>
        /// Applies the coloring strategy to the specified cell and its four immediate neighbors.
        /// </summary>
        /// <param name="board">The game board where the coloring strategy is applied.</param>
        /// <param name="i">The row index of the targeted cell.</param>
        /// <param name="j">The column index of the targeted cell.</param>
        public void coloring(Board board, int i, int j)
        {
            // Change the color of the target button
            board.changeColor(board.Buttons[i, j]);
            // Change the color of the button above
            if (i > 0) board.changeColor(board.Buttons[i - 1, j]);
            // Change the color of the button below
            if (i < board.height - 1) board.changeColor(board.Buttons[i + 1, j]);
            // Change the color of the button to the left
            if (j > 0) board.changeColor(board.Buttons[i, j - 1]);
            // Change the color of the button to the right
            if (j < board.width - 1) board.changeColor(board.Buttons[i, j + 1]);
        }

        /// <summary>
        /// Gets the description of the coloring strategy.
        /// </summary>
        string IColorer.Description => "Color4Neighbours";
    }

    /// <summary>
    /// Implements a coloring strategy that changes the color of the selected button and three of its neighbors
    /// (above, left, and right) on the game board.
    /// </summary>
    public class Color3Neighbours : IColorer
    {
        /// <summary>
        /// Applies the coloring strategy to the specified cell and three of its neighbors.
        /// </summary>
        /// <param name="board">The game board where the coloring strategy is applied.</param>
        /// <param name="i">The row index of the targeted cell.</param>
        /// <param name="j">The column index of the targeted cell.</param>
        public void coloring(Board board, int i, int j)
        {
            // Change the color of the target button
            board.changeColor(board.Buttons[i, j]);
            // Change the color of the button above
            if (i > 0) board.changeColor(board.Buttons[i - 1, j]);
            // Change the color of the button to the left
            if (j > 0) board.changeColor(board.Buttons[i, j - 1]);
            // Change the color of the button to the right
            if (j < board.width - 1) board.changeColor(board.Buttons[i, j + 1]);
        }

        /// <summary>
        /// Gets the description of the coloring strategy.
        /// </summary>
        string IColorer.Description => "Color3Neighbours";
    }
}
