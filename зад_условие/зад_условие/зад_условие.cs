using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зад_условие
{
    internal class зад_условие
    {
        static void Main(string[] args)
        {
            Console.Write("number=");
            var number=double.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Супер си");
            }
            else Console.WriteLine("Ти си умен");

        }
    }
}
