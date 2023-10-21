using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AshirbakievAR.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double d = 0;
            do
            {
                d += (Math.Pow(0.5, startValue) + value) * Math.Cos(startValue);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(d, 3);
        }
    }
}
