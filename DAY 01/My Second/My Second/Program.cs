using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            //Student s1=new Student();
            //Student.printDetails();
            //s1.getAge();
            //System.out.println("Hello Java!");
            //Scanner sc=new Scanner(System.in);
            //int num1=sc.nextInt();
            Console.Write("Enter Number 1 : ");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 * num2));
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2)); 
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
        }
    }

