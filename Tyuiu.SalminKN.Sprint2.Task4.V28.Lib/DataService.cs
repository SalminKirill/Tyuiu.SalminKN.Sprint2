using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SalminKN.Sprint2.Task4.V28.Lib
{
    public class DataService : ISprint2Task4V28
    {
        public double Calculate(double x, double y)
        {
           if (x < (y * 2 - 10))
            {
                double res = 1 + ((y + 2) / Math.Pow(x, 2));
                double z = Math.Pow(res, x);
                return z;
            }
            else
            {
                double e = (2 * Math.Pow(x, 2)) - Math.Pow(Math.Cos(y), 2) + 12;
                double r = Math.Pow(y, 2) - Math.Sin(Math.Pow(x, 2)) + 9;
                double res = e / r;
                return res;
            }
        }
    }
}
