using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tu01Q7
{
    enum Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
     static void Main(string[] args)
     {
        Days today = Days.Wed;
        Console.WriteLine("Today is "+today);
        Console.WriteLine("Today is "+(int)today);
     }
}
