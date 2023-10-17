using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AshirbakievAR.Sprint3.Task3.V11.Lib;

namespace Tyuiu.AshirbakievAR.Sprint3.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Аширбакиев А. Р. | СмартБ 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Аширбакиев Алмаз Ринатович | СмартБ 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы q на цифру 7 в строке:            *");
            Console.WriteLine("* sqwreq vqwqq q                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите cтроку: ");
            string value = Console.ReadLine();
            Console.Write("Введите заменяемый символ: ");
            char replaceable = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите замену символа: ");
            char replacement = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.ReplaceCharOnNum(value, replaceable, replacement));
            Console.ReadKey();
        }
    }
}
