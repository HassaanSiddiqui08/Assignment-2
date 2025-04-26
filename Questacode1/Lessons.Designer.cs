namespace Questacode1
{
    partial class Lessons
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
            grpTopics = new GroupBox();
            lblbOperators = new Label();
            lblOutIn = new Label();
            lblVariables = new Label();
            lblIntroduction = new Label();
            panel1 = new Panel();
            grpCodeEditor = new GroupBox();
            grpSubTopics = new GroupBox();
            lblConditions = new Label();
            lblMethodFunctions = new Label();
            lblArrays = new Label();
            label1 = new Label();
            grpTopics.SuspendLayout();
            SuspendLayout();
            // 
            // grpTopics
            // 
            grpTopics.Controls.Add(label1);
            grpTopics.Controls.Add(lblArrays);
            grpTopics.Controls.Add(lblMethodFunctions);
            grpTopics.Controls.Add(lblConditions);
            grpTopics.Controls.Add(lblbOperators);
            grpTopics.Controls.Add(lblOutIn);
            grpTopics.Controls.Add(lblVariables);
            grpTopics.Controls.Add(lblIntroduction);
            grpTopics.Location = new Point(12, 39);
            grpTopics.Name = "grpTopics";
            grpTopics.Size = new Size(254, 698);
            grpTopics.TabIndex = 0;
            grpTopics.TabStop = false;
            grpTopics.Text = "Topics";
            // 
            // lblbOperators
            // 
            lblbOperators.AutoSize = true;
            lblbOperators.Location = new Point(15, 288);
            lblbOperators.Name = "lblbOperators";
            lblbOperators.Size = new Size(75, 20);
            lblbOperators.TabIndex = 3;
            lblbOperators.Text = "Operators";
            // 
            // lblOutIn
            // 
            lblOutIn.AutoSize = true;
            lblOutIn.Location = new Point(15, 215);
            lblOutIn.Name = "lblOutIn";
            lblOutIn.Size = new Size(133, 20);
            lblOutIn.TabIndex = 2;
            lblOutIn.Text = "Basic Input/Output";
            // 
            // lblVariables
            // 
            lblVariables.AutoSize = true;
            lblVariables.Location = new Point(15, 140);
            lblVariables.Name = "lblVariables";
            lblVariables.Size = new Size(69, 20);
            lblVariables.TabIndex = 1;
            lblVariables.Text = "Variables";
            // 
            // lblIntroduction
            // 
            lblIntroduction.AutoSize = true;
            lblIntroduction.Location = new Point(15, 60);
            lblIntroduction.Name = "lblIntroduction";
            lblIntroduction.Size = new Size(90, 20);
            lblIntroduction.TabIndex = 0;
            lblIntroduction.Text = "Introduction";
            // 
            // panel1
            // 
            panel1.Location = new Point(272, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 516);
            panel1.TabIndex = 1;
            // 
            // grpCodeEditor
            // 
            grpCodeEditor.Location = new Point(272, 558);
            grpCodeEditor.Name = "grpCodeEditor";
            grpCodeEditor.Size = new Size(701, 179);
            grpCodeEditor.TabIndex = 2;
            grpCodeEditor.TabStop = false;
            grpCodeEditor.Text = "Code Editor";
            // 
            // grpSubTopics
            // 
            grpSubTopics.Location = new Point(983, 39);
            grpSubTopics.Name = "grpSubTopics";
            grpSubTopics.Size = new Size(190, 514);
            grpSubTopics.TabIndex = 3;
            grpSubTopics.TabStop = false;
            grpSubTopics.Text = "Sub Topics";
            // 
            // lblConditions
            // 
            lblConditions.AutoSize = true;
            lblConditions.Location = new Point(15, 361);
            lblConditions.Name = "lblConditions";
            lblConditions.Size = new Size(80, 20);
            lblConditions.TabIndex = 4;
            lblConditions.Text = "Conditions";
            // 
            // lblMethodFunctions
            // 
            lblMethodFunctions.AutoSize = true;
            lblMethodFunctions.Location = new Point(13, 446);
            lblMethodFunctions.Name = "lblMethodFunctions";
            lblMethodFunctions.Size = new Size(177, 20);
            lblMethodFunctions.TabIndex = 5;
            lblMethodFunctions.Text = "Functions and Procedures";
            // 
            // lblArrays
            // 
            lblArrays.AutoSize = true;
            lblArrays.Location = new Point(15, 509);
            lblArrays.Name = "lblArrays";
            lblArrays.Size = new Size(111, 20);
            lblArrays.TabIndex = 6;
            lblArrays.Text = "Arrays and Lists";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 578);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 7;
            label1.Text = "Introduction";
            // 
            // Lessons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(grpSubTopics);
            Controls.Add(grpCodeEditor);
            Controls.Add(panel1);
            Controls.Add(grpTopics);
            Name = "Lessons";
            Text = "Lessons";
            grpTopics.ResumeLayout(false);
            grpTopics.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTopics;
        private Label lblVariables;
        private Label lblIntroduction;
        private Panel panel1;
        private GroupBox grpCodeEditor;
        private GroupBox grpSubTopics;
        private Label lblbOperators;
        private Label lblOutIn;
        private Label lblMethodFunctions;
        private Label lblConditions;
        private Label label1;
        private Label lblArrays;
    }
}