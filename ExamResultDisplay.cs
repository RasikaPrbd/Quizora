using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizora
{
    internal class ExamResultDisplay
    {
        public string StudentName { get; set; }
        public string RegNo { get; set; }
        public string PaperNo { get; set; }
        public string DateTime { get; set; }
        public int CorrectAnswers { get; set; }
        public int TotalQuestions { get; set; }
        public string Percentage => $"{((double)CorrectAnswers / TotalQuestions * 100):F2}%";
    }
}
