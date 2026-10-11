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

        // These are "fields": variables that belong to the whole form,
        // so every method below can read and change them.
        private int secondsPerQuestion;  // how many seconds each question gets
        private int timeLeft;            // how many seconds are left right now

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

            // The player made their choices, so hide the setup panel
            pnlSetup.Visible = false;

            // Move the quiz panel to its spot (50 from the left, 140 from the top)
            pnlQuiz.Location = new Point(50, 140);

            // Show the quiz panel
            pnlQuiz.Visible = true;


            // Pick the time limit based on the difficulty the player chose.
            if (difficulty == "Easy")
            {
                secondsPerQuestion = 60;
            }
            else if (difficulty == "Medium")
            {
                secondsPerQuestion = 45;
            }
            else
            {
                secondsPerQuestion = 30;   // anything else is Hard
            }

            // Start the countdown from the full time and show it on screen.
            // The + joins the text "Time: " with the number.
            timeLeft = secondsPerQuestion;
            lblTimer.Text = "Time: " + timeLeft;

            // Turn the clock on. It will now tick once every second.
            quizTimer.Start();
        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            // This runs automatically every 1 second while the timer is on.

            // Count down by 1 second and update the label.
            timeLeft = timeLeft - 1;
            lblTimer.Text = "Time: " + timeLeft;

            // If time runs out, stop the clock and say so.
            if (timeLeft <= 0)
            {
                quizTimer.Stop();
                lblTimer.Text = "Time's up!";
            }
        }
    }
}
