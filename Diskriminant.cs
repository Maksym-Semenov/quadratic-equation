using System;

namespace quadratic_equation
{
    public class Diskriminant
    {
        public int A;
        public int B;
        public int C;
        public Diskriminant(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public double GetDiskriminant(int A, int B, int C)
        {
            double result = Math.Sqrt(Math.Pow(B, 2) - (4 * A * C));
            return result;
        }
    }
}
