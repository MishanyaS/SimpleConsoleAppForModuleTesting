using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleAppForModuleTesting
{
    public class Methods
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Difference(double a, double b)
        {
            return a - b;
        }

        public double Devision(double a, double b)
        {

            if (b == 0) throw new DivideByZeroException();

            return a / b;
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }
    }
}
