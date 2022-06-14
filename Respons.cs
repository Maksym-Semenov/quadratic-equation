using System;

namespace quadratic_equation
{
    public class Respons
    {
        public double[] GetRespons(double diskriminant, int A, int B)
        {
            if (diskriminant > 0)
            {
                double X1 = (((-1) * B) + diskriminant) / (2 * A);
                double X2 = (((-1) * B) - diskriminant) / (2 * A);
                double[] array = new double[2];
                array[0] = X1;
                array[1] = X2;
                return array;
            }
            else if (diskriminant == 0)
            {
                double X12 = (B / (2 * A) * (-1));
                double[] array = new double[2];
                array[0] = X12;
                array[1] = X12;
                return array;
            }
            return null;
        }
    }
}
