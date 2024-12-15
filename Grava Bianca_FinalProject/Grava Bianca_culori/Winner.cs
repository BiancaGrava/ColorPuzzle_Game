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
    public partial class Winner : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Winner"/> form.
        /// This is the form that will be shown when the player wins the game.
        /// </summary>
        public Winner()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the 'Close' button click. Closes the winner form.
        /// </summary>
        /// <param name="sender">The object that triggered the event (the 'Close' button).</param>
        /// <param name="e">Event data.</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Closes the winner form when the 'Close' button is clicked
            this.Close();
        }
    }
}
