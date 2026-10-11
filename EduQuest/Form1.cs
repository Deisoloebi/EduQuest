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

        /* These are "fields": variables that belong to the whole form,
           so every method below can read and change them. */
        private int secondsPerQuestion;  // how many seconds each question gets
        private int timeLeft;            // how many seconds are left right now

        private string correctAnswer;  // the right answer for the question on screen
        private int score = 0;         // the player's total points

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

        // Which question we're on right now. Counting starts at 0, so 0 is the first.
        private int currentQuestion = 0;



        // Puts all the questions into the list.
        private void LoadQuestions()
        {
            // Empty the list first, so questions don't pile up when the quiz is played again.
            questions.Clear();

            // Each line adds ONE question, in this order:
            // question text, choice A, choice B, choice C, choice D, correct answer.
            // The \" inside the last one lets us put quote marks inside the text.
            questions.Add(new Question("She ___ to school every day.", "go", "goes", "going", "gone", "goes"));
            questions.Add(new Question("Which sentence is correct?", "He don't like apples.", "He doesn't like apples.", "He not like apples.", "He didn't likes apples.", "He doesn't like apples."));
            questions.Add(new Question("They ___ playing outside right now.", "is", "am", "are", "be", "are"));
            questions.Add(new Question("Which is the correct spelling?", "Recieve", "Receive", "Receeve", "Receve", "Receive"));
            questions.Add(new Question("What is the past tense of \"run\"?", "runned", "ran", "running", "runs", "ran"));

        }




        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Hide the PLAY button so it disappears from the screen
            btnPlay.Visible = false;

            // Lilipat yung panel sa middle
            pnlMenu.Location = new Point(100, 150);

            // Show the setup panel (it was hidden at the start)
            pnlMenu.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            /* Read what the player picked in each dropdown.
               SelectedItem is the choice that is currently selected,
               and ToString() turns it into plain text we can use. */
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

            // A new quiz starts: reset the score, fill the question list,
            // and begin at the first question (counting starts at 0).
            score = 0;
            LoadQuestions();
            currentQuestion = 0;

            // Show the first question on the screen
            ShowQuestion();
        }





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
                // Time ran out, so lock all four buttons
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                // Show the right answer so the player can learn from it
                lblTimer.Text = "Time's up! The answer was " + correctAnswer;

                nextTimer.Start();
            }
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
                lblTimer.Text = "Correct! +" + points + " points";
            }
            else
            {
                lblTimer.Text = "Wrong! The answer was " + correctAnswer;

            }
            // Wait 2 seconds so the player can read the result, then move on
            nextTimer.Start();

        }

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
                // No questions left. The real results screen comes in the next step.
                quizTimer.Stop();
                lblQuestion.Text = "Quest complete!";
                lblTimer.Text = "Total score: " + score;
            }
        }
    }
}
