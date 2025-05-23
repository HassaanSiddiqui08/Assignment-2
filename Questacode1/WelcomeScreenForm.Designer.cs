namespace Questacode1
{
    partial class WelcomeScreenForm
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
            this.components = new System.ComponentModel.Container(); // Added for the Timer
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.animatedGifPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.closeTimer = new System.Windows.Forms.Timer(this.components); // Initialize Timer with components container
            ((System.ComponentModel.ISupportInitialize)(this.animatedGifPictureBox)).BeginInit();
            this.SuspendLayout();
            //
            // welcomeMessageLabel
            //
            this.welcomeMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessageLabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.welcomeMessageLabel.Location = new System.Drawing.Point(100, 50); // Adjusted for centering
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(600, 84);
            this.welcomeMessageLabel.Text = "Welcome, Little Coder!";
            this.welcomeMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // animatedGifPictureBox
            //
            this.animatedGifPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animatedGifPictureBox.Location = new System.Drawing.Point(200, 150); // Adjusted for centering
            this.animatedGifPictureBox.Name = "animatedGifPictureBox";
            this.animatedGifPictureBox.Size = new System.Drawing.Size(400, 300);
            this.animatedGifPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom; // Zoom to fit, maintain aspect ratio
            this.animatedGifPictureBox.TabIndex = 1;
            this.animatedGifPictureBox.TabStop = false;
            //
            // startButton
            //
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.BackColor = System.Drawing.Color.LimeGreen;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(275, 480); // Position below GIF
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(250, 60);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Let's Start!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            //
            // closeTimer
            //
            this.closeTimer.Interval = 5000; // Set interval in designer (or code)
            this.closeTimer.Tick += new System.EventHandler(this.CloseTimer_Tick); // Attach event handler
            //
            // WelcomeScreenForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue; // A friendly background color
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.animatedGifPictureBox);
            this.Controls.Add(this.welcomeMessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Make it borderless for a full-screen feel
            this.MaximizeBox = false;
            this.Name = "WelcomeScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Fun Zone!";
            this.KeyPreview = true; // Enable KeyPreview for the form itself
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WelcomeScreenForm_KeyDown); // Attach KeyDown event handler
            ((System.ComponentModel.ISupportInitialize)(this.animatedGifPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.PictureBox animatedGifPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer closeTimer; // Declared here for designer access
    }
}
