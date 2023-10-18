using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint2.Task7.V5.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.WriteLine("Введите значение x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            int y = Convert.ToInt32(Console.ReadLine());


            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine($"Ответ: {res}");
            Console.ReadLine();
        }
    }
}
