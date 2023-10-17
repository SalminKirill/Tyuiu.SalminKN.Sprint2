using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SalminKN.Sprint2.Task3.V1.Lib
{
    public class DataService : ISprint2Task3V1
    {
        public double Calculate(double x)
        {
            if (x > 0)
            {
                double y = (Math.Pow(Math.E, x)) - (12 * x) + Math.Cos(x);
                return y;
            }
            else if (x == 2)
            {
                double z = x + (15 / x);
                return z;
            }
            else if (-5 < x && x < 3)
            {
                double b = x + (10 * x) - (1 / x);
                return b;
            }
            else if (x < -5)
            {
                double n = x + (10 * x) - (1 / (Math.Pow(x, 3) + 3));
                return n;
            }
            else
            {
                return 0;
            }
        }
    }
}
