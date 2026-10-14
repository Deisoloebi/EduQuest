namespace EduQuest
{
    public partial class EduQuest : Form
    {
        // =====================================================================
        #region Question data
        // Everything about the questions themselves lives in this group.
        // =====================================================================

        // A "class" is a blueprint. This one describes ONE quiz question:
        // the question text, four choices, and which answer is right.
        private class Question
        {
            public string Text;
            public string A;
            public string B;
            public string C;
            public string D;
            public string Answer;   // the right answer (must match a choice exactly)

            // A constructor lets us build a whole question in one line.
            public Question(string text, string a, string b, string c, string d, string answer)
            {
                Text = text;
                A = a;
                B = b;
                C = c;
                D = d;
                Answer = answer;
            }
        }

        // A List holds many items. This one holds all the questions of the quiz.
        private List<Question> questions = new List<Question>();

        // Puts all the questions into the list.
        private void LoadQuestions()
        {
            // Empty the list first, so questions don't pile up when the quiz is played again.
            questions.Clear();

            // Each line adds ONE question, in this order:
            // question text, choice A, choice B, choice C, choice D, correct answer.
            // The \" inside a text lets us put quote marks inside the text.
            questions.Add(new Question("She ___ to school every day.", "go", "goes", "going", "gone", "goes"));
            questions.Add(new Question("Which sentence is correct?", "He don't like apples.", "He doesn't like apples.", "He not like apples.", "He didn't likes apples.", "He doesn't like apples."));
            questions.Add(new Question("They ___ playing outside right now.", "is", "am", "are", "be", "are"));
            questions.Add(new Question("Which is the correct spelling?", "Recieve", "Receive", "Receeve", "Receve", "Receive"));
            questions.Add(new Question("What is the past tense of \"run\"?", "runned", "ran", "running", "runs", "ran"));
        }

        #endregion

        // =====================================================================
        #region Game state
        // These are "fields": variables that belong to the whole form,
        // so every method below can read and change them.
        // =====================================================================

        private int secondsPerQuestion;     // how many seconds each question gets
        private int timeLeft;               // how many seconds are left right now
        private string correctAnswer = "";  // the right answer for the question on screen
        private int score = 0;              // the player's total points
        private int correctCount = 0;       // how many questions the player got right

        // Which question we're on right now. Counting starts at 0, so 0 is the first.
        private int currentQuestion = 0;

        #endregion

        // =====================================================================
        #region Startup and window
        // What happens when the program opens and when the window changes size.
        // =====================================================================

        public EduQuest()
        {
            InitializeComponent();

            // Naka-default yung choices para hindi empty (index 0)
            cboCategory.SelectedIndex = 0;
            cboDifficulty.SelectedIndex = 0;

            // Center the game as soon as the window opens
            CenterMainPanel();
        }

        // Keeps the whole game (pnlMain) in the middle of the window,
        // no matter how big the window is.
        private void CenterMainPanel()
        {
            // ClientSize is the usable area inside the window.
            // Subtract the panel's size, then split the leftover space in half
            // so there is an equal gap on each side.
            int x = (ClientSize.Width - pnlMain.Width) / 2;
            int y = (ClientSize.Height - pnlMain.Height) / 2;

            // Move the panel to that spot
            pnlMain.Location = new Point(x, y);
        }

        private void EduQuest_Resize(object sender, EventArgs e)
        {
            // The window just changed size, so re-center the game
            CenterMainPanel();
        }

        #endregion

        // =====================================================================
        #region Home screen and menu
        // PLAY button, then the menu (Start Quiz / Make Quiz / Exit).
        // =====================================================================

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Hide the PLAY button so it disappears from the screen
            btnPlay.Visible = false;

            // Lilipat yung panel sa middle
            pnlMenu.Location = new Point(100, 150);

            // Show the menu panel (it was hidden at the start)
            pnlMenu.Visible = true;
        }

        private void btnMenuStartQuiz_Click(object sender, EventArgs e)
        {
            // The player chose "Start Quiz", so hide the menu
            pnlMenu.Visible = false;

            // Show the category and difficulty choices in the middle
            pnlSetup.Location = new Point(100, 200);
            pnlSetup.Visible = true;
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            // Close the whole program
            Application.Exit();
        }

        #endregion

        // =====================================================================
        #region Quiz setup
        // The START button on the category and difficulty screen.
        // =====================================================================

        private void btnStart_Click(object sender, EventArgs e)
        {
            /* Read what the player picked in each dropdown.
               SelectedItem is the choice that is currently selected,
               and ToString() turns it into plain text we can use. */
            string category = cboCategory.SelectedItem.ToString();   // not used yet: later it will choose which questions to load
            string difficulty = cboDifficulty.SelectedItem.ToString();

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

            // A new quiz starts: reset the score, fill the question list,
            // and begin at the first question (counting starts at 0).
            score = 0;
            correctCount = 0;
            LoadQuestions();
            currentQuestion = 0;

            // The player made their choices, so hide the setup panel
            pnlSetup.Visible = false;

            // Move the quiz panel to its spot (50 from the left, 140 from the top)
            pnlQuiz.Location = new Point(50, 140);

            // Show the quiz panel
            pnlQuiz.Visible = true;

            // Start the countdown from the full time and show it on screen.
            // The + joins the text "Time: " with the number.
            timeLeft = secondsPerQuestion;
            lblTimer.Text = "Time: " + timeLeft;

            // Turn the clock on. It will now tick once every second.
            quizTimer.Start();

            // Show the first question on the screen
            ShowQuestion();
        }

        #endregion

        // =====================================================================
        #region Quiz play
        // Showing a question, checking the answer, the timers, and moving on.
        // =====================================================================

        // This one puts a question and its four answers on the screen.
        private void ShowQuestion()
        {
            // Take the current question out of the list.
            // questions[0] is the first one, questions[1] the second, and so on.
            Question q = questions[currentQuestion];

            // Put its text on the screen
            lblQuestion.Text = q.Text;
            btnA.Text = q.A;
            btnB.Text = q.B;
            btnC.Text = q.C;
            btnD.Text = q.D;

            // Remember the right answer so AnswerButton_Click can check it
            correctAnswer = q.Answer;

            // Unlock the buttons (they get locked after every answer)
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
        }

        // All four answer buttons (A, B, C, D) run this same method.
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            // "sender" is the button that was just clicked.
            // (Button)sender tells C# to treat it as a Button so we can read its Text.
            Button clicked = (Button)sender;

            // The player answered, so stop the clock...
            quizTimer.Stop();

            // ...and lock all four buttons so they can't answer twice.
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            // Compare the text on the clicked button with the right answer.
            if (clicked.Text == correctAnswer)
            {
                // 100 points for being right, plus 2 for every second left.
                int points = 100 + (timeLeft * 2);
                score = score + points;
                correctCount = correctCount + 1;
                lblTimer.Text = "Correct! +" + points + " points";
            }
            else
            {
                lblTimer.Text = "Wrong! The answer was " + correctAnswer;
            }

            // This line is OUTSIDE the if/else on purpose, so it runs for
            // both right and wrong answers.
            // Wait 2 seconds so the player can read the result, then move on.
            nextTimer.Start();
        }

        // The question countdown. Runs automatically every 1 second.
        private void quizTimer_Tick(object sender, EventArgs e)
        {
            // Count down by 1 second and update the label.
            timeLeft = timeLeft - 1;
            lblTimer.Text = "Time: " + timeLeft;

            // If time runs out, stop the clock and say so.
            if (timeLeft <= 0)
            {
                quizTimer.Stop();

                // Time ran out, so lock all four buttons
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                // Show the right answer so the player can learn from it
                lblTimer.Text = "Time's up! The answer was " + correctAnswer;

                // Wait 2 seconds, then move on to the next question
                nextTimer.Start();
            }
        }

        // The 2-second pause between questions.
        private void nextTimer_Tick(object sender, EventArgs e)
        {
            // Stop this timer so it only fires once per question
            nextTimer.Stop();

            // Move to the next question in the list
            currentQuestion = currentQuestion + 1;

            // questions.Count is how many questions the list holds.
            // Are there still questions left?
            if (currentQuestion < questions.Count)
            {
                // Reset the countdown for the new question and start it again
                timeLeft = secondsPerQuestion;
                lblTimer.Text = "Time: " + timeLeft;
                quizTimer.Start();

                // Put the next question on the screen
                ShowQuestion();
            }
            else
            {
                // No questions left, so the quiz is over: show the results.
                quizTimer.Stop();
                ShowResults();
            }
        }

        #endregion

        // =====================================================================
        #region Results screen
        // Working out the score, percentage, fun IQ, and rank.
        // =====================================================================

        // Works out the results and shows the results screen.
        private void ShowResults()
        {
            // Hide the quiz screen
            pnlQuiz.Visible = false;

            // Percentage = correct answers divided by total questions, times 100.
            // (double) keeps the decimals. Without it, 3 / 5 would become 0.
            double percent = (double)correctCount / questions.Count * 100;

            // Just for fun: 0% gives an "IQ" of 70, and 100% gives 130
            int funIQ = 70 + (int)(percent * 0.6);

            // Pick a rank. C# checks these from the top and stops at the first match.
            string rank;
            if (percent >= 90)
            {
                rank = "ARCHMAGE";
            }
            else if (percent >= 75)
            {
                rank = "SAGE";
            }
            else if (percent >= 60)
            {
                rank = "KNIGHT";
            }
            else if (percent >= 40)
            {
                rank = "APPRENTICE";
            }
            else
            {
                rank = "NOVICE";
            }

            // Put the results on the screen.
            // percent.ToString("0") shows 80 and not 80.0000.
            lblScore.Text = "Score: " + score;
            lblPercent.Text = "Percentage: " + percent.ToString("0") + "%";
            lblFunIQ.Text = "Fun IQ: " + funIQ;
            lblRank.Text = rank;

            // "\n" starts a new line, so the disclaimer fits on two lines
            lblDisclaimer.Text = "For entertainment and interactive purposes only.\nResults are not an actual measure of intelligence, IQ, or overall knowledge.";

            // Show the results panel in its spot
            pnlResults.Location = new Point(50, 140);
            pnlResults.Visible = true;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // Hide the results screen
            pnlResults.Visible = false;

            // Go back to the menu, so the player can start a new quiz
            pnlMenu.Location = new Point(100, 150);
            pnlMenu.Visible = true;
        }

        #endregion
    }
}