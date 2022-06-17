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

                Answers answer = new Answers();
                string reply = answer.GetAnswer(response);
                Console.WriteLine(reply);
            }
        }
    }
}
