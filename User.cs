using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizora
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "Student";
    }
}
