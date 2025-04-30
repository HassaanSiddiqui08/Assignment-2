namespace Questacode1
{
    partial class Introduction
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
            grpCodeEditor = new GroupBox();
            textBox1 = new TextBox();
            grpSubTopics = new GroupBox();
            pictureBox1 = new PictureBox();
            grpCodeEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpCodeEditor
            // 
            grpCodeEditor.Controls.Add(textBox1);
            grpCodeEditor.Location = new Point(59, 562);
            grpCodeEditor.Name = "grpCodeEditor";
            grpCodeEditor.Size = new Size(912, 179);
            grpCodeEditor.TabIndex = 2;
            grpCodeEditor.TabStop = false;
            grpCodeEditor.Text = "Code Editor";
            grpCodeEditor.Enter += grpCodeEditor_Enter;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(906, 153);
            textBox1.TabIndex = 0;
            // 
            // grpSubTopics
            // 
            grpSubTopics.Location = new Point(983, 12);
            grpSubTopics.Name = "grpSubTopics";
            grpSubTopics.Size = new Size(190, 541);
            grpSubTopics.TabIndex = 3;
            grpSubTopics.TabStop = false;
            grpSubTopics.Text = "Sub Topics";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(59, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(909, 544);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Introduction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(pictureBox1);
            Controls.Add(grpSubTopics);
            Controls.Add(grpCodeEditor);
            Location = new Point(500, 200);
            Name = "Introduction";
            StartPosition = FormStartPosition.Manual;
            Text = "Introduction";
            grpCodeEditor.ResumeLayout(false);
            grpCodeEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpCodeEditor;
        private GroupBox grpSubTopics;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}