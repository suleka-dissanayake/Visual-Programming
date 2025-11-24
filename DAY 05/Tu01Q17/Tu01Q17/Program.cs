using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q17
{
    internal class Program
    {
        delegate int AddDelegate(int x, int y); //declare delegate
        static int Add(int a, int b) //method to match delegate
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            AddDelegate ad = Add; //points delegate to Add method
            int result = ad(1, 2);
            Console.WriteLine("Sum: "+result);
        }
    }
}
