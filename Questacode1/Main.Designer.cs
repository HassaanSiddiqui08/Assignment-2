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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            lessonsToolStripMenuItem = new ToolStripMenuItem();
            lessonsOveToolStripMenuItem = new ToolStripMenuItem();
            qUIZZESToolStripMenuItem = new ToolStripMenuItem();
            gAMEToolStripMenuItem = new ToolStripMenuItem();
            pROGRESSToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            menuStrip2 = new MenuStrip();
            introToolStripMenuItem = new ToolStripMenuItem();
            variablesToolStripMenuItem = new ToolStripMenuItem();
            variablesToolStripMenuItem1 = new ToolStripMenuItem();
            basicInputOutputToolStripMenuItem = new ToolStripMenuItem();
            operatorsToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1334, 79);
            panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { lessonsToolStripMenuItem, qUIZZESToolStripMenuItem, gAMEToolStripMenuItem, pROGRESSToolStripMenuItem, eXITToolStripMenuItem });
            menuStrip1.Location = new Point(249, 30);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(384, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // lessonsToolStripMenuItem
            // 
            lessonsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lessonsOveToolStripMenuItem });
            lessonsToolStripMenuItem.Name = "lessonsToolStripMenuItem";
            lessonsToolStripMenuItem.Size = new Size(84, 24);
            lessonsToolStripMenuItem.Text = "LESSONS";
            // 
            // lessonsOveToolStripMenuItem
            // 
            lessonsOveToolStripMenuItem.Name = "lessonsOveToolStripMenuItem";
            lessonsOveToolStripMenuItem.Size = new Size(207, 26);
            lessonsOveToolStripMenuItem.Text = "Lessons Overview";
            lessonsOveToolStripMenuItem.Click += lessonsOveToolStripMenuItem_Click_1;
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
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(52, 24);
            eXITToolStripMenuItem.Text = "EXIT";
            eXITToolStripMenuItem.Click += eXITToolStripMenuItem_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip2);
            panel2.Location = new Point(12, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 623);
            panel2.TabIndex = 4;
            panel2.Visible = false;
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { introToolStripMenuItem, variablesToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(110, 623);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // introToolStripMenuItem
            // 
            introToolStripMenuItem.Name = "introToolStripMenuItem";
            introToolStripMenuItem.Size = new Size(97, 24);
            introToolStripMenuItem.Text = "Introduction";
            introToolStripMenuItem.Click += introToolStripMenuItem_Click_1;
            // 
            // variablesToolStripMenuItem
            // 
            variablesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { variablesToolStripMenuItem1, basicInputOutputToolStripMenuItem, operatorsToolStripMenuItem });
            variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            variablesToolStripMenuItem.Size = new Size(97, 24);
            variablesToolStripMenuItem.Text = "Topics";
            // 
            // variablesToolStripMenuItem1
            // 
            variablesToolStripMenuItem1.Name = "variablesToolStripMenuItem1";
            variablesToolStripMenuItem1.Size = new Size(216, 26);
            variablesToolStripMenuItem1.Text = "Variables";
            // 
            // basicInputOutputToolStripMenuItem
            // 
            basicInputOutputToolStripMenuItem.Name = "basicInputOutputToolStripMenuItem";
            basicInputOutputToolStripMenuItem.Size = new Size(216, 26);
            basicInputOutputToolStripMenuItem.Text = "Basic Input/Output";
            // 
            // operatorsToolStripMenuItem
            // 
            operatorsToolStripMenuItem.Name = "operatorsToolStripMenuItem";
            operatorsToolStripMenuItem.Size = new Size(216, 26);
            operatorsToolStripMenuItem.Text = "Operators";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 757);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            FormClosing += Main_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem introToolStripMenuItem;
        private ToolStripMenuItem variablesToolStripMenuItem;
        private ToolStripMenuItem variablesToolStripMenuItem1;
        private ToolStripMenuItem basicInputOutputToolStripMenuItem;
        private ToolStripMenuItem operatorsToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem lessonsToolStripMenuItem;
        private ToolStripMenuItem lessonsOveToolStripMenuItem;
        private ToolStripMenuItem qUIZZESToolStripMenuItem;
        private ToolStripMenuItem gAMEToolStripMenuItem;
        private ToolStripMenuItem pROGRESSToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
    }
}
