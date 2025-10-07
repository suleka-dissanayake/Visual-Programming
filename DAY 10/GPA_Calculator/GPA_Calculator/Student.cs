using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator
{
    internal class Student
    {
        public int RegNo { get; set; }
        public string IndexNo { get; set; }
        public string Name { get; set; }
        public int VP_T_Marks { get; set; }
        public int VP_T_Grade { get; set; }
        public int VP_P_Marks { get; set; }
        public int VP_P_Grade { get; set; }
        public int CG_T_Marks { get; set; }
        public int CG_T_Grade { get; set; }
        public int CG_P_Marks { get; set; }
        public int CG_P_Grade { get; set; }

        Student(int regNo, string indexNo, string name, int vP_T_Marks, int vP_T_Grade, int vP_P_Marks, int vP_P_Grade, int cG_T_Marks, int cG_T_Grade, int cG_P_Marks, int cG_P_Grade)
        {
            RegNo = regNo;
            IndexNo = indexNo;
            Name = name;
            VP_T_Marks = vP_T_Marks;
            VP_T_Grade = vP_T_Grade;
            VP_P_Marks = vP_P_Marks;
            VP_P_Grade = vP_P_Grade;
            CG_T_Marks = cG_T_Marks;
            CG_T_Grade = cG_T_Grade;
            CG_P_Marks = cG_P_Marks;
            CG_P_Grade = cG_P_Grade;
        }

        public string Results(int Tm1, int Tc1, int Pm1, int Pc1)
        {
            string grade;
            double Total_Marks = ((Tm1 * Tc1) + (Pm1 * Pc1)) / (Tc1 + Pc1);

            double roundMark = Math.Round(Total_Marks);

            if(roundMark >= 80)
            {
                grade = "A+";
            } 
            else if(roundMark >= 75)
            {
                grade = "A";
            }
            else if(roundMark >= 70)
            {
                grade = "A-";
            }
            else if(roundMark >= 65)
            {
                grade = "B+";
            }
            else if(roundMark >= 60)
            {
                grade = "B";
            }
            else if(roundMark >= 55)
            {
                grade = "B-";
            }
            else if(roundMark >= 50)
            {
                grade = "C+";
            }
            else if(roundMark >= 45)
            {
                grade = "C";
            }
            else if(roundMark >= 40)
            {
                grade = "C-";
            }
            else if(roundMark >= 35)
            {
                grade = "D+";
            }
            else if(roundMark >= 30)
            {
                grade = "D";
            }
            else
            {
                grade = "E";
            }
            return grade;
        }

        public double GPA(String grade)
        {
            double gpa;
            if(grade == "A+" || grade == "A")
            {
                gpa = 4.0;
            }
            else if(grade == "A-")
            {
                gpa = 3.7;
            }
            else if(grade == "B+")
            {
                gpa = 3.3;
            }
            else if(grade == "B")
            {
                gpa = 3.0;
            }
            else if(grade == "B-")
            {
                gpa = 2.7;
            }
            else if(grade == "C+")
            {
                gpa = 2.3;
            }
            else if(grade == "C")
            {
                gpa = 2.0;
            }
            else if(grade == "C-")
            {
                gpa = 1.7;
            }
            else if(grade == "D+")
            {
                gpa = 1.3;
            }
            else if(grade == "D")
            {
                gpa = 1.0;
            }
            else
            {
                gpa = 0.0;
            }
            return gpa;
        }
    }
}

/*
private static readonly Dictionary<string, double> GradeToGPA = new Dictionary<string, double>
{
    { "A+", 4.0 }, { "A", 4.0 }, { "A-", 3.7 },
    { "B+", 3.3 }, { "B", 3.0 }, { "B-", 2.7 },
    { "C+", 2.3 }, { "C", 2.0 }, { "C-", 1.7 },
    { "D+", 1.3 }, { "D", 1.0 }, { "E", 0.0 }
};

public double GPA(string grade)
{
    return GradeToGPA.TryGetValue(grade, out double gpa) ? gpa : 0.0;
} 
*/
