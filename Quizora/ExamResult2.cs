using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizora
{
    public class ExamResult2
    {
        public int Correct { get; set; }
        public int Total { get; set; }
        public string DateTime { get; set; }
        public string PaperNo { get; set; }
        public string Percentage { get; set; }
        public Dictionary<string, string> selectedAnswers { get; set; }
    }

}
