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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        /* This method handles when this form has been closed to show the MainMenu Form. */
        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the Main Menu.
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}
