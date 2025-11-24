using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q5
{
    internal class Student
    {
        String name;
        int age;

        Student(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        void print()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
        }
        static void Main(string[] args)
        {
            Student st = new Student("Bob", 25);
            st.print();
        }
    }
}
