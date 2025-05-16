using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questacode1.Lessons
{
    public partial class FirstProgram : Form
    {
        string qText = "\r\npublic class MyClass {\r\n      public static void Main(string[] args) {\r\n\r\n          Console.                                                               (\"Hello, World!\");\r\n\r\n      }\r\n  }";

        Question question;


        public FirstProgram()
        {
            InitializeComponent();
            Utilities.LoadFile(richTextBox1, "BasicInputOutput.rtf");

            question = new Question()
            {
                QuestionText = qText,
                Options = new string[] { "Read", "WriteLine", "Hello" },
                CorrectAnswerIndex = 1
            };

            LoadQuestion();
        }

        private void LoadQuestion()
        {
            labelCode.Text = question.QuestionText;
            label1.Text = question.Options[0];
            label2.Text = question.Options[1];
            label3.Text = question.Options[2];
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1.DoDragDrop(label1.Text, DragDropEffects.Move);
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label2.DoDragDrop(label2.Text, DragDropEffects.Move);
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label3.DoDragDrop(label3.Text, DragDropEffects.Move);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the dragged data is text
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                // Allow the drop operation
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                // Disallow the drop operation
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            // Get the dragged text
            string draggedText = (string)e.Data.GetData(DataFormats.Text);

            // Update the drop target (e.g., the Panel's Controls or a Label within the Panel)
            // For a Panel, you might add a Label to it:
            Label newLabel = new Label();
            newLabel.Text = draggedText;
            newLabel.Dock = DockStyle.Fill;  // Make it fill the panel
            panel1.Controls.Clear();    // Clear any previous content
            panel1.Controls.Add(newLabel);

            // Check if the dropped text is the correct answer
            if (draggedText == question.Options[question.CorrectAnswerIndex])
            {
                Utilities.PlaySound("family-applause.wav");
                MessageBox.Show("Correct Answer!");

            }
            else
            {
                Utilities.PlaySound("wrong-choice.wav");
                MessageBox.Show("Incorrect Answer, Try Again");
                panel1.Controls.Clear(); //remove the label.
            }
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(e.LinkText) { UseShellExecute = true });

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not open link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.CurrentTask = "Basics";
            user.LastCompletedTask = "Variables";
            user.Score = 5;
            user.CurrentLevel = 1;

            user.SaveProgress();
        }
    }
}
