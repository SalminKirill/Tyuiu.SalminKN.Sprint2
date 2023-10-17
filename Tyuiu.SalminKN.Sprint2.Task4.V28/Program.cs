using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint2.Task4.V28.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task4.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 8;
            double res = Math.Round(ds.Calculate(x, y), 3);
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
