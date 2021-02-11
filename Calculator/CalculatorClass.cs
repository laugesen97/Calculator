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
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new Exception("Can't devide by 0.");
            }

        }

        public double circleAreal(double r)
        {
           return Math.Round(Math.Pow(r, 2) * Math.PI,1);
        }


        public double Pytagoras(double a, double b)
        {
            var sqh = a * a + b * b;

            var c = Math.Sqrt(sqh);

            return Math.Round(c, 1);
        }
    }
}