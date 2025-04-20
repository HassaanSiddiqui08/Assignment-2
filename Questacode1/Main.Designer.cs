namespace Questacode1
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            lessonsToolStripMenuItem = new ToolStripMenuItem();
            qUIZZESToolStripMenuItem = new ToolStripMenuItem();
            gAMEToolStripMenuItem = new ToolStripMenuItem();
            pROGRESSToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { lessonsToolStripMenuItem, qUIZZESToolStripMenuItem, gAMEToolStripMenuItem, pROGRESSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1034, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lessonsToolStripMenuItem
            // 
            lessonsToolStripMenuItem.Name = "lessonsToolStripMenuItem";
            lessonsToolStripMenuItem.Size = new Size(84, 24);
            lessonsToolStripMenuItem.Text = "LESSONS";
            // 
            // qUIZZESToolStripMenuItem
            // 
            qUIZZESToolStripMenuItem.Name = "qUIZZESToolStripMenuItem";
            qUIZZESToolStripMenuItem.Size = new Size(82, 24);
            qUIZZESToolStripMenuItem.Text = "QUIZZES";
            // 
            // gAMEToolStripMenuItem
            // 
            gAMEToolStripMenuItem.Name = "gAMEToolStripMenuItem";
            gAMEToolStripMenuItem.Size = new Size(64, 24);
            gAMEToolStripMenuItem.Text = "GAME";
            // 
            // pROGRESSToolStripMenuItem
            // 
            pROGRESSToolStripMenuItem.Name = "pROGRESSToolStripMenuItem";
            pROGRESSToolStripMenuItem.Size = new Size(94, 24);
            pROGRESSToolStripMenuItem.Text = "PROGRESS";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 593);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lessonsToolStripMenuItem;
        private ToolStripMenuItem qUIZZESToolStripMenuItem;
        private ToolStripMenuItem gAMEToolStripMenuItem;
        private ToolStripMenuItem pROGRESSToolStripMenuItem;
    }
}
