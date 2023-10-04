using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KultyshevaEA.Sprint2.Task1.V4.Lib
{
    public class DataService : ISprint2Task1V4
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < b);
            res[1] = (a * 2 > c) & (b != d);
            res[2] = (c != d) || (b < a);
            res[3] = (d * 4 <= a) && (b >= c);
            res[4] = !(a == b);
            res[5] = (b + 25 > a) ^ (d - 14 < c);

            return res;
        }
    }
}
