using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    internal class Student1
    {
        private string RegNo;
        private string IndexNo;
        private string Name;
        private int TVisualM;
        private int TVisualC;
        private int TCGM;
        private int TCGC;
        private int PCGM;
        private int PCGC;
        private int PVisualM;
        private int PVisualC;



        public Student1(string RegNo, string IndexNo, string Name, int TVisualM, int TVisualC, int TCGM, int TCGC, int PVisualM, int PVisualC, int PCGM, int PCGC)
        {
            this.RegNo = RegNo;
            this.IndexNo = IndexNo;
            this.Name = Name;
            this.TVisualM = TVisualM;
            this.TVisualC = TVisualC;
            this.TCGM = TCGM;
            this.TCGC = TCGC;
            this.PCGM = PCGC;
            this.PCGC = PCGC;
            this.PVisualM = PVisualM;
            this.PVisualC = PVisualC;
        }


        public string Results(int Tm1, int Tc1, int Pm1, int Pc1)
        {
            string grade;
            double Total_Marks = ((Tm1 * Tc1) + (Pm1 * Pc1)) / (Tc1 + Pc1);

            double roundMark = Math.Round(Total_Marks);

            if (roundMark >= 80)
            {
                grade = "A+";
            }
            else if (roundMark >= 75)
            {
                grade = "A";
            }
            else if (roundMark >= 70)
            {
                grade = "A-";
            }
            else if (roundMark >= 65)
            {
                grade = "B+";
            }
            else if (roundMark >= 60)
            {
                grade = "B";
            }
            else if (roundMark >= 55)
            {
                grade = "B-";
            }
            else if (roundMark >= 50)
            {
                grade = "C+";
            }
            else if (roundMark >= 45)
            {
                grade = "C";
            }
            else if (roundMark >= 40)
            {
                grade = "C-";
            }
            else if (roundMark >= 35)
            {
                grade = "D+";
            }
            else if (roundMark >= 30)
            {
                grade = "D";
            }
            else
            {
                grade = "fail";
            }

            return grade;

        }

        public double GPA(string grade)
        {
            double gpa;

            if (grade == "A+")
                gpa = 4.0;
            else if (grade == "A")
                gpa = 4.0;
            else if (grade == "A-")
                gpa = 3.7;
            else if (grade == "B+")
                gpa = 3.3;
            else if (grade == "B")
                gpa = 3.0;
            else if (grade == "B-")
                gpa = 2.7;
            else if (grade == "C+")
                gpa = 2.3;
            else if (grade == "C")
                gpa = 2.0;
            else if (grade == "C-")
                gpa = 1.7;
            else if (grade == "D+")
                gpa = 1.3;
            else if (grade == "D")
                gpa = 1.00;
            else
                gpa = 0.0; // Fail / F

            return gpa;

        }


        public double finalGPA(double Sgpa1, int c1, double Sgpa2, int c2)
        {
            double FinalGPA;
            FinalGPA = ((Sgpa1 * c1) + (Sgpa2 * c2) )/ (c1 + c2);
            return FinalGPA;
        }

    }
}
