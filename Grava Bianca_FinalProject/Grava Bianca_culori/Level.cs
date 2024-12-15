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
        /// <summary>
        /// An instance of the <see cref="IBoardPreparer"/> interface, responsible for preparing the game board.
        /// </summary>
        IBoardPreparer boardPreparer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Level"/> form and sets up the game board with buttons.
        /// </summary>
        /// <param name="boarder">An implementation of the <see cref="IBoardPreparer"/> interface to set up the board.</param>
        public Level(IBoardPreparer boarder)
        {
            InitializeComponent();

            // Prepare the board with the specified height and width.
            boarder.PrepareBoard(boarder.Height, boarder.Width);

            // Get the buttons array from the board.
            Button[,] buttons = boarder.Board.Buttons;

            // Add each button to the form's controls.
            for (int i = 0; i < boarder.Height; i++)
            {
                for (int j = 0; j < boarder.Width; j++)
                {
                    this.Controls.Add(buttons[i, j]);
                }
            }

            // Store the board preparer instance.
            boardPreparer = boarder;

            // Update the label and button with board-related information.
            this.label1.Text = boarder.Description;
            this.button1.BackColor = boarder.Board.color;
        }


        /// <summary>
        /// Closes the level form when the close button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event data.</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Resets the game board to its initial state when the reset button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event data.</param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            boardPreparer.Reset();
        }

    }
}
