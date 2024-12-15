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
    public partial class ErrorForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorForm"/> form.
        /// This constructor sets up the form with the necessary components for displaying an error message.
        /// </summary>
        public ErrorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the 'Close' button click. Closes the error form when the button is clicked.
        /// </summary>
        /// <param name="sender">The object that triggered the event (the 'Close' button).</param>
        /// <param name="e">Event data.</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Closes the error form when the 'Close' button is clicked
            this.Close();
        }
    }
}
