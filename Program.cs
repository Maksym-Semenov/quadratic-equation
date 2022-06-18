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
                Console.Write("Введите первый коэффициент A, не равный 0: ");

                if (int.TryParse(Console.ReadLine(), out int a) && a != 0)
                    _ = a;
                else
                {
                    Console.WriteLine("Введите не 0");
                    Console.ReadLine();
                    continue;
                }
                Console.Write("Введите второй коэффициент B, не равный 0: ");
                if (int.TryParse(Console.ReadLine(), out int b) && b != 0)
                    _ = b;
                else
                {
                    Console.WriteLine("Введите не 0");
                    Console.ReadLine();
                    continue;
                }
                Console.Write("Введите третий коэффициент C, не равный 0: ");
                if (int.TryParse(Console.ReadLine(), out int c) && c != 0)
                    _ = c;
                else
                {
                    Console.WriteLine("Введите не 0");
                    Console.ReadLine();
                    continue;
                }
                Diskriminant diskriminant = new Diskriminant();
                double result = diskriminant.GetDiskriminant(a, b, c);

                Respons array = new Respons();
                double[] response = array.GetRespons(result, a, b);

                Answers answer = new Answers();
                string reply = answer.GetAnswer(response);

                Console.WriteLine(reply);
                Console.ReadLine();
            }
        }
    }
}
