using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q17
{
    internal class Delegate
    {
        //delegate declaration
        delegate int Operation(int a, int b);

        //Methods
        static int Add(int x, int y) => x + y; //=> mns return 
        static int Sub(int x, int y) => x - y;
        static int Mul(int x, int y) => x * y;
        static int Div(int x, int y) => x / y;

        //Method that accepts delegates
        static void Execute(Operation op, int a, int b)
        {
            Console.WriteLine("Result: " + op(a, b));
        }

        static void Main(string[] args)
        {
            Adddelegate d = Add();
            int result = d(10, 20);
            Console.WriteLine("Result: " + result);
            d += Sub();
            int result1 = d(20, 20);
            //pass methods as arguments
            Execute(Add, 5, 5);
            Execute(Mul, 5, 3);
        }
    }
}