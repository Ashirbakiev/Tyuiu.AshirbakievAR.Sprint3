using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AshirbakievAR.Sprint3.Task1.V11.Lib
{
    public class DataService
    {
        public double multiplication(int start, int end)
        {
            double d = 1;
            while (start <= end)
            {
                d *= (Math.Pow(0.75, start) + 0.5);
                start++;
            }
            return Math.Round(d, 3);
        }
    }
}
