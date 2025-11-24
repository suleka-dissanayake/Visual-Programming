using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*           //Q1
                       double n1,n2;
                       Console.Write("Enter a 1st value: ");
                       n1=Convert.ToDouble(Console.ReadLine());
                       Console.Write("Enter a 2nd value: ");
                       n2 = Convert.ToDouble(Console.ReadLine());
                       Console.WriteLine("Addition: "+n1+" + "+n2+" = "+(n1+n2));
                       Console.WriteLine("Subtraction: " + n1 + " - " + n2 + " = " + (n1 - n2));
                       Console.WriteLine("Difference: " + n1 + " / " + n2 + " = " + (n1 / n2));
                       Console.WriteLine("Multiplication: " + n1 + " * " + n2 + " = " + (n1 * n2));
                       Console.WriteLine(" ");

                       //Q2
                       int sum = 0;
                       for (int i = 1; i <= 10; i++)
                       {
                           sum = sum + i;
                       }
                       Console.WriteLine("Sum of 1 to 10: " + sum);
                       Console.WriteLine(" ");

                       //Q3
                       Console.Write("Enter number of the day (1 to 7):");
                       int d=Convert.ToInt32(Console.ReadLine());
                       switch (d){
                           case 1:
                               Console.WriteLine("Monday");
                               break;
                           case 2:
                               Console.WriteLine("Tuesday");
                               break;
                           case 3:
                               Console.WriteLine("Wednesday");
                               break;
                           case 4:
                               Console.WriteLine("Thursday");
                               break;
                           case 5:
                               Console.WriteLine("Friday");
                               break;
                           case 6:
                               Console.WriteLine("Saturday");
                               break;
                           case 7:
                               Console.WriteLine("Sunday");
                               break;
                           default:
                               Console.WriteLine("Invalid Entry!");
                               break;
                       }
                       Console.WriteLine(" ");
           */
            //Q4
            double[] marks = new double[5];
            double total=0;
            for(int i=0; i<5; i++)
            {
                Console.Write("Enter the marks of Student "+(i+1)+": ");
                marks[i] = Convert.ToDouble(Console.ReadLine());
                total=total+marks[i];
            }
            Console.WriteLine("Average marks: "+(total/5));
            Console.WriteLine(" ");
        }
    }
}
