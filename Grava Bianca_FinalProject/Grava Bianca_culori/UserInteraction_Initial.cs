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
        public UserInteraction_Initial()
        {
            InitializeComponent();
        }

        private void UserInteraction_Initial_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string level = textBoxLevel.Text;
            string Width = textBoxWidth.Text;
            string Height = textBoxHeight.Text;
            int width,height;
            bool isError=false;
            if (!int.TryParse(Width, out width))
            {
                isError = true;
            }
            if (!int.TryParse(Height, out height))
            {
                isError = true;
            }
            if (isError)
            {
                ErrorForm err = new ErrorForm();
                err.Show();
            }
            else
            {
                Menu form1 = new Menu(height,width);
                form1.Show();
                /*if (level == "level1")
                {
                    SimpleBoardPreparer sp = new SimpleBoardPreparer( height, width );
                    Level lForm = new Level(sp);
                    lForm.Show();
                }
                else
                {
                    if (level == "level2")
                    {
                        MediumBoardPreparer mp = new MediumBoardPreparer(height, width);
                        Level lForm = new Level(mp);
                        lForm.Show();
                    }
                    else
                    {
                        if(level == "level3")
                        {
                            DifficultBoardPreparer dp=new DifficultBoardPreparer(height, width);
                            Level lForm = new Level(dp);
                            lForm.Show();
                        }
                        else
                        {
                            ErrorForm err = new ErrorForm();
                            err.Show();

                        }
                    }
                }*/

            }
        }

        private void textBoxLevel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
