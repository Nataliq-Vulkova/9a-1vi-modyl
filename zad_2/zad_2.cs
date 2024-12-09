using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class zad_2
    {
        static void Main(string[] args)
        {
            Console.Write("y=");
            var y=int.Parse(Console.ReadLine());
            if (y > 3)
            {
                int x = 9 * y * y * y + 3;
                Console.WriteLine("x="+x);
            }
            else
                if (1 < y && y <= 3)
            {
                Console.WriteLine("x=7*y*y*y*y*y*y*y*y*y"+(7 * y * y * y * y * y * y * y * y * y));
            }
            else
                if(y <= 3)

            {
                Console.WriteLine("x=5*y + 7");
            }
            Console.WriteLine($"x=", y);






        }
    }
}
