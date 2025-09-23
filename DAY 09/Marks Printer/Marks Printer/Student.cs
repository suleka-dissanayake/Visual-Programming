using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks_Printer
{
    internal class Student
    {
        public String name;
        public int marks;

        public Student(string name, int marks)
        {
            this.name = name;
            this.marks = marks;
        }

        public String GetGrade()
        {
            if (marks >= 75) return "A";
            else if (marks >= 50) return "B";
            else return "Fail";
        }
    }
}
