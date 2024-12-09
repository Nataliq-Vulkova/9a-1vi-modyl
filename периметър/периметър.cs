using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace периметър
{
    internal class периметър
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a=double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b=double.Parse(Console.ReadLine());
            double S = a * b;
            double P = 2*(a+b);
            Console.WriteLine("S=" +S);
            Console.WriteLine("P=" +P);




        }
    }
}
