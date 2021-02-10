using System;
using System.Net.Http.Headers;

namespace Calculator
{
    public class CalculatorClass
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Devider(double a, double b)
        {
            return a / b;
        }

        public double TestMath(double q, double z)
        {
            return q  /  z;
        }

        public double tech(double d, double c)
        {
           return c * c * d;
        }


        public double Pytagoras(double a, double b)
        {
            var sqh = a * a + b * b;

            var p = Math.Sqrt(sqh);
        }
    }
}