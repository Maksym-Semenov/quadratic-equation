using System;

namespace quadratic_equation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Эта программа решает квадратные уравнения вида ax2+bx+c=0");
                Console.Write("Введите первый коэффициент A ");
                bool successA = int.TryParse(Console.ReadLine(), out int a);
                Console.Write("Введите второй коэффициент B ");
                bool successB = int.TryParse(Console.ReadLine(), out int b);
                Console.Write("Введите третий коэффициент C ");
                bool successC = int.TryParse(Console.ReadLine(), out int c);

                Diskriminant diskriminant = new Diskriminant(a, b, c);
                double result = diskriminant.GetDiskriminant(a, b, c);

                Respons respons = new Respons();
                Console.WriteLine(respons);
                Console.ReadLine();

                //if (result < 0)
                //{
                //    Console.WriteLine("Дискриминант меньше 0, поэтому уравнение не имеет рациональных корней");
                //}
                //else if (result == 0)
                //{
                //    Console.Write("Дискриминант равен 0, решение уравнения имеет два равных корня x = " + x12);
                //}
                //else if (result > 0)
                //{
                //    Console.WriteLine("Дискриминант больше 0, поэтому есть два решения ");
                //    Console.WriteLine("Первый корень уравнения x1 = " + x1);
                //    Console.WriteLine("Второй корень уравнения x2 = " + x2);
                //}
                //Console.ReadLine();
            }
        }
    }
}
