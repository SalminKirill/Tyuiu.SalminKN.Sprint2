using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint2.Task2.V10.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x;
            int y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            bool what = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(what);
            Console.ReadLine();
        }
    }
}
