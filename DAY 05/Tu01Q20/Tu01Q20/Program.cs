using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a String: ");
            String s= Console.ReadLine();

            Console.WriteLine("Length: "+s.Length);
            Console.WriteLine("Uppercase: " + s.ToUpper()); 

            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine("Reversed: "+new string(arr));
        }
    }
}
