using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;

            x = Convert.ToInt32(Console.ReadLine());

            y = Convert.ToInt32(Console.ReadLine());

            if (x > y)

            {

                int k = x;

                x = y;

                y = k;

            }

            Console.WriteLine(x + ", " + y);
            Console.ReadKey();
        }
    }
}
