using System;
using System.Collections.Generic;

namespace corsoIngProject.Dal
{
    public class Exam
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public int Grade { get; set; }
        public List<string> ArgumentList { get; set; }
    }
}
