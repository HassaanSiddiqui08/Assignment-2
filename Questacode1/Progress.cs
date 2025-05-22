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
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            User user = new User();

            user = user.RetrieveProgress();

            lblCurrentTask.Text = user.CurrentTask;
            lblLastCompleted.Text = user.LastCompletedTask;
            lblScore.Text = user.Score.ToString();
            lblCurrentLevel.Text = user.CurrentLevel.ToString();
            lblQuizScore.Text = user.QuizScore.ToString();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.QuizScore = Convert.ToInt32(txtQuestions.Text);
            Properties.Settings.Default.Save();
        }
    }
}
