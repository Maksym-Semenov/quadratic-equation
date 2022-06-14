namespace quadratic_equation
{
    public class Respons
    {
        public double X1;
        public double X2;
        public double X12;
        public string GetRespons(double diskriminant, int A, int B)
            {
            double X1 = (((-1) * B) + diskriminant) / (2 * A);
            double X2 = (((-1) * B) - diskriminant) / (2 * A);
            double X12 = (B / (2 * A) * (-1));
            return X1.ToString() + X2.ToString() + X12.ToString();
        }
    }
}
