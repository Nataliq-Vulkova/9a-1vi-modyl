using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace време
{
    internal class време
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Избери си ден с число от 1 до 7");
            var number = double.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Супер си");
            }
            else Console.WriteLine("Ти си умен");
        }
    }
}
