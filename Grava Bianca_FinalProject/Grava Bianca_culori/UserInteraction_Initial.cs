using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grava_Bianca_culori
{
    public partial class UserInteraction_Initial : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInteraction_Initial"/> form.
        /// This constructor sets up the initial form where users can input the dimensions of the game board.
        /// </summary>
        public UserInteraction_Initial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the 'Exit' button click. Exits the application.
        /// </summary>
        /// <param name="sender">The object that triggered the event (the 'Exit' button).</param>
        /// <param name="e">Event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            // Closes the application when the 'Exit' button is clicked
            Application.Exit();
        }

        /// <summary>
        /// Event handler for the 'Start' button click. Processes the user input for the board's width and height.
        /// Validates the input and opens the main menu if valid, otherwise shows an error form.
        /// </summary>
        /// <param name="sender">The object that triggered the event (the 'Start' button).</param>
        /// <param name="e">Event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            // Retrieve the input values from the textboxes
            string Width = textBoxWidth.Text;
            string Height = textBoxHeight.Text;
            int width, height;
            bool isError = false;

            // Try parsing the input values as integers
            if (!int.TryParse(Width, out width))
            {
                isError = true; // Flag as error if parsing fails
            }
            if (!int.TryParse(Height, out height))
            {
                isError = true; // Flag as error if parsing fails
            }

            // If there was an error, show an error form
            if (isError)
            {
                ErrorForm err = new ErrorForm();
                err.Show();
            }
            else
            {
                // If the input is valid, create the main menu form and pass the dimensions
                Menu form1 = new Menu(height, width);
                form1.Show();
            }
        }

        /// <summary>
        /// Event handler for text change in the 'Level' textbox.
        /// Currently not implemented, but can be used for additional functionality if needed in the future.
        /// </summary>
        /// <param name="sender">The object that triggered the event (the 'Level' textbox).</param>
        /// <param name="e">Event data.</param>
        private void textBoxLevel_TextChanged(object sender, EventArgs e)
        {
            // This method is currently empty, but could handle changes to the 'Level' textbox in the future
        }
    }
}
