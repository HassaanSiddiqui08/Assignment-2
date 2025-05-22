using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

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
                },
                new Question
                {
                    QuestionText = "What is a procedure?",
                    Options = new string[] { "crazy person", "a good boy", "set of instructions" },
                    CorrectAnswerIndex = 2,
                },
                new Question
                {
                    QuestionText = "If you have a box to keep numbers, what is that box called in coding?",
                    Options = new string[] { "A table", "A variable", "A chair" },
                    CorrectAnswerIndex = 1,
                },
                new Question
                {
                    QuestionText = "Which word tells the computer that something is a whole number?",
                    Options = new string[] { "text", "decimal", "integer" },
                    CorrectAnswerIndex = 2,
                },
                new Question
                {
                    QuestionText = "What do we use to store words or sentences in coding?",
                    Options = new string[] { "number", "string", "picture" },
                    CorrectAnswerIndex = 1,
                },

                // Operators
                new Question
                {
                    QuestionText = "What does the '+' sign do in coding?",
                    Options = new string[] { "Makes things smaller", "Adds numbers together", "Deletes things" },
                    CorrectAnswerIndex = 1,
                },
                new Question
                {
                    QuestionText = "If you want to multiply two numbers, which sign do you use?",
                    Options = new string[] { "-", "*", "/" },
                    CorrectAnswerIndex = 1,
                },
                new Question
                {
                    QuestionText = "What does the '=' sign mean in coding?",
                    Options = new string[] { "It's equal to", "It gives a value to something", "It's a question mark" },
                    CorrectAnswerIndex = 1,
                },
                new Question
                {
                    QuestionText = "Which sign means 'not equal to'?",
                    Options = new string[] { "==", "!=", "<=" },
                    CorrectAnswerIndex = 1,
                },

                // Conditions (If/Else)
                new Question
                {
                    QuestionText = "If it's raining, what should you do?",
                    Options = new string[] { "Go outside without umbrella", "Stay inside or use an umbrella", "Sing loudly" },
                    CorrectAnswerIndex = 1,
                },
                new Question
                {
                    QuestionText = "In coding, what word helps the computer make a choice?",
                    Options = new string[] { "Run", "If", "Stop" },
                    CorrectAnswerIndex = 1,
                },
                new Question
                {
                    QuestionText = "What happens if an 'if' condition is not true?",
                    Options = new string[] { "The computer stops", "It tries the 'else' part", "It asks for help" },
                    CorrectAnswerIndex = 1,
                },

                // Loops
                new Question
                {
                    QuestionText = "If you want the computer to do something many times, what do you use?",
                    Options = new string[] { "A single command", "A loop", "A pause" },
                    CorrectAnswerIndex = 1,
                },
                new Question
                {
                    QuestionText = "Which loop repeats something a certain number of times?",
                    Options = new string[] { "While loop", "For loop", "If loop" },
                    CorrectAnswerIndex = 1,
                },
                new Question
                {
                    QuestionText = "What does a 'while' loop do?",
                    Options = new string[] { "Runs once", "Runs only if it's correct", "Keeps running as long as a condition is true" },
                    CorrectAnswerIndex = 2,
                },

                // Functions/Methods
                new Question
                {
                    QuestionText = "What is a small block of code that does a specific job?",
                    Options = new string[] { "A book", "A function (or method)", "A game" },
                    CorrectAnswerIndex = 1,
                },
                new Question
                {
                    QuestionText = "When you 'call' a function, what are you doing?",
                    Options = new string[] { "Talking to it", "Making it do its job", "Ignoring it" },
                    CorrectAnswerIndex = 1,
                },
                new Question
                {
                    QuestionText = "Why do we use functions in coding?",
                    Options = new string[] { "To make code longer", "To organize code and reuse it", "To make code disappear" },
                    CorrectAnswerIndex = 1,
                }
            };


            questions = questions.OrderBy(x => Guid.NewGuid()).ToList();
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

                // save changes to Quiz score
                Properties.Settings.Default.QuizScore = score;
                Properties.Settings.Default.Save(); // Saves the changes to the user.config file
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
                Utilities.PlaySound("family-applause.wav");
                MessageBox.Show("Correct!");
            }
            else
            {
                Utilities.PlaySound("wrong-choice.wav");
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
