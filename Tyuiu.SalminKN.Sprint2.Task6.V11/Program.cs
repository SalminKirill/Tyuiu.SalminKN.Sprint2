using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint2.Task6.V11.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ds.FindDateOfNextDay(g,m,n));
            Console.ReadLine();

        }
    }
}
