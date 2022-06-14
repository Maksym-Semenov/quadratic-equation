using System;

namespace quadratic_equation
{
    public class Diskriminant
    {
        public double GetDiskriminant(int A, int B, int C)
        {
            double result = Math.Sqrt(Math.Pow(B, 2) - (4 * A * C));
            return result;
        }
    }
}
