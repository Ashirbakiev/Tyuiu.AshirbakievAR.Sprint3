using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AshirbakievAR.Sprint3.Task6.V4.Lib
{
    public class DataService : ISprint3Task6V4
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int i=startValue;i<= stopValue; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if ((i % j == 0)&&(j>9))
                    {
                        count++;
                    }
                }
                
            }
            return count;
        }
    }
}
