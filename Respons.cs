using System;

namespace quadratic_equation
{
    public class Respons
    {
        
        public double[] GetRespons(double diskriminant, int A, int B)
        {
            if (diskriminant > 0)
            {
                double X1 = (((-1) * B) + diskriminant) / ( 2 * A );
                double X2 = (((-1) * B) - diskriminant) / ( 2 * A );
                double[] array = { X1, X2 };
                return array;
            }
            else if (diskriminant == 0)
            {
                double X1 = (B / (2 * A) * (-1));
                double X2 = (B / (2 * A) * (-1));
                double[] array = { X1, X2 };
                return array;
            }
            return null;
        }
        
    }
}
