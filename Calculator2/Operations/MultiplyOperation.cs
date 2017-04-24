using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{    
    class MultiplyOperation:IBinarOperation
    {
        double a, b;

        public double execute(double x, double y)
        {
            return Multiply(x,y);
        }

        private double Multiply(double x, double y)
        {
            x = 1.4;
            y = 1.5;
            return x * y;
        }
    }
}
