﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AshirbakievAR.Sprint3.Task7.V23.Lib;

namespace Tyuiu.AshirbakievAR.Sprint3.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Аширбакиев А. Р. | СмартБ 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Аширбакиев Алмаз Ринатович | СмартБ 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по  *");
            Console.WriteLine("* формуле S=(1/sin(k))^2                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите начало отрезка: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конец отрезка: ");
            int end = Convert.ToInt32(Console.ReadLine());
            int len = end - start + 1;
            double[] VauleArray;
            VauleArray = new double[len];
            VauleArray = ds.GetMassFunction(start, end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|     X    |    f(x)  |");
            Console.WriteLine("+----------+----------+");
            foreach(double i in VauleArray)
            {
                Console.WriteLine("|{0,5:d}     | {1,5:f2}    |",start, i);
                start++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
