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
            pnlSetup.SuspendLayout();
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
            pnlSetup.Paint += pnlSetup_Paint;
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
            cboCategory.Items.AddRange(new object[] { "   Mathematics", "   English Grammar", "   General Knowledge" });
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
            // EduQuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 20, 45);
            ClientSize = new Size(700, 480);
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
    }
}
