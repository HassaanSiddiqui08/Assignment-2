namespace Questacode1
{
    partial class Variables
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
            grpSubTopics = new GroupBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // grpSubTopics
            // 
            grpSubTopics.Dock = DockStyle.Right;
            grpSubTopics.Location = new Point(992, 0);
            grpSubTopics.Name = "grpSubTopics";
            grpSubTopics.Size = new Size(190, 753);
            grpSubTopics.TabIndex = 3;
            grpSubTopics.TabStop = false;
            grpSubTopics.Text = "Sub Topics";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(992, 753);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.LinkClicked += richTextBox1_LinkClicked;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Variables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(richTextBox1);
            Controls.Add(grpSubTopics);
            Location = new Point(500, 200);
            Name = "Variables";
            StartPosition = FormStartPosition.Manual;
            Text = "Variables";
            Load += Variables_Load;
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpSubTopics;
        private RichTextBox richTextBox1;
    }
}