using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProj
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return second * first;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }
    }
}
