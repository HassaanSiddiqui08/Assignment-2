using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questacode1
{
    public class User
    {
        
        public string CurrentTask { get; set; }
        public string LastCompletedTask { get; set; }
        public int Score { get; set; }
        public int CurrentLevel { get; set; }
        public int QuizScore { get; set; }

        public void SaveProgress()
        {
            // To save progress:
            Properties.Settings.Default.CurrentLevel = CurrentLevel;
            Properties.Settings.Default.Score = Score;
            Properties.Settings.Default.LastCompletedTask = LastCompletedTask;
            Properties.Settings.Default.CurrentTask = CurrentTask;
            Properties.Settings.Default.QuizScore = QuizScore;
            Properties.Settings.Default.Save(); // Saves the changes to the user.config file
        }

        public User RetrieveProgress()
        {
            User user = new User();

            user.CurrentLevel = Properties.Settings.Default.CurrentLevel;
            user.Score = Properties.Settings.Default.Score;
            user.LastCompletedTask = Properties.Settings.Default.LastCompletedTask;
            user.CurrentTask = Properties.Settings.Default.CurrentTask;
            user.QuizScore = Properties.Settings.Default.QuizScore;

            return user;
        }
    }
}
