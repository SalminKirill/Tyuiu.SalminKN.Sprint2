using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint2.Task5.V8.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task5.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ds.FindDateOfPreviousDay(m, n));
            Console.ReadLine();
        }
    }
}
