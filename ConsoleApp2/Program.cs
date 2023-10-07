using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 0;

            x = Convert.ToInt32(Console.ReadLine());

            y = Convert.ToInt32(Console.ReadLine());

            z = Convert.ToInt32(Console.ReadLine());

            int k;

            if ((x > y) && (x > z)) k = x;

            else if (y < z) k = z;

            else k = y;
            Console.ReadKey();
        }
    }
}
