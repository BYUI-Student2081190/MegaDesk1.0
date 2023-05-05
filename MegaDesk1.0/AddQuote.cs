using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk1._0
{
    public partial class AddQuote : Form
    {
        // Attributes.

        /* When we have a new form get created, create a new
           Desk object to use in the code.

           Why here? The idea behind this program is for this
           form class to create and help assign the values needed
           for the Desk Object from the form.
        */
        Desk _currDesk;

        /* This attribute holds if it is ok to go forward with the rest of
           the program. If true we are good to go, if false we cannot move on.
        */
        bool _goodToGo;

        // Constructors.
        public AddQuote()
        {
            InitializeComponent();

            // While the form is created, create new object.
            _currDesk = new Desk();
        }

        // Methods.

        /* This method allow the user to close the form with both a button,
           and the cancel "x" button on the form. While allowing the MainMenu Form
           to still be shown.
        */
        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the Main Menu.
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        /* This method allows the cancel button to close the form. */
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* These two methods both control checks that happen on the width and depth values
           when the user hits enter on the keyboard while the value input is selected. */
        private void widthNumSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                // Convert the width to a string.
                string testNum = widthNumSelect.Value.ToString();

                // Start the tests.
                NumberValidationChecker(testNum, 0);
            }
        }

        private void depthNumSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                // Convert the width to a string.
                string testNum = depthNumSelect.Value.ToString();

                // Start the tests.
                NumberValidationChecker(testNum, 1);
            }
        }

        /* This method handles when the addNewQuoteButton is clicked. This method's job
           is to first, preform validation checks on all the user inputs. Second if all those
           values check out, set the values to the Desk Object. Third create a new DeskQuote object,
           then set the values needed in the DeskQuote, and run the DeskQuote.*/
        private void addNewQuoteButton_Click(object sender, EventArgs e)
        {
            // Code will go here later. Right now it should do nothing.
        }

        /* This method sets up a few tests for the numbers inserted into the method. This
            is done by the string version of the number, and then the type of number.
            
            NUMBER TYPE KEY:
            0 = width
            1 = depth
            2 = drawers
        */
        private bool NumberValidationChecker(string testNum, int type) 
        {
            // First call the digit test.
            bool testOne = NumberDigitTest(testNum);

            if (testOne)
            {
                // Convert the testNum into a int.
                int number = int.Parse(testNum);

                // Create varible to hold second test.
                bool testTwo;

                // Call the Second test.

                // Create a switch case for each type of range test.
                switch (type)
                {
                    //This case is Width.
                    case 0:
                        testTwo = NumberRangeTest(number, _currDesk.GetMINWIDTH(), _currDesk.GetMAXWIDTH());
                        break;

                    // This case is Depth
                    case 1:
                        testTwo = NumberRangeTest(number, _currDesk.GetMINDEPTH(), _currDesk.GetMAXDEPTH());
                        break;

                    // This case is Drawers.
                    case 2:
                        testTwo = NumberRangeTest(number, _currDesk.GetMINDRAWERS(), _currDesk.GetMAXDRAWERS());
                        break;

                    // Default testTwo failed.
                    default:
                        testTwo = false;
                        break;
                }

                if (testTwo) 
                {
                    // All done it passed all the tests.
                    return true;
                }

                else 
                {
                    // We did not pass all the tests.
                    return false;
                }
            }

            else
            {
                // Tests not passed.
                return false;
            }
        }

        /* Tests if the number is a digit. */
        private bool NumberDigitTest(string testNum) 
        {
            // Use a try catch here.
            try 
            {
                int x;

                x = int.Parse(testNum);

                return true;
            }

            catch 
            {
                MessageBox.Show("One of your inputs was not a number. Please try again!");

                return false;
            }
        }

        /* Tests if the number is in it's range. */
        private bool NumberRangeTest(int number, int min, int max) 
        {
            if (number <= max && number >= min) 
            {
                return true;
            }

            else 
            {
                MessageBox.Show("Your input was not in range. Please try again.");
                return false;
            }
            
        }
    }
}
