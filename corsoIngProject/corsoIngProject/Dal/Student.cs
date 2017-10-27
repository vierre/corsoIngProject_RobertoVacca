using System;
using System.Collections.Generic;

namespace corsoIngProject.Dal
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ImmatricolationDate { get; set; }
        public List<Exam> ExamsList { get; set; }
    }
}
