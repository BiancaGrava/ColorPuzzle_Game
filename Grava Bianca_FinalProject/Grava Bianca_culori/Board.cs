using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class.
        /// This constructor initializes the game grid with the given dimensions and color.
        /// </summary>
        /// <param name="height">The number of rows on the game board.</param>
        /// <param name="width">The number of columns on the game board.</param>
        /// <param name="colour">The color that will be used to toggle the buttons when clicked.</param>
        public Board(int height, int width, Color colour)
        {
            this.width = width;
            this.height = height;
            Button[,] b = new Button[height, width];

            // Initialize buttons and set their properties (size, location, color, etc.)
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    b[i, j] = new Button();
                    b[i, j].Size = new Size(80, 80); // Set button size (80x80 pixels)
                    // Set button position with spacing between buttons
                    b[i, j].Location = new Point(15 + (80 + 10) * j, 13 + (80 + 10) * i);
                    b[i, j].Enabled = true; // Make button clickable
                    b[i, j].BackColor = defaultColor; // Set initial button color
                    b[i, j].Click += new System.EventHandler(buton_clic); // Bind click event
                }

            Buttons = b;  // Assign the array of buttons to the class property
            color = colour; // Set the color to be used when a button is clicked
        }

        /// <summary>
        /// Resets the colors of all buttons to the default color and enables all buttons.
        /// This method is used to reset the game state for a new round.
        /// </summary>
        public void initialColorReset()
        {
            // Loop through all buttons and reset their color to default and enable them
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    Buttons[i, j].Enabled = true;  // Enable the button
                    Buttons[i, j].BackColor = defaultColor;  // Set the button back to the default color
                }
        }

        /// <summary>
        /// Handles the click event for any button on the board.
        /// This method toggles the color of the clicked button and its neighboring buttons (up, down, left, right).
        /// It also checks if the game is won after the color changes.
        /// </summary>
        /// <param name="sender">The object that triggered the event (the clicked button).</param>
        /// <param name="e">The event data.</param>
        public void buton_clic(object sender, EventArgs e)
        {
            int i, j;

            // Loop through the grid to find the button that was clicked
            for (i = 0; i < height; i++)
                for (j = 0; j < width; j++)
                    if (Buttons[i, j] == sender) // If this is the clicked button
                    {
                        // Change the color of the clicked button and its adjacent buttons
                        changeColor(Buttons[i, j]);
                        if (i > 0) changeColor(Buttons[i - 1, j]); // Change color of the button above
                        if (i < height - 1) changeColor(Buttons[i + 1, j]); // Change color of the button below
                        if (j > 0) changeColor(Buttons[i, j - 1]); // Change color of the button to the left
                        if (j < width - 1) changeColor(Buttons[i, j + 1]); // Change color of the button to the right

                        // Check if the game has been won (all buttons are now colored)
                        if (won_game())
                        {
                            // Display the winner form if the game is won
                            Winner winner = new Winner();
                            winner.Show();

                            // Disable all buttons to prevent further interaction
                            for (i = 0; i < height; i++)
                                for (j = 0; j < width; j++)
                                {
                                    Buttons[i, j].Enabled = false;  // Disable the button
                                }
                        }
                    }
        }

        /// <summary>
        /// Toggles the color of the specified button between the default color and the selected color.
        /// If the button's color is the default color, it changes to the selected color; otherwise, it changes back to the default.
        /// </summary>
        /// <param name="x">The button whose color will be changed.</param>
        public void changeColor(Button x)
        {
            // Toggle the button color between the default color and the selected color
            if (x.BackColor == defaultColor)
                x.BackColor = color;  // Change to the selected color
            else
                x.BackColor = defaultColor;  // Change back to the default color
        }

        /// <summary>
        /// Checks whether the game has been won, which happens when all buttons are colored (none have the default color).
        /// </summary>
        /// <returns>True if all buttons have been toggled to the selected color; otherwise, false.</returns>
        private bool won_game()
        {
            int i, j;

            // Loop through all the buttons and check if any of them still have the default color
            for (i = 0; i < height; i++)
                for (j = 0; j < width; j++)
                    if (Buttons[i, j].BackColor == defaultColor)
                        return false;  // If any button still has the default color, return false

            return true;  // All buttons are colored, so the game is won
        }
    }
}
