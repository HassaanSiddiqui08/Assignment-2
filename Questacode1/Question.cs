using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questacode1
{
    public class Question
    {
        public string QuestionText { get; set; }
        public string[] Options { get; set; }
        public int CorrectAnswerIndex { get; set; } // Index of the correct option in the Options array
    }
}
