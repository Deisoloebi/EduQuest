namespace EduQuest
{
    partial class EduQuest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblSubtitle = new Label();
            goldLine = new Panel();
            btnPlay = new Button();
            pnlSetup = new Panel();
            btnStart = new Button();
            cboDifficulty = new ComboBox();
            lblDifficulty = new Label();
            cboCategory = new ComboBox();
            lblCategory = new Label();
            pnlQuiz = new Panel();
            lblTimer = new Label();
            btnD = new Button();
            btnB = new Button();
            btnC = new Button();
            btnA = new Button();
            lblQuestion = new Label();
            quizTimer = new System.Windows.Forms.Timer(components);
            pnlMenu = new Panel();
            btnMenuExit = new Button();
            btnMenuMakeQuiz = new Button();
            btnMenuLeaderboard = new Button();
            btnMenuStartQuiz = new Button();
            nextTimer = new System.Windows.Forms.Timer(components);
            pnlMain = new Panel();
            pnlLeaderboard = new Panel();
            btnDeleteRecord = new Button();
            btnLeaderboardBack = new Button();
            lblLeaderboardTitle = new Label();
            lstLeaderboard = new ListBox();
            pnlName = new Panel();
            btnSaveScore = new Button();
            txtName = new TextBox();
            lblNamePrompt = new Label();
            pnlResults = new Panel();
            btnPlayAgain = new Button();
            lblDisclaimer = new Label();
            lblFunIQ = new Label();
            lblPercent = new Label();
            lblScore = new Label();
            lblRank = new Label();
            lblResultTitle = new Label();
            pnlSetup.SuspendLayout();
            pnlQuiz.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlLeaderboard.SuspendLayout();
            pnlName.SuspendLayout();
            pnlResults.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Georgia", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(230, 190, 80);
            lblTitle.Location = new Point(0, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "EduQuest";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Georgia", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(245, 230, 200);
            lblSubtitle.Location = new Point(0, 80);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(700, 35);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "The quest for knowledge begins";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // goldLine
            // 
            goldLine.BackColor = Color.FromArgb(230, 190, 80);
            goldLine.Location = new Point(150, 125);
            goldLine.Name = "goldLine";
            goldLine.Size = new Size(400, 3);
            goldLine.TabIndex = 2;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(230, 190, 80);
            btnPlay.Cursor = Cursors.Hand;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.ForeColor = Color.FromArgb(25, 20, 45);
            btnPlay.Location = new Point(250, 200);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(200, 60);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "PLAY";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // pnlSetup
            // 
            pnlSetup.Controls.Add(btnStart);
            pnlSetup.Controls.Add(cboDifficulty);
            pnlSetup.Controls.Add(lblDifficulty);
            pnlSetup.Controls.Add(cboCategory);
            pnlSetup.Controls.Add(lblCategory);
            pnlSetup.Location = new Point(100, 270);
            pnlSetup.Name = "pnlSetup";
            pnlSetup.Size = new Size(500, 200);
            pnlSetup.TabIndex = 4;
            pnlSetup.Visible = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(230, 190, 80);
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.FromArgb(25, 20, 45);
            btnStart.Location = new Point(150, 145);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(200, 45);
            btnStart.TabIndex = 4;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // cboDifficulty
            // 
            cboDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDifficulty.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDifficulty.FormattingEnabled = true;
            cboDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            cboDifficulty.Location = new Point(20, 102);
            cboDifficulty.Name = "cboDifficulty";
            cboDifficulty.Size = new Size(460, 26);
            cboDifficulty.TabIndex = 3;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDifficulty.ForeColor = Color.FromArgb(245, 230, 200);
            lblDifficulty.Location = new Point(20, 75);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(228, 23);
            lblDifficulty.TabIndex = 2;
            lblDifficulty.Text = "Choose your difficulty";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Mathematics", "English Grammar", "General Knowledge" });
            cboCategory.Location = new Point(20, 35);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(460, 26);
            cboCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.FromArgb(245, 230, 200);
            lblCategory.Location = new Point(20, 5);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(222, 23);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Choose your category";
            // 
            // pnlQuiz
            // 
            pnlQuiz.Controls.Add(lblTimer);
            pnlQuiz.Controls.Add(btnD);
            pnlQuiz.Controls.Add(btnB);
            pnlQuiz.Controls.Add(btnC);
            pnlQuiz.Controls.Add(btnA);
            pnlQuiz.Controls.Add(lblQuestion);
            pnlQuiz.Location = new Point(50, 140);
            pnlQuiz.Name = "pnlQuiz";
            pnlQuiz.Size = new Size(600, 330);
            pnlQuiz.TabIndex = 5;
            pnlQuiz.Visible = false;
            // 
            // lblTimer
            // 
            lblTimer.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.FromArgb(230, 190, 80);
            lblTimer.Location = new Point(20, 285);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(560, 35);
            lblTimer.TabIndex = 5;
            lblTimer.Text = "Time: 15";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnD
            // 
            btnD.BackColor = Color.FromArgb(245, 230, 200);
            btnD.Cursor = Cursors.Hand;
            btnD.FlatStyle = FlatStyle.Flat;
            btnD.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnD.ForeColor = Color.FromArgb(25, 20, 45);
            btnD.Location = new Point(304, 212);
            btnD.Name = "btnD";
            btnD.Size = new Size(270, 60);
            btnD.TabIndex = 4;
            btnD.Text = "Answer D";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += AnswerButton_Click;
            // 
            // btnB
            // 
            btnB.BackColor = Color.FromArgb(245, 230, 200);
            btnB.Cursor = Cursors.Hand;
            btnB.FlatStyle = FlatStyle.Flat;
            btnB.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnB.ForeColor = Color.FromArgb(25, 20, 45);
            btnB.Location = new Point(304, 130);
            btnB.Name = "btnB";
            btnB.Size = new Size(270, 60);
            btnB.TabIndex = 3;
            btnB.Text = "Answer B";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += AnswerButton_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(245, 230, 200);
            btnC.Cursor = Cursors.Hand;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnC.ForeColor = Color.FromArgb(25, 20, 45);
            btnC.Location = new Point(20, 210);
            btnC.Name = "btnC";
            btnC.Size = new Size(270, 60);
            btnC.TabIndex = 2;
            btnC.Text = "Answer C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += AnswerButton_Click;
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(245, 230, 200);
            btnA.Cursor = Cursors.Hand;
            btnA.FlatStyle = FlatStyle.Flat;
            btnA.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnA.ForeColor = Color.FromArgb(25, 20, 45);
            btnA.Location = new Point(20, 130);
            btnA.Name = "btnA";
            btnA.Size = new Size(270, 60);
            btnA.TabIndex = 1;
            btnA.Text = "Answer A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += AnswerButton_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.FromArgb(245, 230, 200);
            lblQuestion.Location = new Point(20, 20);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(560, 80);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Sample question goes here";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quizTimer
            // 
            quizTimer.Interval = 1000;
            quizTimer.Tick += quizTimer_Tick;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnMenuExit);
            pnlMenu.Controls.Add(btnMenuMakeQuiz);
            pnlMenu.Controls.Add(btnMenuLeaderboard);
            pnlMenu.Controls.Add(btnMenuStartQuiz);
            pnlMenu.Location = new Point(100, 150);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(500, 300);
            pnlMenu.TabIndex = 6;
            pnlMenu.Visible = false;
            // 
            // btnMenuExit
            // 
            btnMenuExit.BackColor = Color.FromArgb(230, 190, 80);
            btnMenuExit.Cursor = Cursors.Hand;
            btnMenuExit.FlatStyle = FlatStyle.Flat;
            btnMenuExit.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuExit.ForeColor = Color.FromArgb(25, 20, 45);
            btnMenuExit.Location = new Point(100, 215);
            btnMenuExit.Name = "btnMenuExit";
            btnMenuExit.Size = new Size(300, 55);
            btnMenuExit.TabIndex = 2;
            btnMenuExit.Text = "EXIT";
            btnMenuExit.UseVisualStyleBackColor = false;
            btnMenuExit.Click += btnMenuExit_Click;
            // 
            // btnMenuMakeQuiz
            // 
            btnMenuMakeQuiz.BackColor = Color.FromArgb(230, 190, 80);
            btnMenuMakeQuiz.Cursor = Cursors.Hand;
            btnMenuMakeQuiz.FlatStyle = FlatStyle.Flat;
            btnMenuMakeQuiz.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuMakeQuiz.ForeColor = Color.FromArgb(25, 20, 45);
            btnMenuMakeQuiz.Location = new Point(100, 85);
            btnMenuMakeQuiz.Name = "btnMenuMakeQuiz";
            btnMenuMakeQuiz.Size = new Size(300, 55);
            btnMenuMakeQuiz.TabIndex = 1;
            btnMenuMakeQuiz.Text = "MAKE QUIZ";
            btnMenuMakeQuiz.UseVisualStyleBackColor = false;
            // 
            // btnMenuLeaderboard
            // 
            btnMenuLeaderboard.BackColor = Color.FromArgb(230, 190, 80);
            btnMenuLeaderboard.Cursor = Cursors.Hand;
            btnMenuLeaderboard.FlatStyle = FlatStyle.Flat;
            btnMenuLeaderboard.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuLeaderboard.ForeColor = Color.FromArgb(25, 20, 45);
            btnMenuLeaderboard.Location = new Point(100, 150);
            btnMenuLeaderboard.Name = "btnMenuLeaderboard";
            btnMenuLeaderboard.Size = new Size(300, 55);
            btnMenuLeaderboard.TabIndex = 3;
            btnMenuLeaderboard.Text = "LEADERBOARD";
            btnMenuLeaderboard.UseVisualStyleBackColor = false;
            btnMenuLeaderboard.Click += btnMenuLeaderboard_Click;
            // 
            // btnMenuStartQuiz
            // 
            btnMenuStartQuiz.BackColor = Color.FromArgb(230, 190, 80);
            btnMenuStartQuiz.Cursor = Cursors.Hand;
            btnMenuStartQuiz.FlatStyle = FlatStyle.Flat;
            btnMenuStartQuiz.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuStartQuiz.ForeColor = Color.FromArgb(25, 20, 45);
            btnMenuStartQuiz.Location = new Point(100, 20);
            btnMenuStartQuiz.Name = "btnMenuStartQuiz";
            btnMenuStartQuiz.Size = new Size(300, 55);
            btnMenuStartQuiz.TabIndex = 0;
            btnMenuStartQuiz.Text = "START QUIZ";
            btnMenuStartQuiz.UseVisualStyleBackColor = false;
            btnMenuStartQuiz.Click += btnMenuStartQuiz_Click;
            // 
            // nextTimer
            // 
            nextTimer.Interval = 2000;
            nextTimer.Tick += nextTimer_Tick;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlLeaderboard);
            pnlMain.Controls.Add(pnlName);
            pnlMain.Controls.Add(pnlResults);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Controls.Add(lblSubtitle);
            pnlMain.Controls.Add(goldLine);
            pnlMain.Controls.Add(btnPlay);
            pnlMain.Controls.Add(pnlQuiz);
            pnlMain.Controls.Add(pnlMenu);
            pnlMain.Controls.Add(pnlSetup);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(700, 480);
            pnlMain.TabIndex = 7;
            // 
            // pnlLeaderboard
            // 
            pnlLeaderboard.Controls.Add(btnDeleteRecord);
            pnlLeaderboard.Controls.Add(btnLeaderboardBack);
            pnlLeaderboard.Controls.Add(lblLeaderboardTitle);
            pnlLeaderboard.Controls.Add(lstLeaderboard);
            pnlLeaderboard.Location = new Point(50, 140);
            pnlLeaderboard.Name = "pnlLeaderboard";
            pnlLeaderboard.Size = new Size(600, 330);
            pnlLeaderboard.TabIndex = 10;
            pnlLeaderboard.Visible = false;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.BackColor = Color.FromArgb(178, 58, 58);
            btnDeleteRecord.Cursor = Cursors.Hand;
            btnDeleteRecord.FlatStyle = FlatStyle.Flat;
            btnDeleteRecord.Font = new Font("Georgia", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteRecord.ForeColor = Color.FromArgb(245, 230, 200);
            btnDeleteRecord.Location = new Point(110, 265);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(180, 45);
            btnDeleteRecord.TabIndex = 7;
            btnDeleteRecord.Text = "DELETE";
            btnDeleteRecord.UseVisualStyleBackColor = false;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // btnLeaderboardBack
            // 
            btnLeaderboardBack.BackColor = Color.FromArgb(230, 190, 80);
            btnLeaderboardBack.Cursor = Cursors.Hand;
            btnLeaderboardBack.FlatStyle = FlatStyle.Flat;
            btnLeaderboardBack.Font = new Font("Georgia", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeaderboardBack.ForeColor = Color.FromArgb(25, 20, 45);
            btnLeaderboardBack.Location = new Point(310, 265);
            btnLeaderboardBack.Name = "btnLeaderboardBack";
            btnLeaderboardBack.Size = new Size(180, 45);
            btnLeaderboardBack.TabIndex = 6;
            btnLeaderboardBack.Text = "BACK";
            btnLeaderboardBack.UseVisualStyleBackColor = false;
            btnLeaderboardBack.Click += btnLeaderboardBack_Click;
            // 
            // lblLeaderboardTitle
            // 
            lblLeaderboardTitle.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeaderboardTitle.ForeColor = Color.FromArgb(230, 190, 80);
            lblLeaderboardTitle.Location = new Point(20, 5);
            lblLeaderboardTitle.Name = "lblLeaderboardTitle";
            lblLeaderboardTitle.Size = new Size(560, 35);
            lblLeaderboardTitle.TabIndex = 4;
            lblLeaderboardTitle.Text = "LEADERBOARD";
            lblLeaderboardTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstLeaderboard
            // 
            lstLeaderboard.BackColor = Color.FromArgb(45, 38, 80);
            lstLeaderboard.BorderStyle = BorderStyle.None;
            lstLeaderboard.Font = new Font("Consolas", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstLeaderboard.ForeColor = Color.FromArgb(245, 230, 200);
            lstLeaderboard.FormattingEnabled = true;
            lstLeaderboard.IntegralHeight = false;
            lstLeaderboard.Location = new Point(20, 45);
            lstLeaderboard.Name = "lstLeaderboard";
            lstLeaderboard.Size = new Size(560, 200);
            lstLeaderboard.TabIndex = 5;
            // 
            // pnlName
            // 
            pnlName.BackColor = Color.FromArgb(45, 38, 80);
            pnlName.BorderStyle = BorderStyle.FixedSingle;
            pnlName.Controls.Add(btnSaveScore);
            pnlName.Controls.Add(txtName);
            pnlName.Controls.Add(lblNamePrompt);
            pnlName.Location = new Point(150, 140);
            pnlName.Name = "pnlName";
            pnlName.Size = new Size(400, 200);
            pnlName.TabIndex = 8;
            pnlName.Visible = false;
            // 
            // btnSaveScore
            // 
            btnSaveScore.BackColor = Color.FromArgb(230, 190, 80);
            btnSaveScore.Cursor = Cursors.Hand;
            btnSaveScore.FlatStyle = FlatStyle.Flat;
            btnSaveScore.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveScore.ForeColor = Color.FromArgb(25, 20, 45);
            btnSaveScore.Location = new Point(100, 135);
            btnSaveScore.Name = "btnSaveScore";
            btnSaveScore.Size = new Size(200, 45);
            btnSaveScore.TabIndex = 2;
            btnSaveScore.Text = "SAVE SCORE";
            btnSaveScore.UseVisualStyleBackColor = false;
            btnSaveScore.Click += btnSaveScore_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(50, 85);
            txtName.MaxLength = 15;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 29);
            txtName.TabIndex = 1;
            // 
            // lblNamePrompt
            // 
            lblNamePrompt.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamePrompt.ForeColor = Color.FromArgb(230, 190, 80);
            lblNamePrompt.Location = new Point(20, 20);
            lblNamePrompt.Name = "lblNamePrompt";
            lblNamePrompt.Size = new Size(360, 50);
            lblNamePrompt.TabIndex = 0;
            lblNamePrompt.Text = "Enter your name";
            lblNamePrompt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlResults
            // 
            pnlResults.Controls.Add(btnPlayAgain);
            pnlResults.Controls.Add(lblDisclaimer);
            pnlResults.Controls.Add(lblFunIQ);
            pnlResults.Controls.Add(lblPercent);
            pnlResults.Controls.Add(lblScore);
            pnlResults.Controls.Add(lblRank);
            pnlResults.Controls.Add(lblResultTitle);
            pnlResults.Location = new Point(50, 140);
            pnlResults.Name = "pnlResults";
            pnlResults.Size = new Size(600, 330);
            pnlResults.TabIndex = 7;
            pnlResults.Visible = false;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.BackColor = Color.FromArgb(230, 190, 80);
            btnPlayAgain.Cursor = Cursors.Hand;
            btnPlayAgain.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayAgain.ForeColor = Color.FromArgb(25, 20, 45);
            btnPlayAgain.Location = new Point(200, 265);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(200, 50);
            btnPlayAgain.TabIndex = 6;
            btnPlayAgain.Text = "PLAY AGAIN";
            btnPlayAgain.UseVisualStyleBackColor = false;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // lblDisclaimer
            // 
            lblDisclaimer.AutoSize = true;
            lblDisclaimer.Font = new Font("Georgia", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisclaimer.ForeColor = Color.FromArgb(245, 230, 200);
            lblDisclaimer.Location = new Point(20, 205);
            lblDisclaimer.Name = "lblDisclaimer";
            lblDisclaimer.Size = new Size(789, 16);
            lblDisclaimer.TabIndex = 5;
            lblDisclaimer.Text = "For entertainment and interactive purposes only. Results are not an actual measure of intelligence, IQ, or overall knowledge.";
            lblDisclaimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFunIQ
            // 
            lblFunIQ.Font = new Font("Georgia", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFunIQ.ForeColor = Color.FromArgb(245, 230, 200);
            lblFunIQ.Location = new Point(400, 130);
            lblFunIQ.Name = "lblFunIQ";
            lblFunIQ.Size = new Size(180, 50);
            lblFunIQ.TabIndex = 4;
            lblFunIQ.Text = "Fun IQ: 100";
            lblFunIQ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPercent
            // 
            lblPercent.Font = new Font("Georgia", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercent.ForeColor = Color.FromArgb(245, 230, 200);
            lblPercent.Location = new Point(210, 130);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(180, 50);
            lblPercent.TabIndex = 3;
            lblPercent.Text = "Percentage: 0%";
            lblPercent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            lblScore.Font = new Font("Georgia", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.FromArgb(245, 230, 200);
            lblScore.Location = new Point(20, 130);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(180, 50);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score: 0";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRank
            // 
            lblRank.Font = new Font("Georgia", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRank.ForeColor = Color.FromArgb(230, 190, 80);
            lblRank.Location = new Point(20, 55);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(560, 55);
            lblRank.TabIndex = 1;
            lblRank.Text = "SAGE";
            lblRank.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResultTitle
            // 
            lblResultTitle.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultTitle.ForeColor = Color.FromArgb(230, 190, 80);
            lblResultTitle.Location = new Point(20, 5);
            lblResultTitle.Name = "lblResultTitle";
            lblResultTitle.Size = new Size(560, 40);
            lblResultTitle.TabIndex = 0;
            lblResultTitle.Text = "Quest Complete!";
            lblResultTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EduQuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 20, 45);
            ClientSize = new Size(714, 501);
            Controls.Add(pnlMain);
            Name = "EduQuest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Resize += EduQuest_Resize;
            pnlSetup.ResumeLayout(false);
            pnlSetup.PerformLayout();
            pnlQuiz.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlLeaderboard.ResumeLayout(false);
            pnlName.ResumeLayout(false);
            pnlName.PerformLayout();
            pnlResults.ResumeLayout(false);
            pnlResults.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel goldLine;
        private Button btnPlay;
        private Panel pnlSetup;
        private Label lblCategory;
        private ComboBox cboCategory;
        private ComboBox cboDifficulty;
        private Label lblDifficulty;
        private Button btnStart;
        private Panel pnlQuiz;
        private Label lblQuestion;
        private Button btnA;
        private Button btnD;
        private Button btnB;
        private Button btnC;
        private Label lblTimer;
        private System.Windows.Forms.Timer quizTimer;
        private Panel pnlMenu;
        private Button btnMenuStartQuiz;
        private Button btnMenuExit;
        private Button btnMenuMakeQuiz;
        private System.Windows.Forms.Timer nextTimer;
        private Panel pnlMain;
        private Panel pnlResults;
        private Label lblRank;
        private Label lblResultTitle;
        private Label lblScore;
        private Label lblDisclaimer;
        private Label lblFunIQ;
        private Label lblPercent;
        private Button btnPlayAgain;
        private Panel pnlName;
        private TextBox txtName;
        private Label lblNamePrompt;
        private Button btnSaveScore;
        private FlowLayoutPanel pnlOld;
        private Panel pnlLeaderboard;
        private Button btnDeleteRecord;
        private Button btnLeaderboardBack;
        private Label lblLeaderboardTitle;
        private ListBox lstLeaderboard;
        private Button btnMenuLeaderboard;
    }
}
