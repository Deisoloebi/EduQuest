namespace EduQuest
{
    public partial class EduQuest : Form
    {
        #region Question data

        // One quiz question: the question, four choices, and the correct answer
        private class Question
        {
            public string Text;
            public string A;
            public string B;
            public string C;
            public string D;
            public string Answer;

            // Lets us create a question in one line
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

        // All the questions for the current quiz
        private List<Question> questions = new List<Question>();

        // Loads the questions that match the chosen category and difficulty
        private void LoadQuestions(string category, string difficulty)
        {
            // Clear first so the questions don't repeat when the quiz is replayed
            questions.Clear();

            // Lowercase so capital letters don't matter when comparing names
            category = category.Trim().ToLower();
            difficulty = difficulty.Trim().ToLower();

            // Format: question, choices A to D, correct answer
            if (category == "mathematics")
            {
                if (difficulty == "easy")
                {
                    questions.Add(new Question("What is 5 + 7?", "10", "11", "12", "13", "12"));
                    questions.Add(new Question("What is 6 x 3?", "18", "15", "21", "12", "18"));
                    questions.Add(new Question("What is 20 - 8?", "10", "12", "14", "16", "12"));
                }
                else if (difficulty == "medium")
                {
                    questions.Add(new Question("What is 12 x 8?", "86", "96", "108", "88", "96"));
                    questions.Add(new Question("What is 144 / 12?", "10", "11", "12", "14", "12"));
                    questions.Add(new Question("What is 25% of 200?", "25", "40", "50", "75", "50"));
                }
                else if (difficulty == "hard")
                {
                    questions.Add(new Question("Solve: 15 x 12 - 40", "120", "130", "140", "150", "140"));
                    questions.Add(new Question("What is the square root of 225?", "12", "13", "15", "25", "15"));
                    questions.Add(new Question("Solve: 3x + 7 = 22. What is x?", "3", "5", "7", "9", "5"));
                }
            }
            else if (category == "english grammar")
            {
                if (difficulty == "easy")
                {
                    questions.Add(new Question("She ___ to school every day.", "go", "goes", "going", "gone", "goes"));
                    questions.Add(new Question("What is the opposite of hot?", "Warm", "Cold", "Dry", "Bright", "Cold"));
                    questions.Add(new Question("What is the plural of child?", "Childs", "Childes", "Children", "Childrens", "Children"));
                }
                else if (difficulty == "medium")
                {
                    questions.Add(new Question("Which sentence is grammatically correct?", "He don't play.", "He doesn't play.", "He not play.", "He doesn't plays.", "He doesn't play."));
                    questions.Add(new Question("What is a synonym for rapid?", "Slow", "Fast", "Weak", "Quiet", "Fast"));
                    questions.Add(new Question("What is the past tense of write?", "Writing", "Writes", "Wrote", "Written", "Wrote"));
                }
                else if (difficulty == "hard")
                {
                    questions.Add(new Question("Which word means 'unavoidable'?", "Optional", "Inevitable", "Uncertain", "Temporary", "Inevitable"));
                    questions.Add(new Question("Identify the adjective: 'The brilliant student won.'", "Student", "Won", "Brilliant", "The", "Brilliant"));
                    questions.Add(new Question("Which is the correct sentence?", "Neither answer are correct.", "Neither answer is correct.", "Neither answers is correct.", "Neither answer were correct.", "Neither answer is correct."));
                }
            }
            else if (category == "general knowledge")
            {
                if (difficulty == "easy")
                {
                    questions.Add(new Question("Which planet do we live on?", "Mars", "Earth", "Venus", "Jupiter", "Earth"));
                    questions.Add(new Question("Which organ pumps blood?", "Lungs", "Brain", "Heart", "Stomach", "Heart"));
                    questions.Add(new Question("What do plants need from sunlight?", "Energy", "Salt", "Plastic", "Metal", "Energy"));
                }
                else if (difficulty == "medium")
                {
                    questions.Add(new Question("What gas do plants absorb during photosynthesis?", "Oxygen", "Nitrogen", "Carbon dioxide", "Hydrogen", "Carbon dioxide"));
                    questions.Add(new Question("What is the chemical symbol for gold?", "Ag", "Au", "Fe", "Go", "Au"));
                    questions.Add(new Question("Which organ filters blood to produce urine?", "Heart", "Kidney", "Liver", "Lung", "Kidney"));
                }
                else if (difficulty == "hard")
                {
                    questions.Add(new Question("What is the powerhouse of the cell?", "Nucleus", "Ribosome", "Mitochondrion", "Membrane", "Mitochondrion"));
                    questions.Add(new Question("What is the approximate speed of light in a vacuum?", "30,000 km/s", "150,000 km/s", "300,000 km/s", "500,000 km/s", "300,000 km/s"));
                    questions.Add(new Question("What is the pH of a neutral solution at 25°C?", "0", "5", "7", "14", "7"));
                }
            }

            // Warn if nothing matched (usually a category name that doesn't match the dropdown)
            if (questions.Count == 0)
            {
                MessageBox.Show("No questions found for this category and difficulty.", "No Questions");
            }
        }

        #endregion

        #region Game state

        private int secondsPerQuestion;     // time limit per question (set by the difficulty)
        private int timeLeft;               // seconds left on the timer
        private string correctAnswer = "";  // correct answer of the current question
        private int score = 0;              // total points
        private int correctCount = 0;       // number of correct answers
        private int currentQuestion = 0;    // position in the list (starts at 0)

        #endregion

        #region Startup and window

        public EduQuest()
        {
            InitializeComponent();

            // Naka-default yung choices para hindi empty (index 0)
            cboCategory.SelectedIndex = 0;
            cboDifficulty.SelectedIndex = 0;

            // Center the game when the program opens
            CenterMainPanel();
        }

        // Keeps the game panel in the middle of the window
        private void CenterMainPanel()
        {
            int x = (ClientSize.Width - pnlMain.Width) / 2;
            int y = (ClientSize.Height - pnlMain.Height) / 2;
            pnlMain.Location = new Point(x, y);
        }

        // Re-centers the game when the window is resized
        private void EduQuest_Resize(object sender, EventArgs e)
        {
            CenterMainPanel();
        }

        #endregion

        #region Home screen and menu

        // PLAY button: hides itself and shows the menu
        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;

            // Lilipat yung panel sa middle
            pnlMenu.Location = new Point(100, 150);
            pnlMenu.Visible = true;
        }

        // START QUIZ button: goes to the category and difficulty screen
        private void btnMenuStartQuiz_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlSetup.Location = new Point(100, 200);
            pnlSetup.Visible = true;
        }

        // EXIT button: closes the program
        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Quiz setup

        // START button: sets up the quiz and shows the first question
        private void btnStart_Click(object sender, EventArgs e)
        {
            // What the player picked
            string category = cboCategory.SelectedItem.ToString();
            string difficulty = cboDifficulty.SelectedItem.ToString();

            // Time per question depends on the difficulty
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
                secondsPerQuestion = 30;   // Hard
            }

            // Reset the score and load the questions for this category and difficulty
            score = 0;
            correctCount = 0;
            LoadQuestions(category, difficulty);
            currentQuestion = 0;

            // No questions found: stay on the setup screen
            if (questions.Count == 0)
            {
                return;
            }

            // Switch from the setup screen to the quiz screen
            pnlSetup.Visible = false;
            pnlQuiz.Location = new Point(50, 140);
            pnlQuiz.Visible = true;

            // Start the timer
            timeLeft = secondsPerQuestion;
            lblTimer.Text = "Time: " + timeLeft;
            quizTimer.Start();

            ShowQuestion();
        }

        #endregion

        #region Quiz play

        // Shows the current question and its four choices
        private void ShowQuestion()
        {
            Question q = questions[currentQuestion];

            lblQuestion.Text = q.Text;
            btnA.Text = q.A;
            btnB.Text = q.B;
            btnC.Text = q.C;
            btnD.Text = q.D;

            // Save the correct answer so it can be checked later
            correctAnswer = q.Answer;

            // Enable the choices for the new question
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
        }

        // Runs when a choice (A to D) is clicked: checks the answer and updates the score
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            // The button that was clicked
            Button clicked = (Button)sender;

            // Stop the timer and lock the choices
            quizTimer.Stop();
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            if (clicked.Text == correctAnswer)
            {
                // Correct: 100 points + 2 points for every second left
                int points = 100 + (timeLeft * 2);
                score = score + points;
                correctCount = correctCount + 1;
                lblTimer.Text = "Correct! +" + points + " points";
            }
            else
            {
                // Wrong: show the correct answer
                lblTimer.Text = "Wrong! The answer was " + correctAnswer;
            }

            // Go to the next question after 2 seconds (for right and wrong answers)
            nextTimer.Start();
        }

        // Runs every second: lowers the time left
        private void quizTimer_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            lblTimer.Text = "Time: " + timeLeft;

            // Time's up: lock the choices and show the correct answer
            if (timeLeft <= 0)
            {
                quizTimer.Stop();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;

                lblTimer.Text = "Time's up! The answer was " + correctAnswer;
                nextTimer.Start();
            }
        }

        // Waits 2 seconds after each question, then shows the next question or the results
        private void nextTimer_Tick(object sender, EventArgs e)
        {
            nextTimer.Stop();
            currentQuestion = currentQuestion + 1;

            if (currentQuestion < questions.Count)
            {
                // Next question: reset the timer
                timeLeft = secondsPerQuestion;
                lblTimer.Text = "Time: " + timeLeft;
                quizTimer.Start();
                ShowQuestion();
            }
            else
            {
                // No more questions: show the results
                quizTimer.Stop();
                ShowResults();
            }
        }

        #endregion

        #region Results screen

        // Computes the percentage, fun IQ, and rank, then shows the results screen
        private void ShowResults()
        {
            pnlQuiz.Visible = false;

            // Percentage of correct answers
            double percent = (double)correctCount / questions.Count * 100;

            // Fun IQ from 70 to 130 (for entertainment only)
            int funIQ = 70 + (int)(percent * 0.6);

            // Rank based on the percentage
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

            // Show the results
            lblScore.Text = "Score: " + score;
            lblPercent.Text = "Percentage: " + percent.ToString("0") + "%";
            lblFunIQ.Text = "Fun IQ: " + funIQ;
            lblRank.Text = rank;

            // Disclaimer (two lines so it fits)
            lblDisclaimer.Text = "For entertainment and interactive purposes only.\nResults are not an actual measure of intelligence, IQ, or overall knowledge.";

            pnlResults.Location = new Point(50, 140);
            pnlResults.Visible = true;

            // Ask for the player's name so the score can be saved
            txtName.Text = "";
            lblNamePrompt.Text = "Quest complete! Score: " + score + "\nEnter your name to save it";
            pnlName.Location = new Point(150, 140);
            pnlName.Visible = true;
            pnlName.BringToFront();
            txtName.Focus();
        }

        // PLAY AGAIN button: goes back to the menu
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            pnlResults.Visible = false;
            pnlMenu.Location = new Point(100, 150);
            pnlMenu.Visible = true;
        }

        #endregion

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            // Remove extra spaces, and the "|" character (it separates name and score in the file)
            string name = txtName.Text.Trim().Replace("|", "");

            // A name is required
            if (name == "")
            {
                MessageBox.Show("Please type your name.", "Name Needed");
                return;
            }

            // Add one line "name|score" to leaderboard.txt (the file is created if it doesn't exist)
            string path = Path.Combine(Application.StartupPath, "leaderboard.txt");
            File.AppendAllText(path, name + "|" + score + Environment.NewLine);

            // Close the pop-up and the results screen, then show the leaderboard
            pnlName.Visible = false;
            pnlResults.Visible = false;

            LoadScoresFromFile();
            ShowLeaderboardList();
            pnlLeaderboard.Location = new Point(50, 140);
            pnlLeaderboard.Visible = true;
            pnlLeaderboard.BringToFront();
        }

        #region Leaderboard

        // One record on the leaderboard
        private class ScoreEntry
        {
            public string Name;
            public int Score;

            public ScoreEntry(string name, int score)
            {
                Name = name;
                Score = score;
            }
        }

        // All saved scores, and the file they are saved in
        private List<ScoreEntry> scoreEntries = new List<ScoreEntry>();
        private string leaderboardPath = Path.Combine(Application.StartupPath, "leaderboard.txt");

        // Reads leaderboard.txt into the list (each line looks like: name|score)
        private void LoadScoresFromFile()
        {
            scoreEntries.Clear();

            // Nothing saved yet
            if (!File.Exists(leaderboardPath))
            {
                return;
            }

            foreach (string line in File.ReadAllLines(leaderboardPath))
            {
                string[] parts = line.Split('|');
                int savedScore;

                // Only keep lines that have a name and a valid number
                if (parts.Length == 2 && int.TryParse(parts[1], out savedScore))
                {
                    scoreEntries.Add(new ScoreEntry(parts[0], savedScore));
                }
            }
        }

        // Writes the whole list back to leaderboard.txt (used after deleting)
        private void SaveScoresToFile()
        {
            List<string> lines = new List<string>();

            foreach (ScoreEntry entry in scoreEntries)
            {
                lines.Add(entry.Name + "|" + entry.Score);
            }

            File.WriteAllLines(leaderboardPath, lines);
        }

        // Sorts the scores (highest first) and shows them in the list box
        private void ShowLeaderboardList()
        {
            // Compares two entries so the higher score comes first
            scoreEntries.Sort((a, b) => b.Score.CompareTo(a.Score));

            lstLeaderboard.Items.Clear();

            for (int i = 0; i < scoreEntries.Count; i++)
            {
                // PadRight adds spaces so the columns line up
                string rankText = (i + 1).ToString().PadRight(5);
                string nameText = scoreEntries[i].Name.PadRight(18);
                lstLeaderboard.Items.Add(rankText + nameText + scoreEntries[i].Score);
            }
        }

        #endregion


        private void btnMenuLeaderboard_Click(object sender, EventArgs e)
        {
            // LEADERBOARD button: shows the saved scores
            pnlMenu.Visible = false;
            LoadScoresFromFile();
            ShowLeaderboardList();
            pnlLeaderboard.Location = new Point(50, 140);
            pnlLeaderboard.Visible = true;
        }

        private void btnLeaderboardBack_Click(object sender, EventArgs e)
        {
            // BACK button: returns to the menu
            pnlLeaderboard.Visible = false;
            pnlMenu.Location = new Point(100, 150);
            pnlMenu.Visible = true;
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            // DELETE button: removes the selected record after asking to confirm
            int index = lstLeaderboard.SelectedIndex;

            // Nothing selected yet
            if (index < 0)
            {
                MessageBox.Show("Select a record to delete first.", "Delete Record");
                return;
            }

            DialogResult answer = MessageBox.Show("Delete " + scoreEntries[index].Name + "'s score?", "Delete Record", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                scoreEntries.RemoveAt(index);
                SaveScoresToFile();
                ShowLeaderboardList();
            }
        }
    }

}