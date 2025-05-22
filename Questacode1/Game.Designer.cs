namespace Questacode1
{
    partial class Game
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.ticTacToeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticTacToePanel = new System.Windows.Forms.Panel();
            this.ticTacToeTurnLabel = new System.Windows.Forms.Label();
            this.ticTacToeResetButton = new System.Windows.Forms.Button();

            this.mainPanel.SuspendLayout();
            this.ticTacToePanel.SuspendLayout();
            this.SuspendLayout();

            //
            // mainPanel
            //
            this.mainPanel.BackColor = System.Drawing.Color.LightCyan;
            this.mainPanel.Controls.Add(this.welcomeLabel);
            this.mainPanel.Controls.Add(this.messageLabel);
            this.mainPanel.Controls.Add(this.ticTacToeButton);
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.ticTacToePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(584, 461); // Adjusted size for better fit
            this.mainPanel.TabIndex = 0;
            //
            // welcomeLabel
            //
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(90, 20); // Centered horizontally for 584 width
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(405, 46);
            this.welcomeLabel.Text = "Welcome to the Gaming Zone!";
            //
            // messageLabel
            //
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(20, 100);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(130, 27);
            this.messageLabel.Text = "Enter choice";
            //
            // ticTacToeButton
            //
            this.ticTacToeButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ticTacToeButton.FlatAppearance.BorderSize = 0;
            this.ticTacToeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticTacToeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticTacToeButton.ForeColor = System.Drawing.Color.White;
            this.ticTacToeButton.Location = new System.Drawing.Point(20, 150);
            this.ticTacToeButton.Name = "ticTacToeButton";
            this.ticTacToeButton.Size = new System.Drawing.Size(250, 40);
            this.ticTacToeButton.Text = "1. Play Tic Tac Toe (with your Buddy)";
            this.ticTacToeButton.UseVisualStyleBackColor = false;
            this.ticTacToeButton.Click += new System.EventHandler(this.TicTacToeButton_Click);
            //
            // exitButton
            //
            this.exitButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(20, 200);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(250, 40);
            this.exitButton.Text = "2. Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            //
            // ticTacToePanel
            //
            this.ticTacToePanel.BackColor = System.Drawing.Color.LightGray;
            this.ticTacToePanel.Controls.Add(this.ticTacToeTurnLabel);
            this.ticTacToePanel.Controls.Add(this.ticTacToeResetButton);
            this.ticTacToePanel.Location = new System.Drawing.Point(40, 80); // Adjusted location for better centering
            this.ticTacToePanel.Name = "ticTacToePanel";
            this.ticTacToePanel.Size = new System.Drawing.Size(500, 400);
            this.ticTacToePanel.TabIndex = 0;
            this.ticTacToePanel.Visible = false;
            //
            // ticTacToeTurnLabel
            //
            this.ticTacToeTurnLabel.AutoSize = true;
            this.ticTacToeTurnLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticTacToeTurnLabel.Location = new System.Drawing.Point(10, 10);
            this.ticTacToeTurnLabel.Name = "ticTacToeTurnLabel";
            this.ticTacToeTurnLabel.Size = new System.Drawing.Size(248, 32);
            this.ticTacToeTurnLabel.Text = "Player 1's Turn (X)";
            //
            // ticTacToeResetButton
            //
            this.ticTacToeResetButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ticTacToeResetButton.FlatAppearance.BorderSize = 0;
            this.ticTacToeResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticTacToeResetButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticTacToeResetButton.ForeColor = System.Drawing.Color.White;
            this.ticTacToeResetButton.Location = new System.Drawing.Point(125, 340);
            this.ticTacToeResetButton.Name = "ticTacToeResetButton";
            this.ticTacToeResetButton.Size = new System.Drawing.Size(250, 40);
            this.ticTacToeResetButton.Text = "Reset Tic Tac Toe";
            this.ticTacToeResetButton.UseVisualStyleBackColor = false;
            this.ticTacToeResetButton.Click += new System.EventHandler(this.TicTacToeResetButton_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Default for .NET Framework, adjust for .NET Core/.NET 5+
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaming Zone";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ticTacToePanel.ResumeLayout(false);
            this.ticTacToePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel mainPanel;
        private Label welcomeLabel;
        private Button ticTacToeButton;
        private Button exitButton;
        private Label messageLabel;

        private Panel ticTacToePanel;
        private Label ticTacToeTurnLabel;
        private Button ticTacToeResetButton;
    }
}