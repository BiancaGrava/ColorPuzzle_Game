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
        /// <summary>
        /// Height of the game board.
        /// </summary>
        public int height;

        /// <summary>
        /// Width of the game board.
        /// </summary>
        public int width;

        /// <summary>
        /// A list of possible board levels (Simple, Medium, and Difficult) in this specific case.
        /// </summary>
        public List<IBoardPreparer> possibleLevels;

        /// <summary>
        /// Initializes a new instance of the <see cref="Menu"/> form.
        /// Sets the height, width, and defines the possible game levels.
        /// </summary>
        /// <param name="height">The height of the game board.</param>
        /// <param name="width">The width of the game board.</param>
        public Menu(int height, int width, IColorer c4)
        {
            InitializeComponent();
            this.height = height;
            this.width = width;

            // Initialize the possible game levels (Simple, Medium, and Difficult).
            possibleLevels = new List<IBoardPreparer>() {
                new SimpleBoardPreparer(height, width,c4),
                new MediumBoardPreparer(height, width,c4),
                new DifficultBoardPreparer(height, width,c4)
            };
        }

        /// <summary>
        /// Event handler for the 'Exit' button click. Closes the application.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler for the 'Simple' button click. Starts a new game with the Simple level.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the SimpleBoardPreparer from the list of possible levels
            SimpleBoardPreparer sp = (SimpleBoardPreparer)possibleLevels[0];

            // Create a new Level form and pass the SimpleBoardPreparer to it
            Level lForm = new Level(sp);

            // Show the Level form
            lForm.Show();
        }

        /// <summary>
        /// Event handler for the 'Medium' button click. Starts a new game with the Medium level.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            // Get the MediumBoardPreparer from the list of possible levels
            MediumBoardPreparer mp = (MediumBoardPreparer)possibleLevels[1];

            // Create a new Level form and pass the MediumBoardPreparer to it
            Level lForm = new Level(mp);

            // Show the Level form
            lForm.Show();
        }

        /// <summary>
        /// Event handler for the 'Difficult' button click. Starts a new game with the Difficult level.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event data.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            // Get the DifficultBoardPreparer from the list of possible levels
            DifficultBoardPreparer dp = (DifficultBoardPreparer)possibleLevels[2];

            // Create a new Level form and pass the DifficultBoardPreparer to it
            Level lForm = new Level(dp);

            // Show the Level form
            lForm.Show();
        }

        /// <summary>
        /// Event handler for the 'Close' button click. Closes the menu form.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event data.</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
