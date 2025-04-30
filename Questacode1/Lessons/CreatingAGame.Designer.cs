namespace Questacode1.Lessons
{
    partial class CreateGame
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
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            grpSubTopics = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 481);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(845, 125);
            textBox1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(227, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(676, 350);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // grpSubTopics
            // 
            grpSubTopics.Location = new Point(991, 109);
            grpSubTopics.Name = "grpSubTopics";
            grpSubTopics.Size = new Size(190, 541);
            grpSubTopics.TabIndex = 17;
            grpSubTopics.TabStop = false;
            grpSubTopics.Text = "Sub Topics";
            // 
            // CreateGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 730);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(grpSubTopics);
            Name = "CreateGame";
            Text = "Creating a Game!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox grpSubTopics;
    }
}