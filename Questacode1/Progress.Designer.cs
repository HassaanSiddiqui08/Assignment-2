namespace Questacode1
{
    partial class Progress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblCurrentTask = new Label();
            lblLastCompleted = new Label();
            label3 = new Label();
            lblCurrentLevel = new Label();
            label5 = new Label();
            lblScore = new Label();
            label7 = new Label();
            label6 = new Label();
            lblQuizScore = new Label();
            label2 = new Label();
            txtQuestions = new TextBox();
            btnSet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 95);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 31);
            label1.TabIndex = 0;
            label1.Text = "Current task";
            // 
            // lblCurrentTask
            // 
            lblCurrentTask.AutoSize = true;
            lblCurrentTask.Location = new Point(322, 95);
            lblCurrentTask.Margin = new Padding(5, 0, 5, 0);
            lblCurrentTask.Name = "lblCurrentTask";
            lblCurrentTask.Size = new Size(132, 31);
            lblCurrentTask.TabIndex = 1;
            lblCurrentTask.Text = "CurrentTask";
            // 
            // lblLastCompleted
            // 
            lblLastCompleted.AutoSize = true;
            lblLastCompleted.Location = new Point(322, 151);
            lblLastCompleted.Margin = new Padding(5, 0, 5, 0);
            lblLastCompleted.Name = "lblLastCompleted";
            lblLastCompleted.Size = new Size(168, 31);
            lblLastCompleted.TabIndex = 3;
            lblLastCompleted.Text = "LastCompleted";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 151);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(171, 31);
            label3.TabIndex = 2;
            label3.Text = "Last completed";
            // 
            // lblCurrentLevel
            // 
            lblCurrentLevel.AutoSize = true;
            lblCurrentLevel.Location = new Point(322, 267);
            lblCurrentLevel.Margin = new Padding(5, 0, 5, 0);
            lblCurrentLevel.Name = "lblCurrentLevel";
            lblCurrentLevel.Size = new Size(142, 31);
            lblCurrentLevel.TabIndex = 7;
            lblCurrentLevel.Text = "CurrentLevel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 267);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 31);
            label5.TabIndex = 6;
            label5.Text = "Level";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(322, 211);
            lblScore.Margin = new Padding(5, 0, 5, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(70, 31);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 211);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 31);
            label7.TabIndex = 4;
            label7.Text = "Score";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 325);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 31);
            label6.TabIndex = 8;
            label6.Text = "QuizScore";
            // 
            // lblQuizScore
            // 
            lblQuizScore.AutoSize = true;
            lblQuizScore.Location = new Point(322, 325);
            lblQuizScore.Margin = new Padding(5, 0, 5, 0);
            lblQuizScore.Name = "lblQuizScore";
            lblQuizScore.Size = new Size(116, 31);
            lblQuizScore.TabIndex = 9;
            lblQuizScore.Text = "QuizScore";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 389);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 31);
            label2.TabIndex = 10;
            label2.Text = "QuizQuestions";
            // 
            // txtQuestions
            // 
            txtQuestions.Location = new Point(339, 392);
            txtQuestions.Name = "txtQuestions";
            txtQuestions.Size = new Size(125, 38);
            txtQuestions.TabIndex = 11;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(518, 392);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(91, 38);
            btnSet.TabIndex = 12;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // Progress
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 698);
            Controls.Add(btnSet);
            Controls.Add(txtQuestions);
            Controls.Add(label2);
            Controls.Add(lblQuizScore);
            Controls.Add(label6);
            Controls.Add(lblCurrentLevel);
            Controls.Add(label5);
            Controls.Add(lblScore);
            Controls.Add(label7);
            Controls.Add(lblLastCompleted);
            Controls.Add(label3);
            Controls.Add(lblCurrentTask);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Progress";
            Text = "Progress";
            Load += Progress_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCurrentTask;
        private Label lblLastCompleted;
        private Label label3;
        private Label lblCurrentLevel;
        private Label label5;
        private Label lblScore;
        private Label label7;
        private Label label6;
        private Label lblQuizScore;
        private Label label2;
        private TextBox txtQuestions;
        private Button btnSet;
    }
}