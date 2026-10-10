namespace EduQuest
{
    public partial class EduQuest : Form
    {
        public EduQuest()
        {
            InitializeComponent();

            // Naka-default yung choices para hindi empty (index 0)
            cboCategory.SelectedIndex = 0;
            cboDifficulty.SelectedIndex = 0;
        }

        private void pnlSetup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Hide the PLAY button so it disappears from the screen
            btnPlay.Visible = false;

            // Lilipat yung panel sa middle
            pnlSetup.Location = new Point(100, 200);

            // Show the setup panel (it was hidden at the start)
            pnlSetup.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Read what the player picked in each dropdown.
            // SelectedItem is the choice that is currently selected,
            // and ToString() turns it into plain text we can use.
            string category = cboCategory.SelectedItem.ToString();
            string difficulty = cboDifficulty.SelectedItem.ToString();

            // Show a small pop-up box to test that it works.
            // The + joins pieces of text together, and \n starts a new line.
            // We'll replace this with the real quiz later.
            MessageBox.Show("Category: " + category + "\nDifficulty: " + difficulty, "Your Quest");
        }
    }
}
