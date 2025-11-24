using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    internal class Student
    {
        internal string Name;
        private int Marks;

        public Student(string name, int marks)
        {
            this.Name = name;
            this.Marks = marks;
        }

        public String GetGrade()
        {
            if (Marks >= 75) return "A";
            else if(Marks >= 50) return "B";
            else return "Fail";
        }
    }
}
