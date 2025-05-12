namespace Questacode1.Lessons
{
    partial class FirstProgram
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
            label1 = new Label();
            panel1 = new Panel();
            labelCode = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // grpSubTopics
            // 
            grpSubTopics.Location = new Point(1040, 12);
            grpSubTopics.Name = "grpSubTopics";
            grpSubTopics.Size = new Size(190, 541);
            grpSubTopics.TabIndex = 7;
            grpSubTopics.TabStop = false;
            grpSubTopics.Text = "Sub Topics";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(8, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1026, 406);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 444);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 9;
            label1.Text = "Read";
            label1.MouseDown += label1_MouseDown;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.ForeColor = Color.RoyalBlue;
            panel1.Location = new Point(554, 498);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 46);
            panel1.TabIndex = 10;
            panel1.DragDrop += panel1_DragDrop;
            panel1.DragEnter += panel1_DragEnter;
            // 
            // labelCode
            // 
            labelCode.Location = new Point(430, 431);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(524, 244);
            labelCode.TabIndex = 11;
            labelCode.Text = "\r\npublic class MyClass {\r\n      public static void Main(string[] args) {\r\n\r\n          Console.                                                               (\"Hello, World!\");\r\n\r\n      }\r\n  }";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 498);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 12;
            label2.Text = "WriteLine";
            label2.MouseDown += label2_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 554);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 13;
            label3.Text = "Hello";
            label3.MouseDown += label3_MouseDown;
            // 
            // FirstProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 684);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(grpSubTopics);
            Controls.Add(labelCode);
            Name = "FirstProgram";
            Text = "Write your first program";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grpSubTopics;
        private RichTextBox richTextBox1;
        private Label label1;
        private Panel panel1;
        private Label labelCode;
        private Label label2;
        private Label label3;
    }
}