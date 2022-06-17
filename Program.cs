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
                if(int.TryParse(Console.ReadLine(), out int a) && a!= 0)
                    Console.ReadLine();
                else
                {
                    Console.WriteLine("Введите не 0");
                    continue;
                }
                Console.Write("Введите второй коэффициент B ");
                if(int.TryParse(Console.ReadLine(), out int b) && b != 0)
                    Console.ReadLine();
                else
                {
                    Console.WriteLine("Введите не 0");
                    continue;
                }
                Console.Write("Введите третий коэффициент C ");
                if(int.TryParse(Console.ReadLine(), out int c) && c != 0)
                    Console.ReadLine();
                else
                {
                    Console.WriteLine("Введите не 0");
                    continue;
                }
                Diskriminant diskriminant = new Diskriminant();
                double result = diskriminant.GetDiskriminant(a, b, c);

                Respons array = new Respons();
                double[] response = array.GetRespons(result, a, b);

                if (response == null)
                    Console.WriteLine("Уравнение не имеет рациональных корней");
                else if (response[0] != response[1])
                    Console.WriteLine($"Дискриминант больше 0, поэтому есть два решения: X1 = {response[0]}, X2 = {response[1]}");
                else if(response[0] == response[1])
                    Console.WriteLine($"Дискриминант равен 0, поэтому есть два одинаковых решения: X1 = X2 = {response[0]}");
                Console.ReadLine();
            }
        }
    }
}
