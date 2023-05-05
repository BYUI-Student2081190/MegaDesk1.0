namespace MegaDesk1._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /* This Method takes us to the AddQuote Form and then hides this form.*/
        private void addNewQuoteButton_Click(object sender, EventArgs e)
        {
            // Create a new form object to show.
            AddQuote showAddQuote = new AddQuote();
            showAddQuote.Tag = this;
            showAddQuote.Show(this);
            // Hide the current MainMenu Form.
            // We don't want to close it, just hide it.
            this.Hide();
        }

        /* This Method takes us to the ViewAllQuote Form and then hides this form.*/
        private void viewAllQuoteButton_Click(object sender, EventArgs e)
        {
            // Create a new form object to show.
            ViewAllQuote showViewAllQuote = new ViewAllQuote();
            showViewAllQuote.Tag = this;
            showViewAllQuote.Show(this);
            // Hide the current MainMenu Form.
            // We don't want to close it, just hide it.
            this.Hide();
        }

        /* This Method takes us to the SearchQuotes Form and then hides this form.*/
        private void searchQuoteButton_Click(object sender, EventArgs e)
        {
            // Create a new form object to show.
            SearchQuotes showSearchQuotes = new SearchQuotes();
            showSearchQuotes.Tag = this;
            showSearchQuotes.Show(this);
            // Hide the current MainMenu Form.
            // We don't want to close it, just hide it.
            this.Hide();
        }

        /* This method handles when the Exit button has been clicked, it
           closes the form. */
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }

        /* This event trigger when the user closes this form. It causes the whole application to exit. */
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the Application.
            Application.Exit();
        }
    }
}