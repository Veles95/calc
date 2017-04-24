using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class AddOperation:IBinarOperation
    {
        public double addFunk(double a, double b)
        {           
            return a + b;
        }

        public double execute(double x, double y)
        {
            return addFunk(x, y);
        }
    }
}
