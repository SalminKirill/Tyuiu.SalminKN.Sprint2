using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint2.Task3.V1.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            Console.WriteLine(Math.Round(res,3));
            Console.ReadLine();

        }
    }
}
