using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questacode1
{
    public partial class Quizzes : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;
        public Quizzes()
        {
            InitializeComponent();
            LoadQuestions();
            ShowQuestion();

            labelScore.Text = $"Score: {score}";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void LoadQuestions()
        {
            questions = new List<Question>()
            {
                new Question
                {
                    QuestionText = "What is a variable?",
                    Options = new string[] { "a placeholder to store value", "a method", "a function" },
                    CorrectAnswerIndex = 0,
                },
                new Question
                {
                    QuestionText = "What is a datatype?",
                    Options = new string[] { "a liquid", "type of a variable", "a car" },
                    CorrectAnswerIndex = 1,
                }
                //todo: add more questions
            };
        }

        private void ShowQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                labelQuestion.Text = questions[currentQuestionIndex].QuestionText;

                if (questions[currentQuestionIndex].Options.Length >= 3)
                {
                    radioButton1.Text = questions[currentQuestionIndex].Options[0];
                    radioButton2.Text = questions[currentQuestionIndex].Options[1];
                    radioButton3.Text = questions[currentQuestionIndex].Options[2];

                    //turned the checked property to false
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;

                    labelQuestionNumber.Text = $"Question {currentQuestionIndex + 1} of {questions.Count}";
                    buttonNext.Enabled = false; // Disable next button until an answer is submitted
                    buttonSubmit.Enabled = true;
                }
            }
            else
            {
                //quiz is finished
                MessageBox.Show($"Your score is {score} out of {questions.Count}");
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int selectedAnswerIndex = -1;

            if (radioButton1.Checked)
            {
                selectedAnswerIndex = 0;
            }
            else if (radioButton2.Checked)
            {
                selectedAnswerIndex = 1;
            }
            else if (radioButton3.Checked)
            {
                selectedAnswerIndex = 2;
            }

            if (selectedAnswerIndex == -1)
            {
                MessageBox.Show("Please select an answer");
                return;
            }

            if (selectedAnswerIndex == questions[currentQuestionIndex].CorrectAnswerIndex)
            {
                score++;
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show($"Incorrect. The correct answer was: {questions[currentQuestionIndex].Options[questions[currentQuestionIndex].CorrectAnswerIndex]}", "Result");
            }

            labelScore.Text = $"Score: {score}";
            buttonSubmit.Enabled = false;
            buttonNext.Enabled = true; // Enable the next button
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentQuestionIndex += 1;
            ShowQuestion();
        }

        private void Quizzes_Load(object sender, EventArgs e)
        {

        }
    }
}
