using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class DivideOperation: IBinarOperation
    {
        private double Divide(double x, double y)
        {
                return x / y;
        }

        public double execute(double x, double y)
        {
            return Divide(x, y);
        }
    }
}
