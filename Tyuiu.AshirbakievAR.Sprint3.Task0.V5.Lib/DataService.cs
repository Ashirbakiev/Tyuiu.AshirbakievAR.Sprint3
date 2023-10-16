using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AshirbakievAR.Sprint3.Task0.V5.Lib
{
    public class DataService
    {
        public double Summ(int start, int end)
        {
            double d=0;
            for (int i=start; i <= end; i++)
            {
                d += Math.Pow(1 / Math.Sin(i), 2);
            }
            return Math.Round(d,3);
        }
    }
}
