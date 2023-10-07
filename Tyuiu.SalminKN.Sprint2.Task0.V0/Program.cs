using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint2.Task0.V0.Lib;
namespace Tyuiu.SalminKN.Sprint2.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 15;
            int y = 16;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);


            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
