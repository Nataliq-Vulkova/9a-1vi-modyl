using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace през_цикъл
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            for (i = 1; i <= 1000; i++)
            {
               if (i % 2 ==0)
                {
                    Console.WriteLine("i=" + i);
                }

            }
            

        }
    }
}
