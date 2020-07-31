using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace D__OOP
{
    public class Calculator
    {


        public static bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0;
            if (divisor == 0)
            {
                return false;
            }
            result = divisible / divisor;
            return true;
        }

        public static double Average(int[] numbers)
        {
            int sum = 0;

            foreach (int n in numbers)
            {
                sum += n;

            }
            return (double)sum / numbers.Length;
        }

        //массив создан неявно
        public static double Average2(params int[] numbers)
        {
            int sum = 0;

            foreach (int n in numbers)
            {
                sum += n;

            }

            return (double)sum / numbers.Length;
        }

        public static double CalcTriangleSquare(double AB, double BC, double AC)
        {
            double p = (AB + BC + AC) / 2;

            return Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
        }

        public static double CalcTriangleSquare(double b, double h)
        {

            return 0.5 * b * h;



        }


        public static double CalcTriangleSquare(double ab, double ac, int alpha, bool isInRadians = false)
        {

            if (isInRadians)
            {
                return 0.5 * ab * ac * Math.Sin(alpha);
            }
            else
            {
                double rads = alpha * Math.PI / 180;
                return 0.5 * ab * ac * Math.Sin(rads);
            }

            static double CalcTriangleSquare(double ab, double ac, int alpha, bool isInRadians)
            {
                {
                    double rads = alpha * Math.PI / 180;
                    return 0.5 * ab * ac * Math.Sin(rads);
                }

                /*
                double x;

                x = a * Math.PI / 180;

                return 0.5 * (ab * bc * Math.Sin(x));
                */

            }
        }
    }
}


