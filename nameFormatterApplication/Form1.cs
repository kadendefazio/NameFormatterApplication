namespace nameFormatterApplication
{
    public partial class nameFormatterApplication : Form
    {
        public nameFormatterApplication()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void formattedNamesLabel_Click(object sender, EventArgs e)
        {
            // This event handler clears the textboxes when the label is clicked.
            userFirstNameTextBox.Text = "";
            userMiddleNameTextBox.Text = "";
            userLastNameTextBox.Text = "";
        }

        private void userFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // This event handler can be used to update the label's text when the first name textbox text changes.
            UpdateFormattedNamesLabel();
        }

        private void userMiddleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // This event handler can be used to update the label's text when the middle name textbox text changes.
            UpdateFormattedNamesLabel();
        }

        private void userLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // This event handler can be used to update the label's text when the last name textbox text changes.
            UpdateFormattedNamesLabel();
        }

        private void UpdateFormattedNamesLabel()
        {
            // This method updates the label's text based on the text in the textboxes.
            formattedNamesLabel.Text = $"{userFirstNameTextBox.Text} {userMiddleNameTextBox.Text} {userLastNameTextBox.Text}";
        }

    }
}
