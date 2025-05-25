using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizora
{
    internal class ExamResult
    {
        public string PaperNo { get; set; }
        public string DateTime { get; set; }
        public int Correct { get; set; }
        public int Total { get; set; }
        public string Percentage { get; set; }

    }
}
