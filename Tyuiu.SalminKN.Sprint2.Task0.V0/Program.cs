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
            int x = 5;

            int y = (x <= 0) || (x >= 10) ? 1 + x * 5 : 10 - 2 * x;
            Console.WriteLine(y);
            Console.ReadKey();


        }
        
        }
    }

