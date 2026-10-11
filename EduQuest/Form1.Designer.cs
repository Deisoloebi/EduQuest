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
            btnMenuStartQuiz = new Button();
            nextTimer = new System.Windows.Forms.Timer(components);
            pnlSetup.SuspendLayout();
            pnlQuiz.SuspendLayout();
            pnlMenu.SuspendLayout();
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
            pnlMenu.Controls.Add(btnMenuStartQuiz);
            pnlMenu.Location = new Point(100, 150);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(500, 250);
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
            btnMenuExit.Location = new Point(100, 163);
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
            btnMenuMakeQuiz.Location = new Point(100, 98);
            btnMenuMakeQuiz.Name = "btnMenuMakeQuiz";
            btnMenuMakeQuiz.Size = new Size(300, 55);
            btnMenuMakeQuiz.TabIndex = 1;
            btnMenuMakeQuiz.Text = "MAKE QUIZ";
            btnMenuMakeQuiz.UseVisualStyleBackColor = false;
            // 
            // btnMenuStartQuiz
            // 
            btnMenuStartQuiz.BackColor = Color.FromArgb(230, 190, 80);
            btnMenuStartQuiz.Cursor = Cursors.Hand;
            btnMenuStartQuiz.FlatStyle = FlatStyle.Flat;
            btnMenuStartQuiz.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuStartQuiz.ForeColor = Color.FromArgb(25, 20, 45);
            btnMenuStartQuiz.Location = new Point(100, 30);
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
            // EduQuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 20, 45);
            ClientSize = new Size(700, 480);
            Controls.Add(pnlMenu);
            Controls.Add(pnlQuiz);
            Controls.Add(pnlSetup);
            Controls.Add(btnPlay);
            Controls.Add(goldLine);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EduQuest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlSetup.ResumeLayout(false);
            pnlSetup.PerformLayout();
            pnlQuiz.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
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
    }
}
