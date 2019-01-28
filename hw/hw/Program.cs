using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0;
            y = LineValueForY(m, x, b);

        }

        static double LineValueForY (double m, double x, double b)
        {
            double y;
            y = m * x + b;
            return y;

            
        }
    }
}
