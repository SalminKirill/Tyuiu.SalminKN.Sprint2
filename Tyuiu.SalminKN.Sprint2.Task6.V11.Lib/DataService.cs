using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SalminKN.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {

            switch (m)
            {
                case 1:
                    Console.WriteLine("Январь");
                    if (n < 31)
                    {
                        Console.WriteLine($"Завтра {n + 1}ое число.");
                    }
                    else if (n == 31)
                    {
                        Console.WriteLine("Завтра будет февраль!");
                    }
                    else
                    {
                        Console.WriteLine("В январе 31 день!");
                    }
                    Console.WriteLine(g + "год.");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    if (n < 28)
                    {
                        Console.WriteLine($"Завтра {n + 1}ое число.");
                    }
                    else if (n == 28)
                    {
                        Console.WriteLine("Завтра будет март!");
                    }
                    else
                    {
                        Console.WriteLine("В феврале 28 дней!");
                    }
                    Console.WriteLine(g + "год.");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    if (n < 31)
                    {
                        Console.WriteLine($"Завтра {n + 1}ое число.");
                    }
                    else if (n == 31)
                    {
                        Console.WriteLine("Завтра будет апрель!");
                    }
                    else
                    {
                        Console.WriteLine("В марте 31 день!");
                    }
                    Console.WriteLine(g + "год.");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    if (n < 30)
                    {
                        Console.WriteLine($"Завтра {n + 1}ое число.");
                    }
                    else if (n == 30)
                    {
                        Console.WriteLine("Завтра будет май!");
                    }
                    else
                    {
                        Console.WriteLine("В Апреле 30 дней!");
                    }
                    Console.WriteLine(g + "год.");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    if (n < 31)
                    {
                        Console.WriteLine($"Завтра {n + 1}ое число.");
                    }
                    else if (n == 31)
                    {
                        Console.WriteLine("Завтра будет июнь!");
                    }
                    else
                    {
                        Console.WriteLine("В мае 31 день!");
                    }
                    Console.WriteLine(g + "год.");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    if (n < 30)
                    {
                        Console.WriteLine($"Завтра {n + 1}ое число.");
                    }
                    else if (n == 30)
                    {
                        Console.WriteLine("Завтра будет июль!");
                    }
                    else
                    {
                        Console.WriteLine("В июне 30 дней!");
                    }
                    Console.WriteLine(g + "год.");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    if (n < 31)
                    {
                        Console.WriteLine($"Завтра {n + 1}ое число.");
                    }
                    else if (n == 31)
                    {
                        Console.WriteLine("Завтра будет август!");
                    }
                    else
                    {
                        Console.WriteLine("В июле 31 день!");
                    }
                    Console.WriteLine(g + "год.");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    if (n < 31)
                    {
                        Console.WriteLine($"Завтра {n + 1}ое число.");
                    }
                    else if (n == 31)
                    {
                        Console.WriteLine("Завтра будет сентябрь!");
                    }
                    else
                    {
                        Console.WriteLine("В августе 31 день!");
                    }
                    Console.WriteLine(g + "год.");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    if (n < 30)
                    {
                        Console.WriteLine($"Завтра {n + 1}ое число.");
                    }
                    else if (n == 30)
                    {
                        Console.WriteLine("Завтра будет октябрь!");
                    }
                    else
                    {
                        Console.WriteLine("В сентябре 30 дней!");
                    }
                    Console.WriteLine(g + "год.");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    if (n < 31)
                    {
                        Console.WriteLine($"Завтра {n + 1}ое число.");
                    }
                    else if (n == 31)
                    {
                        Console.WriteLine("Завтра будет ноябрь!");
                    }
                    else
                    {
                        Console.WriteLine("В октябре 31 день!");
                    }
                    Console.WriteLine(g + "год.");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    if (n < 30)
                    {
                        Console.WriteLine($"Завтра {n + 1}ое число.");
                    }
                    else if (n == 30)
                    {
                        Console.WriteLine("Завтра будет декабрь!");
                    }
                    else
                    {
                        Console.WriteLine("В ноябре 30 дней!");
                    }
                    Console.WriteLine(g + "год.");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    if (n < 31)
                    {
                        Console.WriteLine($"Завтра {n + 1}ое число.");
                    }
                    else if (n == 31)
                    {
                        Console.WriteLine("Завтра будет январь!");
                        g++;
                    }
                    else
                    {
                        Console.WriteLine("В декабре 31 день!");
                    }
                    Console.WriteLine(g + "год.");
                    break;
                default:
                    Console.WriteLine("Нет такого месяца.");
                    break;
            }
            return "Спасибо что воспользовались нашим сервисом!";
        }
    }
}
