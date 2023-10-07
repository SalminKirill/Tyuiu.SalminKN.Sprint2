using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint2.Task0.V8.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task0.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Салмин К. Н. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #8                                                             *");
            Console.WriteLine("* Выполнил: Салмин Кирилл Николаевич | АСОиУБ-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=,          *" +
                              "*последовательность операций не должна нарушаться) и арифметических       *" +
                              "*которая вернет логическую последовательность(массив):                    *" +
                              "*выражений, (True, False, True, False, True, False)                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите первое число:");
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите второе число:");
            int y = Convert.ToInt32(Console.ReadLine());

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
}
