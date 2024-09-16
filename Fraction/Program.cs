using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator(2, 3);
            Calculator c2 = new Calculator(5);
            Calculator c3 = new Calculator(2.6);
            //Console.WriteLine(c1 >= c2);
            

            c1.print();
            c2.print();
            c3.print();
        }
    }
}
