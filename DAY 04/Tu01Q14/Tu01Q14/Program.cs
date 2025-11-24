using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu01Q14
{

    public interface IShape
    {
        void Draw();
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle...");
        }
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a square...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           IShape s1 = new Circle();
           s1.Draw();

           IShape s2 = new Square();
           s2.Draw();
        }
    }
}
