using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AshirbakievAR.Sprint3.Task2.V15.Lib
{
    public class DataService
    {
        public double sum(int start, int end)
        {
            double d = 0;
            do
            {
                d += (Math.Pow(0.5, start) + 0.5) * Math.Cos(start);
                start++;
            } while (start <= end);
            return Math.Round(d, 3);
        }
    }
}
