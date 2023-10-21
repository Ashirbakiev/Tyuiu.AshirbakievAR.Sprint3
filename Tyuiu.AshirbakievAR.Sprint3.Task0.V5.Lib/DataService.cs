using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AshirbakievAR.Sprint3.Task0.V5.Lib
{
    public class DataService : ISprint3Task0V5
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double d = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                d += Math.Pow(1 / Math.Sin(i), 2);
            }
            return Math.Round(d, 3);
        }
    }
}
