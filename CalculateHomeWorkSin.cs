using System;
using System.Collections.Generic;
using System.Text;

namespace D__OOP
{
    public class CalculateHomeWorkSin
    {
        public double CalcTriangleSquareHomeWork(double b, double h)
        {

            return 0.5 * b * h;



        }

        public double CalcTriangleSquareHomeWork(double ab, double bc, double a)
        {
            double x;

            x = a * Math.PI / 180;

            return 0.5 * (ab * bc * Math.Sin(x));



        }

    }
}
